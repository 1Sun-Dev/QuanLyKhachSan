using System;
using System.Windows.Forms;

namespace QuanLyPhong_SyNguyen
{
 public partial class Themphong : Form
 {
 public Themphong()
 {
 InitializeComponent();
 }

 private void btnSave_Click(object sender, EventArgs e)
 {
 // TODO: validate and pass data back
 this.DialogResult = DialogResult.OK;
 this.Close();
 }

 private void btnCancel_Click(object sender, EventArgs e)
 {
 this.DialogResult = DialogResult.Cancel;
 this.Close();
 }

        private void AddRoomForm_Load(object sender, EventArgs e)
        {

        }
    }
}
