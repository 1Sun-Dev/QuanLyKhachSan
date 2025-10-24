using System;
using System.Windows.Forms;

namespace QuanLyKhachSan // Đảm bảo namespace khớp
{
    public partial class frmInputQuantity : Form
    {
        public int SoLuong { get; private set; } // Thuộc tính để lấy số lượng

        public frmInputQuantity(string tenDichVu)
        {
            InitializeComponent();
            lblTenDV.Text = $"Nhập số lượng cho:\n{tenDichVu}";
            this.SoLuong = 0; // Mặc định
        }

        // Chỉ cho phép nhập số
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Nút OK
        private void btnOK_Click(object sender, EventArgs e)
        {
            int soLuongNhap = 0;
            if (int.TryParse(txtSoLuong.Text, out soLuongNhap) && soLuongNhap > 0)
            {
                this.SoLuong = soLuongNhap;
                this.DialogResult = DialogResult.OK; // Đặt kết quả
                this.Close(); // Đóng form
            }
            else
            {
                MessageBox.Show("Số lượng phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.SelectAll();
                txtSoLuong.Focus();
            }
        }
    }
}