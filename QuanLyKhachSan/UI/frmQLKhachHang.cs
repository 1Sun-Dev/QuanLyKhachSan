using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Guna.UI2.WinForms; // Sử dụng Guna

namespace QuanLyKhachSan // Đảm bảo namespace khớp
{
    public partial class frmQLKhachHang : Form // Kế thừa từ Form
    {
        // 1. Chuỗi kết nối
        private string connectionString =
            @"Data Source=admin;Initial Catalog=QuanLyKhachSan;Integrated Security=True;Encrypt=False";

        public frmQLKhachHang()
        {
            InitializeComponent();
        }

        private void frmQLKhachHang_Load(object sender, EventArgs e)
        {
            LoadGridData();
            ClearForm();
        }

        #region HÀM TẢI DỮ LIỆU VÀ XỬ LÝ FORM

        // Tải dữ liệu chính cho GridView
        private void LoadGridData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT MaKH, HoTen, SDT, CCCD_HoChieu, Email, LoaiKH, DiemTichLuy FROM KhachHang";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvKhachHang.DataSource = dt;

                    // Cấu hình cột
                    dgvKhachHang.Columns["MaKH"].HeaderText = "Mã KH";
                    dgvKhachHang.Columns["HoTen"].HeaderText = "Họ Tên";
                    dgvKhachHang.Columns["SDT"].HeaderText = "SĐT";
                    dgvKhachHang.Columns["CCCD_HoChieu"].HeaderText = "CCCD/Hộ chiếu";
                    dgvKhachHang.Columns["Email"].HeaderText = "Email";
                    dgvKhachHang.Columns["LoaiKH"].HeaderText = "Loại KH";
                    dgvKhachHang.Columns["DiemTichLuy"].HeaderText = "Điểm";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xóa trắng form và mở khóa MaKH
        private void ClearForm()
        {
            txtMaKH.Text = "";
            txtHoTen.Text = "";
            txtSDT.Text = "";
            txtCCCD.Text = "";
            txtEmail.Text = "";
            cmbLoaiKH.SelectedItem = "Vãng lai"; // Đặt mặc định
            spinDiemTichLuy.Value = 0;

            txtMaKH.ReadOnly = false; // Mở khóa Mã KH
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaKH.Focus();
        }

        #endregion

        #region SỰ KIỆN CONTROLS

        // Click vào 1 dòng trên lưới
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvKhachHang.Rows.Count)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];

                txtMaKH.Text = row.Cells["MaKH"].Value?.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
                txtSDT.Text = row.Cells["SDT"].Value?.ToString();
                txtCCCD.Text = row.Cells["CCCD_HoChieu"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                cmbLoaiKH.SelectedItem = row.Cells["LoaiKH"].Value?.ToString();
                spinDiemTichLuy.Value = Convert.ToDecimal(row.Cells["DiemTichLuy"].Value ?? 0);

                // Khóa Mã KH và bật nút Sửa/Xóa
                txtMaKH.ReadOnly = true;
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        // Nút Làm Mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        // Nút Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã Khách hàng.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKH.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ tên Khách hàng.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            string query = @"
                INSERT INTO KhachHang (MaKH, HoTen, SDT, CCCD_HoChieu, Email, LoaiKH, DiemTichLuy)
                VALUES (@MaKH, @HoTen, @SDT, @CCCD, @Email, @LoaiKH, @Diem)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text.Trim());
                        cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text.Trim());
                        cmd.Parameters.AddWithValue("@SDT", (object)txtSDT.Text.Trim() ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@CCCD", (object)txtCCCD.Text.Trim() ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Email", (object)txtEmail.Text.Trim() ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@LoaiKH", cmbLoaiKH.SelectedItem?.ToString() ?? "Vãng lai");
                        cmd.Parameters.AddWithValue("@Diem", (spinDiemTichLuy.Value > 0) ? (object)spinDiemTichLuy.Value : DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGridData();
                ClearForm();
            }
            catch (SqlException sqlex) when (sqlex.Number == 2627) // Lỗi trùng khóa chính
            {
                MessageBox.Show($"Mã khách hàng '{txtMaKH.Text.Trim()}' đã tồn tại.", "Lỗi Trùng Mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaKH.Focus();
                txtMaKH.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text) || txtMaKH.ReadOnly == false)
            {
                MessageBox.Show("Vui lòng chọn một khách hàng từ lưới để sửa.", "Chưa chọn khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"
                UPDATE KhachHang 
                SET HoTen = @HoTen, SDT = @SDT, CCCD_HoChieu = @CCCD, 
                    Email = @Email, LoaiKH = @LoaiKH, DiemTichLuy = @Diem
                WHERE MaKH = @MaKH";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text.Trim());
                        cmd.Parameters.AddWithValue("@SDT", (object)txtSDT.Text.Trim() ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@CCCD", (object)txtCCCD.Text.Trim() ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Email", (object)txtEmail.Text.Trim() ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@LoaiKH", cmbLoaiKH.SelectedItem?.ToString() ?? "Vãng lai");
                        cmd.Parameters.AddWithValue("@Diem", (spinDiemTichLuy.Value > 0) ? (object)spinDiemTichLuy.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text.Trim()); // Điều kiện WHERE

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGridData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text) || txtMaKH.ReadOnly == false)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa.", "Chưa chọn khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa khách hàng '{txtHoTen.Text}' (Mã: {txtMaKH.Text}) không?",
                                     "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = "DELETE FROM KhachHang WHERE MaKH = @MaKH";
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text.Trim());
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGridData();
                    ClearForm();
                }
                catch (SqlException sqlex) when (sqlex.Number == 547) // Lỗi khóa ngoại
                {
                    MessageBox.Show("Không thể xóa khách hàng này vì đang được tham chiếu (ví dụ: trong một phiếu thuê phòng).", "Lỗi Khóa Ngoại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion
    }
}