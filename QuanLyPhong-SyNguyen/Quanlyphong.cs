using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyPhong_SyNguyen
{
 public partial class Quanlyphong : Form
 {
 public Quanlyphong()
 {
  InitializeComponent();

 if (!DesignMode)
 {
 InitializeSampleData();
 }
 }

 private void InitializeSampleData()
 {
 var table = new DataTable();
 table.Columns.Add("RoomID");
 table.Columns.Add("RoomName");
 table.Columns.Add("Type");
 table.Columns.Add("PricePerNight");
 table.Columns.Add("Status");

 table.Rows.Add("R001", "Phòng101", "Deluxe", "500000", "Trống");
 table.Rows.Add("R002", "Phòng102", "Standard", "300000", "Đã thuê");
 table.Rows.Add("R003", "Phòng201", "Suite", "800000", "Trống");

 dgvRooms.DataSource = table;
 }

 private void btnAdd_Click(object sender, EventArgs e)
 {
 using (var f = new Themphong())
 {
 if (f.ShowDialog() == DialogResult.OK)
 {
 
 MessageBox.Show("AddRoomForm returned OK. Bạn có thể xử lý thêm dữ liệu ở đây.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
 }
 }
 }

 private void btnEdit_Click(object sender, EventArgs e)
 {
 if (dgvRooms.SelectedRows.Count ==0)
 {
 MessageBox.Show("Vui lòng chọn phòng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
 return;
 }


 var row = dgvRooms.SelectedRows[0];
 txtDetailType.Text = row.Cells["Type"].Value?.ToString();
 txtDetailPrice.Text = row.Cells["PricePerNight"].Value?.ToString();
 txtDetailStatus.Text = row.Cells["Status"].Value?.ToString();
 txtDetailDescription.Text = row.Cells["RoomName"].Value?.ToString();

 MessageBox.Show("Đã nạp dữ liệu dòng để sửa. Bạn có thể bổ sung logic lưu lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
 }

 private void btnDelete_Click(object sender, EventArgs e)
 {
 if (dgvRooms.SelectedRows.Count ==0)
 {
 MessageBox.Show("Vui lòng chọn phòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
 return;
 }

 var result = MessageBox.Show("Bạn có chắc muốn xóa phòng đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
 if (result == DialogResult.Yes)
 {
 
 MessageBox.Show("Đã xóa (chỉ mô phỏng).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
 }
 }

 private void btnRefresh_Click(object sender, EventArgs e)
 {

 MessageBox.Show("Làm mới danh sách (chỉ mô phỏng).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
 }

 private void txtSearch__TextChanged(object sender, EventArgs e)
 {
 var keyword = txtSearch.Text.Trim().ToLower();
 if (dgvRooms.DataSource is DataTable dt)
 {
 if (string.IsNullOrEmpty(keyword))
 {
 dt.DefaultView.RowFilter = string.Empty;
 }
 else
 {

 dt.DefaultView.RowFilter = $"RoomID LIKE '%{keyword}%' OR RoomName LIKE '%{keyword}%'";
 }
 }
 }

 private void dgvRooms_SelectionChanged(object sender, EventArgs e)
 {
 if (dgvRooms.SelectedRows.Count ==0) return;
 var row = dgvRooms.SelectedRows[0];
 txtDetailType.Text = row.Cells["Type"].Value?.ToString();
 txtDetailPrice.Text = row.Cells["PricePerNight"].Value?.ToString();
 txtDetailStatus.Text = row.Cells["Status"].Value?.ToString();
 txtDetailDescription.Text = row.Cells["RoomName"].Value?.ToString();
 }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
