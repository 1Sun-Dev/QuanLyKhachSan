using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmDatPhong : Form
    {
        // 1. Chuỗi kết nối
        private string connectionString =
     @"Data Source=Phuc-ne;Initial Catalog=QuanLyKhachSan;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        // 2. DataTables để quản lý dữ liệu động
        private DataTable dtPhongDaChon;
        private DataTable dtDichVuDaDung;

        public frmDatPhong()
        {
            InitializeComponent();
        }

        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            try
            {
                SetupDataTables();
                LoadKhachHang();
                LoadPhongTrong();
                LoadDichVu();
                SetDefaults();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi tạo form: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region HÀM KHỞI TẠO VÀ TẢI DỮ LIỆU

        // Khởi tạo các DataTable và gán cho Grid
        private void SetupDataTables()
        {
            // Cấu hình Phòng đã chọn
            dtPhongDaChon = new DataTable();
            dtPhongDaChon.Columns.Add("MaPhong", typeof(string));
            dtPhongDaChon.Columns.Add("SoPhong", typeof(string));
            dtPhongDaChon.Columns.Add("DonGia", typeof(decimal));
            dtPhongDaChon.Columns.Add("SoNgay", typeof(int));
            dtPhongDaChon.Columns.Add("ThanhTien", typeof(decimal), "DonGia * SoNgay");
            gridPhongDaChon.DataSource = dtPhongDaChon;
            SetupGridColumns(gridPhongDaChon, true);

            // Cấu hình Dịch vụ đã dùng
            dtDichVuDaDung = new DataTable();
            dtDichVuDaDung.Columns.Add("MaDV", typeof(string));
            dtDichVuDaDung.Columns.Add("TenDV", typeof(string));
            dtDichVuDaDung.Columns.Add("SoLuong", typeof(int));
            dtDichVuDaDung.Columns.Add("GiaDV", typeof(decimal));
            dtDichVuDaDung.Columns.Add("ThanhTien", typeof(decimal), "GiaDV * SoLuong");
            gridDichVuDaDung.DataSource = dtDichVuDaDung;
            SetupGridColumns(gridDichVuDaDung, true);
        }

        // Cấu hình chung cho các GridView
        private void SetupGridColumns(Guna2DataGridView grid, bool addDeleteButton)
        {
            grid.AutoGenerateColumns = false;
            grid.Columns.Clear();

            if (grid == gridPhongDaChon)
            {
                grid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "SoPhong",
                    HeaderText = "Số Phòng",
                    Name = "colSoPhong",
                    ReadOnly = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });
                grid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "DonGia",
                    HeaderText = "Đơn Giá",
                    Name = "colDonGia",
                    ReadOnly = true,
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" },
                    Width = 120
                });
                grid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "SoNgay",
                    HeaderText = "Số Ngày",
                    Name = "colSoNgay",
                    ReadOnly = true,
                    Width = 80
                });
                grid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "ThanhTien",
                    HeaderText = "Thành Tiền",
                    Name = "colThanhTien",
                    ReadOnly = true,
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" },
                    Width = 150
                });
            }
            else if (grid == gridDichVuDaDung)
            {
                grid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "TenDV",
                    HeaderText = "Tên Dịch Vụ",
                    Name = "colTenDV",
                    ReadOnly = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });
                grid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "SoLuong",
                    HeaderText = "SL",
                    Name = "colSoLuong",
                    ReadOnly = true,
                    Width = 60
                });
                grid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "GiaDV",
                    HeaderText = "Đơn Giá",
                    Name = "colGiaDV",
                    ReadOnly = true,
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" },
                    Width = 120
                });
                grid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "ThanhTien",
                    HeaderText = "Thành Tiền",
                    Name = "colThanhTien",
                    ReadOnly = true,
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" },
                    Width = 150
                });
            }

            if (addDeleteButton)
            {
                DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
                btnCol.Name = "colXoa";
                btnCol.HeaderText = "";
                btnCol.Text = "Xóa";
                btnCol.UseColumnTextForButtonValue = true;
                btnCol.Width = 60;
                btnCol.FlatStyle = FlatStyle.Flat;
                btnCol.DefaultCellStyle.BackColor = Color.Tomato;
                btnCol.DefaultCellStyle.ForeColor = Color.White;
                grid.Columns.Add(btnCol);
            }
        }

        // Tải danh sách khách hàng - SỬA LỖI Ở ĐÂY
        private void LoadKhachHang()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT MaKH, HoTen, SDT FROM KhachHang ORDER BY HoTen";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Kiểm tra nếu có dữ liệu
                    if (dt.Rows.Count > 0)
                    {
                        cbKhachHang.DataSource = dt;
                        cbKhachHang.DisplayMember = "HoTen";
                        cbKhachHang.ValueMember = "MaKH";
                    }
                    else
                    {
                        // Nếu không có khách hàng, tạo một DataTable rỗng
                        DataTable emptyTable = new DataTable();
                        emptyTable.Columns.Add("MaKH", typeof(string));
                        emptyTable.Columns.Add("HoTen", typeof(string));
                        emptyTable.Columns.Add("SDT", typeof(string));

                        cbKhachHang.DataSource = emptyTable;
                        cbKhachHang.DisplayMember = "HoTen";
                        cbKhachHang.ValueMember = "MaKH";
                    }

                    cbKhachHang.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tải danh sách phòng trống
        private void LoadPhongTrong()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT P.MaPhong, P.SoPhong, LP.TenLP, LP.DonGia, P.TANG
                        FROM Phong P
                        JOIN LoaiPhong LP ON P.MaLP = LP.MaLP
                        WHERE P.TinhTrang = N'Trống'
                        ORDER BY P.TANG, P.SoPhong";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridPhongTrong.DataSource = dt;

                    // Cấu hình GridView
                    if (dt.Columns.Contains("MaPhong"))
                        gridPhongTrong.Columns["MaPhong"].Visible = false;
                    if (dt.Columns.Contains("TenLP"))
                        gridPhongTrong.Columns["TenLP"].Visible = false;

                    if (dt.Columns.Contains("SoPhong"))
                        gridPhongTrong.Columns["SoPhong"].HeaderText = "Số Phòng";
                    if (dt.Columns.Contains("DonGia"))
                    {
                        gridPhongTrong.Columns["DonGia"].HeaderText = "Đơn Giá";
                        gridPhongTrong.Columns["DonGia"].DefaultCellStyle.Format = "N0";
                    }
                    if (dt.Columns.Contains("TANG"))
                        gridPhongTrong.Columns["TANG"].HeaderText = "Tầng";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải phòng trống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tải danh sách dịch vụ
        private void LoadDichVu()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT MaDV, TenDV, GiaDV FROM DichVu ORDER BY TenDV";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridDichVu.DataSource = dt;

                    // Cấu hình GridView
                    if (dt.Columns.Contains("MaDV"))
                        gridDichVu.Columns["MaDV"].Visible = false;

                    if (dt.Columns.Contains("TenDV"))
                    {
                        gridDichVu.Columns["TenDV"].HeaderText = "Tên Dịch Vụ";
                        gridDichVu.Columns["TenDV"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }

                    if (dt.Columns.Contains("GiaDV"))
                    {
                        gridDichVu.Columns["GiaDV"].HeaderText = "Đơn Giá";
                        gridDichVu.Columns["GiaDV"].DefaultCellStyle.Format = "N0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Đặt giá trị mặc định
        private void SetDefaults()
        {
            try
            {
                dateNgayDen.Value = DateTime.Today;
                dateNgayDi.Value = DateTime.Today.AddDays(1);

                // Khởi tạo ComboBox trạng thái
                if (cbTrangThai.Items.Count == 0)
                {
                    cbTrangThai.Items.Add("Đặt trước");
                    cbTrangThai.Items.Add("Nhận phòng ngay");
                }
                cbTrangThai.SelectedIndex = 0;

                txtMaPhieu.Text = "P" + DateTime.Now.ToString("yyMMddHH");
                CalculateAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thiết lập mặc định: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region XỬ LÝ SỰ KIỆN

        // Double-click vào phòng trống
        private void gridPhongTrong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataRowView drv = (DataRowView)gridPhongTrong.Rows[e.RowIndex].DataBoundItem;
                if (drv == null) return;

                string maPhong = drv["MaPhong"].ToString();

                // Kiểm tra phòng đã được chọn chưa
                if (dtPhongDaChon.Select($"MaPhong = '{maPhong}'").Length > 0)
                {
                    MessageBox.Show("Phòng này đã được chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Thêm vào dtPhongDaChon
                DataRow newRow = dtPhongDaChon.NewRow();
                newRow["MaPhong"] = maPhong;
                newRow["SoPhong"] = drv["SoPhong"];
                newRow["DonGia"] = drv["DonGia"];
                newRow["SoNgay"] = 1; // Mặc định 1 ngày
                dtPhongDaChon.Rows.Add(newRow);

                CalculateAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Double-click vào dịch vụ
        private void gridDichVu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataRowView drv = (DataRowView)gridDichVu.Rows[e.RowIndex].DataBoundItem;
                if (drv == null) return;

                string maDV = drv["MaDV"].ToString();
                string tenDV = drv["TenDV"].ToString();
                decimal giaDV = Convert.ToDecimal(drv["GiaDV"]);

                // Hiển thị form nhập số lượng
                using (frmInputQuantity frmNhap = new frmInputQuantity(tenDV))
                {
                    if (frmNhap.ShowDialog() == DialogResult.OK)
                    {
                        int soLuong = frmNhap.SoLuong;
                        if (soLuong > 0)
                        {
                            // Kiểm tra xem dịch vụ đã có trong danh sách chưa
                            DataRow[] existingRows = dtDichVuDaDung.Select($"MaDV = '{maDV}'");
                            if (existingRows.Length > 0)
                            {
                                existingRows[0]["SoLuong"] = Convert.ToInt32(existingRows[0]["SoLuong"]) + soLuong;
                            }
                            else
                            {
                                dtDichVuDaDung.Rows.Add(maDV, tenDV, soLuong, giaDV);
                            }
                            CalculateAll();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Click nút Xóa trên lưới Phòng đã chọn
        private void gridPhongDaChon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (Guna2DataGridView)sender;
            if (e.RowIndex >= 0 && grid.Columns["colXoa"] != null && e.ColumnIndex == grid.Columns["colXoa"].Index)
            {
                try
                {
                    dtPhongDaChon.Rows[e.RowIndex].Delete();
                    CalculateAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Click nút Xóa trên lưới Dịch vụ đã dùng
        private void gridDichVuDaDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (Guna2DataGridView)sender;
            if (e.RowIndex >= 0 && grid.Columns["colXoa"] != null && e.ColumnIndex == grid.Columns["colXoa"].Index)
            {
                try
                {
                    dtDichVuDaDung.Rows[e.RowIndex].Delete();
                    CalculateAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Thay đổi ngày
        private void dateNgayDen_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dateNgayDi.Value.Date < dateNgayDen.Value.Date)
                {
                    dateNgayDi.Value = dateNgayDen.Value.Date.AddDays(1);
                }
                CalculateAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật ngày: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateNgayDi_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dateNgayDi.Value.Date < dateNgayDen.Value.Date)
                {
                    dateNgayDi.Value = dateNgayDen.Value.Date.AddDays(1);
                }
                CalculateAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật ngày: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region TÍNH TOÁN VÀ LƯU

        // Tính toán lại toàn bộ
        private void CalculateAll()
        {
            try
            {
                // Tính số ngày
                TimeSpan duration = dateNgayDi.Value.Date - dateNgayDen.Value.Date;
                int soNgay = (int)Math.Max(1, Math.Ceiling(duration.TotalDays));

                // Cập nhật số ngày và tính tiền phòng
                decimal tongTienPhong = 0;
                foreach (DataRow row in dtPhongDaChon.Rows)
                {
                    if (row.RowState != DataRowState.Deleted)
                    {
                        row["SoNgay"] = soNgay;
                        tongTienPhong += Convert.ToDecimal(row["DonGia"]) * soNgay;
                    }
                }
                txtTienPhong.Text = tongTienPhong.ToString("N0");

                // Tính tiền dịch vụ
                decimal tongTienDV = 0;
                foreach (DataRow row in dtDichVuDaDung.Rows)
                {
                    if (row.RowState != DataRowState.Deleted)
                    {
                        tongTienDV += Convert.ToDecimal(row["GiaDV"]) * Convert.ToInt32(row["SoLuong"]);
                    }
                }
                txtTienDichVu.Text = tongTienDV.ToString("N0");

                // Tổng tiền
                decimal tongTien = tongTienPhong + tongTienDV;
                txtTongTien.Text = tongTien.ToString("N0");
            }
            catch (Exception ex)
            {
                // Bỏ qua lỗi tính toán để không làm gián đoạn ứng dụng
                Console.WriteLine("Lỗi tính toán: " + ex.Message);
            }
        }

        // Nút thực hiện (Lưu Đặt Phòng / Nhận Phòng) - SỬA LỖI Ở ĐÂY
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kiểm tra khách hàng - SỬA CÁCH KIỂM TRA
                if (cbKhachHang.SelectedValue == null || string.IsNullOrEmpty(cbKhachHang.SelectedValue.ToString()))
                {
                    MessageBox.Show("Vui lòng chọn khách hàng.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Kiểm tra phòng đã chọn
                if (dtPhongDaChon.Rows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một phòng.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. Kiểm tra mã phiếu
                if (string.IsNullOrWhiteSpace(txtMaPhieu.Text))
                {
                    MessageBox.Show("Vui lòng nhập Mã Phiếu.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maPhieu = txtMaPhieu.Text.Trim();
                string maKH = cbKhachHang.SelectedValue.ToString();
                DateTime ngayDen = dateNgayDen.Value;
                bool laDatPhong = (cbTrangThai.SelectedIndex == 0); // 0 = "Đặt trước"
                bool laNhanPhong = (cbTrangThai.SelectedIndex == 1); // 1 = "Nhận phòng ngay"

                // 2. Mở kết nối và Transaction
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction trans = conn.BeginTransaction();
                    try
                    {
                        if (laDatPhong)
                        {
                            // --- XỬ LÝ ĐẶT PHÒNG TRƯỚC ---
                            string sqlPDP = "INSERT INTO PhieuDatPhong (MaPDP, NgayNhan, TinhTrang, MaKH) VALUES (@MaPhieu, @NgayNhan, N'Đã đặt', @MaKH)";
                            using (SqlCommand cmd = new SqlCommand(sqlPDP, conn, trans))
                            {
                                cmd.Parameters.AddWithValue("@MaPhieu", maPhieu);
                                cmd.Parameters.AddWithValue("@NgayNhan", ngayDen);
                                cmd.Parameters.AddWithValue("@MaKH", maKH);
                                cmd.ExecuteNonQuery();
                            }

                            string sqlCTDP = "INSERT INTO CT_DatPhong (MaPDP, MaPhong) VALUES (@MaPhieu, @MaPhong)";
                            foreach (DataRow row in dtPhongDaChon.Rows)
                            {
                                if (row.RowState != DataRowState.Deleted)
                                {
                                    using (SqlCommand cmd = new SqlCommand(sqlCTDP, conn, trans))
                                    {
                                        cmd.Parameters.AddWithValue("@MaPhieu", maPhieu);
                                        cmd.Parameters.AddWithValue("@MaPhong", row["MaPhong"]);
                                        cmd.ExecuteNonQuery();
                                    }
                                }
                            }
                        }
                        else if (laNhanPhong)
                        {
                            // --- XỬ LÝ NHẬN PHÒNG NGAY ---
                            string sqlPTP = "INSERT INTO PhieuThuePhong (MaPTP, NgayThue, MaKH) VALUES (@MaPhieu, @NgayThue, @MaKH)";
                            using (SqlCommand cmd = new SqlCommand(sqlPTP, conn, trans))
                            {
                                cmd.Parameters.AddWithValue("@MaPhieu", maPhieu);
                                cmd.Parameters.AddWithValue("@NgayThue", ngayDen);
                                cmd.Parameters.AddWithValue("@MaKH", maKH);
                                cmd.ExecuteNonQuery();
                            }

                            string sqlCTTP = "INSERT INTO CT_ThuePhong (MaPTP, MaPhong) VALUES (@MaPhieu, @MaPhong)";
                            string sqlUpdatePhong = "UPDATE Phong SET TinhTrang = N'Đang thuê' WHERE MaPhong = @MaPhong";
                            foreach (DataRow row in dtPhongDaChon.Rows)
                            {
                                if (row.RowState != DataRowState.Deleted)
                                {
                                    using (SqlCommand cmd = new SqlCommand(sqlCTTP, conn, trans))
                                    {
                                        cmd.Parameters.AddWithValue("@MaPhieu", maPhieu);
                                        cmd.Parameters.AddWithValue("@MaPhong", row["MaPhong"]);
                                        cmd.ExecuteNonQuery();
                                    }
                                    using (SqlCommand cmd = new SqlCommand(sqlUpdatePhong, conn, trans))
                                    {
                                        cmd.Parameters.AddWithValue("@MaPhong", row["MaPhong"]);
                                        cmd.ExecuteNonQuery();
                                    }
                                }
                            }

                            // Thêm dịch vụ nếu có
                            if (dtDichVuDaDung.Rows.Count > 0)
                            {
                                string sqlPDV = "INSERT INTO PhieuDV (MaPDV, MaPTP, MaDV, SoLuong, ThanhTien) VALUES (@MaPDV, @MaPhieu, @MaDV, @SoLuong, @ThanhTien)";
                                foreach (DataRow row in dtDichVuDaDung.Rows)
                                {
                                    if (row.RowState != DataRowState.Deleted)
                                    {
                                        string maPDV = "PDV" + Guid.NewGuid().ToString("N").Substring(0, 7);
                                        using (SqlCommand cmd = new SqlCommand(sqlPDV, conn, trans))
                                        {
                                            cmd.Parameters.AddWithValue("@MaPDV", maPDV);
                                            cmd.Parameters.AddWithValue("@MaPhieu", maPhieu);
                                            cmd.Parameters.AddWithValue("@MaDV", row["MaDV"]);
                                            cmd.Parameters.AddWithValue("@SoLuong", row["SoLuong"]);
                                            cmd.Parameters.AddWithValue("@ThanhTien", row["ThanhTien"]);
                                            cmd.ExecuteNonQuery();
                                        }
                                    }
                                }
                            }
                        }

                        // Hoàn tất
                        trans.Commit();
                        MessageBox.Show("Thực hiện thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reset form
                        LoadPhongTrong();
                        dtPhongDaChon.Clear();
                        dtDichVuDaDung.Clear();
                        SetDefaults();
                        cbKhachHang.SelectedIndex = -1;

                    }
                    catch (SqlException sqlex) when (sqlex.Number == 2627)
                    {
                        trans.Rollback();
                        MessageBox.Show($"Mã Phiếu '{maPhieu}' đã tồn tại. Vui lòng nhập mã khác.", "Lỗi Trùng Mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaPhieu.Focus();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        MessageBox.Show("Thực hiện thất bại! Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xử lý: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void panelChiTiet_Paint(object sender, PaintEventArgs e)
        {
            // Có thể thêm mã vẽ tùy chỉnh ở đây nếu cần
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            frmQLKhachHang frmKH = new frmQLKhachHang();
         
            frmKH.ShowDialog();

        }

        private void txtTienPhong_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelPhongTrong_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelDichVu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDichVu_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}