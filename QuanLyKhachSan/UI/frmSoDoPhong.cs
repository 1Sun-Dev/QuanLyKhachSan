using Guna.UI2.WinForms;
using QuanLyKhachSan.UI;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
// Thêm using cho các form khác nếu chúng nằm ở namespace khác, ví dụ:
// using QuanLyKhachSan.UI; 

namespace QuanLyKhachSan
{
    public partial class frmSoDoPhong : Form
    {
        private string connectionString =
            @"Data Source=admin;Initial Catalog=QuanLyKhachSan;Integrated Security=True;Encrypt=False";

        public frmSoDoPhong()
        {
            InitializeComponent();
        }

        private void frmSoDoPhong_Load(object sender, EventArgs e)
        {
            // Gọi hàm load sơ đồ khi form load
            LoadRoomLayout(this.flowLayoutPanelPhong);
        }

        // Tải và vẽ sơ đồ phòng
        private void LoadRoomLayout(FlowLayoutPanel targetPanel)
        {
            if (targetPanel == null)
            {
                MessageBox.Show("Lỗi: flowLayoutPanelPhong chưa được khởi tạo.", "Lỗi Giao Diện", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            targetPanel.Controls.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Lấy đúng tên cột từ CSDL của bạn
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
                        string soPhong = reader["SoPhong"].ToString(); // Dùng SoPhong
                        string tinhTrang = reader["TinhTrang"]?.ToString() ?? "Trống"; // Dùng TinhTrang
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

                        btnPhong.Click += PhongButton_Click;
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

        // Sự kiện khi click vào một nút phòng
        private void PhongButton_Click(object sender, EventArgs e)
        {
            Guna2Button clickedButton = sender as Guna2Button;
            if (clickedButton != null && clickedButton.Tag is Tuple<string, string> roomInfo)
            {
                string maPhong = roomInfo.Item1;
                string tinhTrang = roomInfo.Item2;

                // Lấy form Main (giả sử form này được mở trong form Main)
                frmMain mainForm = this.ParentForm as frmMain;
                if (mainForm == null)
                {
                    // Thử tìm MdiParent nếu cách trên thất bại
                    mainForm = this.MdiParent as frmMain;
                }

                if (mainForm == null)
                {
                    MessageBox.Show("Lỗi: Không tìm thấy form Main để điều hướng.", "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Xử lý nghiệp vụ
                switch (tinhTrang.ToLower())
                {
                    case "trống":
                        // Gọi hàm OpenChildForm CÔNG KHAI của frmMain
                        mainForm.OpenChildForm(new frmDatPhong());
                        break;
                    case "đang thuê":
                        // Gọi hàm OpenChildForm CÔNG KHAI của frmMain
                        mainForm.OpenChildForm(new frmThanhToan());
                        break;
                    case "đang dọn":
                        if (MessageBox.Show($"Phòng {maPhong} đã dọn xong?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (UpdatePhongStatus(maPhong, "Trống"))
                            {
                                LoadRoomLayout(this.flowLayoutPanelPhong);
                                MessageBox.Show($"Đã cập nhật phòng {maPhong} thành Trống.", "Thông báo");
                            }
                        }
                        break;
                }
            }
        }

        // Hàm cập nhật trạng thái phòng trong CSDL
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
    }
}