namespace QuanLyKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phong")]
    public partial class Phong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phong()
        {
            CT_DatPhong = new HashSet<CT_DatPhong>();
            CT_DatPhong1 = new HashSet<CT_DatPhong>();
            CT_ThuePhong = new HashSet<CT_ThuePhong>();
            CT_ThuePhong1 = new HashSet<CT_ThuePhong>();
        }

        [Key]
        [StringLength(10)]
        public string MaPhong { get; set; }

        [StringLength(10)]
        public string SoPhong { get; set; }

        [StringLength(10)]
        public string MaLP { get; set; }

        [StringLength(10)]
        public string MaNV { get; set; }

        [StringLength(20)]
        public string TinhTrang { get; set; }

        public int? TANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_DatPhong> CT_DatPhong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_DatPhong> CT_DatPhong1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_ThuePhong> CT_ThuePhong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_ThuePhong> CT_ThuePhong1 { get; set; }

        public virtual LoaiPhong LoaiPhong { get; set; }

        public virtual LoaiPhong LoaiPhong1 { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual NhanVien NhanVien1 { get; set; }
    }
}
