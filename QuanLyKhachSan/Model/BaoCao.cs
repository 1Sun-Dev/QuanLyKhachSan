namespace QuanLyKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaoCao")]
    public partial class BaoCao
    {
        [Key]
        [StringLength(10)]
        public string MaBC { get; set; }

        [StringLength(100)]
        public string TenBC { get; set; }

        public int? SoLuongKhach { get; set; }

        public int? TongPhong { get; set; }

        public decimal? DoanhThu { get; set; }

        [StringLength(10)]
        public string MaNV { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual NhanVien NhanVien1 { get; set; }
    }
}
