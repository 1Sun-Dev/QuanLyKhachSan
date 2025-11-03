namespace QuanLyKhachSan // Đảm bảo namespace khớp
{
    partial class frmCapNhatDichVu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.groupDichVu = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gridDichVu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.groupDaChon = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gridDichVuDaDung = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnDong = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.groupDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDichVu)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.groupDaChon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDichVuDaDung)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnDong);
            this.guna2Panel1.Controls.Add(this.lblTenPhong);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(900, 60);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.BackColor = System.Drawing.Color.White;
            this.lblTenPhong.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.lblTenPhong.Location = new System.Drawing.Point(12, 18);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(273, 25);
            this.lblTenPhong.TabIndex = 0;
            this.lblTenPhong.Text = "Cập nhật dịch vụ cho phòng: ";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2Panel1;
            this.guna2DragControl1.TransparentWhileDrag = true;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.groupDichVu);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 60);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Padding = new System.Windows.Forms.Padding(10, 0, 5, 10);
            this.guna2Panel2.Size = new System.Drawing.Size(400, 540);
            this.guna2Panel2.TabIndex = 1;
            // 
            // groupDichVu
            // 
            this.groupDichVu.Controls.Add(this.gridDichVu);
            this.groupDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupDichVu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupDichVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupDichVu.Location = new System.Drawing.Point(10, 0);
            this.groupDichVu.Name = "groupDichVu";
            this.groupDichVu.Size = new System.Drawing.Size(385, 530);
            this.groupDichVu.TabIndex = 1;
            this.groupDichVu.Text = "Danh sách dịch vụ";
            // 
            // gridDichVu
            // 
            this.gridDichVu.AllowUserToAddRows = false;
            this.gridDichVu.AllowUserToDeleteRows = false;
            this.gridDichVu.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridDichVu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridDichVu.ColumnHeadersHeight = 22;
            this.gridDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDichVu.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridDichVu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridDichVu.Location = new System.Drawing.Point(3, 43);
            this.gridDichVu.Name = "gridDichVu";
            this.gridDichVu.ReadOnly = true;
            this.gridDichVu.RowHeadersVisible = false;
            this.gridDichVu.RowTemplate.Height = 24;
            this.gridDichVu.Size = new System.Drawing.Size(379, 484);
            this.gridDichVu.TabIndex = 0;
            this.gridDichVu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            // ... (Theme properties)
            this.gridDichVu.ThemeStyle.HeaderStyle.Height = 22;
            this.gridDichVu.ThemeStyle.ReadOnly = true;
            this.gridDichVu.ThemeStyle.RowsStyle.Height = 24;
            this.gridDichVu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDichVu_CellDoubleClick);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.groupDaChon);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.Location = new System.Drawing.Point(400, 60);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Padding = new System.Windows.Forms.Padding(5, 0, 10, 10);
            this.guna2Panel3.Size = new System.Drawing.Size(500, 540);
            this.guna2Panel3.TabIndex = 2;
            // 
            // groupDaChon
            // 
            this.groupDaChon.Controls.Add(this.gridDichVuDaDung);
            this.groupDaChon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupDaChon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupDaChon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupDaChon.Location = new System.Drawing.Point(5, 0);
            this.groupDaChon.Name = "groupDaChon";
            this.groupDaChon.Size = new System.Drawing.Size(485, 530);
            this.groupDaChon.TabIndex = 2;
            this.groupDaChon.Text = "Dịch vụ đã sử dụng (Click Xóa)";
            // 
            // gridDichVuDaDung
            // 
            this.gridDichVuDaDung.AllowUserToAddRows = false;
            this.gridDichVuDaDung.AllowUserToDeleteRows = false;
            this.gridDichVuDaDung.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gridDichVuDaDung.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridDichVuDaDung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDichVuDaDung.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridDichVuDaDung.ColumnHeadersHeight = 22;
            this.gridDichVuDaDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDichVuDaDung.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridDichVuDaDung.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridDichVuDaDung.Location = new System.Drawing.Point(3, 43);
            this.gridDichVuDaDung.Name = "gridDichVuDaDung";
            this.gridDichVuDaDung.ReadOnly = true;
            this.gridDichVuDaDung.RowHeadersVisible = false;
            this.gridDichVuDaDung.RowTemplate.Height = 24;
            this.gridDichVuDaDung.Size = new System.Drawing.Size(479, 484);
            this.gridDichVuDaDung.TabIndex = 0;
            this.gridDichVuDaDung.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            // ... (Theme properties)
            this.gridDichVuDaDung.ThemeStyle.HeaderStyle.Height = 22;
            this.gridDichVuDaDung.ThemeStyle.ReadOnly = true;
            this.gridDichVuDaDung.ThemeStyle.RowsStyle.Height = 24;
            this.gridDichVuDaDung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDichVuDaDung_CellContentClick);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.BorderRadius = 5;
            this.btnDong.DialogResult = System.Windows.Forms.DialogResult.OK; // Tự động đóng form
            this.btnDong.FillColor = System.Drawing.Color.Gray;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(808, 12);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(80, 35);
            this.btnDong.TabIndex = 7;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmCapNhatDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCapNhatDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cập nhật Dịch vụ";
            this.Load += new System.EventHandler(this.frmCapNhatDichVu_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.groupDichVu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDichVu)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.groupDaChon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDichVuDaDung)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label lblTenPhong;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2GroupBox groupDichVu;
        private Guna.UI2.WinForms.Guna2DataGridView gridDichVu;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2GroupBox groupDaChon;
        private Guna.UI2.WinForms.Guna2DataGridView gridDichVuDaDung;
        private Guna.UI2.WinForms.Guna2Button btnDong;
    }
}