using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmKhachHang : Form
    {
        private DataTable dtKH;

        public frmKhachHang()
        {
            InitializeComponent();
            LoadData();
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;
        }

        private void LoadData()
        {
            dtKH = new DataTable();
            dtKH.Columns.Add("MaKH");
            dtKH.Columns.Add("HoTen");
            dtKH.Columns.Add("GioiTinh");
            dtKH.Columns.Add("NgaySinh");
            dtKH.Columns.Add("SDT");
            dtKH.Columns.Add("DiaChi");

            dtKH.Rows.Add("KH01", "Nguyễn Văn A", "Nam", "1995-05-10", "0909123456", "Hà Nội");
            dtKH.Rows.Add("KH02", "Trần Thị B", "Nữ", "1998-07-15", "0987654321", "Đà Nẵng");
            dtKH.Rows.Add("KH03", "Lê Minh C", "Nam", "1990-12-01", "0911222333", "TP.HCM");

            dgvKhachHang.DataSource = dtKH;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dtKH.Rows.Add(txtMaKH.Text, txtHoTen.Text, cboGioiTinh.Text,
                dtpNgaySinh.Value.ToString("yyyy-MM-dd"), txtSDT.Text, txtDiaChi.Text);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow != null)
            {
                var row = dgvKhachHang.CurrentRow;
                row.Cells["HoTen"].Value = txtHoTen.Text;
                row.Cells["GioiTinh"].Value = cboGioiTinh.Text;
                row.Cells["NgaySinh"].Value = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
                row.Cells["SDT"].Value = txtSDT.Text;
                row.Cells["DiaChi"].Value = txtDiaChi.Text;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow != null)
                dgvKhachHang.Rows.RemoveAt(dgvKhachHang.CurrentRow.Index);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            cboGioiTinh.SelectedIndex = -1;
            dtpNgaySinh.Value = DateTime.Now;
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvKhachHang.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells["MaKH"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                cboGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                dtpNgaySinh.Value = DateTime.Parse(row.Cells["NgaySinh"].Value.ToString());
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
