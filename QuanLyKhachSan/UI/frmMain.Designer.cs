using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna2BorderlessForm(this.components);
            this.panelSidebar = new Guna2Panel();
            this.btnDangXuat = new Guna2Button();
            this.btnBaoCao = new Guna2Button();
            this.btnQLDichVu = new Guna2Button();
            this.btnQLNhanVien = new Guna2Button();
            this.btnQLKhachHang = new Guna2Button();
            this.btnQLPhong = new Guna2Button();
            this.btnThanhToan = new Guna2Button();
            this.btnDatPhong = new Guna2Button();
            this.btnSoDoPhong = new Guna2Button();
            this.panelLogo = new Guna2Panel();
            this.labelLogo = new Label();
            this.panelContainer = new Guna2Panel();
            this.panelTopBar = new Guna2Panel();
            this.guna2ControlBoxMin = new Guna2ControlBox();
            this.guna2ControlBoxMax = new Guna2ControlBox();
            this.guna2ControlBoxClose = new Guna2ControlBox();
            this.guna2DragControl1 = new Guna2DragControl(this.components);
            this.panelSidebar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTopBar.SuspendLayout();
            this.SuspendLayout();

            // guna2BorderlessForm1
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;

            // panelSidebar
            this.panelSidebar.BackColor = Color.FromArgb(50, 55, 89);
            this.panelSidebar.Controls.Add(this.btnDangXuat);
            this.panelSidebar.Controls.Add(this.btnBaoCao);
            this.panelSidebar.Controls.Add(this.btnQLDichVu);
            this.panelSidebar.Controls.Add(this.btnQLNhanVien);
            this.panelSidebar.Controls.Add(this.btnQLKhachHang);
            this.panelSidebar.Controls.Add(this.btnQLPhong);
            this.panelSidebar.Controls.Add(this.btnThanhToan);
            this.panelSidebar.Controls.Add(this.btnDatPhong);
            this.panelSidebar.Controls.Add(this.btnSoDoPhong);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Dock = DockStyle.Left;
            this.panelSidebar.Size = new Size(220, 720);

            // Setup button list
            Guna2Button[] buttons =
            {
                btnSoDoPhong, btnDatPhong, btnThanhToan, btnQLPhong,
                btnQLKhachHang, btnQLNhanVien, btnQLDichVu, btnBaoCao, btnDangXuat
            };

            foreach (var btn in buttons)
            {
                btn.Dock = DockStyle.Top;
                btn.FillColor = Color.FromArgb(50, 55, 89);
                btn.Font = new Font("Segoe UI", 10F);
                btn.ForeColor = Color.White;
                btn.TextAlign = HorizontalAlignment.Left;
                btn.Height = 45;
                btn.ImageOffset = new Point(10, 0);
                btn.Padding = new Padding(10, 0, 0, 0);
                btn.HoverState.FillColor = Color.FromArgb(70, 75, 110);
            }

            btnSoDoPhong.Text = "Sơ Đồ Phòng";
            btnDatPhong.Text = "Đặt / Nhận Phòng";
            btnThanhToan.Text = "Thanh Toán";
            btnQLPhong.Text = "Quản Lý Phòng";
            btnQLKhachHang.Text = "Quản Lý Khách Hàng";
            btnQLNhanVien.Text = "Quản Lý Nhân Viên";
            btnQLDichVu.Text = "Quản Lý Dịch Vụ";
            btnBaoCao.Text = "Báo Cáo";
            btnDangXuat.Text = "Đăng Xuất";

            // Gắn event handler
            btnSoDoPhong.Click += btnSoDoPhong_Click;
            btnDatPhong.Click += btnDatPhong_Click;
            btnThanhToan.Click += btnThanhToan_Click;
            btnQLPhong.Click += btnQLPhong_Click;
            btnQLKhachHang.Click += btnQLKhachHang_Click;
            btnQLNhanVien.Click += btnQLNhanVien_Click;
            btnQLDichVu.Click += btnQLDichVu_Click;
            btnBaoCao.Click += btnBaoCao_Click;
            btnDangXuat.Click += btnDangXuat_Click;

            // panelLogo
            this.panelLogo.Controls.Add(this.labelLogo);
            this.panelLogo.Dock = DockStyle.Top;
            this.panelLogo.Size = new Size(220, 95);

            // labelLogo
            this.labelLogo.Dock = DockStyle.Fill;
            this.labelLogo.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            this.labelLogo.ForeColor = Color.White;
            this.labelLogo.TextAlign = ContentAlignment.MiddleCenter;
            this.labelLogo.Text = "KHÁCH SẠN ABC";

            // panelTopBar
            this.panelTopBar.BackColor = Color.WhiteSmoke;
            this.panelTopBar.Dock = DockStyle.Top;
            this.panelTopBar.Size = new Size(1060, 30);
            this.panelTopBar.Controls.Add(this.guna2ControlBoxMin);
            this.panelTopBar.Controls.Add(this.guna2ControlBoxMax);
            this.panelTopBar.Controls.Add(this.guna2ControlBoxClose);

            // guna2ControlBoxClose
            this.guna2ControlBoxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.guna2ControlBoxClose.Location = new Point(1015, 0);
            this.guna2ControlBoxClose.IconColor = Color.Gray;

            // guna2ControlBoxMax
            this.guna2ControlBoxMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.guna2ControlBoxMax.Location = new Point(970, 0);
            this.guna2ControlBoxMax.ControlBoxType = ControlBoxType.MaximizeBox;
            this.guna2ControlBoxMax.IconColor = Color.Gray;

            // guna2ControlBoxMin
            this.guna2ControlBoxMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.guna2ControlBoxMin.Location = new Point(925, 0);
            this.guna2ControlBoxMin.ControlBoxType = ControlBoxType.MinimizeBox;
            this.guna2ControlBoxMin.IconColor = Color.Gray;

            // guna2DragControl1
            this.guna2DragControl1.TargetControl = this.panelTopBar;
            this.guna2DragControl1.TransparentWhileDrag = true;

            // panelContainer
            this.panelContainer.Dock = DockStyle.Fill;
            this.panelContainer.BackColor = Color.White;

            // frmMain
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1280, 720);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTopBar);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Khách Sạn";
            this.Load += new EventHandler(this.frmMain_Load);

            this.panelSidebar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTopBar.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private Guna2BorderlessForm guna2BorderlessForm1;
        private Guna2Panel panelSidebar;
        private Guna2Panel panelLogo;
        private Guna2Button btnSoDoPhong;
        private Guna2Button btnDangXuat;
        private Guna2Button btnBaoCao;
        private Guna2Button btnQLDichVu;
        private Guna2Button btnQLNhanVien;
        private Guna2Button btnQLKhachHang;
        private Guna2Button btnQLPhong;
        private Guna2Button btnThanhToan;
        private Guna2Button btnDatPhong;
        private Label labelLogo;
        private Guna2Panel panelContainer;
        private Guna2Panel panelTopBar;
        private Guna2ControlBox guna2ControlBoxMin;
        private Guna2ControlBox guna2ControlBoxMax;
        private Guna2ControlBox guna2ControlBoxClose;
        private Guna2DragControl guna2DragControl1;
    }
}
