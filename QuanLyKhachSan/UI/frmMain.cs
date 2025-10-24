using System;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            btnNhanVien.Click += (s, e) => OpenChildForm(new frmNhanVien(), "Quản lý Nhân viên");
            btnPhong.Click += (s, e) => OpenChildForm(new frmQLPhong(), "Quản lý Phòng");
            btnDichVu.Click += (s, e) => OpenChildForm(new frmQLDV(), "Quản lý Dịch vụ");
            btnKhachHang.Click += (s, e) => OpenChildForm(new frmKhachHang(), "Quản lý Khách hàng");
            btnThoat.Click += (s, e) => this.Close();
        }

        private void OpenChildForm(Form childForm, string title)
        {
            pnlMain.Controls.Clear();
            lblTitle.Text = "🏨 " + title;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(childForm);
            childForm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
