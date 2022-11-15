﻿using A_DAL.Entities;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLChiTietGiay
    {
        bool Add(ChiTietGiay obj);
        bool Update(ChiTietGiay obj);
        bool Delete(ChiTietGiay obj);
        List<ChiTietGiayView> GetAllView();
    }
}
