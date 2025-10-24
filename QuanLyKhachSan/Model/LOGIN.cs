namespace QuanLyKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOGIN")]
    public partial class LOGIN
    {
        [Key]
        [StringLength(15)]
        public string TaiKhoan { get; set; }

        [StringLength(15)]
        public string MatKhau { get; set; }

        [StringLength(25)]
        public string Email { get; set; }
    }
}
