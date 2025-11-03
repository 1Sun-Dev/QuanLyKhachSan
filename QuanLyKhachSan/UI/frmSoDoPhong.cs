using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmSoDoPhong : Form
    {
        private string connectionString =
       @"Data Source=admin;Initial Catalog=QuanLyKhachSan;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        // Biến tạm để lưu phòng vừa được click chuột phải
        private string selectedMaPhong = null;
        private string selectedTinhTrang = null;

        public frmSoDoPhong()
        {
            InitializeComponent();

            // Gán sự kiện click cho các mục trong menu
            itemDatPhong.Click += itemDatPhong_Click;
            itemCapNhatDichVu.Click += itemCapNhatDichVu_Click;
            itemChuyenPhong.Click += itemChuyenPhong_Click;
            itemThanhToan.Click += itemThanhToan_Click;
            itemHoanTatDon.Click += itemHoanTatDon_Click;
        }

        private void frmSoDoPhong_Load(object sender, EventArgs e)
        {
            // Gọi hàm load sơ đồ khi form load
            /*LoadRoomLayout(this.flowLayoutPanelPhong);*/
        }

        // === SỬA LỖI 1: THÊM HÀM NÀY ===
        /// <summary>
        /// Hàm public để form Main có thể gọi để tải lại sơ đồ phòng.
        /// </summary>
        public void ReloadRooms()
        {
            LoadRoomLayout(this.flowLayoutPanelPhong);
        }
        // ================================

        // Tải và vẽ sơ đồ phòng
        private void LoadRoomLayout(FlowLayoutPanel targetPanel)
        {
            if (targetPanel == null) return;
            targetPanel.Controls.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT P.MaPhong, P.SoPhong, P.TinhTrang, LP.TenLP 
                        FROM Phong P 
                        LEFT JOIN LoaiPhong LP ON P.MaLP = LP.MaLP 
                        ORDER BY P.TANG, P.SoPhong";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string maPhong = reader["MaPhong"].ToString();
                        string soPhong = reader["SoPhong"].ToString();
                        string tinhTrang = reader["TinhTrang"]?.ToString() ?? "Trống";
                        string tenLP = reader["TenLP"]?.ToString() ?? "N/A";

                        Guna2Button btnPhong = new Guna2Button();

                        btnPhong.Text = $"{soPhong}\n({tenLP})";
                        btnPhong.Width = 150;
                        btnPhong.Height = 100;
                        btnPhong.BorderRadius = 10;
                        btnPhong.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                        btnPhong.Tag = new Tuple<string, string>(maPhong, tinhTrang);
                        btnPhong.Margin = new Padding(10);
                        btnPhong.ForeColor = Color.White;
                        btnPhong.TextAlign = HorizontalAlignment.Center;
                        btnPhong.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                        // Đặt màu nền
                        switch (tinhTrang.ToLower())
                        {
                            case "trống": btnPhong.FillColor = Color.SeaGreen; break;
                            case "đang thuê": btnPhong.FillColor = Color.OrangeRed; break;
                            case "đang dọn": btnPhong.FillColor = Color.SlateGray; break;
                            default: btnPhong.FillColor = Color.Gray; break;
                        }

                        // GÁN SỰ KIỆN MOUSE DOWN
                        btnPhong.MouseDown += new MouseEventHandler(btnPhong_MouseDown);

                        targetPanel.Controls.Add(btnPhong);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải sơ đồ phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // XỬ LÝ KHI CLICK CHUỘT VÀO PHÒNG
        private void btnPhong_MouseDown(object sender, MouseEventArgs e)
        {
            Guna2Button clickedButton = sender as Guna2Button;
            if (clickedButton == null) return;

            Tuple<string, string> roomInfo = clickedButton.Tag as Tuple<string, string>;
            if (roomInfo == null) return;

            // Lưu lại thông tin phòng vừa click
            selectedMaPhong = roomInfo.Item1;
            selectedTinhTrang = roomInfo.Item2.ToLower();

            // Nếu là click phải
            if (e.Button == MouseButtons.Right)
            {
                // Cấu hình menu dựa trên trạng thái phòng
                itemDatPhong.Visible = (selectedTinhTrang == "trống");

                itemCapNhatDichVu.Visible = (selectedTinhTrang == "đang thuê");
                itemChuyenPhong.Visible = (selectedTinhTrang == "đang thuê");
                itemThanhToan.Visible = (selectedTinhTrang == "đang thuê");

                itemHoanTatDon.Visible = (selectedTinhTrang == "đang dọn");

                // Hiển thị menu tại vị trí chuột
                menuPhong.Show(clickedButton, e.Location);
            }
        }


        #region === SỰ KIỆN CLICK CÁC MỤC TRONG MENU ===

        private void itemDatPhong_Click(object sender, EventArgs e)
        {
            if (selectedTinhTrang == "trống")
            {
                frmMain mainForm = this.MdiParent as frmMain;
                if (mainForm == null) mainForm = this.ParentForm as frmMain;

                if (mainForm != null)
                {
                    mainForm.OpenChildForm(new frmDatPhong());
                }
            }
        }

        private void itemThanhToan_Click(object sender, EventArgs e)
        {
            if (selectedTinhTrang == "đang thuê")
            {
                frmMain mainForm = this.MdiParent as frmMain;
                if (mainForm == null) mainForm = this.ParentForm as frmMain;

                if (mainForm != null)
                {
                    mainForm.OpenChildForm(new frmThanhToan(selectedMaPhong));
                }
            }
        }

        private void itemHoanTatDon_Click(object sender, EventArgs e)
        {
            if (selectedTinhTrang == "đang dọn")
            {
                if (MessageBox.Show($"Xác nhận phòng {selectedMaPhong} đã dọn xong?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (UpdatePhongStatus(selectedMaPhong, "Trống"))
                    {
                        LoadRoomLayout(this.flowLayoutPanelPhong); // Tải lại sơ đồ
                    }
                }
            }
        }

        private void itemCapNhatDichVu_Click(object sender, EventArgs e)
        {
            if (selectedTinhTrang == "đang thuê" && !string.IsNullOrEmpty(selectedMaPhong))
            {
                // Bước 1: Tìm MaPTP đang hoạt động của phòng này
                string maPTP = FindActiveMaPTP(selectedMaPhong);

                if (maPTP != null)
                {
                    // Bước 2: Mở form Cập nhật Dịch vụ và truyền MaPTP, SoPhong sang
                    string soPhong = (flowLayoutPanelPhong.Controls.Find(selectedMaPhong, true).FirstOrDefault() as Guna2Button)?.Text.Split('\n')[0];

                    frmCapNhatDichVu frm = new frmCapNhatDichVu(maPTP, soPhong ?? selectedMaPhong);
                    frm.ShowDialog(this); // Hiển thị dạng Dialog
                }
                else
                {
                    MessageBox.Show("Lỗi: Không tìm thấy Phiếu thuê phòng đang hoạt động cho phòng này.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private string FindActiveMaPTP(string maPhong)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                SELECT TOP 1 PTP.MaPTP
                FROM PhieuThuePhong PTP
                JOIN CT_ThuePhong CTP ON PTP.MaPTP = CTP.MaPTP
                WHERE CTP.MaPhong = @MaPhong AND PTP.NgayTra IS NULL
                ORDER BY PTP.NgayThue DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            return result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm Mã phiếu thuê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null; // Không tìm thấy
        }
        // ============================================

        private void itemChuyenPhong_Click(object sender, EventArgs e)
        {
            if (selectedTinhTrang == "đang thuê" && !string.IsNullOrEmpty(selectedMaPhong))
            {
                // Bước 1: Tìm MaPTP đang hoạt động của phòng này
                string maPTP = FindActiveMaPTP(selectedMaPhong);

                if (maPTP != null)
                {
                    // Bước 2: Lấy tên phòng (SoPhong) từ button
                    string soPhongHienTai = "Phòng " + selectedMaPhong; // Giá trị dự phòng
                    var btn = flowLayoutPanelPhong.Controls.OfType<Guna2Button>().FirstOrDefault(b => b.Tag is Tuple<string, string> t && t.Item1 == selectedMaPhong);
                    if (btn != null)
                    {
                        soPhongHienTai = btn.Text.Split('\n')[0]; // Lấy dòng đầu tiên (Tên phòng)
                    }

                    // Bước 3: Mở form Chuyển phòng
                    frmChuyenPhong frm = new frmChuyenPhong(maPTP, selectedMaPhong, soPhongHienTai);

                    // Bước 4: Kiểm tra kết quả và tải lại Sơ đồ phòng
                    if (frm.ShowDialog(this) == DialogResult.OK)
                    {
                        ReloadRooms(); // Tải lại sơ đồ phòng
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi: Không tìm thấy Phiếu thuê phòng đang hoạt động cho phòng này.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion


        // Hàm cập nhật trạng thái phòng (Giữ nguyên)
        private bool UpdatePhongStatus(string maPhong, string newStatus)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Phong SET TinhTrang = @TinhTrang WHERE MaPhong = @MaPhong";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TinhTrang", newStatus);
                        cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi cập nhật trạng thái phòng {maPhong}: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void flowLayoutPanelPhong_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}