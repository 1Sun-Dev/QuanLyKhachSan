using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Guna.UI2.WinForms;
using System.Configuration;
using System.IO;

namespace QuanLyKhachSan
{
    public partial class frmBaoCaoDoanhThu : Form
    {
        // Lấy chuỗi kết nối từ App.config
        private string connectionString =
              @"Data Source=admin;Initial Catalog=QuanLyKhachSan;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public frmBaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void frmBaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            LoadReport(); // Tải báo cáo ngay khi mở
        }

        // Xóa hàm btnXem_Click
        // Xóa hàm dateFilter_ValueChanged

        private void LoadReport()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // 1. SỬA QUERY: Lấy TẤT CẢ doanh thu, không lọc theo ngày
                    string query = @"
                        SELECT MaHD, NgayVao, NgayRa, TongTien FROM HoaDon";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    // Không cần gán Parameters

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    reportViewer1.LocalReport.DataSources.Clear();

                    // 2. Tên DataSet phải khớp
                    ReportDataSource rds = new ReportDataSource("DataSetDoanhThu", dt);

                    // 3. Đường dẫn file .rdlc
                    string reportPath = Path.Combine(Application.StartupPath, @"Report\ReportBaoCaoDoanhThu.rdlc");

                    if (!File.Exists(reportPath))
                    {
                        MessageBox.Show($"Không tìm thấy file báo cáo: {reportPath}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    reportViewer1.LocalReport.ReportPath = reportPath;
                    reportViewer1.LocalReport.DataSources.Add(rds);

                    // 4. XÓA BỎ PHẦN SET PARAMETERS
                    // reportViewer1.LocalReport.SetParameters(parameters);

                    // 5. Refresh
                    reportViewer1.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}