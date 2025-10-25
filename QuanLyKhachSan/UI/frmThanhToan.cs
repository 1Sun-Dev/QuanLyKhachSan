using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
// KHÔNG dùng using DevExpress.XtraEditors;
// KHÔNG dùng using DevExpress.Data;
using Guna.UI2.WinForms; // Dùng Guna controls

namespace QuanLyKhachSan // Đảm bảo namespace này khớp với project
{
    public partial class frmThanhToan : Form // Kế thừa từ Form chuẩn
    {
        // 1. Chuỗi kết nối
        private string connectionString =
           @"Data Source=Phuc-ne;Initial Catalog = QuanLyKhachSan; Integrated Security = True";

        // Biến lưu thông tin cần thiết khi chọn phòng
        private string selectedMaPTP = null;
        private DateTime ngayThue;
        private decimal donGiaPhong = 0;

        public frmThanhToan()
        {
            InitializeComponent();
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            LoadPhongDangThue();
            dateNgayTra.Value = DateTime.Now; // Mặc định ngày trả là hôm nay

            // Gán sự kiện
            btnThanhToan.Click += btnThanhToan_Click;
            btnHuy.Click += (s, args) => this.Close();

            // Cấu hình cột Tổng cộng cho lưới Dịch vụ
            SetupDichVuGrid();
        }

        #region HÀM TẢI DỮ LIỆU VÀ TÍNH TOÁN

        // Tải danh sách phòng đang thuê vào ComboBox
        private void LoadPhongDangThue()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                SELECT DISTINCT P.MaPhong, P.SoPhong, KH.HoTen 
                FROM Phong P
                JOIN CT_ThuePhong CTP ON P.MaPhong = CTP.MaPhong
                JOIN PhieuThuePhong PTP ON CTP.MaPTP = PTP.MaPTP
                JOIN KhachHang KH ON PTP.MaKH = KH.MaKH
                WHERE PTP.NgayTra IS NULL 
                ORDER BY P.SoPhong";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();

                    dt.Columns.Add("DisplayMember", typeof(string));
                    dt.Columns.Add("ValueMember", typeof(string));
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        row["DisplayMember"] = $"{row["SoPhong"]} - (Khách: {row["HoTen"]})";
                        row["ValueMember"] = row["MaPhong"];
                    }

                    lookUpPhongDangThue.DataSource = dt;
                    lookUpPhongDangThue.DisplayMember = "DisplayMember"; // <- Dòng này sửa lỗi
                    lookUpPhongDangThue.ValueMember = "ValueMember";   // <- Dòng này sửa lỗi
                    lookUpPhongDangThue.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách phòng đang thuê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện khi chọn phòng khác (Sửa tên hàm)
        private void lookUpPhongDangThue_EditValueChanged(object sender, EventArgs e)
        {
            Guna2ComboBox cbx = sender as Guna2ComboBox;
            if (cbx == null) return;

            // Lấy giá trị đã chọn (là MaPhong)
            object selectedValue = cbx.SelectedValue;

            if (selectedValue == null || selectedValue == DBNull.Value)
            {
                ClearDetails();
                return;
            }

            string maPhong = selectedValue.ToString();

            // Gọi hàm load chi tiết với MaPhong đã lấy được
            LoadThongTinThuePhong(maPhong);
        }

