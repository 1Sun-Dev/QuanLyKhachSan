using Guna.UI2.WinForms;
using QuanLyKhachSan.UI;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmLogin : Form
    {
        private readonly string connectionString =
          @"Data Source=DESKTOP-6M2C0FQ\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public frmLogin()
        {
            InitializeComponent();

            // Khởi tạo borderless form
            guna2BorderlessForm1 = new Guna2BorderlessForm();
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6;
        }

        

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDangNhap_Click(sender, e);
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = gntxtTaiKhoan.Text.Trim();  // giờ dùng EMAIL làm tài khoản
            string matKhau = gntxtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(taiKhoan) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ email và mật khẩu.",
                                "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT MatKhau FROM LOGIN WHERE TaiKhoan = @TaiKhoan";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TaiKhoan", taiKhoan); // dùng biến tài khoản thay vì email
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string passwordFromDB = result.ToString().Trim();

                            // 🔹 So sánh trực tiếp vì DB chưa mã hoá
                            if (matKhau == passwordFromDB)
                            {
                                MessageBox.Show("Đăng nhập thành công!", "Thông báo",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Ẩn form login
                                this.Hide();

                                // Mở form chính
                                frmMain mainForm = new frmMain();
                                mainForm.ShowDialog();

                                // Sau khi frmMain đóng, thoát chương trình
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Sai mật khẩu. Vui lòng thử lại.",
                                                "Lỗi Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản không tồn tại.",
                                            "Lỗi Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Thoát chương trình", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frmDangKy dk = new frmDangKy();
            dk.ShowDialog();
            this.Hide();
        }

        private void lbX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkBoxHienMK_CheckedChanged(object sender, EventArgs e)
        {
            gntxtMatKhau.PasswordChar = chkBoxHienMK.Checked ? '\0' : '•';
        }
    }
}
