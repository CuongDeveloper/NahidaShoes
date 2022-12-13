using A_DAL.Entities;

namespace B_BUS.View_Models
{
    public class ChiTietGiayView
    {
        //chi tiet giay
        public ChiTietGiay ChiTietGiay { get; set; } = new();
        //mau sac
        public MauSac MauSac { get; set; } = new();
        //nsx
        public Nsx Nsx { get; set; } = new();
        //size
        public Size Size { get; set; } = new();
        //giay
        public Giay Giay { get; set; } = new();
        //hang giay
        public HangGiay HangGiay { get; set; } = new();
        //chieu cao de giay
        public ChieuCaoDeGiay ChieuCaoDeGiay { get; set; } = new();
        public ChiTietSale ChiTietSale { get; set; } = new();
        public Sale Sale { get; set; } = new();
    }
}
