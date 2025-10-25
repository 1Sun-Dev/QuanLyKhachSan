using Guna.UI2.WinForms;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmMain : Form
    {
        private Form activeForm = null;

        private string connectionString =
           @"Data Source=admin;Initial Catalog=QuanLyKhachSan;Integrated Security=True;Encrypt=False";

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Khi form load, bạn có thể mở mặc định trang "Sơ đồ phòng"
            // OpenChildForm(new frmSoDoPhong());
        }

        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(childForm);
            this.panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

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
            OpenChildForm(new frmViewerBaoCao());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
