namespace QuanLyKhachSan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BaoCao",
                c => new
                    {
                        MaBC = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        TenBC = c.String(maxLength: 100),
                        SoLuongKhach = c.Int(),
                        TongPhong = c.Int(),
                        DoanhThu = c.Decimal(precision: 18, scale: 2),
                        MaNV = c.String(maxLength: 10, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.MaBC)
                .ForeignKey("dbo.NhanVien", t => t.MaNV)
                .Index(t => t.MaNV);
            
            CreateTable(
                "dbo.NhanVien",
                c => new
                    {
                        MaNV = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        HoTen = c.String(maxLength: 50),
                        ChucVu = c.String(maxLength: 30),
                        SDT = c.String(maxLength: 15),
                        Email = c.String(maxLength: 50),
                        GioiTinh = c.String(maxLength: 5),
                        NgaySinh = c.DateTime(storeType: "date"),
                        Luong = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.MaNV);
            
            CreateTable(
                "dbo.Phong",
                c => new
                    {
                        MaPhong = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        SoPhong = c.String(maxLength: 10),
                        MaLP = c.String(maxLength: 10, fixedLength: true, unicode: false),
                        MaNV = c.String(maxLength: 10, fixedLength: true, unicode: false),
                        TinhTrang = c.String(maxLength: 20),
                        TANG = c.Int(),
                    })
                .PrimaryKey(t => t.MaPhong)
                .ForeignKey("dbo.LoaiPhong", t => t.MaLP)
                .ForeignKey("dbo.NhanVien", t => t.MaNV)
                .Index(t => t.MaLP)
                .Index(t => t.MaNV);
            
            CreateTable(
                "dbo.CT_DatPhong",
                c => new
                    {
                        MaPDP = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        MaPhong = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => new { t.MaPDP, t.MaPhong })
                .ForeignKey("dbo.PhieuDatPhong", t => t.MaPDP)
                .ForeignKey("dbo.Phong", t => t.MaPhong)
                .Index(t => t.MaPDP)
                .Index(t => t.MaPhong);
            
            CreateTable(
                "dbo.PhieuDatPhong",
                c => new
                    {
                        MaPDP = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        NgayNhan = c.DateTime(storeType: "date"),
                        TinhTrang = c.String(maxLength: 20),
                        MaKH = c.String(maxLength: 10, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.MaPDP)
                .ForeignKey("dbo.KhachHang", t => t.MaKH)
                .Index(t => t.MaKH);
            
            CreateTable(
                "dbo.KhachHang",
                c => new
                    {
                        MaKH = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        HoTen = c.String(maxLength: 50),
                        SDT = c.String(maxLength: 15),
                        CCCD_HoChieu = c.String(maxLength: 20),
                        Email = c.String(maxLength: 50),
                        LoaiKH = c.String(maxLength: 20),
                        DiemTichLuy = c.Int(),
                    })
                .PrimaryKey(t => t.MaKH);
            
            CreateTable(
                "dbo.PhieuThuePhong",
                c => new
                    {
                        MaPTP = c.String(nullable: false, maxLength: 20, unicode: false),
                        NgayThue = c.DateTime(storeType: "date"),
                        NgayTra = c.DateTime(storeType: "date"),
                        MaKH = c.String(maxLength: 10, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.MaPTP)
                .ForeignKey("dbo.KhachHang", t => t.MaKH)
                .Index(t => t.MaKH);
            
            CreateTable(
                "dbo.CT_HoaDon",
                c => new
                    {
                        MaHD = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        MaPTP = c.String(nullable: false, maxLength: 20, unicode: false),
                        SoLuong = c.Int(),
                        TongTien = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.MaHD, t.MaPTP })
                .ForeignKey("dbo.HoaDon", t => t.MaHD)
                .ForeignKey("dbo.PhieuThuePhong", t => t.MaPTP)
                .Index(t => t.MaHD)
                .Index(t => t.MaPTP);
            
            CreateTable(
                "dbo.HoaDon",
                c => new
                    {
                        MaHD = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        NgayVao = c.DateTime(storeType: "date"),
                        NgayRa = c.DateTime(storeType: "date"),
                        TongTien = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.MaHD);
            
            CreateTable(
                "dbo.CT_ThuePhong",
                c => new
                    {
                        MaPTP = c.String(nullable: false, maxLength: 20, unicode: false),
                        MaPhong = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => new { t.MaPTP, t.MaPhong })
                .ForeignKey("dbo.PhieuThuePhong", t => t.MaPTP)
                .ForeignKey("dbo.Phong", t => t.MaPhong)
                .Index(t => t.MaPTP)
                .Index(t => t.MaPhong);
            
            CreateTable(
                "dbo.PhieuDV",
                c => new
                    {
                        MaPDV = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        MaPTP = c.String(maxLength: 20, unicode: false),
                        MaDV = c.String(maxLength: 10, fixedLength: true, unicode: false),
                        SoLuong = c.Int(),
                        ThanhTien = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.MaPDV)
                .ForeignKey("dbo.DichVu", t => t.MaDV)
                .ForeignKey("dbo.PhieuThuePhong", t => t.MaPTP)
                .Index(t => t.MaPTP)
                .Index(t => t.MaDV);
            
            CreateTable(
                "dbo.DichVu",
                c => new
                    {
                        MaDV = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        TenDV = c.String(maxLength: 50),
                        GiaDV = c.Decimal(precision: 18, scale: 2),
                        MaLDV = c.String(maxLength: 10, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.MaDV)
                .ForeignKey("dbo.LoaiDV", t => t.MaLDV)
                .Index(t => t.MaLDV);
            
            CreateTable(
                "dbo.LoaiDV",
                c => new
                    {
                        MaLDV = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        TenLDV = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaLDV);
            
            CreateTable(
                "dbo.LoaiPhong",
                c => new
                    {
                        MaLP = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        TenLP = c.String(maxLength: 50),
                        DonGia = c.Decimal(precision: 18, scale: 2),
                        SoNguoiToiDa = c.Int(),
                    })
                .PrimaryKey(t => t.MaLP);
            
            CreateTable(
                "dbo.LOGIN",
                c => new
                    {
                        TaiKhoan = c.String(nullable: false, maxLength: 15, fixedLength: true, unicode: false),
                        MatKhau = c.String(maxLength: 15, fixedLength: true, unicode: false),
                        Email = c.String(maxLength: 25, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.TaiKhoan);
            
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Phong", "MaNV", "dbo.NhanVien");
            DropForeignKey("dbo.Phong", "MaLP", "dbo.LoaiPhong");
            DropForeignKey("dbo.CT_ThuePhong", "MaPhong", "dbo.Phong");
            DropForeignKey("dbo.CT_DatPhong", "MaPhong", "dbo.Phong");
            DropForeignKey("dbo.PhieuThuePhong", "MaKH", "dbo.KhachHang");
            DropForeignKey("dbo.PhieuDV", "MaPTP", "dbo.PhieuThuePhong");
            DropForeignKey("dbo.PhieuDV", "MaDV", "dbo.DichVu");
            DropForeignKey("dbo.DichVu", "MaLDV", "dbo.LoaiDV");
            DropForeignKey("dbo.CT_ThuePhong", "MaPTP", "dbo.PhieuThuePhong");
            DropForeignKey("dbo.CT_HoaDon", "MaPTP", "dbo.PhieuThuePhong");
            DropForeignKey("dbo.CT_HoaDon", "MaHD", "dbo.HoaDon");
            DropForeignKey("dbo.PhieuDatPhong", "MaKH", "dbo.KhachHang");
            DropForeignKey("dbo.CT_DatPhong", "MaPDP", "dbo.PhieuDatPhong");
            DropForeignKey("dbo.BaoCao", "MaNV", "dbo.NhanVien");
            DropIndex("dbo.DichVu", new[] { "MaLDV" });
            DropIndex("dbo.PhieuDV", new[] { "MaDV" });
            DropIndex("dbo.PhieuDV", new[] { "MaPTP" });
            DropIndex("dbo.CT_ThuePhong", new[] { "MaPhong" });
            DropIndex("dbo.CT_ThuePhong", new[] { "MaPTP" });
            DropIndex("dbo.CT_HoaDon", new[] { "MaPTP" });
            DropIndex("dbo.CT_HoaDon", new[] { "MaHD" });
            DropIndex("dbo.PhieuThuePhong", new[] { "MaKH" });
            DropIndex("dbo.PhieuDatPhong", new[] { "MaKH" });
            DropIndex("dbo.CT_DatPhong", new[] { "MaPhong" });
            DropIndex("dbo.CT_DatPhong", new[] { "MaPDP" });
            DropIndex("dbo.Phong", new[] { "MaNV" });
            DropIndex("dbo.Phong", new[] { "MaLP" });
            DropIndex("dbo.BaoCao", new[] { "MaNV" });
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.LOGIN");
            DropTable("dbo.LoaiPhong");
            DropTable("dbo.LoaiDV");
            DropTable("dbo.DichVu");
            DropTable("dbo.PhieuDV");
            DropTable("dbo.CT_ThuePhong");
            DropTable("dbo.HoaDon");
            DropTable("dbo.CT_HoaDon");
            DropTable("dbo.PhieuThuePhong");
            DropTable("dbo.KhachHang");
            DropTable("dbo.PhieuDatPhong");
            DropTable("dbo.CT_DatPhong");
            DropTable("dbo.Phong");
            DropTable("dbo.NhanVien");
            DropTable("dbo.BaoCao");
        }
    }
}
