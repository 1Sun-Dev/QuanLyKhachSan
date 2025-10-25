using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.UI
{
    public partial class frmThanhToan2 : Form
    {
        public frmThanhToan2()
        {
            InitializeComponent();
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            frmThuKhacTT tk = new frmThuKhacTT();   
            tk.ShowDialog();
        }

        private void gnbtnHoanThanh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            frmThanhToan thanhToan = new frmThanhToan();
            thanhToan.ShowDialog();
            this.Close();
        }
    }
}
