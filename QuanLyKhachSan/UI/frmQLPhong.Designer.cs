namespace QuanLyKhachSan
{
    partial class frmQLPhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvPhong = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtMaPhong = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLoaiPhong = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTinhTrang = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblTitle.Location = new System.Drawing.Point(195, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ PHÒNG KHÁCH SẠN";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPhong
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.dgvPhong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhong.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhong.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPhong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPhong.Location = new System.Drawing.Point(340, 80);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersVisible = false;
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.RowTemplate.Height = 28;
            this.dgvPhong.Size = new System.Drawing.Size(465, 256);
            this.dgvPhong.TabIndex = 2;
            this.dgvPhong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.dgvPhong.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPhong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPhong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPhong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPhong.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPhong.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPhong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.dgvPhong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPhong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvPhong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPhong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPhong.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvPhong.ThemeStyle.ReadOnly = false;
            this.dgvPhong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPhong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPhong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvPhong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPhong.ThemeStyle.RowsStyle.Height = 28;
            this.dgvPhong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPhong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.BorderRadius = 8;
            this.txtMaPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaPhong.DefaultText = "";
            this.txtMaPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaPhong.Location = new System.Drawing.Point(20, 20);
            this.txtMaPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.PlaceholderText = "Mã phòng";
            this.txtMaPhong.SelectedText = "";
            this.txtMaPhong.Size = new System.Drawing.Size(260, 40);
            this.txtMaPhong.TabIndex = 0;
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.BorderRadius = 8;
            this.txtLoaiPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoaiPhong.DefaultText = "";
            this.txtLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLoaiPhong.Location = new System.Drawing.Point(20, 80);
            this.txtLoaiPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.PlaceholderText = "Loại phòng";
            this.txtLoaiPhong.SelectedText = "";
            this.txtLoaiPhong.Size = new System.Drawing.Size(260, 40);
            this.txtLoaiPhong.TabIndex = 1;
            // 
            // txtGia
            // 
            this.txtGia.BorderRadius = 8;
            this.txtGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGia.DefaultText = "";
            this.txtGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGia.Location = new System.Drawing.Point(20, 140);
            this.txtGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGia.Name = "txtGia";
            this.txtGia.PlaceholderText = "Giá";
            this.txtGia.SelectedText = "";
            this.txtGia.Size = new System.Drawing.Size(260, 40);
            this.txtGia.TabIndex = 2;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.BorderRadius = 8;
            this.txtTinhTrang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTinhTrang.DefaultText = "";
            this.txtTinhTrang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTinhTrang.Location = new System.Drawing.Point(20, 200);
            this.txtTinhTrang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.PlaceholderText = "Tình trạng";
            this.txtTinhTrang.SelectedText = "";
            this.txtTinhTrang.Size = new System.Drawing.Size(260, 40);
            this.txtTinhTrang.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 10;
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(351, 342);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 45);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            // 
            // btnSua
            // 
            this.btnSua.BorderRadius = 10;
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(476, 342);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(72, 45);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 10;
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(586, 342);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(71, 45);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BorderRadius = 10;
            this.btnLamMoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(692, 342);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(113, 45);
            this.btnLamMoi.TabIndex = 6;
            this.btnLamMoi.Text = "Làm mới";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.Controls.Add(this.txtMaPhong);
            this.guna2Panel1.Controls.Add(this.txtLoaiPhong);
            this.guna2Panel1.Controls.Add(this.txtGia);
            this.guna2Panel1.Controls.Add(this.txtTinhTrang);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(20, 80);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Depth = 10;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.Size = new System.Drawing.Size(300, 307);
            this.guna2Panel1.TabIndex = 1;
            // 
            // frmQLPhong
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(830, 480);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLamMoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phòng khách sạn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPhong;
        private Guna.UI2.WinForms.Guna2TextBox txtMaPhong;
        private Guna.UI2.WinForms.Guna2TextBox txtLoaiPhong;
        private Guna.UI2.WinForms.Guna2TextBox txtGia;
        private Guna.UI2.WinForms.Guna2TextBox txtTinhTrang;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;

        #endregion
    }
}
