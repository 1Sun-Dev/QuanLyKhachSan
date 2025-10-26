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
        private frmSoDoPhong soDoPhongForm;
        private frmDanhSachPhong danhSachPhongForm;
        private Guna2Button currentButton;
        private Color activeButtonColor = Color.FromArgb(100, 88, 255);
        private Color defaultButtonColor = Color.FromArgb(50, 55, 89);

        private string connectionString =
        @"Data Source=admin;Initial Catalog=QuanLyKhachSan;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public frmMain()
        {
            InitializeComponent();
        }
        private void ActivateButton(Guna2Button button)
        {
            if (button == null) return;

            // Nếu có nút hiện tại đang sáng -> trả về mặc định
            if (currentButton != null)
            {
                currentButton.FillColor = defaultButtonColor;
                currentButton.ForeColor = Color.White;
                currentButton.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            }

            // Làm sáng nút mới
            currentButton = button;
            currentButton.FillColor = activeButtonColor;
            currentButton.ForeColor = Color.Yellow;
            currentButton.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            
            ActivateButton(btnSoDoPhong);
            OpenChildForm(new frmSoDoPhong());
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
        private void DanhSachPhongForm_PhongDataChanged(object sender, EventArgs e)
        {
            if (soDoPhongForm != null && !soDoPhongForm.IsDisposed)
            {
                soDoPhongForm.ReloadRooms(); 
            }
        }

        private void btnSoDoPhong_Click(object sender, EventArgs e)
        {
            ActivateButton((Guna2Button)sender);
            soDoPhongForm = new frmSoDoPhong();
            OpenChildForm(soDoPhongForm);
        }
        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            ActivateButton((Guna2Button)sender);
            OpenChildForm(new frmDatPhong());
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            ActivateButton((Guna2Button)sender);
            // You need to provide a string argument for 'maPhong' when creating frmThanhToan
            // For example, if you have a selected room code, pass it here. 
            // Replace "someMaPhong" with the actual variable or value you want to use.
            string maPhong = ""; // TODO: Set this to the correct room code
            OpenChildForm(new frmThanhToan(maPhong));
        }
        private void btnQLPhong_Click(object sender, EventArgs e) 
        {
            ActivateButton((Guna2Button)sender);
            danhSachPhongForm = new frmDanhSachPhong();
            danhSachPhongForm.PhongDataChanged += DanhSachPhongForm_PhongDataChanged;
            OpenChildForm(danhSachPhongForm);
        }
        private void btnQLKhachHang_Click(object sender, EventArgs e) 
        {
            ActivateButton((Guna2Button)sender);
            OpenChildForm(new frmQLKhachHang());
        }
        private void btnQLNhanVien_Click(object sender, EventArgs e) 
        {
            ActivateButton((Guna2Button)sender);
            OpenChildForm(new frmNhanVien());
        }
        private void btnQLDichVu_Click(object sender, EventArgs e) 
        {
            ActivateButton((Guna2Button)sender);
            OpenChildForm(new frmQuanLyDichVu());
        }
        private void btnBaoCao_Click(object sender, EventArgs e) 
        {
            ActivateButton((Guna2Button)sender);
            OpenChildForm(new frmViewerBaoCao());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            ActivateButton((Guna2Button)sender); // Có thể bỏ nếu không muốn sáng nút này
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
