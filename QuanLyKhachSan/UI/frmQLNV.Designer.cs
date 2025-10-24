using Guna.UI2.WinForms;

namespace QuanLyKhachSan
{
    partial class frmNhanVien
    {
        private Guna2DataGridView dgvNhanVien;
        private Guna2TextBox txtMaNV, txtHoTen, txtSDT, txtDiaChi, txtChucVu, txtLuong;
        private Guna2ComboBox cboGioiTinh;
        private Guna2DateTimePicker dtpNgaySinh;
        private Guna2Button btnThem, btnSua, btnXoa, btnLamMoi;
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvNhanVien = new Guna2DataGridView();
            this.txtMaNV = new Guna2TextBox();
            this.txtHoTen = new Guna2TextBox();
            this.cboGioiTinh = new Guna2ComboBox();
            this.dtpNgaySinh = new Guna2DateTimePicker();
            this.txtSDT = new Guna2TextBox();
            this.txtDiaChi = new Guna2TextBox();
            this.txtChucVu = new Guna2TextBox();
            this.txtLuong = new Guna2TextBox();
            this.btnThem = new Guna2Button();
            this.btnSua = new Guna2Button();
            this.btnXoa = new Guna2Button();
            this.btnLamMoi = new Guna2Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();

            // dgvNhanVien
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(20, 250);
            this.dgvNhanVien.Size = new System.Drawing.Size(850, 250);
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);

            // txtMaNV
            this.txtMaNV.PlaceholderText = "Mã nhân viên";
            this.txtMaNV.Location = new System.Drawing.Point(20, 20);
            this.txtMaNV.Size = new System.Drawing.Size(200, 36);

            // txtHoTen
            this.txtHoTen.PlaceholderText = "Họ tên";
            this.txtHoTen.Location = new System.Drawing.Point(240, 20);
            this.txtHoTen.Size = new System.Drawing.Size(200, 36);

            // cboGioiTinh
            this.cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            this.cboGioiTinh.Location = new System.Drawing.Point(460, 20);
            this.cboGioiTinh.Size = new System.Drawing.Size(120, 36);

            // dtpNgaySinh
            this.dtpNgaySinh.Location = new System.Drawing.Point(600, 20);
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 36);

            // txtSDT
            this.txtSDT.PlaceholderText = "Số điện thoại";
            this.txtSDT.Location = new System.Drawing.Point(20, 70);
            this.txtSDT.Size = new System.Drawing.Size(200, 36);

            // txtDiaChi
            this.txtDiaChi.PlaceholderText = "Địa chỉ";
            this.txtDiaChi.Location = new System.Drawing.Point(240, 70);
            this.txtDiaChi.Size = new System.Drawing.Size(200, 36);

            // txtChucVu
            this.txtChucVu.PlaceholderText = "Chức vụ";
            this.txtChucVu.Location = new System.Drawing.Point(460, 70);
            this.txtChucVu.Size = new System.Drawing.Size(160, 36);

            // txtLuong
            this.txtLuong.PlaceholderText = "Lương";
            this.txtLuong.Location = new System.Drawing.Point(640, 70);
            this.txtLuong.Size = new System.Drawing.Size(160, 36);

            // btnThem
            this.btnThem.Text = "Thêm";
            this.btnThem.Location = new System.Drawing.Point(20, 130);
            this.btnThem.Size = new System.Drawing.Size(100, 40);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // btnSua
            this.btnSua.Text = "Sửa";
            this.btnSua.Location = new System.Drawing.Point(140, 130);
            this.btnSua.Size = new System.Drawing.Size(100, 40);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // btnXoa
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(260, 130);
            this.btnXoa.Size = new System.Drawing.Size(100, 40);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // btnLamMoi
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Location = new System.Drawing.Point(380, 130);
            this.btnLamMoi.Size = new System.Drawing.Size(120, 40);
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            // frmNhanVien
            this.ClientSize = new System.Drawing.Size(900, 520);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.cboGioiTinh);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtChucVu);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLamMoi);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
