using A_DAL.Entities;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLChiTietTheLoai
    {
        bool Add(ChiTietTheLoai obj);
        bool Update(ChiTietTheLoai obj);
        bool Delete(ChiTietTheLoai obj);
        bool checkma(Guid obj);
        List<ChiTietTheLoaiView> GetAllView();
    }
}
