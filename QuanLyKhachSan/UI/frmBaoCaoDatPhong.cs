using Microsoft.Reporting.WinForms;
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
    public partial class frmBaoCaoDatPhong : Form
    {
        string connectionString = @"Data Source=Phuc-ne;Initial Catalog=QuanLyKhachSan;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public frmBaoCaoDatPhong()
        {
            InitializeComponent();
        }

        private void frmBaoCaoDatPhong_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            LoadReport();
        }
        private void LoadReport()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Lấy dữ liệu từ PhieuDatPhong kết hợp KHACHHANG
                    string query = @"
                        SELECT 
                            pd.MaPDP AS MaPhieuDat,
                            k.HoTen AS TenKhachHang,
                            pd.NgayNhan,
                            pd.TinhTrang
                        FROM PhieuDatPhong pd
                        JOIN KHACHHANG k ON pd.MaKH = k.MaKH
                        ORDER BY pd.NgayNhan";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Xóa dữ liệu cũ
                    reportViewer1.LocalReport.DataSources.Clear();

                    // Tạo nguồn dữ liệu cho report
                    ReportDataSource rds = new ReportDataSource("dsPhieuDatPhong", dt);
                    // **Tên DataSet trong RDLC phải trùng với "dsPhieuDatPhong"**

                    // Chỉ định đường dẫn đến file ReportDatPhong.rdlc
                    string reportPath = System.IO.Path.Combine(Application.StartupPath, @"Report\ReportDatPhong.rdlc");
                    if (!System.IO.File.Exists(reportPath))
                    {
                        MessageBox.Show($"Không tìm thấy file báo cáo: {reportPath}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    reportViewer1.LocalReport.ReportPath = reportPath;

                    // Thêm nguồn dữ liệu
                    reportViewer1.LocalReport.DataSources.Add(rds);

                    // Nếu muốn thêm Parameter Từ ngày – Đến ngày
                    ReportParameter[] parameters = new ReportParameter[]
                    {
                        new ReportParameter("TuNgay", DateTime.Today.ToShortDateString()),
                        new ReportParameter("DenNgay", DateTime.Today.ToShortDateString())
                    };
                    reportViewer1.LocalReport.SetParameters(parameters);

                    // Refresh report
                    reportViewer1.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
