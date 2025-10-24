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
    public partial class frmThanhToan : Form
    {
        public frmThanhToan()
        {
            InitializeComponent();
        }

        private void gnbtnThanhToan_Click(object sender, EventArgs e)
        {
            frmThanhToan2 thanhToan2 = new frmThanhToan2();
            thanhToan2.ShowDialog();
            this.Hide();
        }
    }
}
