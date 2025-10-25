using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Guna.UI2.WinForms; // Sử dụng Guna

namespace QuanLyKhachSan // Đảm bảo namespace khớp
{
    public partial class frmDanhSachPhong : Form // Kế thừa từ Form
    {
        // 1. Chuỗi kết nối
        private string connectionString =
            @"Data Source=Phuc-ne;Initial Catalog = QuanLyKhachSan; Integrated Security = True";

        public frmDanhSachPhong()
        {
            InitializeComponent();
        }

        private void frmDanhSachPhong_Load(object sender, EventArgs e)
        {
            LoadLoaiPhong();
            LoadNhanVien();
            LoadGridData();
            ClearForm();
        }

        #region HÀM TẢI DỮ LIỆU

        // Tải danh sách Loại phòng vào ComboBox
        private void LoadLoaiPhong()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT MaLP, TenLP FROM LoaiPhong ORDER BY TenLP";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbLoaiPhong.DataSource = dt;
                    cmbLoaiPhong.DisplayMember = "TenLP";
                    cmbLoaiPhong.ValueMember = "MaLP";
                    cmbLoaiPhong.SelectedIndex = -1; // Không chọn gì ban đầu
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải loại phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tải danh sách Nhân viên vào ComboBox
        private void LoadNhanVien()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT MaNV, HoTen FROM NhanVien ORDER BY HoTen";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbNhanVien.DataSource = dt;
                    cmbNhanVien.DisplayMember = "HoTen";
                    cmbNhanVien.ValueMember = "MaNV";
                    cmbNhanVien.SelectedIndex = -1; // Không chọn gì ban đầu
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tải dữ liệu chính cho GridView
        private void LoadGridData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT P.MaPhong, P.SoPhong, P.TinhTrang, P.TANG, 
                               P.MaLP, LP.TenLP, 
                               P.MaNV, NV.HoTen AS TenNV
                        FROM Phong P
                        LEFT JOIN LoaiPhong LP ON P.MaLP = LP.MaLP
                        LEFT JOIN NhanVien NV ON P.MaNV = NV.MaNV
                        ORDER BY P.TANG, P.SoPhong";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPhong.DataSource = dt;

                    // Cấu hình cột (nếu cần AutoGenerateColumns = false)
                    // dgvPhong.Columns["MaPhong"].HeaderText = "Mã Phòng";
                    // ...
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xóa trắng form và mở khóa MaPhong
        private void ClearForm()
        {
            txtMaPhong.Text = "";
            txtSoPhong.Text = "";
            cmbLoaiPhong.SelectedValue = DBNull.Value;
            cmbNhanVien.SelectedValue = DBNull.Value;
            cmbTinhTrang.SelectedItem = "Trống"; // Đặt mặc định
            spinTang.Value = 1; // Đặt tầng 1
            txtMaPhong.ReadOnly = false; // Mở khóa Mã phòng
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaPhong.Focus();
        }

        #endregion

        #region SỰ KIỆN CONTROLS

        // Click vào 1 dòng trên lưới
        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvPhong.Rows.Count)
            {
                DataGridViewRow row = dgvPhong.Rows[e.RowIndex];

                txtMaPhong.Text = row.Cells["MaPhong"].Value?.ToString();
                txtSoPhong.Text = row.Cells["SoPhong"].Value?.ToString();
                cmbTinhTrang.SelectedItem = row.Cells["TinhTrang"].Value?.ToString();
                spinTang.Value = Convert.ToDecimal(row.Cells["TANG"].Value ?? 1);

                // Gán giá trị cho ComboBox bằng ValueMember
                cmbLoaiPhong.SelectedValue = row.Cells["MaLP"].Value ?? DBNull.Value;
                cmbNhanVien.SelectedValue = row.Cells["MaNV"].Value ?? DBNull.Value;

                // Khóa Mã phòng và bật nút Sửa/Xóa
                txtMaPhong.ReadOnly = true;
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        // Nút Làm Mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        // Nút Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhong.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã phòng.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhong.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSoPhong.Text))
            {
                MessageBox.Show("Vui lòng nhập Số phòng (Tên phòng).", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoPhong.Focus();
                return;
            }

            string query = @"
                INSERT INTO Phong (MaPhong, SoPhong, MaLP, MaNV, TinhTrang, TANG) 
                VALUES (@MaPhong, @SoPhong, @MaLP, @MaNV, @TinhTrang, @TANG)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaPhong", txtMaPhong.Text.Trim());
                        cmd.Parameters.AddWithValue("@SoPhong", txtSoPhong.Text.Trim());
                        cmd.Parameters.AddWithValue("@MaLP", cmbLoaiPhong.SelectedValue ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@MaNV", cmbNhanVien.SelectedValue ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@TinhTrang", cmbTinhTrang.SelectedItem?.ToString() ?? "Trống");
                        cmd.Parameters.AddWithValue("@TANG", spinTang.Value);

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Thêm phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGridData();
                ClearForm();
            }
            catch (SqlException sqlex) when (sqlex.Number == 2627) // Lỗi trùng khóa chính
            {
                MessageBox.Show($"Mã phòng '{txtMaPhong.Text.Trim()}' đã tồn tại.", "Lỗi Trùng Mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaPhong.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhong.Text) || txtMaPhong.ReadOnly == false)
            {
                MessageBox.Show("Vui lòng chọn một phòng từ lưới để sửa.", "Chưa chọn phòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"
                UPDATE Phong 
                SET SoPhong = @SoPhong, MaLP = @MaLP, 
                    MaNV = @MaNV, TinhTrang = @TinhTrang, TANG = @TANG
                WHERE MaPhong = @MaPhong";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SoPhong", txtSoPhong.Text.Trim());
                        cmd.Parameters.AddWithValue("@MaLP", cmbLoaiPhong.SelectedValue ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@MaNV", cmbNhanVien.SelectedValue ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@TinhTrang", cmbTinhTrang.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@TANG", spinTang.Value);
                        cmd.Parameters.AddWithValue("@MaPhong", txtMaPhong.Text.Trim()); // Điều kiện WHERE

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Cập nhật phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGridData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhong.Text) || txtMaPhong.ReadOnly == false)
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa.", "Chưa chọn phòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa phòng '{txtSoPhong.Text}' (Mã: {txtMaPhong.Text}) không?",
                                     "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = "DELETE FROM Phong WHERE MaPhong = @MaPhong";
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaPhong", txtMaPhong.Text.Trim());
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Xóa phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGridData();
                    ClearForm();
                }
                catch (SqlException sqlex) when (sqlex.Number == 547) // Lỗi khóa ngoại
                {
                    MessageBox.Show("Không thể xóa phòng này vì đang được tham chiếu (ví dụ: trong một phiếu thuê).", "Lỗi Khóa Ngoại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion
    }
}