namespace QuanLyKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_ThuePhong
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string MaPTP { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaPhong { get; set; }

        public virtual Phong Phong { get; set; }

        public virtual Phong Phong1 { get; set; }

        public virtual PhieuThuePhong PhieuThuePhong { get; set; }
    }
}
