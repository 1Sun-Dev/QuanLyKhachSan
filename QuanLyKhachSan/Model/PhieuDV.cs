namespace QuanLyKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuDV")]
    public partial class PhieuDV
    {
        [Key]
        [StringLength(10)]
        public string MaPDV { get; set; }

        [StringLength(20)]
        public string MaPTP { get; set; }

        [StringLength(10)]
        public string MaDV { get; set; }

        public int? SoLuong { get; set; }

        public decimal? ThanhTien { get; set; }

        public virtual DichVu DichVu { get; set; }

        public virtual DichVu DichVu1 { get; set; }

        public virtual PhieuThuePhong PhieuThuePhong { get; set; }
    }
}
