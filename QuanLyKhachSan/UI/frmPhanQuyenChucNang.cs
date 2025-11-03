using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.UI
{
    public partial class frmPhanQuyenChucNang : Form
    {
        private string connectionString = "Data Source=DESKTOP-6M2C0FQ\\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        public frmPhanQuyenChucNang()
        {
            InitializeComponent();
            lvChucNang.MouseUp += lvChucNang_MouseUp; // dùng MouseUp thay vì SelectedIndexChanged
        }

        private void frmPhanQuyenChucNang_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
            LoadChucNang();
            lvChucNang.ContextMenuStrip = contextMenuQuyen;

        }
        private void LoadNhanVien()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MaNV, HoTen FROM NhanVien";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                lvNhanVien.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    // Dòng đầu tiên là MaNV (ẩn đi nếu cần)
                    ListViewItem item = new ListViewItem(row["MaNV"].ToString());
                    item.SubItems.Add(row["HoTen"].ToString());
                    lvNhanVien.Items.Add(item);
                }
            }
        }
        private void LoadChucNang()
        {
            // Giả sử bạn có sẵn danh sách chức năng
            lvChucNang.Items.Clear();
            string[] chucNangList = { "Đặt phòng", "Thanh toán", "Quản lý khách hàng", "Phân quyền" };

            foreach (string cn in chucNangList)
            {
                ListViewItem item = new ListViewItem(cn);
                item.SubItems.Add("Chưa cấp");
                lvChucNang.Items.Add(item);
            }
        }
        private void LoadQuyenTheoNhanVien(string maNV)
        {

            // Làm mới trước
            foreach (ListViewItem item in lvChucNang.Items)
            {
                item.SubItems[1].Text = "Chưa cấp";
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ChucNang, Quyen FROM PHANQUYEN WHERE MaNV = @MaNV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNV", maNV);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string chucNang = reader["ChucNang"].ToString();
                    string quyen = reader["Quyen"].ToString();

                    foreach (ListViewItem item in lvChucNang.Items)
                    {
                        if (item.Text == chucNang)
                        {
                            item.SubItems[1].Text = quyen;
                            break;
                        }
                    }
                }
                reader.Close();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (lvNhanVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần phân quyền!");
                return;
            }

            string maNV = lvNhanVien.SelectedItems[0].Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand deleteCmd = new SqlCommand("DELETE FROM PHANQUYEN WHERE MaNV = @MaNV", conn);
                deleteCmd.Parameters.AddWithValue("@MaNV", maNV);
                deleteCmd.ExecuteNonQuery();

                foreach (ListViewItem item in lvChucNang.Items)
                {
                    string chucNang = item.Text;
                    string quyen = item.SubItems[1].Text;

                    if (quyen != "Chưa cấp")
                    {
                        string insert = "INSERT INTO PHANQUYEN (MaNV, ChucNang, Quyen) VALUES (@MaNV, @ChucNang, @Quyen)";
                        SqlCommand cmd = new SqlCommand(insert, conn);
                        cmd.Parameters.AddWithValue("@MaNV", maNV);
                        cmd.Parameters.AddWithValue("@ChucNang", chucNang);
                        cmd.Parameters.AddWithValue("@Quyen", quyen);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("Đã lưu quyền cho nhân viên!");
        }

        private void lvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNhanVien.SelectedItems.Count > 0)
            {
                string maNV = lvNhanVien.SelectedItems[0].Text;
                LoadQuyenTheoNhanVien(maNV);
            }
            else
            {
                foreach (ListViewItem item in lvChucNang.Items)
                    item.SubItems[1].Text = "Chưa cấp";
            }
        }

        private void lvChucNang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNhanVien.SelectedItems.Count > 0)
            {
                string maNV = lvNhanVien.SelectedItems[0].Text;
                LoadQuyenTheoNhanVien(maNV);
            }
            else
            {
                foreach (ListViewItem item in lvChucNang.Items)
                    item.SubItems[1].Text = "Chưa cấp";
            }
        }
        private void CapNhatQuyen(string quyen)
        {
            ListViewItem selectedItem = lvChucNang.FocusedItem;

            if (selectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn chức năng để cấp quyền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            selectedItem.SubItems[1].Text = quyen;
        }

        private void nmXem_Click(object sender, EventArgs e)
        {
            CapNhatQuyen("Xem");
        }

        private void mnToanQuyen_Click(object sender, EventArgs e)
        {
            CapNhatQuyen("Toàn quyền");
        }

        private void mnCamQuyen_Click(object sender, EventArgs e)
        {
            CapNhatQuyen("Cấm quyền");
        }

        private void lvChucNang_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var item = lvChucNang.GetItemAt(e.X, e.Y);
                if (item != null)
                {
                    lvChucNang.FocusedItem = item;
                    item.Selected = true;
                    contextMenuQuyen.Show(lvChucNang, e.Location);
                }
            }
        }
    }
}
