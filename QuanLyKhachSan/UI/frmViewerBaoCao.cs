using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms; // Cần cho ReportViewer

namespace QuanLyKhachSan // Đảm bảo namespace khớp
{
    public partial class frmViewerBaoCao : Form
    {
        // 1. Chuỗi kết nối
        private string connectionString =
        @"Data Source=admin;Initial Catalog=QuanLyKhachSan;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public frmViewerBaoCao()
        {
            InitializeComponent();
        }

        private void frmViewerBaoCao_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // 1. Lấy dữ liệu từ bảng BaoCao (hoặc bất kỳ bảng nào bạn dùng cho report)
                    string query = "SELECT MaBC, TenBC, SoLuongKhach, TongPhong, DoanhThu, MaNV FROM BaoCao";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // 2. Xóa dữ liệu cũ trên ReportViewer
                    reportViewer1.LocalReport.DataSources.Clear();

                    // 3. Tạo nguồn dữ liệu mới cho Report  
                    // *** QUAN TRỌNG: Tên "DataSet1" phải khớp 100% với tên DataSet bạn đặt
                    // trong file .rdlc khi thiết kế ***
                    ReportDataSource rds = new ReportDataSource("DataSet_BaoCao", dt);
                    // (Nếu bạn đặt tên DataSet là "DataSet_BaoCao", hãy sửa "DataSet1" thành "DataSet_BaoCao")

                    // 4. Chỉ định đường dẫn đến file .rdlc
                    // (Giả sử file .rdlc nằm trong thư mục Report của project)
                    string reportPath = System.IO.Path.Combine(Application.StartupPath, @"Report\BaoCao.rdlc"); // Giả sử tên file là BaoCao.rdlc
                    if (!System.IO.File.Exists(reportPath))
                    {
                        MessageBox.Show($"Không tìm thấy file báo cáo: {reportPath}\nHãy đảm bảo file .rdlc nằm trong thư mục 'Report' và đã set 'Copy to Output Directory' thành 'Copy if newer'.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    reportViewer1.LocalReport.ReportPath = reportPath;

                    // 5. Thêm nguồn dữ liệu vào report
                    reportViewer1.LocalReport.DataSources.Add(rds);

                    // 6. Refresh lại ReportViewer
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