using System;
using System.Configuration; // Cần để đọc App.config
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Guna.UI2.WinForms; // Cần cho Guna

namespace QuanLyKhachSan // Đảm bảo namespace khớp
{
   
    public partial class frmDangKyTaiKhoan : Form
    {
        // Lấy chuỗi kết nối từ App.config
        private string connectionString =
     @"Data Source=admin;Initial Catalog=QuanLyKhachSan;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public frmDangKyTaiKhoan()
        {
            InitializeComponent(); // Lỗi 'InitializeComponent' does not exist... sẽ hết
        }

        // Nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Lỗi DialogResult sẽ hết
            this.Close(); // Lỗi Close() sẽ hết
        }

        // Nút Đăng Ký
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text.Trim(); // Lỗi txtTaiKhoan sẽ hết
            string matKhau = txtMatKhau.Text.Trim();
            string nhapLaiMatKhau = txtNhapLaiMatKhau.Text.Trim();
            string email = txtEmail.Text.Trim();

            // 1. Kiểm tra thông tin nhập
            if (string.IsNullOrEmpty(taiKhoan) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(nhapLaiMatKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên đăng nhập và Mật khẩu.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (matKhau != nhapLaiMatKhau)
            {
                MessageBox.Show("Mật khẩu và mật khẩu nhập lại không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhapLaiMatKhau.Focus();
                txtNhapLaiMatKhau.SelectAll();
                return;
            }

            // 2. Băm mật khẩu
           

            // 3. Thêm vào CSDL
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO LOGIN (TaiKhoan, MatKhau, Email) VALUES (@TaiKhoan, @MatKhau, @Email)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                        cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                        cmd.Parameters.AddWithValue("@Email", (object)email ?? DBNull.Value);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (SqlException sqlex) when (sqlex.Number == 2627) // Lỗi trùng khóa chính
            {
                MessageBox.Show($"Tên tài khoản '{taiKhoan}' đã tồn tại. Vui lòng chọn tên khác.", "Lỗi Trùng Tên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTaiKhoan.Focus();
                txtTaiKhoan.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng ký thất bại! Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}