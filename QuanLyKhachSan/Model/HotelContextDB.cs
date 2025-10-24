using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyKhachSan.Model
{
    public partial class HotelContextDB : DbContext
    {
        public HotelContextDB()  : base("name=HotelContextDB")
        {
        }

        public virtual DbSet<BaoCao> BaoCaos { get; set; }
        public virtual DbSet<CT_DatPhong> CT_DatPhong { get; set; }
        public virtual DbSet<CT_HoaDon> CT_HoaDon { get; set; }
        public virtual DbSet<CT_ThuePhong> CT_ThuePhong { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiDV> LoaiDVs { get; set; }
        public virtual DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public virtual DbSet<LOGIN> LOGINs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhieuDatPhong> PhieuDatPhongs { get; set; }
        public virtual DbSet<PhieuDV> PhieuDVs { get; set; }
        public virtual DbSet<PhieuThuePhong> PhieuThuePhongs { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaoCao>()
                .Property(e => e.MaBC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BaoCao>()
                .Property(e => e.MaNV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_DatPhong>()
                .Property(e => e.MaPDP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_DatPhong>()
                .Property(e => e.MaPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_HoaDon>()
                .Property(e => e.MaHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_HoaDon>()
                .Property(e => e.MaPTP)
                .IsUnicode(false);

            modelBuilder.Entity<CT_ThuePhong>()
                .Property(e => e.MaPTP)
                .IsUnicode(false);

            modelBuilder.Entity<CT_ThuePhong>()
                .Property(e => e.MaPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DichVu>()
                .Property(e => e.MaDV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DichVu>()
                .Property(e => e.MaLDV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DichVu>()
                .HasMany(e => e.PhieuDVs)
                .WithOptional(e => e.DichVu)
                .HasForeignKey(e => e.MaDV);

            modelBuilder.Entity<DichVu>()
                .HasMany(e => e.PhieuDVs1)
                .WithOptional(e => e.DichVu1)
                .HasForeignKey(e => e.MaDV);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.CT_HoaDon)
                .WithRequired(e => e.HoaDon)
                .HasForeignKey(e => e.MaHD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.CT_HoaDon1)
                .WithRequired(e => e.HoaDon1)
                .HasForeignKey(e => e.MaHD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.PhieuDatPhongs)
                .WithOptional(e => e.KhachHang)
                .HasForeignKey(e => e.MaKH);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.PhieuDatPhongs1)
                .WithOptional(e => e.KhachHang1)
                .HasForeignKey(e => e.MaKH);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.PhieuThuePhongs)
                .WithOptional(e => e.KhachHang)
                .HasForeignKey(e => e.MaKH);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.PhieuThuePhongs1)
                .WithOptional(e => e.KhachHang1)
                .HasForeignKey(e => e.MaKH);

            modelBuilder.Entity<LoaiDV>()
                .Property(e => e.MaLDV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LoaiDV>()
                .HasMany(e => e.DichVus)
                .WithOptional(e => e.LoaiDV)
                .HasForeignKey(e => e.MaLDV);

            modelBuilder.Entity<LoaiDV>()
                .HasMany(e => e.DichVus1)
                .WithOptional(e => e.LoaiDV1)
                .HasForeignKey(e => e.MaLDV);

            modelBuilder.Entity<LoaiPhong>()
                .Property(e => e.MaLP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LoaiPhong>()
                .HasMany(e => e.Phongs)
                .WithOptional(e => e.LoaiPhong)
                .HasForeignKey(e => e.MaLP);

            modelBuilder.Entity<LoaiPhong>()
                .HasMany(e => e.Phongs1)
                .WithOptional(e => e.LoaiPhong1)
                .HasForeignKey(e => e.MaLP);

            modelBuilder.Entity<LOGIN>()
                .Property(e => e.TaiKhoan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN>()
                .Property(e => e.MatKhau)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOGIN>()
                .Property(e => e.Email)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.BaoCaos)
                .WithOptional(e => e.NhanVien)
                .HasForeignKey(e => e.MaNV);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.BaoCaos1)
                .WithOptional(e => e.NhanVien1)
                .HasForeignKey(e => e.MaNV);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.Phongs)
                .WithOptional(e => e.NhanVien)
                .HasForeignKey(e => e.MaNV);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.Phongs1)
                .WithOptional(e => e.NhanVien1)
                .HasForeignKey(e => e.MaNV);

            modelBuilder.Entity<PhieuDatPhong>()
                .Property(e => e.MaPDP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuDatPhong>()
                .Property(e => e.MaKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuDatPhong>()
                .HasMany(e => e.CT_DatPhong)
                .WithRequired(e => e.PhieuDatPhong)
                .HasForeignKey(e => e.MaPDP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuDatPhong>()
                .HasMany(e => e.CT_DatPhong1)
                .WithRequired(e => e.PhieuDatPhong1)
                .HasForeignKey(e => e.MaPDP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuDV>()
                .Property(e => e.MaPDV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuDV>()
                .Property(e => e.MaPTP)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuDV>()
                .Property(e => e.MaDV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuThuePhong>()
                .Property(e => e.MaPTP)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuThuePhong>()
                .Property(e => e.MaKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuThuePhong>()
                .HasMany(e => e.CT_HoaDon)
                .WithRequired(e => e.PhieuThuePhong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuThuePhong>()
                .HasMany(e => e.CT_ThuePhong)
                .WithRequired(e => e.PhieuThuePhong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phong>()
                .Property(e => e.MaPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Phong>()
                .Property(e => e.MaLP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Phong>()
                .Property(e => e.MaNV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Phong>()
                .HasMany(e => e.CT_DatPhong)
                .WithRequired(e => e.Phong)
                .HasForeignKey(e => e.MaPhong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phong>()
                .HasMany(e => e.CT_DatPhong1)
                .WithRequired(e => e.Phong1)
                .HasForeignKey(e => e.MaPhong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phong>()
                .HasMany(e => e.CT_ThuePhong)
                .WithRequired(e => e.Phong)
                .HasForeignKey(e => e.MaPhong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phong>()
                .HasMany(e => e.CT_ThuePhong1)
                .WithRequired(e => e.Phong1)
                .HasForeignKey(e => e.MaPhong)
                .WillCascadeOnDelete(false);
        }
    }
}
