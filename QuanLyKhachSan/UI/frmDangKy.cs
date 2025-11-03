using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.UI
{
    public partial class frmDangKy : Form
    {
        string connectionString = @"Data Source=DESKTOP-6M2C0FQ\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True;TrustServerCertificate=True";
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string email = gntxtEmail.Text.Trim();
            string password = gntxtMatKhau.Text.Trim();
            string confirmPassword = gntxtXacNhanMK.Text.Trim();

            // Kiểm tra trống
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra email hợp lệ
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email không hợp lệ! Phải chứa ký tự '@' và đúng định dạng.");
                return;
            }

            // Kiểm tra xác nhận mật khẩu
            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Kiểm tra trùng email
                    string checkQuery = "SELECT COUNT(*) FROM LOGIN WHERE EMAIL = @Email";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Email", email);
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Email này đã được đăng ký!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Thêm user mới
                    string insertQuery = "INSERT INTO LOGIN (EMAIL, PASSWORD) VALUES (@Email, @Password)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Chuyển sang form Login
                        this.Hide();
                        frmLogin lg = new frmLogin();
                        lg.ShowDialog();
                        this.Close();

                        gntxtEmail.Clear();
                        gntxtMatKhau.Clear();
                        gntxtXacNhanMK.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đăng ký: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            gntxtMatKhau.PasswordChar = chkBoxHienThiMK.Checked ? '\0' : '•';
            gntxtXacNhanMK.PasswordChar = chkBoxHienThiMK.Checked ? '\0' : '•';
        }

        private void lbX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmLogin lg = new frmLogin();
            lg.ShowDialog();
            this.Close();
        }
    }
}
