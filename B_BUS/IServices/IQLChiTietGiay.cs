using A_DAL.Entities;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLChiTietGiay
    {
        bool Add(ChiTietGiay obj);
        bool Update(ChiTietGiay obj);
        bool Delete(ChiTietGiay obj);
        List<ChiTietGiay> GetAll();
        bool CheckMa(Guid idSize, Guid idNsx, Guid idMauSac, Guid idHangGiay, Guid idGiay, Guid idChieuCaoDeGiay);
       
        List<ChiTietGiayView> GetAllView();
        List<ChiTietGiayView> GetAllViewSale();
    }
}
