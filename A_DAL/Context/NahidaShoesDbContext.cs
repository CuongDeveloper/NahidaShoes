using A_DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace A_DAL.Context
{
    public class NahidaShoesDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //Đổi connectionString để connect với co sở dữ liệu của mình

            _ = optionsBuilder.UseSqlServer("Data Source=localhost,1433;Initial Catalog=NahidaShos;User ID=SA;Password=cuong191023;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            _ = builder.Entity<ChieuCaoDeGiay>().HasKey(c => c.Id);
            _ = builder.Entity<ChieuCaoDeGiay>().Property(c => c.Id);
            _ = builder.Entity<ChieuCaoDeGiay>().HasIndex(c => c.MaKichCo).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<ChiTietGiay>().HasKey(c => c.Id);
            _ = builder.Entity<ChiTietGiay>().Property(c => c.Id);
            _ = builder.Entity<ChiTietGiay>().Property(c => c.Anh).HasColumnType("image");
            _ = builder.Entity<ChiTietGiay>().HasIndex(c => new { c.IdMauSac, c.IdSize, c.IdNsx, c.IdHangGiay, c.IdChieuCaoDeGiay, c.IdGiay }).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<ChiTietSale>().HasKey(c => c.Id);
            _ = builder.Entity<ChiTietSale>().Property(c => c.Id);
            _ = builder.Entity<ChiTietSale>().HasIndex(c => new { c.IdChiTietGiay, c.IdSale }).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<ChiTietTheLoai>().HasKey(c => c.Id);
            _ = builder.Entity<ChiTietTheLoai>().Property(c => c.Id);
            _ = builder.Entity<ChiTietTheLoai>().HasIndex(c => new { c.IdChiTietGiay, c.IdTheLoai }).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<ChucVu>().HasKey(c => c.Id);
            _ = builder.Entity<ChucVu>().Property(c => c.Id);
            _ = builder.Entity<ChucVu>().HasIndex(c => c.MaChucVu).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<CuaHang>().HasKey(c => c.Id);
            _ = builder.Entity<CuaHang>().Property(c => c.Id);
            _ = builder.Entity<CuaHang>().HasIndex(c => c.MaCuaHang).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<DiemTieuDung>().HasKey(c => c.Id);
            _ = builder.Entity<DiemTieuDung>().Property(c => c.Id);
            _ = builder.Entity<DiemTieuDung>().HasIndex(c => c.MaDiemTieuDung).IsUnique(true);
            _ = builder.Entity<DiemTieuDung>().HasIndex(c => c.IdKhachHang).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<GiaoCa>().HasKey(c => c.Id);
            _ = builder.Entity<GiaoCa>().Property(c => c.Id);
            _ = builder.Entity<GiaoCa>().HasIndex(c => c.MaGiaoCa).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<Giay>().HasKey(c => c.Id);
            _ = builder.Entity<Giay>().Property(c => c.Id);
            _ = builder.Entity<Giay>().HasIndex(c => c.MaGiay).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<HangGiay>().HasKey(c => c.Id);
            _ = builder.Entity<HangGiay>().Property(c => c.Id);
            _ = builder.Entity<HangGiay>().HasIndex(c => c.MaHangGiay).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<HoaDon>().HasKey(c => c.Id);
            _ = builder.Entity<HoaDon>().Property(c => c.Id);
            _ = builder.Entity<HoaDon>().HasIndex(c => c.MaHoaDon).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<HoaDonChiTiet>().HasKey(c => c.Id);
            _ = builder.Entity<HoaDonChiTiet>().Property(c => c.Id);
            _ = builder.Entity<HoaDonChiTiet>().HasIndex(c => new { c.IdChiTietGiay, c.IdHoaDon }).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<KhachHang>().HasKey(c => c.Id);
            _ = builder.Entity<KhachHang>().Property(c => c.Id);
            _ = builder.Entity<KhachHang>().HasIndex(c => c.MaKhachHang).IsUnique(true);
            _ = builder.Entity<KhachHang>().HasIndex(c => c.SoCCCD).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<LichSuDiemTieuDung>().HasKey(c => c.Id);
            _ = builder.Entity<LichSuDiemTieuDung>().Property(c => c.Id);
            _ = builder.Entity<LichSuDiemTieuDung>().HasIndex(c => new { c.IdHoaDon, c.IdDiemTieuDung, c.IdQuyDoi }).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<MauSac>().HasKey(c => c.Id);
            _ = builder.Entity<MauSac>().Property(c => c.Id);
            _ = builder.Entity<MauSac>().HasIndex(c => c.MaMauSac).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<NhanVien>().HasKey(c => c.Id);
            _ = builder.Entity<NhanVien>().Property(c => c.Id);
            _ = builder.Entity<NhanVien>().HasIndex(c => c.MaNhanVien).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<Nsx>().HasKey(c => c.Id);
            _ = builder.Entity<Nsx>().Property(c => c.Id);
            _ = builder.Entity<Nsx>().HasIndex(c => c.MaNsx).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<QuyDoi>().HasKey(c => c.Id);
            _ = builder.Entity<QuyDoi>().Property(c => c.Id);
            _ = builder.Entity<QuyDoi>().HasIndex(c => c.MaQuyDoi).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<Sale>().HasKey(c => c.Id);
            _ = builder.Entity<Sale>().Property(c => c.Id);
            _ = builder.Entity<Sale>().HasIndex(c => c.MaGiamGia).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<Size>().HasKey(c => c.Id);
            _ = builder.Entity<Size>().Property(c => c.Id);
            _ = builder.Entity<Size>().HasIndex(c => c.MaSize).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<TheLoai>().HasKey(c => c.Id);
            _ = builder.Entity<TheLoai>().Property(c => c.Id);
            _ = builder.Entity<TheLoai>().HasIndex(c => c.MaTheLoai).IsUnique(true);
            ///////////////////////////////
            _ = builder.Entity<ChiTietGiay>().HasOne<MauSac>(s => s.IdMauSacNavigation).WithMany(g => g.ChiTietGiays).HasForeignKey(s => s.IdMauSac).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<ChiTietGiay>().HasOne<Nsx>(s => s.IdNsxNavigation).WithMany(g => g.ChiTietGiays).HasForeignKey(s => s.IdNsx).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<ChiTietGiay>().HasOne<Size>(s => s.IdSizeNavigation).WithMany(g => g.ChiTietGiays).HasForeignKey(s => s.IdSize).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<ChiTietGiay>().HasOne<HangGiay>(s => s.IdHangGiayNavigation).WithMany(g => g.ChiTietGiays).HasForeignKey(s => s.IdHangGiay).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<ChiTietGiay>().HasOne<ChieuCaoDeGiay>(s => s.IdChieuCaoDeGiayNavigation).WithMany(g => g.ChiTietGiays).HasForeignKey(s => s.IdChieuCaoDeGiay).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<ChiTietGiay>().HasOne<Giay>(s => s.IdGiayNavigation).WithMany(g => g.ChiTietGiays).HasForeignKey(s => s.IdGiay).OnDelete(DeleteBehavior.Restrict);
            ///////////////////////////////
            _ = builder.Entity<ChiTietSale>().HasOne<ChiTietGiay>(s => s.IdChiTietGiayNavigation).WithMany(g => g.ChiTietSales).HasForeignKey(s => s.IdChiTietGiay).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<ChiTietSale>().HasOne<Sale>(s => s.IdSaleNavigation).WithMany(g => g.ChiTietSales).HasForeignKey(s => s.IdSale).OnDelete(DeleteBehavior.Restrict);
            ///////////////////////////////
            _ = builder.Entity<ChiTietTheLoai>().HasOne<ChiTietGiay>(s => s.IdChiTietGiayNavigation).WithMany(g => g.ChiTietTheLoais).HasForeignKey(s => s.IdChiTietGiay).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<ChiTietTheLoai>().HasOne<TheLoai>(s => s.IdTheLoaiNavigation).WithMany(g => g.ChiTietTheLoais).HasForeignKey(s => s.IdTheLoai).OnDelete(DeleteBehavior.Restrict);
            ///////////////////////////////
            _ = builder.Entity<HoaDonChiTiet>().HasOne<ChiTietGiay>(s => s.IdChiTietGiayNavigation).WithMany(g => g.HoaDonChiTiets).HasForeignKey(s => s.IdChiTietGiay).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<HoaDonChiTiet>().HasOne<HoaDon>(s => s.IdHoaDonNavigation).WithMany(g => g.HoaDonChiTiets).HasForeignKey(s => s.IdHoaDon).OnDelete(DeleteBehavior.Restrict);
            ///////////////////////////////
            _ = builder.Entity<LichSuDiemTieuDung>().HasOne<DiemTieuDung>(s => s.IdDiemTieuDungNavigation).WithMany(g => g.LichSuDiemTieuDungs).HasForeignKey(s => s.IdDiemTieuDung).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<LichSuDiemTieuDung>().HasOne<QuyDoi>(s => s.IdQuyDoiNavigation).WithMany(g => g.LichSuDiemTieuDungs).HasForeignKey(s => s.IdQuyDoi).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<LichSuDiemTieuDung>().HasOne<HoaDon>(s => s.IdHoaDonNavigation).WithMany(g => g.LichSuDiemTieuDungs).HasForeignKey(s => s.IdHoaDon).OnDelete(DeleteBehavior.Restrict);
            ///////////////////////////////
            _ = builder.Entity<HoaDon>().HasOne<KhachHang>(s => s.IdKhachHangNavigation).WithMany(g => g.HoaDons).HasForeignKey(s => s.IdKhachHang).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<HoaDon>().HasOne<NhanVien>(s => s.IdNhanVienNavigation).WithMany(g => g.HoaDons).HasForeignKey(s => s.IdNhanVien).OnDelete(DeleteBehavior.Restrict);
            ///////////////////////////////
            _ = builder.Entity<GiaoCa>().HasOne<NhanVien>(s => s.IdNhanVienNavigation).WithMany(g => g.GiaoCas).HasForeignKey(s => s.IdNhanVien).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<GiaoCa>().HasOne<NhanVien>(s => s.IdNhanVienTiepQuanNavigation).WithMany(g => g.GiaoCaTiepQuans).HasForeignKey(s => s.IdNhanVienTiepQuan).OnDelete(DeleteBehavior.Restrict);
            ///////////////////////////////
            _ = builder.Entity<NhanVien>().HasOne<ChucVu>(s => s.IdChucVuNavigation).WithMany(g => g.NhanViens).HasForeignKey(s => s.IdChucVu).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<NhanVien>().HasOne<CuaHang>(s => s.IdCuaHangNavigation).WithMany(g => g.NhanViens).HasForeignKey(s => s.IdCuaHang).OnDelete(DeleteBehavior.Restrict);
            ///////////////////////////////
            _ = builder.Entity<DiemTieuDung>().HasOne<KhachHang>(s => s.KhachHang).WithOne(g => g.DiemTieuDung).HasForeignKey<DiemTieuDung>(s => s.IdKhachHang).OnDelete(DeleteBehavior.Restrict);
            ///////////////////////////////
            _ = builder.Entity<TheLoai>().HasOne<TheLoai>(s => s.IdTheLoaiNavigation).WithMany(g => g.TheLoais).HasForeignKey(s => s.IdPhanCap).OnDelete(DeleteBehavior.Restrict);
            ///////////////////////////////
            _ = builder.Entity<ChiTietThanhToan>().HasOne<HoaDon>(s => s.IdHoaDonNavigation).WithMany(g => g.ChiTietThanhToans).HasForeignKey(s => s.IdHoaDon).OnDelete(DeleteBehavior.Restrict);
            _ = builder.Entity<ChiTietThanhToan>().HasOne<PhuongThucThanhToan>(s => s.IdPhuongThucThanhToanNavigation).WithMany(g => g.ChiTietThanhToans).HasForeignKey(s => s.IdPhuongThucThanhToan).OnDelete(DeleteBehavior.Restrict);
            ///////////////////////////////
            Guid idCuaHang = Guid.NewGuid();
            _ = builder.Entity<CuaHang>().HasData(new CuaHang { Id = idCuaHang, MaCuaHang = "CH1", DiaChi = "Hà Nội", TenCuaHang = "Cửa hàng 1" });
            ///////////////////////////////
            Guid idChucVu = Guid.NewGuid();
            _ = builder.Entity<ChucVu>().HasData(new ChucVu { Id = idChucVu, MaChucVu = "CV1", TenChucVu = "Nhân viên" });
            ///////////////////////////////
            _ = builder.Entity<NhanVien>().HasData(new NhanVien { Id = Guid.NewGuid(), IdChucVu = idChucVu, IdCuaHang = idCuaHang, DiaChi = "Hà Nội", MaNhanVien = "NV1", TenNhanVien = "Nhân viên 1", GioiTinh = 0, NgaySinh = DateTime.Now, MatKhau = "00000", Sdt = "0385922775" });
            _ = builder.Entity<NhanVien>().HasData(new NhanVien { Id = Guid.NewGuid(), IdChucVu = idChucVu, IdCuaHang = idCuaHang, DiaChi = "Hà Nội", MaNhanVien = "NV2", TenNhanVien = "Nhân viên 2", GioiTinh = 1, NgaySinh = DateTime.Now, MatKhau = "00000", Sdt = "0385922775" });
            ///////////////////////////////
            _ = builder.Entity<KhachHang>().HasData(new KhachHang { Id = Guid.NewGuid(), DiaChi = "Hà Nội", MaKhachHang = "KH1", TenKhachHang = "Khách hàng 1", NgaySinh = DateTime.Now, Sdt = "0385922775", SoCCCD = "12345" });
            _ = builder.Entity<KhachHang>().HasData(new KhachHang { Id = Guid.NewGuid(), DiaChi = "Hà Nội", MaKhachHang = "KH2", TenKhachHang = "Khách hàng 2", NgaySinh = DateTime.Now, Sdt = "0385922775", SoCCCD = "01234" });
            ///////////////////////////////
            List<Guid> idMauSac = new();
            for (int i = 0; i < 5; i++)
            {
                idMauSac.Add(Guid.NewGuid());
            }
            _ = builder.Entity<MauSac>().HasData(new MauSac { Id = idMauSac[0], MaMauSac = "MS1", TenMauSac = "Màu sắc 1" });
            _ = builder.Entity<MauSac>().HasData(new MauSac { Id = idMauSac[1], MaMauSac = "MS2", TenMauSac = "Màu sắc 2" });
            _ = builder.Entity<MauSac>().HasData(new MauSac { Id = idMauSac[2], MaMauSac = "MS3", TenMauSac = "Màu sắc 3" });
            _ = builder.Entity<MauSac>().HasData(new MauSac { Id = idMauSac[3], MaMauSac = "MS4", TenMauSac = "Màu sắc 4" });
            _ = builder.Entity<MauSac>().HasData(new MauSac { Id = idMauSac[4], MaMauSac = "MS5", TenMauSac = "Màu sắc 5" });
            ///////////////////////////////
            List<Guid> idNsx = new();
            for (int i = 0; i < 5; i++)
            {
                idNsx.Add(Guid.NewGuid());
            }
            _ = builder.Entity<Nsx>().HasData(new Nsx { Id = idNsx[0], MaNsx = "NSX1", TenNsx = "Nhà sản xuất 1", DiaChi = "Hà Nội" });
            _ = builder.Entity<Nsx>().HasData(new Nsx { Id = idNsx[1], MaNsx = "NSX2", TenNsx = "Nhà sản xuất 2", DiaChi = "Hà Nội" });
            _ = builder.Entity<Nsx>().HasData(new Nsx { Id = idNsx[2], MaNsx = "NSX3", TenNsx = "Nhà sản xuất 3", DiaChi = "Hà Nội" });
            _ = builder.Entity<Nsx>().HasData(new Nsx { Id = idNsx[3], MaNsx = "NSX4", TenNsx = "Nhà sản xuất 4", DiaChi = "Hà Nội" });
            _ = builder.Entity<Nsx>().HasData(new Nsx { Id = idNsx[4], MaNsx = "NSX5", TenNsx = "Nhà sản xuất 5", DiaChi = "Hà Nội" });
            ///////////////////////////////
            List<Guid> idSize = new();
            for (int i = 0; i < 5; i++)
            {
                idSize.Add(Guid.NewGuid());
            }
            _ = builder.Entity<Size>().HasData(new Size { Id = idSize[0], MaSize = "SZ1", TenSize = "Size 1", SoSize = 30 });
            _ = builder.Entity<Size>().HasData(new Size { Id = idSize[1], MaSize = "SZ2", TenSize = "Size 2", SoSize = 31 });
            _ = builder.Entity<Size>().HasData(new Size { Id = idSize[2], MaSize = "SZ3", TenSize = "Size 3", SoSize = 32 });
            _ = builder.Entity<Size>().HasData(new Size { Id = idSize[3], MaSize = "SZ4", TenSize = "Size 4", SoSize = 33 });
            _ = builder.Entity<Size>().HasData(new Size { Id = idSize[4], MaSize = "SZ5", TenSize = "Size 5", SoSize = 34 });
            ///////////////////////////////
            List<Guid> idGiay = new();
            for (int i = 0; i < 5; i++)
            {
                idGiay.Add(Guid.NewGuid());
            }
            _ = builder.Entity<Giay>().HasData(new Giay { Id = idGiay[0], MaGiay = "G1", TenGiay = "Giày 1" });
            _ = builder.Entity<Giay>().HasData(new Giay { Id = idGiay[1], MaGiay = "G2", TenGiay = "Giày 2" });
            _ = builder.Entity<Giay>().HasData(new Giay { Id = idGiay[2], MaGiay = "G3", TenGiay = "Giày 3" });
            _ = builder.Entity<Giay>().HasData(new Giay { Id = idGiay[3], MaGiay = "G4", TenGiay = "Giày 4" });
            _ = builder.Entity<Giay>().HasData(new Giay { Id = idGiay[4], MaGiay = "G5", TenGiay = "Giày 5" });
            ///////////////////////////////
            List<Guid> idHangGiay = new();
            for (int i = 0; i < 5; i++)
            {
                idHangGiay.Add(Guid.NewGuid());
            }
            _ = builder.Entity<HangGiay>().HasData(new HangGiay { Id = idHangGiay[0], MaHangGiay = "HG1", TenHangGiay = "Hãng giày 1" });
            _ = builder.Entity<HangGiay>().HasData(new HangGiay { Id = idHangGiay[1], MaHangGiay = "HG2", TenHangGiay = "Hãng giày 2" });
            _ = builder.Entity<HangGiay>().HasData(new HangGiay { Id = idHangGiay[2], MaHangGiay = "HG3", TenHangGiay = "Hãng giày 3" });
            _ = builder.Entity<HangGiay>().HasData(new HangGiay { Id = idHangGiay[3], MaHangGiay = "HG4", TenHangGiay = "Hãng giày 4" });
            _ = builder.Entity<HangGiay>().HasData(new HangGiay { Id = idHangGiay[4], MaHangGiay = "HG5", TenHangGiay = "Hãng giày 5" });
            ///////////////////////////////
            List<Guid> idChieuCaoDeGiay = new();
            for (int i = 0; i < 5; i++)
            {
                idChieuCaoDeGiay.Add(Guid.NewGuid());
            }
            _ = builder.Entity<ChieuCaoDeGiay>().HasData(new ChieuCaoDeGiay { Id = idChieuCaoDeGiay[0], MaKichCo = "KC1", KichCo = 1 });
            _ = builder.Entity<ChieuCaoDeGiay>().HasData(new ChieuCaoDeGiay { Id = idChieuCaoDeGiay[1], MaKichCo = "KC2", KichCo = 2 });
            _ = builder.Entity<ChieuCaoDeGiay>().HasData(new ChieuCaoDeGiay { Id = idChieuCaoDeGiay[2], MaKichCo = "KC3", KichCo = 3 });
            _ = builder.Entity<ChieuCaoDeGiay>().HasData(new ChieuCaoDeGiay { Id = idChieuCaoDeGiay[3], MaKichCo = "KC4", KichCo = 4 });
            _ = builder.Entity<ChieuCaoDeGiay>().HasData(new ChieuCaoDeGiay { Id = idChieuCaoDeGiay[4], MaKichCo = "KC5", KichCo = 5 });
            ///////////////////////////////
            Random random = new();
            _ = builder.Entity<ChiTietGiay>().HasData(new ChiTietGiay { Id = Guid.NewGuid(), IdChieuCaoDeGiay = idChieuCaoDeGiay[random.Next(5)], IdGiay = idGiay[random.Next(5)], IdMauSac = idMauSac[random.Next(5)], IdHangGiay = idHangGiay[random.Next(5)], IdNsx = idNsx[random.Next(5)], GiaBan = 10000, GiaNhap = 7000, IdSize = idSize[random.Next(5)], SoLuongTon = 100 });
            _ = builder.Entity<ChiTietGiay>().HasData(new ChiTietGiay { Id = Guid.NewGuid(), IdChieuCaoDeGiay = idChieuCaoDeGiay[random.Next(5)], IdGiay = idGiay[random.Next(5)], IdMauSac = idMauSac[random.Next(5)], IdHangGiay = idHangGiay[random.Next(5)], IdNsx = idNsx[random.Next(5)], GiaBan = 10000, GiaNhap = 7000, IdSize = idSize[random.Next(5)], SoLuongTon = 100 });
            _ = builder.Entity<ChiTietGiay>().HasData(new ChiTietGiay { Id = Guid.NewGuid(), IdChieuCaoDeGiay = idChieuCaoDeGiay[random.Next(5)], IdGiay = idGiay[random.Next(5)], IdMauSac = idMauSac[random.Next(5)], IdHangGiay = idHangGiay[random.Next(5)], IdNsx = idNsx[random.Next(5)], GiaBan = 10000, GiaNhap = 7000, IdSize = idSize[random.Next(5)], SoLuongTon = 100 });
            _ = builder.Entity<ChiTietGiay>().HasData(new ChiTietGiay { Id = Guid.NewGuid(), IdChieuCaoDeGiay = idChieuCaoDeGiay[random.Next(5)], IdGiay = idGiay[random.Next(5)], IdMauSac = idMauSac[random.Next(5)], IdHangGiay = idHangGiay[random.Next(5)], IdNsx = idNsx[random.Next(5)], GiaBan = 10000, GiaNhap = 7000, IdSize = idSize[random.Next(5)], SoLuongTon = 100 });
            _ = builder.Entity<ChiTietGiay>().HasData(new ChiTietGiay { Id = Guid.NewGuid(), IdChieuCaoDeGiay = idChieuCaoDeGiay[random.Next(5)], IdGiay = idGiay[random.Next(5)], IdMauSac = idMauSac[random.Next(5)], IdHangGiay = idHangGiay[random.Next(5)], IdNsx = idNsx[random.Next(5)], GiaBan = 10000, GiaNhap = 7000, IdSize = idSize[random.Next(5)], SoLuongTon = 100 });
            _ = builder.Entity<ChiTietGiay>().HasData(new ChiTietGiay { Id = Guid.NewGuid(), IdChieuCaoDeGiay = idChieuCaoDeGiay[random.Next(5)], IdGiay = idGiay[random.Next(5)], IdMauSac = idMauSac[random.Next(5)], IdHangGiay = idHangGiay[random.Next(5)], IdNsx = idNsx[random.Next(5)], GiaBan = 10000, GiaNhap = 7000, IdSize = idSize[random.Next(5)], SoLuongTon = 100 });
            _ = builder.Entity<ChiTietGiay>().HasData(new ChiTietGiay { Id = Guid.NewGuid(), IdChieuCaoDeGiay = idChieuCaoDeGiay[random.Next(5)], IdGiay = idGiay[random.Next(5)], IdMauSac = idMauSac[random.Next(5)], IdHangGiay = idHangGiay[random.Next(5)], IdNsx = idNsx[random.Next(5)], GiaBan = 10000, GiaNhap = 7000, IdSize = idSize[random.Next(5)], SoLuongTon = 100 });
            _ = builder.Entity<ChiTietGiay>().HasData(new ChiTietGiay { Id = Guid.NewGuid(), IdChieuCaoDeGiay = idChieuCaoDeGiay[random.Next(5)], IdGiay = idGiay[random.Next(5)], IdMauSac = idMauSac[random.Next(5)], IdHangGiay = idHangGiay[random.Next(5)], IdNsx = idNsx[random.Next(5)], GiaBan = 10000, GiaNhap = 7000, IdSize = idSize[random.Next(5)], SoLuongTon = 100 });
            _ = builder.Entity<ChiTietGiay>().HasData(new ChiTietGiay { Id = Guid.NewGuid(), IdChieuCaoDeGiay = idChieuCaoDeGiay[random.Next(5)], IdGiay = idGiay[random.Next(5)], IdMauSac = idMauSac[random.Next(5)], IdHangGiay = idHangGiay[random.Next(5)], IdNsx = idNsx[random.Next(5)], GiaBan = 10000, GiaNhap = 7000, IdSize = idSize[random.Next(5)], SoLuongTon = 100 });
            _ = builder.Entity<ChiTietGiay>().HasData(new ChiTietGiay { Id = Guid.NewGuid(), IdChieuCaoDeGiay = idChieuCaoDeGiay[random.Next(5)], IdGiay = idGiay[random.Next(5)], IdMauSac = idMauSac[random.Next(5)], IdHangGiay = idHangGiay[random.Next(5)], IdNsx = idNsx[random.Next(5)], GiaBan = 10000, GiaNhap = 7000, IdSize = idSize[random.Next(5)], SoLuongTon = 100 });
        }
        public DbSet<MauSac> MauSac { get; set; }
        public DbSet<Nsx> Nsx { get; set; }
        public DbSet<Size> Size { get; set; }
        public DbSet<Giay> Giay { get; set; }
        public DbSet<HangGiay> HangGiay { get; set; }
        public DbSet<ChieuCaoDeGiay> ChieuCaoDeGiay { get; set; }
        public DbSet<ChiTietGiay> ChiTietGiay { get; set; }
        public DbSet<ChiTietSale> ChiTietSale { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<ChiTietTheLoai> ChiTietTheLoai { get; set; }
        public DbSet<TheLoai> TheLoai { get; set; }
        public DbSet<HoaDonChiTiet> HoaDonChiTiet { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<CuaHang> CuaHang { get; set; }
        public DbSet<ChucVu> ChucVu { get; set; }
        public DbSet<GiaoCa> GiaoCa { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<LichSuDiemTieuDung> LichSuDiemTieuDung { get; set; }
        public DbSet<QuyDoi> QuyDoi { get; set; }
        public DbSet<DiemTieuDung> DiemTieuDung { get; set; }
    }
}
