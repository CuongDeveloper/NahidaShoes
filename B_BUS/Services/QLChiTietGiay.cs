using A_DAL.Entities;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IServices;
using B_BUS.View_Models;

namespace B_BUS.Services
{
    public class QLChiTietGiay : IQLChiTietGiay
    {
        //bien
        public IGenericRepository<ChiTietGiay> igchiTietGiay;
        public IGenericRepository<MauSac> igmausac;
        public IGenericRepository<Nsx> igNsx;
        public IGenericRepository<Size> igSize;
        public IGenericRepository<HangGiay> igHangGiay;
        public IGenericRepository<ChieuCaoDeGiay> igchieucaodegiay;
        public IGenericRepository<Giay> igGiay;
        public IGenericRepository<ChiTietSale> igChiTietSale;
        public IGenericRepository<Sale> igSale;
        public QLChiTietGiay()
        {
            igchiTietGiay = new GenericRepository<ChiTietGiay>();
            igmausac = new GenericRepository<MauSac>();
            igNsx = new GenericRepository<Nsx>();
            igSize = new GenericRepository<Size>();
            igHangGiay = new GenericRepository<HangGiay>();
            igchieucaodegiay = new GenericRepository<ChieuCaoDeGiay>();
            igGiay = new GenericRepository<Giay>();
            igChiTietSale = new GenericRepository<ChiTietSale>();
            igSale = new GenericRepository<Sale>();

        }
        public bool Add(ChiTietGiay obj)
        {
            //add
            return igchiTietGiay.Add(obj);
        }

        public bool Update(ChiTietGiay obj)
        {
            return igchiTietGiay.Update(obj);
        }

        public bool Delete(ChiTietGiay obj)
        {
            //delete
            return igchiTietGiay.Delete(obj);
        }

        public List<ChiTietGiay> GetAll()
        {
            return igchiTietGiay.GetAll();
        }

        public bool CheckMa(Guid idSize, Guid idNsx, Guid idMauSac, Guid idHangGiay, Guid idGiay, Guid idChieuCaoDeGiay)
        {
            return !igchiTietGiay.GetAll().Any(c => c.IdSize == idSize && c.IdGiay == idGiay && c.IdNsx == idNsx && c.IdChieuCaoDeGiay == idChieuCaoDeGiay && c.IdHangGiay == idHangGiay && c.IdMauSac == idMauSac);
        }

       

        public List<ChiTietGiayView> GetAllView()
        {
            // getall
            List<ChiTietGiayView> lst = (from a in igchiTietGiay.GetAll()
                                         join b in igmausac.GetAll() on a.IdMauSac equals b.Id
                                         join c in igNsx.GetAll() on a.IdNsx equals c.Id
                                         join d in igSize.GetAll() on a.IdSize equals d.Id
                                         join e in igHangGiay.GetAll() on a.IdHangGiay equals e.Id
                                         join f in igchieucaodegiay.GetAll() on a.IdChieuCaoDeGiay equals f.Id
                                         join g in igGiay.GetAll() on a.IdGiay equals g.Id

                                         select new ChiTietGiayView()
                                         {
                                             ChiTietGiay = a,
                                             MauSac = b,
                                             Nsx = c,
                                             Size = d,
                                             HangGiay = e,
                                             ChieuCaoDeGiay = f,
                                             Giay = g
                                         }).ToList();
            return lst;
        }
        public List<ChiTietGiayView> GetAllViewSale()
        {
            // getall
            List<ChiTietGiayView> lst = (from a in igchiTietGiay.GetAll()
                                         join b in igmausac.GetAll() on a.IdMauSac equals b.Id
                                         join c in igNsx.GetAll() on a.IdNsx equals c.Id
                                         join d in igSize.GetAll() on a.IdSize equals d.Id
                                         join e in igHangGiay.GetAll() on a.IdHangGiay equals e.Id
                                         join f in igchieucaodegiay.GetAll() on a.IdChieuCaoDeGiay equals f.Id
                                         join g in igGiay.GetAll() on a.IdGiay equals g.Id
                                         join i in igChiTietSale.GetAll() on a.Id equals i.IdChiTietGiay
                                         join h in igSale.GetAll() on i.IdSale equals h.Id
                                         select new ChiTietGiayView()
                                         {
                                             ChiTietGiay = a,
                                             MauSac = b,
                                             Nsx = c,
                                             Size = d,
                                             HangGiay = e,
                                             ChieuCaoDeGiay = f,
                                             Giay = g,
                                             ChiTietSale = i,
                                             Sale = h,
                                         }).ToList();
            return lst;
        }
    }
}
