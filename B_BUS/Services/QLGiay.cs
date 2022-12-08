﻿using A_DAL.Entities;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IServices;
using B_BUS.View_Models;

namespace B_BUS.Services
{
    public class QLGiay : IQLGiay
    {
        //bien
        public IGenericRepository<Giay> igiay;
        public QLGiay()
        {
            igiay = new GenericRepository<Giay>();
        }
        public bool Add(Giay obj)
        {
            //add
            return igiay.Add(obj);
        }

        public bool Update(Giay obj)
        {
            //update
            return igiay.Update(obj);
        }

        public bool Delete(Giay obj)
        {
            //delete
            return igiay.Delete(obj);
        }

        public List<Giay> GetAll()
        {
            return igiay.GetAll();
        }

        public Guid idGiay(Giay obj)
        {
            Giay x = new Giay();

            x.Id = Guid.NewGuid();
            x.MaGiay = obj.MaGiay;
            x.TenGiay = obj.TenGiay;
            x.TrangThai = obj.TrangThai;
            
            if (igiay.Add(x)) return x.Id;
            else return Guid.Empty;
        }

        public Giay? GetByMa(string? ma)
        {
            return igiay.GetAll().Find(c => c.MaGiay == ma);
        }

        public bool CheckMa(string ma)
        {
            return !igiay.GetAll().Any(c => c.MaGiay == ma);
        }

        public List<GiayView> GetAllView()
        {
            // getall
            List<GiayView> lst = (from a in igiay.GetAll()
                                  select new GiayView()
                                  {
                                      Giay = a,
                                  }).ToList();
            return lst;
        }
    }
}
