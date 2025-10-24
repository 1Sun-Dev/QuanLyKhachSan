using System;
using System.Windows.Forms;

namespace QuanLyPhong_SyNguyen
{
 public partial class Suathongitnphong : Form
 {
 public string RoomID => txtRoomID.Text.Trim();
 public string RoomName => txtRoomName.Text.Trim();
 public string TypeName => txtType.Text.Trim();
 public string PricePerNight => txtPrice.Text.Trim();
 public string Status => txtStatus.Text.Trim();

 public Suathongitnphong(string roomId, string roomName, string type, string price, string status)
 {
 InitializeComponent();


 txtRoomID.Text = roomId;
 txtRoomID.Enabled = false;
 txtRoomName.Text = roomName;
 txtType.Text = type;
 txtPrice.Text = price;
 txtStatus.Text = status;
 }

 private void btnSave_Click(object sender, EventArgs e)
 {

 this.DialogResult = DialogResult.OK;
 this.Close();
 }

 private void btnCancel_Click(object sender, EventArgs e)
 {
 this.DialogResult = DialogResult.Cancel;
 this.Close();
 }

        private void EditRoomForm_Load(object sender, EventArgs e)
        {

        }

        private void txtRoomID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
