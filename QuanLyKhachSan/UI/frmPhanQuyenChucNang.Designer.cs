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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grBoxChucNang = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lvChucNang = new System.Windows.Forms.ListView();
            this.ChucNang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quyen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grBoxDSNV = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lvNhanVien = new System.Windows.Forms.ListView();
            this.MaNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuQuyen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nmXem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnToanQuyen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnCamQuyen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.grBoxChucNang.SuspendLayout();
            this.grBoxDSNV.SuspendLayout();
            this.contextMenuQuyen.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grBoxChucNang);
            this.panel1.Controls.Add(this.grBoxDSNV);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 284);
            this.panel1.TabIndex = 0;
            // 
            // grBoxChucNang
            // 
            this.grBoxChucNang.Controls.Add(this.lvChucNang);
            this.grBoxChucNang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxChucNang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grBoxChucNang.Location = new System.Drawing.Point(398, 0);
            this.grBoxChucNang.Name = "grBoxChucNang";
            this.grBoxChucNang.Size = new System.Drawing.Size(402, 283);
            this.grBoxChucNang.TabIndex = 1;
            this.grBoxChucNang.Text = "Chức năng";
            // 
            // lvChucNang
            // 
            this.lvChucNang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChucNang,
            this.Quyen});
            this.lvChucNang.FullRowSelect = true;
            this.lvChucNang.HideSelection = false;
            this.lvChucNang.Location = new System.Drawing.Point(2, 40);
            this.lvChucNang.Name = "lvChucNang";
            this.lvChucNang.Size = new System.Drawing.Size(399, 241);
            this.lvChucNang.TabIndex = 0;
            this.lvChucNang.UseCompatibleStateImageBehavior = false;
            this.lvChucNang.View = System.Windows.Forms.View.Details;
            this.lvChucNang.SelectedIndexChanged += new System.EventHandler(this.lvChucNang_SelectedIndexChanged);
            this.lvChucNang.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvChucNang_MouseUp);
            // 
            // ChucNang
            // 
            this.ChucNang.Text = "Chức năng";
            this.ChucNang.Width = 195;
            // 
            // Quyen
            // 
            this.Quyen.Text = "Quyền";
            this.Quyen.Width = 199;
            // 
            // grBoxDSNV
            // 
            this.grBoxDSNV.Controls.Add(this.lvNhanVien);
            this.grBoxDSNV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxDSNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grBoxDSNV.Location = new System.Drawing.Point(1, 0);
            this.grBoxDSNV.Name = "grBoxDSNV";
            this.grBoxDSNV.Size = new System.Drawing.Size(396, 283);
            this.grBoxDSNV.TabIndex = 0;
            this.grBoxDSNV.Text = "Danh sách nhân viên";
            // 
            // lvNhanVien
            // 
            this.lvNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaNV,
            this.HoTen});
            this.lvNhanVien.FullRowSelect = true;
            this.lvNhanVien.HideSelection = false;
            this.lvNhanVien.Location = new System.Drawing.Point(0, 40);
            this.lvNhanVien.Name = "lvNhanVien";
            this.lvNhanVien.Size = new System.Drawing.Size(397, 242);
            this.lvNhanVien.TabIndex = 0;
            this.lvNhanVien.UseCompatibleStateImageBehavior = false;
            this.lvNhanVien.View = System.Windows.Forms.View.Details;
            this.lvNhanVien.SelectedIndexChanged += new System.EventHandler(this.lvNhanVien_SelectedIndexChanged);
            // 
            // MaNV
            // 
            this.MaNV.Text = "Mã nhân viên";
            this.MaNV.Width = 197;
            // 
            // HoTen
            // 
            this.HoTen.Text = "Họ tên";
            this.HoTen.Width = 194;
            // 
            // contextMenuQuyen
            // 
            this.contextMenuQuyen.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuQuyen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nmXem,
            this.toolStripSeparator1,
            this.mnToanQuyen,
            this.toolStripSeparator2,
            this.mnCamQuyen,
            this.toolStripSeparator3});
            this.contextMenuQuyen.Name = "contextMenuStrip1";
            this.contextMenuQuyen.Size = new System.Drawing.Size(159, 100);
            // 
            // nmXem
            // 
            this.nmXem.Image = global::QuanLyKhachSan.Properties.Resources.tải_xuống1;
            this.nmXem.Name = "nmXem";
            this.nmXem.Size = new System.Drawing.Size(214, 26);
            this.nmXem.Text = "Xem";
            this.nmXem.Click += new System.EventHandler(this.nmXem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(211, 6);
            // 
            // mnToanQuyen
            // 
            this.mnToanQuyen.Image = global::QuanLyKhachSan.Properties.Resources.imagestoanquyen1;
            this.mnToanQuyen.Name = "mnToanQuyen";
            this.mnToanQuyen.Size = new System.Drawing.Size(214, 26);
            this.mnToanQuyen.Text = "Toàn quyền";
            this.mnToanQuyen.Click += new System.EventHandler(this.mnToanQuyen_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(211, 6);
            // 
            // mnCamQuyen
            // 
            this.mnCamQuyen.Image = global::QuanLyKhachSan.Properties.Resources.imagescamquyen1;
            this.mnCamQuyen.Name = "mnCamQuyen";
            this.mnCamQuyen.Size = new System.Drawing.Size(214, 26);
            this.mnCamQuyen.Text = "Cấm quyền";
            this.mnCamQuyen.Click += new System.EventHandler(this.mnCamQuyen_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(211, 6);
            // 
            // btnLuu
            // 
            this.btnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(608, 295);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(180, 45);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmPhanQuyenChucNang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 352);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.panel1);
            this.Name = "frmPhanQuyenChucNang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhanQuyenChucNang";
            this.Load += new System.EventHandler(this.frmPhanQuyenChucNang_Load);
            this.panel1.ResumeLayout(false);
            this.grBoxChucNang.ResumeLayout(false);
            this.grBoxDSNV.ResumeLayout(false);
            this.contextMenuQuyen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GroupBox grBoxChucNang;
        private System.Windows.Forms.ListView lvChucNang;
        private System.Windows.Forms.ColumnHeader ChucNang;
        private System.Windows.Forms.ColumnHeader Quyen;
        private Guna.UI2.WinForms.Guna2GroupBox grBoxDSNV;
        private System.Windows.Forms.ListView lvNhanVien;
        private System.Windows.Forms.ColumnHeader MaNV;
        private System.Windows.Forms.ColumnHeader HoTen;
        private System.Windows.Forms.ContextMenuStrip contextMenuQuyen;
        private System.Windows.Forms.ToolStripMenuItem nmXem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnToanQuyen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnCamQuyen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
    }
}