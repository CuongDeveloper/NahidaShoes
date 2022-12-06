using A_DAL.Entities;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IServices;
using B_BUS.View_Models;

namespace B_BUS.Services
{
    public class QLThongKeSPBanChay : IQLThongKeSanPhamBanChay
    {
        private IQLGiay _hhser;
        private IQLHoaDon _hdbser;
        private IQLChiTietGiay _cthhser;
        private IQLHoaDonChiTiet _hdctser;
        private List<ThongKeSanPhamBanChayView> _lstspbanchay;
        private ThongKeSanPhamBanChayView _viewbestseller;
        private string masp;
        private ChiTietGiay cthh;
        private HoaDonChiTiet hdct;
        private int tong;
        private DateTime? day;
        private DateTime? nam;
        private string mon;
        private string year;

        public QLThongKeSPBanChay()
        {
            _hhser = new QLGiay();
            cthh = new ChiTietGiay();
            _hdbser = new QLHoaDon();
            hdct = new HoaDonChiTiet();
            _hdctser = new QLHoaDonChiTiet();
            _cthhser = new QLChiTietGiay();
            _lstspbanchay = new List<ThongKeSanPhamBanChayView>();

            Getlstsanphambanchay();
        }
        public List<ThongKeSanPhamBanChayView> Getlstsanphambanchay()
        {
            var lstcommit = (from a in _hhser.GetAll()
                             join b in _cthhser.GetAll() on a.Id equals b.IdGiay

                             join c in _hdctser.GetAll() on b.Id equals c.IdChiTietGiay
                             join d in _hdbser.GetAll() on c.IdHoaDon equals d.Id

                             select new { a.MaGiay, a.TenGiay, c.SoLuong, d.ThoiGianTao }).ToList();

            foreach (var x in lstcommit)
            {
                //tong = Convert.ToInt32(_hdctser.GetAll().Where(c => c.IdChiTietGiay == cthh.Id).Select(c => c.SoLuong).Sum());
                //nam = x.ThoiGianTao;
                //_viewbestseller = new ThongKeSanPhamBanChayView(masp, x.TenGiay, tong, x.ThoiGianTao);
                //_lstspbanchay.Add(_viewbestseller);
            }
            var _lstfinnal = lstcommit.OrderByDescending(c => c.SoLuong).GroupBy(c => c.ThoiGianTao.Value.ToString("MM-dd-yyyy")).
                Select(g => new ThongKeSanPhamBanChayView(g.Key,
                g.Where(c => c.ThoiGianTao.Value.ToString("MM-dd-yyyy") == g.Key).Select(c => c.MaGiay).FirstOrDefault(),
                g.Where(c => c.ThoiGianTao.Value.ToString("MM-dd-yyyy") == g.Key).Select(c => c.TenGiay).FirstOrDefault(),
                g.Sum(c => c.SoLuong))
                ).ToList();
            return _lstfinnal;
        }
    }
}
