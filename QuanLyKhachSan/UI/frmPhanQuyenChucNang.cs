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
        private ComboBox cmbQuyen = new ComboBox();
        private string connectionString = "Data Source=DESKTOP-6M2C0FQ\\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        public frmPhanQuyenChucNang()
        {
            InitializeComponent();
            cmbQuyen.Items.AddRange(new string[] { "Xem", "Toàn quyền" });
            cmbQuyen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbQuyen.Visible = false;
            cmbQuyen.SelectedIndexChanged += cmbQuyenn_SelectedIndexChanged;
            lvChucNang.Controls.Add(cmbQuyen);

            // Gắn sự kiện click chuột
            lvChucNang.MouseClick += lvChucNang_MouseClick;
            lvChucNang.Leave += lvChucNang_Leave;
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
            lvChucNang.Items.Clear();

            string[] chucnang = { "Đặt phòng", "Thanh toán", "Quản lý phòng", "Quản lý tài sản","Quản lý sản phẩm - dịch vụ", "Quản lý thiết bị" };

            foreach (string cn in chucnang)
            {
                ListViewItem item = new ListViewItem(cn);
                item.SubItems.Add("");
                lvChucNang.Items.Add(item);
            }
        }
        private void LoadQuyenTheoNhanVien(string maNV)
        {

            // Làm mới cột "Quyền" với giá trị mặc định
            // 🧹 1️⃣ Làm mới toàn bộ cột quyền trước
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

                // Xóa quyền cũ
                SqlCommand deleteCmd = new SqlCommand("DELETE FROM PHANQUYEN WHERE MaNV = @MaNV", conn);
                deleteCmd.Parameters.AddWithValue("@MaNV", maNV);
                deleteCmd.ExecuteNonQuery();

                // Ghi quyền mới
                foreach (ListViewItem item in lvChucNang.Items)
                {
                    string chucNang = item.Text;
                    string quyen = item.SubItems[1].Text;

                    if (!string.IsNullOrEmpty(quyen))
                    {
                        string insertQuery = "INSERT INTO PHANQUYEN (MaNV, ChucNang, Quyen) VALUES (@MaNV, @ChucNang, @Quyen)";
                        SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                        insertCmd.Parameters.AddWithValue("@MaNV", maNV);
                        insertCmd.Parameters.AddWithValue("@ChucNang", chucNang);
                        insertCmd.Parameters.AddWithValue("@Quyen", quyen);
                        insertCmd.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("Lưu quyền thành công!");
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
                // 🧹 Nếu bỏ chọn hết nhân viên, cũng làm mới danh sách quyền
                foreach (ListViewItem item in lvChucNang.Items)
                {
                    item.SubItems[1].Text = "Chưa cấp";
                }
            }
        }

        private void lvChucNang_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var item = lvChucNang.GetItemAt(e.X, e.Y);
                if (item != null)
                {
                    lvChucNang.FocusedItem = item;
                    item.Selected = true; // chọn dòng vừa click
                    contextMenuQuyen.Show(lvChucNang, e.Location);
                }
            }
        }

        private void cmbQuyenn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbQuyen.Tag != null)
            {
                ListViewItem item = (ListViewItem)cmbQuyen.Tag;
                item.SubItems[1].Text = cmbQuyen.Text;
            }
            cmbQuyen.Visible = false;
        }

        private void lvChucNang_Leave(object sender, EventArgs e)
        {
            cmbQuyen.Visible = false;
        }

        private void mnXem_Click(object sender, EventArgs e)
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
    }
}
