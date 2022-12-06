using A_DAL.Entities;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IServices;
using B_BUS.View_Models;

namespace B_BUS.Services
{
    public class QLSanPhamBanChay : IQLSanPhamBanChay
    {
        private IQLGiay _iQLGiay;
        private IQLHoaDon _iQLHoaDon;
        private IQLChiTietGiay _iQLChiTietGiay;
        private IQLHoaDonChiTiet _iQLHDCT;
        private List<SanPhamBanChay> _lstspbanchay;
        private ThongKeSanPhamBanChayView _viewbestseller;
        private string masp;
        private Giay giay;
        private HoaDonChiTiet hdct;
        private int tong;
        private DateTime? day;
        private DateTime? nam;
        private string mon;
        private string year;

        public QLSanPhamBanChay()
        {
            _iQLGiay = new QLGiay();
            giay = new Giay();
            _iQLHoaDon = new QLHoaDon();
            hdct = new HoaDonChiTiet();
            _iQLHDCT = new QLHoaDonChiTiet();
            _iQLChiTietGiay = new QLChiTietGiay();
            _lstspbanchay = new List<SanPhamBanChay>();

            Getlstsanphambanchaytheongay();
        }
        public List<SanPhamBanChay> Getlstsanphambanchaytheongay()
        {
            var lstcommit = (from a in _iQLGiay.GetAll()
                             join b in _iQLChiTietGiay.GetAll() on a.Id equals b.IdGiay

                             join c in _iQLHDCT.GetAll() on b.Id equals c.IdChiTietGiay
                             join d in _iQLHoaDon.GetAll() on c.IdHoaDon equals d.Id

                             select new { a.MaGiay, a.TenGiay, c.SoLuong, d.ThoiGianTao }).ToList();


            var _lstfinnal = lstcommit.OrderByDescending(c => c.SoLuong).GroupBy(c => c.MaGiay).
                Select(g => new SanPhamBanChay(g.Key,
                g.Where(c => c.MaGiay == g.Key).Select(c => c.ThoiGianTao.Value.ToString("MM-dd-yyyy")).FirstOrDefault(),
                g.Where(c => c.MaGiay == g.Key).Select(c => c.TenGiay).FirstOrDefault(),
                g.Sum(c => c.SoLuong))
                ).ToList();
            return _lstfinnal;
        }

    }
}