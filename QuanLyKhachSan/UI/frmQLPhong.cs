using System;
using System.Data;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace QuanLyKhachSan
{
    public partial class frmQLPhong : Form
    {
        private DataTable dtPhong;

        public frmQLPhong()
        {
            InitializeComponent();
            LoadData();
            AddEvents();
        }

        private void LoadData()
        {
            // Tạo bảng dữ liệu mẫu
            dtPhong = new DataTable();
            dtPhong.Columns.Add("Mã Phòng");
            dtPhong.Columns.Add("Loại Phòng");
            dtPhong.Columns.Add("Giá");
            dtPhong.Columns.Add("Tình Trạng");

            dtPhong.Rows.Add("P101", "Phòng Đơn", "400000", "Trống");
            dtPhong.Rows.Add("P102", "Phòng Đôi", "600000", "Đã thuê");
            dtPhong.Rows.Add("P201", "Phòng Gia Đình", "900000", "Trống");
            dtPhong.Rows.Add("P202", "Phòng VIP", "1500000", "Đã thuê");

            dgvPhong.DataSource = dtPhong;
        }

        private void AddEvents()
        {
            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            btnLamMoi.Click += BtnLamMoi_Click;
            dgvPhong.CellClick += DgvPhong_CellClick;
        }

        // Khi click vào 1 dòng
        private void DgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaPhong.Text = dgvPhong.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtLoaiPhong.Text = dgvPhong.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtGia.Text = dgvPhong.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTinhTrang.Text = dgvPhong.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text == "" || txtLoaiPhong.Text == "" || txtGia.Text == "" || txtTinhTrang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra mã phòng trùng
            foreach (DataRow row in dtPhong.Rows)
            {
                if (row["Mã Phòng"].ToString() == txtMaPhong.Text)
                {
                    MessageBox.Show("Mã phòng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            dtPhong.Rows.Add(txtMaPhong.Text, txtLoaiPhong.Text, txtGia.Text, txtTinhTrang.Text);
            ClearInput();
            MessageBox.Show("Thêm phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (dgvPhong.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phòng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = dgvPhong.CurrentRow.Index;
            dtPhong.Rows[index]["Mã Phòng"] = txtMaPhong.Text;
            dtPhong.Rows[index]["Loại Phòng"] = txtLoaiPhong.Text;
            dtPhong.Rows[index]["Giá"] = txtGia.Text;
            dtPhong.Rows[index]["Tình Trạng"] = txtTinhTrang.Text;

            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dgvPhong.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa phòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int index = dgvPhong.CurrentRow.Index;
                dtPhong.Rows.RemoveAt(index);
                ClearInput();
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInput();
            LoadData();
        }

        private void ClearInput()
        {
            txtMaPhong.Text = "";
            txtLoaiPhong.Text = "";
            txtGia.Text = "";
            txtTinhTrang.Text = "";
        }
    }
}
