using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmQLDV : Form
    {
        private DataTable dtDichVu;

        public frmQLDV()
        {
            InitializeComponent();
            LoadData();
            dgvDichVu.CellClick += dgvDichVu_CellClick;
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;
        }

        private void LoadData()
        {
            dtDichVu = new DataTable();
            dtDichVu.Columns.Add("Mã DV");
            dtDichVu.Columns.Add("Tên DV");
            dtDichVu.Columns.Add("Đơn giá");
            dtDichVu.Columns.Add("Đơn vị");

            dtDichVu.Rows.Add("DV01", "Giặt ủi", "50000", "Bộ");
            dtDichVu.Rows.Add("DV02", "Ăn sáng buffet", "150000", "Suất");
            dtDichVu.Rows.Add("DV03", "Thuê xe máy", "200000", "Ngày");
            dtDichVu.Rows.Add("DV04", "Spa thư giãn", "400000", "Giờ");

            dgvDichVu.DataSource = dtDichVu;
        }

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaDV.Text = dgvDichVu.Rows[e.RowIndex].Cells["Mã DV"].Value.ToString();
                txtTenDV.Text = dgvDichVu.Rows[e.RowIndex].Cells["Tên DV"].Value.ToString();
                txtDonGia.Text = dgvDichVu.Rows[e.RowIndex].Cells["Đơn giá"].Value.ToString();
                txtDonVi.Text = dgvDichVu.Rows[e.RowIndex].Cells["Đơn vị"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaDV.Text == "" || txtTenDV.Text == "" || txtDonGia.Text == "" || txtDonVi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }

            if (dtDichVu.AsEnumerable().Any(row => row.Field<string>("Mã DV") == txtMaDV.Text))
            {
                MessageBox.Show("Mã dịch vụ đã tồn tại!", "Lỗi");
                return;
            }

            dtDichVu.Rows.Add(txtMaDV.Text, txtTenDV.Text, txtDonGia.Text, txtDonVi.Text);
            MessageBox.Show("Thêm dịch vụ thành công!");
            LamMoi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDichVu.CurrentRow == null)
            {
                MessageBox.Show("Chọn dịch vụ cần sửa!");
                return;
            }

            var row = dgvDichVu.CurrentRow;
            row.Cells["Mã DV"].Value = txtMaDV.Text;
            row.Cells["Tên DV"].Value = txtTenDV.Text;
            row.Cells["Đơn giá"].Value = txtDonGia.Text;
            row.Cells["Đơn vị"].Value = txtDonVi.Text;

            MessageBox.Show("Sửa dịch vụ thành công!");
            LamMoi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDichVu.CurrentRow == null)
            {
                MessageBox.Show("Chọn dịch vụ cần xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dgvDichVu.Rows.Remove(dgvDichVu.CurrentRow);
                MessageBox.Show("Xóa dịch vụ thành công!");
                LamMoi();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e) => LamMoi();

        private void LamMoi()
        {
            txtMaDV.Clear();
            txtTenDV.Clear();
            txtDonGia.Clear();
            txtDonVi.Clear();
            dgvDichVu.ClearSelection();
        }
    }
}
