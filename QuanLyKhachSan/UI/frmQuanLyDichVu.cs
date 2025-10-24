using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Guna.UI2.WinForms; // Sử dụng Guna

namespace QuanLyKhachSan // Đảm bảo namespace khớp
{
    public partial class frmQuanLyDichVu : Form // Kế thừa từ Form
    {
        // 1. Chuỗi kết nối
        private string connectionString =
            @"Data Source=admin;Initial Catalog=QuanLyKhachSan;Integrated Security=True;Encrypt=False";

        public frmQuanLyDichVu()
        {
            InitializeComponent();
        }

        private void frmQuanLyDichVu_Load(object sender, EventArgs e)
        {
            LoadLoaiDichVu();
            LoadGridData();
            ClearForm();
        }

        #region HÀM TẢI DỮ LIỆU VÀ XỬ LÝ FORM

        // Tải danh sách Loại dịch vụ vào ComboBox
        private void LoadLoaiDichVu()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT MaLDV, TenLDV FROM LoaiDV ORDER BY TenLDV";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbLoaiDV.DataSource = dt;
                    cmbLoaiDV.DisplayMember = "TenLDV";
                    cmbLoaiDV.ValueMember = "MaLDV";
                    cmbLoaiDV.SelectedIndex = -1; // Không chọn gì ban đầu
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải loại dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        SELECT DV.MaDV, DV.TenDV, DV.GiaDV, DV.MaLDV, LDV.TenLDV 
                        FROM DichVu DV 
                        LEFT JOIN LoaiDV LDV ON DV.MaLDV = LDV.MaLDV";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvDichVu.DataSource = dt;

                    // Cấu hình cột (nếu AutoGenerateColumns = false, nhưng ở đây đang là true)
                    dgvDichVu.Columns["MaDV"].HeaderText = "Mã DV";
                    dgvDichVu.Columns["TenDV"].HeaderText = "Tên Dịch Vụ";
                    dgvDichVu.Columns["GiaDV"].HeaderText = "Đơn Giá";
                    dgvDichVu.Columns["GiaDV"].DefaultCellStyle.Format = "N0";
                    dgvDichVu.Columns["TenLDV"].HeaderText = "Loại Dịch Vụ";
                    dgvDichVu.Columns["MaLDV"].Visible = false; // Ẩn cột mã loại
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xóa trắng form và mở khóa MaDV
        private void ClearForm()
        {
            txtMaDV.Text = "";
            txtTenDV.Text = "";
            spinGiaDV.Value = 0;
            cmbLoaiDV.SelectedValue = DBNull.Value;

            txtMaDV.ReadOnly = false; // Mở khóa Mã
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaDV.Focus();
        }

        #endregion

        #region SỰ KIỆN CONTROLS

        // Click vào 1 dòng trên lưới
        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDichVu.Rows.Count)
            {
                DataGridViewRow row = dgvDichVu.Rows[e.RowIndex];

                txtMaDV.Text = row.Cells["MaDV"].Value?.ToString();
                txtTenDV.Text = row.Cells["TenDV"].Value?.ToString();
                spinGiaDV.Value = Convert.ToDecimal(row.Cells["GiaDV"].Value ?? 0);
                cmbLoaiDV.SelectedValue = row.Cells["MaLDV"].Value ?? DBNull.Value; // Gán bằng ValueMember

                // Khóa Mã DV và bật nút Sửa/Xóa
                txtMaDV.ReadOnly = true;
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
            if (string.IsNullOrWhiteSpace(txtMaDV.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã Dịch Vụ.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaDV.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTenDV.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên Dịch Vụ.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDV.Focus();
                return;
            }

            string query = "INSERT INTO DichVu (MaDV, TenDV, GiaDV, MaLDV) VALUES (@MaDV, @TenDV, @GiaDV, @MaLDV)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaDV", txtMaDV.Text.Trim());
                        cmd.Parameters.AddWithValue("@TenDV", txtTenDV.Text.Trim());
                        cmd.Parameters.AddWithValue("@GiaDV", (spinGiaDV.Value > 0) ? (object)spinGiaDV.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@MaLDV", cmbLoaiDV.SelectedValue ?? (object)DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Thêm dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGridData();
                ClearForm();
            }
            catch (SqlException sqlex) when (sqlex.Number == 2627) // Lỗi trùng khóa chính
            {
                MessageBox.Show($"Mã dịch vụ '{txtMaDV.Text.Trim()}' đã tồn tại.", "Lỗi Trùng Mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaDV.Focus();
                txtMaDV.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDV.Text) || txtMaDV.ReadOnly == false)
            {
                MessageBox.Show("Vui lòng chọn một dịch vụ từ lưới để sửa.", "Chưa chọn dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE DichVu SET TenDV = @TenDV, GiaDV = @GiaDV, MaLDV = @MaLDV WHERE MaDV = @MaDV";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenDV", txtTenDV.Text.Trim());
                        cmd.Parameters.AddWithValue("@GiaDV", (spinGiaDV.Value > 0) ? (object)spinGiaDV.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@MaLDV", cmbLoaiDV.SelectedValue ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@MaDV", txtMaDV.Text.Trim()); // Điều kiện WHERE

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Cập nhật dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGridData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDV.Text) || txtMaDV.ReadOnly == false)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần xóa.", "Chưa chọn dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa dịch vụ '{txtTenDV.Text}' (Mã: {txtMaDV.Text}) không?",
                                     "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = "DELETE FROM DichVu WHERE MaDV = @MaDV";
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaDV", txtMaDV.Text.Trim());
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Xóa dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGridData();
                    ClearForm();
                }
                catch (SqlException sqlex) when (sqlex.Number == 547) // Lỗi khóa ngoại
                {
                    MessageBox.Show("Không thể xóa dịch vụ này vì đang được sử dụng trong phiếu dịch vụ.", "Lỗi Khóa Ngoại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion
    }
}