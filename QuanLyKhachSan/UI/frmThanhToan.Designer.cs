namespace QuanLyKhachSan.UI
{
    partial class frmThanhToan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTimKiem = new System.Windows.Forms.Label();
            this.gntxtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gntxtTimKiem2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbTimKiem2 = new System.Windows.Forms.Label();
            this.gntxtRoomNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbSoPhong = new System.Windows.Forms.Label();
            this.lbNgayThanhToan = new System.Windows.Forms.Label();
            this.gnNgayThanhToan = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gnbtnThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gnbtnThanhToan);
            this.panel1.Controls.Add(this.gnNgayThanhToan);
            this.panel1.Controls.Add(this.lbNgayThanhToan);
            this.panel1.Controls.Add(this.gntxtRoomNo);
            this.panel1.Controls.Add(this.lbSoPhong);
            this.panel1.Controls.Add(this.gntxtTimKiem2);
            this.panel1.Controls.Add(this.lbTimKiem2);
            this.panel1.Controls.Add(this.guna2DataGridView1);
            this.panel1.Controls.Add(this.gntxtTimKiem);
            this.panel1.Controls.Add(this.lbTimKiem);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 545);
            this.panel1.TabIndex = 0;
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.AutoSize = true;
            this.lbTimKiem.Location = new System.Drawing.Point(298, 24);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(66, 17);
            this.lbTimKiem.TabIndex = 1;
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
            this.gntxtTimKiem.Location = new System.Drawing.Point(301, 45);
            this.gntxtTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gntxtTimKiem.Name = "gntxtTimKiem";
            this.gntxtTimKiem.PlaceholderText = "Enter FullName";
            this.gntxtTimKiem.SelectedText = "";
            this.gntxtTimKiem.Size = new System.Drawing.Size(268, 48);
            this.gntxtTimKiem.TabIndex = 2;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(32, 111);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 24;
            this.guna2DataGridView1.Size = new System.Drawing.Size(819, 316);
            this.guna2DataGridView1.TabIndex = 3;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // gntxtTimKiem2
            // 
            this.gntxtTimKiem2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gntxtTimKiem2.DefaultText = "";
            this.gntxtTimKiem2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gntxtTimKiem2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gntxtTimKiem2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtTimKiem2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtTimKiem2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtTimKiem2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gntxtTimKiem2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtTimKiem2.Location = new System.Drawing.Point(36, 468);
            this.gntxtTimKiem2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gntxtTimKiem2.Name = "gntxtTimKiem2";
            this.gntxtTimKiem2.PlaceholderText = "Enter FullName";
            this.gntxtTimKiem2.SelectedText = "";
            this.gntxtTimKiem2.Size = new System.Drawing.Size(174, 48);
            this.gntxtTimKiem2.TabIndex = 5;
            // 
            // lbTimKiem2
            // 
            this.lbTimKiem2.AutoSize = true;
            this.lbTimKiem2.Location = new System.Drawing.Point(33, 447);
            this.lbTimKiem2.Name = "lbTimKiem2";
            this.lbTimKiem2.Size = new System.Drawing.Size(66, 17);
            this.lbTimKiem2.TabIndex = 4;
            this.lbTimKiem2.Text = "Tìm kiếm";
            // 
            // gntxtRoomNo
            // 
            this.gntxtRoomNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gntxtRoomNo.DefaultText = "";
            this.gntxtRoomNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gntxtRoomNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gntxtRoomNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtRoomNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gntxtRoomNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtRoomNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gntxtRoomNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gntxtRoomNo.Location = new System.Drawing.Point(255, 468);
            this.gntxtRoomNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gntxtRoomNo.Name = "gntxtRoomNo";
            this.gntxtRoomNo.PlaceholderText = "Room No";
            this.gntxtRoomNo.SelectedText = "";
            this.gntxtRoomNo.Size = new System.Drawing.Size(174, 48);
            this.gntxtRoomNo.TabIndex = 7;
            // 
            // lbSoPhong
            // 
            this.lbSoPhong.AutoSize = true;
            this.lbSoPhong.Location = new System.Drawing.Point(252, 447);
            this.lbSoPhong.Name = "lbSoPhong";
            this.lbSoPhong.Size = new System.Drawing.Size(67, 17);
            this.lbSoPhong.TabIndex = 6;
            this.lbSoPhong.Text = "Số phòng";
            // 
            // lbNgayThanhToan
            // 
            this.lbNgayThanhToan.AutoSize = true;
            this.lbNgayThanhToan.Location = new System.Drawing.Point(472, 447);
            this.lbNgayThanhToan.Name = "lbNgayThanhToan";
            this.lbNgayThanhToan.Size = new System.Drawing.Size(112, 17);
            this.lbNgayThanhToan.TabIndex = 8;
            this.lbNgayThanhToan.Text = "Ngày thanh toán";
            // 
            // gnNgayThanhToan
            // 
            this.gnNgayThanhToan.Checked = true;
            this.gnNgayThanhToan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnNgayThanhToan.ForeColor = System.Drawing.Color.Black;
            this.gnNgayThanhToan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.gnNgayThanhToan.Location = new System.Drawing.Point(475, 468);
            this.gnNgayThanhToan.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gnNgayThanhToan.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gnNgayThanhToan.Name = "gnNgayThanhToan";
            this.gnNgayThanhToan.Size = new System.Drawing.Size(145, 48);
            this.gnNgayThanhToan.TabIndex = 9;
            this.gnNgayThanhToan.Value = new System.DateTime(2025, 10, 24, 20, 2, 4, 201);
            // 
            // gnbtnThanhToan
            // 
            this.gnbtnThanhToan.BorderRadius = 25;
            this.gnbtnThanhToan.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.gnbtnThanhToan.BorderThickness = 1;
            this.gnbtnThanhToan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnbtnThanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnbtnThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnbtnThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnbtnThanhToan.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.gnbtnThanhToan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnbtnThanhToan.ForeColor = System.Drawing.Color.White;
            this.gnbtnThanhToan.Location = new System.Drawing.Point(680, 468);
            this.gnbtnThanhToan.Name = "gnbtnThanhToan";
            this.gnbtnThanhToan.Size = new System.Drawing.Size(163, 48);
            this.gnbtnThanhToan.TabIndex = 10;
            this.gnbtnThanhToan.Text = "Thanh Toán";
            this.gnbtnThanhToan.Click += new System.EventHandler(this.gnbtnThanhToan_Click);
            // 
            // frmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 552);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThanhToan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTimKiem;
        private Guna.UI2.WinForms.Guna2TextBox gntxtTimKiem;
        private Guna.UI2.WinForms.Guna2Button gnbtnThanhToan;
        private Guna.UI2.WinForms.Guna2DateTimePicker gnNgayThanhToan;
        private System.Windows.Forms.Label lbNgayThanhToan;
        private Guna.UI2.WinForms.Guna2TextBox gntxtRoomNo;
        private System.Windows.Forms.Label lbSoPhong;
        private Guna.UI2.WinForms.Guna2TextBox gntxtTimKiem2;
        private System.Windows.Forms.Label lbTimKiem2;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
    }
}