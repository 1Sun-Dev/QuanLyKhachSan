namespace QuanLyKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DichVu")]
    public partial class DichVu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DichVu()
        {
            PhieuDVs = new HashSet<PhieuDV>();
            PhieuDVs1 = new HashSet<PhieuDV>();
        }

        [Key]
        [StringLength(10)]
        public string MaDV { get; set; }

        [StringLength(50)]
        public string TenDV { get; set; }

        public decimal? GiaDV { get; set; }

        [StringLength(10)]
        public string MaLDV { get; set; }

        public virtual LoaiDV LoaiDV { get; set; }

        public virtual LoaiDV LoaiDV1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuDV> PhieuDVs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuDV> PhieuDVs1 { get; set; }
    }
}
