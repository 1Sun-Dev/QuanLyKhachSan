namespace QuanLyKhachSan.UI
{
    partial class frmPhanQuyenChucNang
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
            this.gnElipbtnTimKiem = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gnElipbtnThem = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gnElipbtnCapNhat = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gnElipbtnLamMoi = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.grBoxDSNV = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lvNhanVien = new System.Windows.Forms.ListView();
            this.lvChucNang = new System.Windows.Forms.ListView();
            this.ChucNang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quyen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuQuyen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnXem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnToanQuyen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCamQuyen = new System.Windows.Forms.ToolStripMenuItem();
            this.MaNhV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gnElipbtnLuu = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.grBoxDSNV.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.contextMenuQuyen.SuspendLayout();
            this.SuspendLayout();
            // 
            // gnElipbtnThem
            // 
            this.gnElipbtnThem.BorderRadius = 15;
            // 
            // gnElipbtnCapNhat
            // 
            this.gnElipbtnCapNhat.BorderRadius = 15;
            // 
            // gnElipbtnLamMoi
            // 
            this.gnElipbtnLamMoi.BorderRadius = 15;
            // 
            // btnLuu
            // 
            this.btnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(642, 272);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(146, 45);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // grBoxDSNV
            // 
            this.grBoxDSNV.Controls.Add(this.lvNhanVien);
            this.grBoxDSNV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxDSNV.ForeColor = System.Drawing.Color.Black;
            this.grBoxDSNV.Location = new System.Drawing.Point(-1, 0);
            this.grBoxDSNV.Name = "grBoxDSNV";
            this.grBoxDSNV.Size = new System.Drawing.Size(499, 247);
            this.grBoxDSNV.TabIndex = 3;
            this.grBoxDSNV.Text = "Danh sách nhân viên";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.lvChucNang);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(501, 1);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(298, 246);
            this.guna2GroupBox1.TabIndex = 4;
            this.guna2GroupBox1.Text = "Chức năng";
            // 
            // lvNhanVien
            // 
            this.lvNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaNhV,
            this.HoTen});
            this.lvNhanVien.FullRowSelect = true;
            this.lvNhanVien.HideSelection = false;
            this.lvNhanVien.Location = new System.Drawing.Point(0, 41);
            this.lvNhanVien.Name = "lvNhanVien";
            this.lvNhanVien.Size = new System.Drawing.Size(499, 206);
            this.lvNhanVien.TabIndex = 0;
            this.lvNhanVien.UseCompatibleStateImageBehavior = false;
            this.lvNhanVien.View = System.Windows.Forms.View.Details;
            this.lvNhanVien.SelectedIndexChanged += new System.EventHandler(this.lvNhanVien_SelectedIndexChanged);
            // 
            // lvChucNang
            // 
            this.lvChucNang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChucNang,
            this.Quyen});
            this.lvChucNang.HideSelection = false;
            this.lvChucNang.Location = new System.Drawing.Point(0, 40);
            this.lvChucNang.Name = "lvChucNang";
            this.lvChucNang.Size = new System.Drawing.Size(297, 205);
            this.lvChucNang.TabIndex = 0;
            this.lvChucNang.UseCompatibleStateImageBehavior = false;
            this.lvChucNang.View = System.Windows.Forms.View.Details;
            // 
            // ChucNang
            // 
            this.ChucNang.Text = "Chức năng";
            this.ChucNang.Width = 201;
            // 
            // Quyen
            // 
            this.Quyen.Text = "Quyền";
            this.Quyen.Width = 92;
            // 
            // contextMenuQuyen
            // 
            this.contextMenuQuyen.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuQuyen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnXem,
            this.toolStripSeparator1,
            this.mnToanQuyen,
            this.toolStripSeparator2,
            this.mnCamQuyen,
            this.toolStripSeparator3});
            this.contextMenuQuyen.Name = "contextMenuQuyen";
            this.contextMenuQuyen.Size = new System.Drawing.Size(159, 100);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(155, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(155, 6);
            // 
            // mnXem
            // 
            this.mnXem.Image = global::QuanLyKhachSan.Properties.Resources.tải_xuống;
            this.mnXem.Name = "mnXem";
            this.mnXem.Size = new System.Drawing.Size(158, 26);
            this.mnXem.Text = "Xem";
            this.mnXem.Click += new System.EventHandler(this.mnXem_Click);
            // 
            // mnToanQuyen
            // 
            this.mnToanQuyen.Image = global::QuanLyKhachSan.Properties.Resources.imagestoanquyen;
            this.mnToanQuyen.Name = "mnToanQuyen";
            this.mnToanQuyen.Size = new System.Drawing.Size(158, 26);
            this.mnToanQuyen.Text = "Toàn quyền";
            this.mnToanQuyen.Click += new System.EventHandler(this.mnToanQuyen_Click);
            // 
            // mnCamQuyen
            // 
            this.mnCamQuyen.Image = global::QuanLyKhachSan.Properties.Resources.imagescamquyen;
            this.mnCamQuyen.Name = "mnCamQuyen";
            this.mnCamQuyen.Size = new System.Drawing.Size(158, 26);
            this.mnCamQuyen.Text = "Cấm quyền";
            this.mnCamQuyen.Click += new System.EventHandler(this.mnCamQuyen_Click);
            // 
            // MaNhV
            // 
            this.MaNhV.Text = "Mã nhân viên";
            this.MaNhV.Width = 247;
            // 
            // HoTen
            // 
            this.HoTen.Text = "Họ tên";
            this.HoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HoTen.Width = 248;
            // 
            // gnElipbtnLuu
            // 
            this.gnElipbtnLuu.BorderRadius = 20;
            this.gnElipbtnLuu.TargetControl = this.btnLuu;
            // 
            // frmPhanQuyenChucNang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 329);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.grBoxDSNV);
            this.Controls.Add(this.btnLuu);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPhanQuyenChucNang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhanQuyenChucNang";
            this.Load += new System.EventHandler(this.frmPhanQuyenChucNang_Load);
            this.grBoxDSNV.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.contextMenuQuyen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse gnElipbtnTimKiem;
        private Guna.UI2.WinForms.Guna2Elipse gnElipbtnThem;
        private Guna.UI2.WinForms.Guna2Elipse gnElipbtnCapNhat;
        private Guna.UI2.WinForms.Guna2Elipse gnElipbtnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2GroupBox grBoxDSNV;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.ListView lvNhanVien;
        private System.Windows.Forms.ListView lvChucNang;
        private System.Windows.Forms.ColumnHeader ChucNang;
        private System.Windows.Forms.ColumnHeader Quyen;
        private System.Windows.Forms.ContextMenuStrip contextMenuQuyen;
        private System.Windows.Forms.ToolStripMenuItem mnXem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnToanQuyen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnCamQuyen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ColumnHeader MaNhV;
        private System.Windows.Forms.ColumnHeader HoTen;
        private Guna.UI2.WinForms.Guna2Elipse gnElipbtnLuu;
    }
}