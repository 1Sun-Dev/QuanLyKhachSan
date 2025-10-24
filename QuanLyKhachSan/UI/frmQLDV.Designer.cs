namespace QuanLyKhachSan
{
    partial class frmQLDV
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
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvDichVu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtMaDV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenDV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDonGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDonVi = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.pnlNhapLieu = new Guna.UI2.WinForms.Guna2Panel();

            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.pnlNhapLieu.SuspendLayout();
            this.SuspendLayout();

            // 🌟 Form tổng thể
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 255);
            this.ClientSize = new System.Drawing.Size(880, 520);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Text = "Quản lý dịch vụ";

            // 🌟 Tiêu đề
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 64, 128);
            this.lblTitle.Text = "QUẢN LÝ DỊCH VỤ KHÁCH SẠN";
            this.lblTitle.AutoSize = false;
            this.lblTitle.Size = new System.Drawing.Size(600, 50);
            this.lblTitle.Location = new System.Drawing.Point(140, 15);
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;

            // 🌟 Panel nhập liệu
            this.pnlNhapLieu.BorderRadius = 20;
            this.pnlNhapLieu.FillColor = System.Drawing.Color.White;
            this.pnlNhapLieu.ShadowDecoration.Enabled = true;
            this.pnlNhapLieu.ShadowDecoration.Depth = 15;
            this.pnlNhapLieu.Size = new System.Drawing.Size(320, 340);
            this.pnlNhapLieu.Location = new System.Drawing.Point(30, 80);

            // 🌟 Textbox
            this.txtMaDV.PlaceholderText = "Mã dịch vụ";
            this.txtMaDV.BorderRadius = 10;
            this.txtMaDV.Size = new System.Drawing.Size(270, 40);
            this.txtMaDV.Location = new System.Drawing.Point(25, 25);

            this.txtTenDV.PlaceholderText = "Tên dịch vụ";
            this.txtTenDV.BorderRadius = 10;
            this.txtTenDV.Size = new System.Drawing.Size(270, 40);
            this.txtTenDV.Location = new System.Drawing.Point(25, 85);

            this.txtDonGia.PlaceholderText = "Đơn giá";
            this.txtDonGia.BorderRadius = 10;
            this.txtDonGia.Size = new System.Drawing.Size(270, 40);
            this.txtDonGia.Location = new System.Drawing.Point(25, 145);

            this.txtDonVi.PlaceholderText = "Đơn vị tính (VD: Ly, Giờ, Suất...)";
            this.txtDonVi.BorderRadius = 10;
            this.txtDonVi.Size = new System.Drawing.Size(270, 40);
            this.txtDonVi.Location = new System.Drawing.Point(25, 205);

            // 🌟 Thêm vào panel
            this.pnlNhapLieu.Controls.Add(this.txtMaDV);
            this.pnlNhapLieu.Controls.Add(this.txtTenDV);
            this.pnlNhapLieu.Controls.Add(this.txtDonGia);
            this.pnlNhapLieu.Controls.Add(this.txtDonVi);

            // 🌟 DataGridView
            this.dgvDichVu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDichVu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvDichVu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvDichVu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(0, 102, 204);
            this.dgvDichVu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDichVu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(240, 248, 255);
            this.dgvDichVu.ColumnHeadersHeight = 35;
            this.dgvDichVu.Size = new System.Drawing.Size(470, 340);
            this.dgvDichVu.Location = new System.Drawing.Point(370, 80);
            this.dgvDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // 🌟 Nút CRUD
            int y = 440;
            int width = 130;
            int height = 45;
            System.Drawing.Color mainColor = System.Drawing.Color.FromArgb(0, 102, 204);

            this.btnThem.Text = "Thêm";
            this.btnThem.FillColor = mainColor;
            this.btnThem.BorderRadius = 12;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.Size = new System.Drawing.Size(width, height);
            this.btnThem.Location = new System.Drawing.Point(50, y);

            this.btnSua.Text = "Sửa";
            this.btnSua.FillColor = mainColor;
            this.btnSua.BorderRadius = 12;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.Size = new System.Drawing.Size(width, height);
            this.btnSua.Location = new System.Drawing.Point(210, y);

            this.btnXoa.Text = "Xóa";
            this.btnXoa.FillColor = mainColor;
            this.btnXoa.BorderRadius = 12;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Size = new System.Drawing.Size(width, height);
            this.btnXoa.Location = new System.Drawing.Point(370, y);

            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.FillColor = mainColor;
            this.btnLamMoi.BorderRadius = 12;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.Size = new System.Drawing.Size(width + 20, height);
            this.btnLamMoi.Location = new System.Drawing.Point(530, y);

            // 🌟 Thêm vào form
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlNhapLieu);
            this.Controls.Add(this.dgvDichVu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLamMoi);

            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.pnlNhapLieu.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDichVu;
        private Guna.UI2.WinForms.Guna2TextBox txtMaDV;
        private Guna.UI2.WinForms.Guna2TextBox txtTenDV;
        private Guna.UI2.WinForms.Guna2TextBox txtDonGia;
        private Guna.UI2.WinForms.Guna2TextBox txtDonVi;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Panel pnlNhapLieu;

        #endregion
    }
}
