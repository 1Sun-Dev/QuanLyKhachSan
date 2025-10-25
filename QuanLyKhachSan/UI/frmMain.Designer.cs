// Thêm các using cơ bản của WinForms và Guna
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel; // Cần cho IContainer

// Đảm bảo namespace là QuanLyKhachSan
namespace QuanLyKhachSan
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panelSidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.btnBaoCao = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLDichVu = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLKhachHang = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLPhong = new Guna.UI2.WinForms.Guna2Button();
            this.btnThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.btnDatPhong = new Guna.UI2.WinForms.Guna2Button();
            this.btnSoDoPhong = new Guna.UI2.WinForms.Guna2Button();
            this.panelLogo = new Guna.UI2.WinForms.Guna2Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.panelContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.panelTopBar = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBoxMin = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBoxMax = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelSidebar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
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
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(220, 715);
            this.panelSidebar.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangXuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangXuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangXuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDangXuat.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnDangXuat.Location = new System.Drawing.Point(0, 670);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDangXuat.Size = new System.Drawing.Size(220, 45);
            this.btnDangXuat.TabIndex = 9;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBaoCao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBaoCao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBaoCao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBaoCao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaoCao.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnBaoCao.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnBaoCao.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBaoCao.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnBaoCao.Location = new System.Drawing.Point(0, 410);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBaoCao.Size = new System.Drawing.Size(220, 45);
            this.btnBaoCao.TabIndex = 8;
            this.btnBaoCao.Text = "Báo Cáo";
            this.btnBaoCao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnQLDichVu
            // 
            this.btnQLDichVu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQLDichVu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQLDichVu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQLDichVu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQLDichVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLDichVu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnQLDichVu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnQLDichVu.ForeColor = System.Drawing.Color.White;
            this.btnQLDichVu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLDichVu.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnQLDichVu.Location = new System.Drawing.Point(0, 365);
            this.btnQLDichVu.Name = "btnQLDichVu";
            this.btnQLDichVu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQLDichVu.Size = new System.Drawing.Size(220, 45);
            this.btnQLDichVu.TabIndex = 7;
            this.btnQLDichVu.Text = "Quản Lý Dịch Vụ";
            this.btnQLDichVu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLDichVu.Click += new System.EventHandler(this.btnQLDichVu_Click);
            // 
            // btnQLNhanVien
            // 
            this.btnQLNhanVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQLNhanVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQLNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQLNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQLNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLNhanVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnQLNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnQLNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnQLNhanVien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLNhanVien.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnQLNhanVien.Location = new System.Drawing.Point(0, 320);
            this.btnQLNhanVien.Name = "btnQLNhanVien";
            this.btnQLNhanVien.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQLNhanVien.Size = new System.Drawing.Size(220, 45);
            this.btnQLNhanVien.TabIndex = 6;
            this.btnQLNhanVien.Text = "Quản Lý Nhân Viên";
            this.btnQLNhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLNhanVien.Click += new System.EventHandler(this.btnQLNhanVien_Click);
            // 
            // btnQLKhachHang
            // 
            this.btnQLKhachHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQLKhachHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQLKhachHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQLKhachHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQLKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLKhachHang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnQLKhachHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnQLKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnQLKhachHang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLKhachHang.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnQLKhachHang.Location = new System.Drawing.Point(0, 275);
            this.btnQLKhachHang.Name = "btnQLKhachHang";
            this.btnQLKhachHang.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQLKhachHang.Size = new System.Drawing.Size(220, 45);
            this.btnQLKhachHang.TabIndex = 5;
            this.btnQLKhachHang.Text = "Quản Lý Khách Hàng";
            this.btnQLKhachHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLKhachHang.Click += new System.EventHandler(this.btnQLKhachHang_Click);
            // 
            // btnQLPhong
            // 
            this.btnQLPhong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQLPhong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQLPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQLPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQLPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLPhong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnQLPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnQLPhong.ForeColor = System.Drawing.Color.White;
            this.btnQLPhong.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLPhong.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnQLPhong.Location = new System.Drawing.Point(0, 230);
            this.btnQLPhong.Name = "btnQLPhong";
            this.btnQLPhong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQLPhong.Size = new System.Drawing.Size(220, 45);
            this.btnQLPhong.TabIndex = 4;
            this.btnQLPhong.Text = "Quản Lý Phòng";
            this.btnQLPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLPhong.Click += new System.EventHandler(this.btnQLPhong_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThanhToan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThanhToan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThanhToan.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnThanhToan.Location = new System.Drawing.Point(0, 185);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnThanhToan.Size = new System.Drawing.Size(220, 45);
            this.btnThanhToan.TabIndex = 3;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDatPhong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDatPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDatPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDatPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDatPhong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnDatPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDatPhong.ForeColor = System.Drawing.Color.White;
            this.btnDatPhong.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDatPhong.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnDatPhong.Location = new System.Drawing.Point(0, 140);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDatPhong.Size = new System.Drawing.Size(220, 45);
            this.btnDatPhong.TabIndex = 2;
            this.btnDatPhong.Text = "Đặt / Nhận Phòng";
            this.btnDatPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // btnSoDoPhong
            // 
            this.btnSoDoPhong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSoDoPhong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSoDoPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSoDoPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSoDoPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSoDoPhong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnSoDoPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSoDoPhong.ForeColor = System.Drawing.Color.White;
            this.btnSoDoPhong.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSoDoPhong.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnSoDoPhong.Location = new System.Drawing.Point(0, 95);
            this.btnSoDoPhong.Name = "btnSoDoPhong";
            this.btnSoDoPhong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSoDoPhong.Size = new System.Drawing.Size(220, 45);
            this.btnSoDoPhong.TabIndex = 1;
            this.btnSoDoPhong.Text = "Sơ Đồ Phòng";
            this.btnSoDoPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSoDoPhong.Click += new System.EventHandler(this.btnSoDoPhong_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.labelLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 95);
            this.panelLogo.TabIndex = 0;
            // 
            // labelLogo
            // 
            this.labelLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLogo.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.ForeColor = System.Drawing.Color.White;
            this.labelLogo.Location = new System.Drawing.Point(0, 0);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(220, 95);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "KHÁCH SẠN ";
            this.labelLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(220, 30);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1060, 685);
            this.panelContainer.TabIndex = 1;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.White;
            this.panelTopBar.Controls.Add(this.guna2ControlBoxMin);
            this.panelTopBar.Controls.Add(this.guna2ControlBoxMax);
            this.panelTopBar.Controls.Add(this.guna2ControlBoxClose);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(220, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.ShadowDecoration.Depth = 5;
            this.panelTopBar.ShadowDecoration.Enabled = true;
            this.panelTopBar.Size = new System.Drawing.Size(1060, 30);
            this.panelTopBar.TabIndex = 2;
            // 
            // guna2ControlBoxMin
            // 
            this.guna2ControlBoxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBoxMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBoxMin.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBoxMin.IconColor = System.Drawing.Color.DimGray;
            this.guna2ControlBoxMin.Location = new System.Drawing.Point(925, 0);
            this.guna2ControlBoxMin.Name = "guna2ControlBoxMin";
            this.guna2ControlBoxMin.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBoxMin.TabIndex = 2;
            // 
            // guna2ControlBoxMax
            // 
            this.guna2ControlBoxMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBoxMax.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBoxMax.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBoxMax.IconColor = System.Drawing.Color.DimGray;
            this.guna2ControlBoxMax.Location = new System.Drawing.Point(970, 0);
            this.guna2ControlBoxMax.Name = "guna2ControlBoxMax";
            this.guna2ControlBoxMax.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBoxMax.TabIndex = 1;
            // 
            // guna2ControlBoxClose
            // 
            this.guna2ControlBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBoxClose.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBoxClose.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBoxClose.HoverState.IconColor = System.Drawing.Color.White;
            this.guna2ControlBoxClose.IconColor = System.Drawing.Color.DimGray;
            this.guna2ControlBoxClose.Location = new System.Drawing.Point(1015, 0);
            this.guna2ControlBoxClose.Name = "guna2ControlBoxClose";
            this.guna2ControlBoxClose.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBoxClose.TabIndex = 0;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panelTopBar;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 715);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTopBar);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Khách Sạn";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel panelSidebar;
        private Guna.UI2.WinForms.Guna2Panel panelLogo;
        private Guna.UI2.WinForms.Guna2Button btnSoDoPhong;
        private Guna.UI2.WinForms.Guna2Button btnDangXuat;
        private Guna.UI2.WinForms.Guna2Button btnBaoCao;
        private Guna.UI2.WinForms.Guna2Button btnQLDichVu;
        private Guna.UI2.WinForms.Guna2Button btnQLNhanVien;
        private Guna.UI2.WinForms.Guna2Button btnQLKhachHang;
        private Guna.UI2.WinForms.Guna2Button btnQLPhong;
        private Guna.UI2.WinForms.Guna2Button btnThanhToan;
        private Guna.UI2.WinForms.Guna2Button btnDatPhong;
        private System.Windows.Forms.Label labelLogo;
        private Guna.UI2.WinForms.Guna2Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Panel panelTopBar;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBoxMin;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBoxMax;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBoxClose;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}