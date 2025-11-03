using Guna.UI2.WinForms;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
// Đảm bảo bạn có using namespace chứa các form con, ví dụ:
// using QuanLyKhachSan.Report; 

namespace QuanLyKhachSan
{
    // Kế thừa từ Guna2BorderlessForm
    public partial class frmMain : Form
    {
        private Form activeForm = null;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Mở form Sơ đồ phòng mặc định
            OpenChildForm(new frmSoDoPhong());
        }

        // === HÀM MỞ FORM CON (ĐÃ SỬA LẠI ĐỂ TỐI ƯU) ===
        public void OpenChildForm(Form childForm)
        {
            // Nếu form đang mở là form mới => không làm gì
            if (activeForm != null && activeForm.GetType() == childForm.GetType())
            {
                childForm.Dispose(); // Hủy form mới tạo

                // Nếu là form sơ đồ phòng thì tải lại
                if (activeForm is frmSoDoPhong)
                {
                    (activeForm as frmSoDoPhong).ReloadRooms();
                }
                activeForm.BringToFront(); // Đưa lên trên cùng
                return;
            }

            // Đóng form cũ (nếu có)
            if (activeForm != null)
            {
                this.panelContainer.Controls.Remove(activeForm);
                activeForm.Close();
                activeForm.Dispose();
            }

            // Cấu hình và hiển thị form mới
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(childForm);
            this.panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // === HÀM MỚI: XỬ LÝ CLICK NÚT MENU THU GỌN ===
        private void btnMenu_Click(object sender, EventArgs e)
        {
            // Bật/Tắt panel sidebar
            panelSidebar.Visible = !panelSidebar.Visible;
        }

        #region === Sidebar Button Click Events ===

        private void btnSoDoPhong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSoDoPhong());
        }
        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDatPhong());
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThanhToan());
        }
        private void btnQLPhong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDanhSachPhong());
        }
        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLKhachHang());
        }
        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhanVien());
        }
        private void btnQLDichVu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyDichVu());
        }
        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            // Mở form báo cáo (rdlc)
            OpenChildForm(new frmViewerBaoCao());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;
                this.Hide();
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
            }
        }
        #endregion

        private void menuBaoCao_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           frmDangKyTaiKhoan dk = new frmDangKyTaiKhoan();
              dk.ShowDialog();
        }
    }
}