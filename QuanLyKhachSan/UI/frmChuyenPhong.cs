using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKhachSan 
{
  
    public partial class frmChuyenPhong : Form
    {
        private string connectionString =
            @"Data Source=Phuc-ne;Initial Catalog=QuanLyKhachSan;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        // Biến lưu thông tin được truyền từ frmSoDoPhong
        private string currentMaPTP;
        private string currentMaPhong;
        private string currentSoPhong;

        public frmChuyenPhong(string maPTP, string maPhongHienTai, string soPhongHienTai)
        {
            InitializeComponent();
            this.currentMaPTP = maPTP;
            this.currentMaPhong = maPhongHienTai;
            this.currentSoPhong = soPhongHienTai;
        }

        private void frmChuyenPhong_Load(object sender, EventArgs e)
        {
            // Hiển thị phòng hiện tại
            txtPhongHienTai.Text = this.currentSoPhong;

            // Tải danh sách các phòng "Trống"
            LoadPhongTrong();
        }

        // Tải danh sách phòng trống vào ComboBox
        private void LoadPhongTrong()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Lấy phòng trống VÀ không phải là phòng hiện tại
                    string query = @"
                        SELECT MaPhong, SoPhong 
                        FROM Phong 
                        WHERE TinhTrang = N'Trống' AND MaPhong != @MaPhongHienTai
                        ORDER BY SoPhong";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@MaPhongHienTai", this.currentMaPhong);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbPhongTrong.DataSource = dt;
                    cmbPhongTrong.DisplayMember = "SoPhong";
                    cmbPhongTrong.ValueMember = "MaPhong";
                    cmbPhongTrong.SelectedIndex = -1; // Không chọn gì ban đầu
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách phòng trống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút Hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Nút Thực Hiện Chuyển Phòng
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra
            if (cmbPhongTrong.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn phòng muốn chuyển đến.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maPhongMoi = cmbPhongTrong.SelectedValue.ToString();
            string tenPhongMoi = cmbPhongTrong.Text;

            if (MessageBox.Show($"Bạn có chắc muốn chuyển từ phòng {currentSoPhong} sang phòng {tenPhongMoi}?", "Xác nhận chuyển phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            // 2. Thực hiện Transaction
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    // Lệnh 1: Cập nhật CT_ThuePhong - trỏ sang phòng mới
                    string sqlCTTP = "UPDATE CT_ThuePhong SET MaPhong = @MaPhongMoi WHERE MaPTP = @MaPTP AND MaPhong = @MaPhongCu";
                    using (SqlCommand cmd = new SqlCommand(sqlCTTP, conn, trans))
                    {
                        cmd.Parameters.AddWithValue("@MaPhongMoi", maPhongMoi);
                        cmd.Parameters.AddWithValue("@MaPTP", this.currentMaPTP);
                        cmd.Parameters.AddWithValue("@MaPhongCu", this.currentMaPhong);
                        cmd.ExecuteNonQuery();
                    }

                    // Lệnh 2: Cập nhật Phòng Cũ -> Đang dọn (hoặc Trống)
                    string sqlPhongCu = "UPDATE Phong SET TinhTrang = N'Đang dọn' WHERE MaPhong = @MaPhongCu";
                    using (SqlCommand cmd = new SqlCommand(sqlPhongCu, conn, trans))
                    {
                        cmd.Parameters.AddWithValue("@MaPhongCu", this.currentMaPhong);
                        cmd.ExecuteNonQuery();
                    }

                    // Lệnh 3: Cập nhật Phòng Mới -> Đang thuê
                    string sqlPhongMoi = "UPDATE Phong SET TinhTrang = N'Đang thuê' WHERE MaPhong = @MaPhongMoi";
                    using (SqlCommand cmd = new SqlCommand(sqlPhongMoi, conn, trans))
                    {
                        cmd.Parameters.AddWithValue("@MaPhongMoi", maPhongMoi);
                        cmd.ExecuteNonQuery();
                    }

                    // Hoàn tất
                    trans.Commit();
                    MessageBox.Show("Chuyển phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK; // Đặt kết quả để form SoDoPhong biết cần tải lại
                    this.Close();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Chuyển phòng thất bại! Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}