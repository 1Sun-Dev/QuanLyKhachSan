using System;
using System.Data;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace QuanLyKhachSan
{
    public partial class frmNhanVien : Form
    {
        private DataTable dtNhanVien;

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            TaoBangMau();
            dgvNhanVien.DataSource = dtNhanVien;
        }

        private void TaoBangMau()
        {
            dtNhanVien = new DataTable();
            dtNhanVien.Columns.Add("MaNV");
            dtNhanVien.Columns.Add("HoTen");
            dtNhanVien.Columns.Add("GioiTinh");
            dtNhanVien.Columns.Add("NgaySinh");
            dtNhanVien.Columns.Add("SDT");
            dtNhanVien.Columns.Add("DiaChi");
            dtNhanVien.Columns.Add("ChucVu");
            dtNhanVien.Columns.Add("Luong");

            dtNhanVien.Rows.Add("NV01", "Nguyễn Văn A", "Nam", "1998-03-12", "0912345678", "TP.HCM", "Lễ tân", "8000000");
            dtNhanVien.Rows.Add("NV02", "Trần Thị B", "Nữ", "2000-05-21", "0987654321", "Hà Nội", "Buồng phòng", "7500000");
            dtNhanVien.Rows.Add("NV03", "Lê Văn C", "Nam", "1995-11-02", "0905123456", "Đà Nẵng", "Bảo vệ", "7000000");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dtNhanVien.Rows.Add(txtMaNV.Text, txtHoTen.Text, cboGioiTinh.Text,
                dtpNgaySinh.Value.ToString("yyyy-MM-dd"), txtSDT.Text, txtDiaChi.Text, txtChucVu.Text, txtLuong.Text);
            MessageBox.Show("Đã thêm nhân viên thành công!");
            LamMoi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow != null)
            {
                int index = dgvNhanVien.CurrentRow.Index;
                dtNhanVien.Rows[index]["HoTen"] = txtHoTen.Text;
                dtNhanVien.Rows[index]["GioiTinh"] = cboGioiTinh.Text;
                dtNhanVien.Rows[index]["NgaySinh"] = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
                dtNhanVien.Rows[index]["SDT"] = txtSDT.Text;
                dtNhanVien.Rows[index]["DiaChi"] = txtDiaChi.Text;
                dtNhanVien.Rows[index]["ChucVu"] = txtChucVu.Text;
                dtNhanVien.Rows[index]["Luong"] = txtLuong.Text;
                MessageBox.Show("Đã cập nhật thông tin nhân viên!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow != null)
            {
                int index = dgvNhanVien.CurrentRow.Index;
                dtNhanVien.Rows.RemoveAt(index);
                MessageBox.Show("Đã xóa nhân viên!");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void LamMoi()
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            cboGioiTinh.SelectedIndex = -1;
            dtpNgaySinh.Value = DateTime.Now;
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtChucVu.Clear();
            txtLuong.Clear();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                cboGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                dtpNgaySinh.Value = DateTime.Parse(row.Cells["NgaySinh"].Value.ToString());
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtChucVu.Text = row.Cells["ChucVu"].Value.ToString();
                txtLuong.Text = row.Cells["Luong"].Value.ToString();
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
