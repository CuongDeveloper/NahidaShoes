namespace A_DAL.Entities
{
    public class ChiTietGiay
    {
        public ChiTietGiay()
        {
            ChiTietSales = new HashSet<ChiTietSale>();
            ChiTietTheLoais = new HashSet<ChiTietTheLoai>();
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }
        public Guid Id { get; set; }
        public Guid IdMauSac { get; set; }
        public Guid IdNsx { get; set; }
        public Guid IdSize { get; set; }
        public Guid IdHangGiay { get; set; }
        public Guid IdChieuCaoDeGiay { get; set; }
        public Guid IdGiay { get; set; }
        public string? MoTa { get; set; }
        public float GiaBan { get; set; } = 0!;
        public float GiaNhap { get; set; } = 0!;
        public int SoLuongTon { get; set; } = 0!;
        public int TrangThai { get; set; } = 0!;
        public string? Anh { get; set; }
        public MauSac IdMauSacNavigation { get; set; } = null!;
        public Nsx IdNsxNavigation { get; set; } = null!;
        public Size IdSizeNavigation { get; set; } = null!;
        public HangGiay IdHangGiayNavigation { get; set; } = null!;
        public ChieuCaoDeGiay IdChieuCaoDeGiayNavigation { get; set; } = null!;
        public Giay IdGiayNavigation { get; set; } = null!;
        public ICollection<ChiTietSale> ChiTietSales { get; set; }
        public ICollection<ChiTietTheLoai> ChiTietTheLoais { get; set; }
        public ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