        // Tải thông tin chi tiết khi chọn phòng
        private void LoadThongTinThuePhong(string maPhong)
        {
            ClearDetails();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // *** SỬA Ở ĐÂY: Đổi "JOIN LoaiPhong" thành "LEFT JOIN LoaiPhong" ***
                    string query = @"
                SELECT TOP 1 PTP.MaPTP, PTP.NgayThue, KH.HoTen, LP.TenLP, LP.DonGia
                FROM PhieuThuePhong PTP
                JOIN KhachHang KH ON PTP.MaKH = KH.MaKH
                JOIN CT_ThuePhong CTP ON PTP.MaPTP = CTP.MaPTP AND CTP.MaPhong = @MaPhong
                JOIN Phong P ON CTP.MaPhong = P.MaPhong
                LEFT JOIN LoaiPhong LP ON P.MaLP = LP.MaLP 
                WHERE PTP.NgayTra IS NULL
                ORDER BY PTP.NgayThue DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // ... (Phần code còn lại của hàm giữ nguyên) ...
                        cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            selectedMaPTP = reader["MaPTP"].ToString();
                            ngayThue = Convert.ToDateTime(reader["NgayThue"]);
                            // Xử lý nếu DonGia hoặc TenLP bị NULL (do LEFT JOIN)
                            donGiaPhong = (reader["DonGia"] == DBNull.Value) ? 0 : Convert.ToDecimal(reader["DonGia"]);
                            txtTenKhachHang.Text = reader["HoTen"].ToString();
                            dateNgayThue.Value = ngayThue;
                            txtLoaiPhong.Text = (reader["TenLP"] == DBNull.Value) ? "N/A" : reader["TenLP"].ToString();

                            reader.Close();

                            LoadDichVuDaSuDung(selectedMaPTP);
                            CalculateCosts();
                            txtMaHD.Text = "HD" + DateTime.Now.ToString("yyMMddHHmmss");
                        }
                        else
                        {
                            reader.Close();
                            ClearDetails();
                            MessageBox.Show("Không tìm thấy thông tin thuê phòng hợp lệ cho phòng này.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thông tin thuê phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearDetails();
            }
        }
        // Tải danh sách dịch vụ đã sử dụng
        private void LoadDichVuDaSuDung(string maPTP)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT DV.TenDV, PDV.SoLuong, DV.GiaDV, PDV.ThanhTien 
                        FROM PhieuDV PDV
                        JOIN DichVu DV ON PDV.MaDV = DV.MaDV
                        WHERE PDV.MaPTP = @MaPTP";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@MaPTP", maPTP);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridDichVuSD.DataSource = dt;

                    // Tính tổng tiền dịch vụ thủ công và cập nhật TextBox
                    decimal tienDV = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        tienDV += Convert.ToDecimal(row["ThanhTien"]);
                    }
                    txtTienDichVu.Text = tienDV.ToString("N0");
                }
            }
            catch (Exception ex)
            {
                // SỬA: Dùng MessageBox chuẩn
                MessageBox.Show("Lỗi tải danh sách dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gridDichVuSD.DataSource = null;
                txtTienDichVu.Text = "0";
            }
        }

        // Cấu hình GridView Dịch vụ (dùng Guna2DataGridView)
        private void SetupDichVuGrid()
        {
            gridDichVuSD.AutoGenerateColumns = false;
            gridDichVuSD.Columns.Clear();

            // Thêm các cột thủ công
            gridDichVuSD.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TenDV", HeaderText = "Tên Dịch Vụ", Name = "colTenDV", ReadOnly = true, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            gridDichVuSD.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SoLuong", HeaderText = "SL", Name = "colSoLuong", ReadOnly = true, Width = 60 });
            gridDichVuSD.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "GiaDV", HeaderText = "Đơn Giá", Name = "colGiaDV", ReadOnly = true, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }, Width = 120 });
            gridDichVuSD.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ThanhTien", HeaderText = "Thành Tiền", Name = "colThanhTien", ReadOnly = true, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }, Width = 150 });

            // Guna2DataGridView không có summary footer tích hợp, ta đã tính tổng thủ công ở LoadDichVuDaSuDung
        }

        // Sự kiện khi thay đổi ngày trả
        private void dateNgayTra_ValueChanged(object sender, EventArgs e)
        {
            CalculateCosts(); // Tính lại tiền khi ngày trả thay đổi
        }

        // Tính toán các chi phí
        private void CalculateCosts()
        {
            if (dateNgayTra.Value == null || ngayThue == DateTime.MinValue || donGiaPhong <= 0)
            {
                spinSoNgayO.Value = 0;
                txtTienPhong.Text = "0";
                txtTongTien.Text = "0";
                return;
            }

            DateTime ngayTra = dateNgayTra.Value;

            // Tính số ngày ở (ít nhất 1 ngày)
            TimeSpan duration = ngayTra.Date - ngayThue.Date;
            int soNgay = (int)Math.Max(1, Math.Ceiling(duration.TotalDays));
            spinSoNgayO.Value = soNgay;

            // Tính tiền phòng
            decimal tienPhong = soNgay * donGiaPhong;
            txtTienPhong.Text = tienPhong.ToString("N0");

            // Lấy tiền dịch vụ (đã được tính khi load grid)
            decimal tienDichVu = 0;
            // Parse chuỗi có dấu phẩy (N0)
            Decimal.TryParse(txtTienDichVu.Text, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.CurrentCulture, out tienDichVu);

            // Tính tổng tiền
            txtTongTien.Text = (tienPhong + tienDichVu).ToString("N0");
        }

        // Xóa các chi tiết
        private void ClearDetails()
        {
            selectedMaPTP = null;
            ngayThue = DateTime.MinValue;
            donGiaPhong = 0;
            txtTenKhachHang.Text = "";
            dateNgayThue.Value = DateTime.Now;
            dateNgayTra.Value = DateTime.Now;
            txtLoaiPhong.Text = "";
            spinSoNgayO.Value = 0;
            gridDichVuSD.DataSource = null;
            txtTienPhong.Text = "0";
            txtTienDichVu.Text = "0";
            txtTongTien.Text = "0";
            txtMaHD.Text = "";
        }

        #endregion

        #region XỬ LÝ THANH TOÁN

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra dữ liệu
            if (lookUpPhongDangThue.SelectedValue == null || string.IsNullOrEmpty(selectedMaPTP))
            {
                // SỬA: Dùng MessageBox chuẩn
                MessageBox.Show("Vui lòng chọn phòng cần thanh toán.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dateNgayTra.Value == null || dateNgayTra.Value.Date < ngayThue.Date)
            {
                // SỬA: Dùng MessageBox chuẩn
                MessageBox.Show("Ngày trả không hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateNgayTra.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMaHD.Text))
            {
                // SỬA: Dùng MessageBox chuẩn
                MessageBox.Show("Vui lòng nhập Mã Hóa Đơn.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHD.Focus();
                return;
            }

            // Lấy giá trị tiền từ TextBox (loại bỏ dấu phẩy)
            decimal tongTien = 0;
            Decimal.TryParse(txtTongTien.Text, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.CurrentCulture, out tongTien);

            // Xác nhận thanh toán
            // SỬA: Dùng MessageBox chuẩn
            if (MessageBox.Show($"Xác nhận thanh toán cho phòng {lookUpPhongDangThue.Text}?\nTổng tiền: {tongTien:N0} VNĐ",
                                     "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            // 2. Lấy dữ liệu cần thiết
            string maHD = txtMaHD.Text.Trim();
            string maPhong = lookUpPhongDangThue.SelectedValue.ToString();
            DateTime ngayTra = dateNgayTra.Value;

            // 3. Thực hiện Transaction
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    // Lệnh 1: Insert HoaDon
                    string sqlHD = "INSERT INTO HoaDon (MaHD, NgayVao, NgayRa, TongTien) VALUES (@MaHD, @NgayVao, @NgayRa, @TongTien)";
                    using (SqlCommand cmdHD = new SqlCommand(sqlHD, conn, trans))
                    {
                        cmdHD.Parameters.AddWithValue("@MaHD", maHD);
                        cmdHD.Parameters.AddWithValue("@NgayVao", ngayThue);
                        cmdHD.Parameters.AddWithValue("@NgayRa", ngayTra);
                        cmdHD.Parameters.AddWithValue("@TongTien", tongTien);
                        cmdHD.ExecuteNonQuery();
                    }

                    // Lệnh 2: Insert CT_HoaDon
                    string sqlCTHD = "INSERT INTO CT_HoaDon (MaHD, MaPTP, SoLuong, TongTien) VALUES (@MaHD, @MaPTP, @SoLuong, @TongTien)";
                    using (SqlCommand cmdCTHD = new SqlCommand(sqlCTHD, conn, trans))
                    {
                        cmdCTHD.Parameters.AddWithValue("@MaHD", maHD);
                        cmdCTHD.Parameters.AddWithValue("@MaPTP", selectedMaPTP);
                        cmdCTHD.Parameters.AddWithValue("@SoLuong", 1);
                        cmdCTHD.Parameters.AddWithValue("@TongTien", tongTien);
                        cmdCTHD.ExecuteNonQuery();
                    }

                    // Lệnh 3: Update PhieuThuePhong (Set NgayTra)
                    string sqlPTP = "UPDATE PhieuThuePhong SET NgayTra = @NgayTra WHERE MaPTP = @MaPTP";
                    using (SqlCommand cmdPTP = new SqlCommand(sqlPTP, conn, trans))
                    {
                        cmdPTP.Parameters.AddWithValue("@NgayTra", ngayTra);
                        cmdPTP.Parameters.AddWithValue("@MaPTP", selectedMaPTP);
                        cmdPTP.ExecuteNonQuery();
                    }

                    // Lệnh 4: Update Phong (Set TinhTrang)
                    string sqlPhong = "UPDATE Phong SET TinhTrang = N'Đang dọn' WHERE MaPhong = @MaPhong"; // Hoặc 'Trống'
                    using (SqlCommand cmdPhong = new SqlCommand(sqlPhong, conn, trans))
                    {
                        cmdPhong.Parameters.AddWithValue("@MaPhong", maPhong);
                        cmdPhong.ExecuteNonQuery();
                    }

                    trans.Commit();
                    // SỬA: Dùng MessageBox chuẩn
                    MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadPhongDangThue();
                    ClearDetails();

                }
                catch (SqlException sqlex) when (sqlex.Number == 2627)
                {
                    trans.Rollback();
                    // SỬA: Dùng MessageBox chuẩn
                    MessageBox.Show($"Mã Hóa Đơn '{maHD}' đã tồn tại. Vui lòng nhập mã khác.", "Lỗi Trùng Mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaHD.Focus();
                    txtMaHD.SelectAll();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    // SỬA: Dùng MessageBox chuẩn
                    MessageBox.Show("Thanh toán thất bại! Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}