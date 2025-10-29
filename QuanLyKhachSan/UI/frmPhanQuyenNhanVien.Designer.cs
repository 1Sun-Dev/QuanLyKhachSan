namespace QuanLyKhachSan.UI
{
    partial class frmPhanQuyenNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTimKiem = new System.Windows.Forms.Label();
            this.gntxtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.gnbtnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.dgvPhanQuyen = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HienTai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gnGrbPhanQuyen = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lbPhanQuyen = new System.Windows.Forms.Label();
            this.gnCMBPhanQuyen = new Guna.UI2.WinForms.Guna2ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.gnbtnThem = new Guna.UI2.WinForms.Guna2Button();
            this.gnbtnCapNhat = new Guna.UI2.WinForms.Guna2Button();
            this.gnbtnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.gnElipbtnTimKiem = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gnElipbtnThem = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gnElipbtnCapNhat = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gnElipbtnLamMoi = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanQuyen)).BeginInit();
            this.gnGrbPhanQuyen.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvPhanQuyen);
            this.panel1.Controls.Add(this.gnbtnTimKiem);
            this.panel1.Controls.Add(this.gntxtTimKiem);
            this.panel1.Controls.Add(this.lbTimKiem);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 253);
            this.panel1.TabIndex = 0;
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.AutoSize = true;
            this.lbTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimKiem.Location = new System.Drawing.Point(101, 22);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(74, 20);
            this.lbTimKiem.TabIndex = 0;
            this.lbTimKiem.Text = "Tìm kiếm";
            // 
            // gntxtTimKiem
            // 
            this.gntxtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gntxtTimKiem.DefaultText = "";
            this.gntxtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gntxtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gntxtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gntxtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtTimKiem.Location = new System.Drawing.Point(200, 12);
            this.gntxtTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gntxtTimKiem.Name = "gntxtTimKiem";
            this.gntxtTimKiem.PlaceholderText = "Nhập tên nhân viên";
            this.gntxtTimKiem.SelectedText = "";
            this.gntxtTimKiem.Size = new System.Drawing.Size(272, 42);
            this.gntxtTimKiem.TabIndex = 1;
            // 
            // gnbtnTimKiem
            // 
            this.gnbtnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnbtnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnbtnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnbtnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnbtnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnbtnTimKiem.ForeColor = System.Drawing.Color.White;
            this.gnbtnTimKiem.Location = new System.Drawing.Point(589, 12);
            this.gnbtnTimKiem.Name = "gnbtnTimKiem";
            this.gnbtnTimKiem.Size = new System.Drawing.Size(122, 42);
            this.gnbtnTimKiem.TabIndex = 2;
            this.gnbtnTimKiem.Text = "Tìm kiếm";
            // 
            // dgvPhanQuyen
            // 
            this.dgvPhanQuyen.AllowUserToAddRows = false;
            this.dgvPhanQuyen.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvPhanQuyen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhanQuyen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPhanQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhanQuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.HienTai});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhanQuyen.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPhanQuyen.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPhanQuyen.Location = new System.Drawing.Point(3, 65);
            this.dgvPhanQuyen.Name = "dgvPhanQuyen";
            this.dgvPhanQuyen.ReadOnly = true;
            this.dgvPhanQuyen.RowHeadersVisible = false;
            this.dgvPhanQuyen.RowHeadersWidth = 51;
            this.dgvPhanQuyen.RowTemplate.Height = 24;
            this.dgvPhanQuyen.Size = new System.Drawing.Size(793, 185);
            this.dgvPhanQuyen.TabIndex = 3;
            this.dgvPhanQuyen.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPhanQuyen.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPhanQuyen.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPhanQuyen.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPhanQuyen.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPhanQuyen.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPhanQuyen.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPhanQuyen.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPhanQuyen.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPhanQuyen.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPhanQuyen.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPhanQuyen.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhanQuyen.ThemeStyle.HeaderStyle.Height = 19;
            this.dgvPhanQuyen.ThemeStyle.ReadOnly = true;
            this.dgvPhanQuyen.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPhanQuyen.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPhanQuyen.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPhanQuyen.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPhanQuyen.ThemeStyle.RowsStyle.Height = 24;
            this.dgvPhanQuyen.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPhanQuyen.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MaNV
            // 
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.HeaderText = "Tên nhân viên";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // HienTai
            // 
            this.HienTai.HeaderText = "Hiện tại";
            this.HienTai.MinimumWidth = 6;
            this.HienTai.Name = "HienTai";
            this.HienTai.ReadOnly = true;
            // 
            // gnGrbPhanQuyen
            // 
            this.gnGrbPhanQuyen.Controls.Add(this.checkedListBox1);
            this.gnGrbPhanQuyen.Controls.Add(this.gnCMBPhanQuyen);
            this.gnGrbPhanQuyen.Controls.Add(this.lbPhanQuyen);
            this.gnGrbPhanQuyen.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnGrbPhanQuyen.ForeColor = System.Drawing.Color.Black;
            this.gnGrbPhanQuyen.Location = new System.Drawing.Point(1, 258);
            this.gnGrbPhanQuyen.Name = "gnGrbPhanQuyen";
            this.gnGrbPhanQuyen.Size = new System.Drawing.Size(794, 260);
            this.gnGrbPhanQuyen.TabIndex = 1;
            this.gnGrbPhanQuyen.Text = "Phân quyền";
            // 
            // lbPhanQuyen
            // 
            this.lbPhanQuyen.AutoSize = true;
            this.lbPhanQuyen.BackColor = System.Drawing.Color.White;
            this.lbPhanQuyen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhanQuyen.ForeColor = System.Drawing.Color.Black;
            this.lbPhanQuyen.Location = new System.Drawing.Point(88, 71);
            this.lbPhanQuyen.Name = "lbPhanQuyen";
            this.lbPhanQuyen.Size = new System.Drawing.Size(103, 23);
            this.lbPhanQuyen.TabIndex = 0;
            this.lbPhanQuyen.Text = "Phân quyền";
            // 
            // gnCMBPhanQuyen
            // 
            this.gnCMBPhanQuyen.BackColor = System.Drawing.Color.Transparent;
            this.gnCMBPhanQuyen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gnCMBPhanQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gnCMBPhanQuyen.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gnCMBPhanQuyen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gnCMBPhanQuyen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gnCMBPhanQuyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gnCMBPhanQuyen.ItemHeight = 30;
            this.gnCMBPhanQuyen.Location = new System.Drawing.Point(241, 58);
            this.gnCMBPhanQuyen.Name = "gnCMBPhanQuyen";
            this.gnCMBPhanQuyen.Size = new System.Drawing.Size(244, 36);
            this.gnCMBPhanQuyen.TabIndex = 1;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Quản lý",
            "Lễ tân",
            "Kỹ thuật",
            "Vệ sinh"});
            this.checkedListBox1.Location = new System.Drawing.Point(242, 103);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(242, 129);
            this.checkedListBox1.TabIndex = 2;
            // 
            // gnbtnThem
            // 
            this.gnbtnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnbtnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnbtnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnbtnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnbtnThem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnbtnThem.ForeColor = System.Drawing.Color.White;
            this.gnbtnThem.Location = new System.Drawing.Point(93, 525);
            this.gnbtnThem.Name = "gnbtnThem";
            this.gnbtnThem.Size = new System.Drawing.Size(166, 45);
            this.gnbtnThem.TabIndex = 2;
            this.gnbtnThem.Text = "Thêm";
            // 
            // gnbtnCapNhat
            // 
            this.gnbtnCapNhat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnbtnCapNhat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnbtnCapNhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnbtnCapNhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnbtnCapNhat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnbtnCapNhat.ForeColor = System.Drawing.Color.White;
            this.gnbtnCapNhat.Location = new System.Drawing.Point(320, 525);
            this.gnbtnCapNhat.Name = "gnbtnCapNhat";
            this.gnbtnCapNhat.Size = new System.Drawing.Size(166, 45);
            this.gnbtnCapNhat.TabIndex = 3;
            this.gnbtnCapNhat.Text = "Cập nhật";
            // 
            // gnbtnLamMoi
            // 
            this.gnbtnLamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnbtnLamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnbtnLamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnbtnLamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnbtnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnbtnLamMoi.ForeColor = System.Drawing.Color.White;
            this.gnbtnLamMoi.Location = new System.Drawing.Point(557, 525);
            this.gnbtnLamMoi.Name = "gnbtnLamMoi";
            this.gnbtnLamMoi.Size = new System.Drawing.Size(166, 45);
            this.gnbtnLamMoi.TabIndex = 4;
            this.gnbtnLamMoi.Text = "Làm mới";
            // 
            // gnElipbtnTimKiem
            // 
            this.gnElipbtnTimKiem.TargetControl = this.gnbtnTimKiem;
            // 
            // gnElipbtnThem
            // 
            this.gnElipbtnThem.BorderRadius = 15;
            this.gnElipbtnThem.TargetControl = this.gnbtnThem;
            // 
            // gnElipbtnCapNhat
            // 
            this.gnElipbtnCapNhat.BorderRadius = 15;
            this.gnElipbtnCapNhat.TargetControl = this.gnbtnCapNhat;
            // 
            // gnElipbtnLamMoi
            // 
            this.gnElipbtnLamMoi.BorderRadius = 15;
            this.gnElipbtnLamMoi.TargetControl = this.gnbtnLamMoi;
            // 
            // frmPhanQuyenNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 582);
            this.Controls.Add(this.gnbtnLamMoi);
            this.Controls.Add(this.gnbtnCapNhat);
            this.Controls.Add(this.gnbtnThem);
            this.Controls.Add(this.gnGrbPhanQuyen);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPhanQuyenNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhanQuyenNhanVien";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanQuyen)).EndInit();
            this.gnGrbPhanQuyen.ResumeLayout(false);
            this.gnGrbPhanQuyen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox gntxtTimKiem;
        private System.Windows.Forms.Label lbTimKiem;
        private Guna.UI2.WinForms.Guna2Button gnbtnTimKiem;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPhanQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HienTai;
        private Guna.UI2.WinForms.Guna2GroupBox gnGrbPhanQuyen;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private Guna.UI2.WinForms.Guna2ComboBox gnCMBPhanQuyen;
        private System.Windows.Forms.Label lbPhanQuyen;
        private Guna.UI2.WinForms.Guna2Button gnbtnThem;
        private Guna.UI2.WinForms.Guna2Button gnbtnCapNhat;
        private Guna.UI2.WinForms.Guna2Button gnbtnLamMoi;
        private Guna.UI2.WinForms.Guna2Elipse gnElipbtnTimKiem;
        private Guna.UI2.WinForms.Guna2Elipse gnElipbtnThem;
        private Guna.UI2.WinForms.Guna2Elipse gnElipbtnCapNhat;
        private Guna.UI2.WinForms.Guna2Elipse gnElipbtnLamMoi;
    }
}