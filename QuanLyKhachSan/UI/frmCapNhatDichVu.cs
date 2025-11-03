using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Linq; // Cần cho .FirstOrDefault()

namespace QuanLyKhachSan // Đảm bảo namespace khớp
{
    public partial class frmCapNhatDichVu : Form
    {
        private string connectionString =
            @"Data Source=admin;Initial Catalog=QuanLyKhachSan;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        private string currentMaPTP; // Mã phiếu thuê phòng đang xử lý
        private string currentSoPhong; // Tên phòng đang xử lý

        public frmCapNhatDichVu(string maPTP, string soPhong)
        {
            InitializeComponent();
            this.currentMaPTP = maPTP;
            this.currentSoPhong = soPhong;
            this.lblTenPhong.Text = $"Cập nhật dịch vụ cho phòng: {soPhong}";
        }

        private void frmCapNhatDichVu_Load(object sender, EventArgs e)
        {
            LoadDichVu();
            LoadDichVuDaDung();
        }

        #region HÀM TẢI DỮ LIỆU

        // Tải danh sách tất cả dịch vụ
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

                    // Cấu hình Grid
                    gridDichVu.Columns["MaDV"].Visible = false;
                    gridDichVu.Columns["TenDV"].HeaderText = "Tên Dịch Vụ";
                    gridDichVu.Columns["TenDV"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    gridDichVu.Columns["GiaDV"].HeaderText = "Đơn Giá";
                    gridDichVu.Columns["GiaDV"].DefaultCellStyle.Format = "N0";
                    gridDichVu.Columns["GiaDV"].Width = 100;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tải dịch vụ đã dùng của phòng này
        private void LoadDichVuDaDung()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT PDV.MaPDV, DV.TenDV, PDV.SoLuong, DV.GiaDV, PDV.ThanhTien 
                        FROM PhieuDV PDV
                        JOIN DichVu DV ON PDV.MaDV = DV.MaDV
                        WHERE PDV.MaPTP = @MaPTP";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@MaPTP", this.currentMaPTP);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridDichVuDaDung.DataSource = dt;

                    // Cấu hình Grid
                    gridDichVuDaDung.AutoGenerateColumns = false; // Tắt tự động
                    gridDichVuDaDung.Columns.Clear(); // Xóa cột cũ

                    gridDichVuDaDung.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaPDV", HeaderText = "Mã PĐV", Name = "colMaPDV", ReadOnly = true, Visible = false });
                    gridDichVuDaDung.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TenDV", HeaderText = "Tên Dịch Vụ", Name = "colTenDV", ReadOnly = true, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
                    gridDichVuDaDung.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SoLuong", HeaderText = "SL", Name = "colSoLuong", ReadOnly = true, Width = 60 });
                    gridDichVuDaDung.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ThanhTien", HeaderText = "Thành Tiền", Name = "colThanhTien", ReadOnly = true, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }, Width = 120 });

                    // Thêm cột Xóa
                    DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
                    btnCol.Name = "colXoa";
                    btnCol.HeaderText = "";
                    btnCol.Text = "Xóa";
                    btnCol.UseColumnTextForButtonValue = true;
                    btnCol.Width = 60;
                    btnCol.FlatStyle = FlatStyle.Flat;
                    btnCol.DefaultCellStyle.BackColor = Color.Tomato;
                    btnCol.DefaultCellStyle.ForeColor = Color.White;
                    gridDichVuDaDung.Columns.Add(btnCol);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dịch vụ đã dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region XỬ LÝ SỰ KIỆN

        // Double-click vào dịch vụ (bên trái) để thêm
        private void gridDichVu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataRowView drv = (DataRowView)gridDichVu.Rows[e.RowIndex].DataBoundItem;
            if (drv == null) return;

            string maDV = drv["MaDV"].ToString();
            string tenDV = drv["TenDV"].ToString();
            decimal giaDV = Convert.ToDecimal(drv["GiaDV"]);

            // Dùng form nhập số lượng (frmInputQuantity bạn đã tạo)
            using (frmInputQuantity frmNhap = new frmInputQuantity(tenDV))
            {
                if (frmNhap.ShowDialog(this) == DialogResult.OK)
                {
                    int soLuong = frmNhap.SoLuong;
                    if (soLuong > 0)
                    {
                        ThemDichVuVaoPhieu(maDV, soLuong, giaDV * soLuong);
                        LoadDichVuDaDung(); // Tải lại lưới bên phải
                    }
                }
            }
        }

        // Click nút Xóa (bên phải)
        private void gridDichVuDaDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gridDichVuDaDung.Columns["colXoa"].Index && e.RowIndex >= 0)
            {
                string maPDV = gridDichVuDaDung.Rows[e.RowIndex].Cells["colMaPDV"].Value.ToString();
                string tenDV = gridDichVuDaDung.Rows[e.RowIndex].Cells["colTenDV"].Value.ToString();

                if (MessageBox.Show($"Bạn có chắc muốn xóa dịch vụ '{tenDV}' khỏi phòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    XoaDichVuKhoiPhieu(maPDV);
                    LoadDichVuDaDung(); // Tải lại lưới
                }
            }
        }

        // Nút Đóng
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region TƯƠNG TÁC CSDL

        private void ThemDichVuVaoPhieu(string maDV, int soLuong, decimal thanhTien)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Tạo MaPDV duy nhất
                    string maPDV = "PDV" + Guid.NewGuid().ToString("N").Substring(0, 7);

                    string query = "INSERT INTO PhieuDV (MaPDV, MaPTP, MaDV, SoLuong, ThanhTien) VALUES (@MaPDV, @MaPTP, @MaDV, @SoLuong, @ThanhTien)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaPDV", maPDV);
                        cmd.Parameters.AddWithValue("@MaPTP", this.currentMaPTP);
                        cmd.Parameters.AddWithValue("@MaDV", maDV);
                        cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                        cmd.Parameters.AddWithValue("@ThanhTien", thanhTien);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XoaDichVuKhoiPhieu(string maPDV)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM PhieuDV WHERE MaPDV = @MaPDV";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaPDV", maPDV);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}