using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data.SqlClient;
using DTO;


namespace DAL
{
    public class DALTheLoaiSach
    {
        private static DALTheLoaiSach instance;

        public static DALTheLoaiSach Instance
        {
            get
            {
                if (instance == null)
                    instance = new DALTheLoaiSach();
                return instance;
            }
        }

        public List<THELOAI> GetAllTheLoai()
        {
            using (var context = new QUANLYTHUVIENEntities2())
            {
                return context.THELOAIs.ToList();
            }
        }

        public void AddTheLoai(THELOAI theLoai)
        {
            using (var context = new QUANLYTHUVIENEntities2())
            {
                context.THELOAIs.Add(theLoai);
                context.SaveChanges();
            }
        }

        public void UpdateTheLoai(THELOAI theLoai)
        {
            using (var context = new QUANLYTHUVIENEntities2())
            {
                var existingTheLoai = context.THELOAIs.Find(theLoai.MATL);
                if (existingTheLoai != null)
                {
                    existingTheLoai.TENTL = theLoai.TENTL;
                    context.SaveChanges();
                }
            }
        }

        public void DeleteTheLoai(string maTL)
        {
            using (var context = new QUANLYTHUVIENEntities2())
            {
                var theLoai = context.THELOAIs.Find(maTL);
                if (theLoai != null)
                {
                    context.THELOAIs.Remove(theLoai);
                    context.SaveChanges();
                }
            }
        }

        public List<THELOAI> SearchTheLoai(string maTL, string tenTL)
        {
            using (var context = new QUANLYTHUVIENEntities2())
            {
                var query = context.THELOAIs.AsQueryable();

                if (!string.IsNullOrEmpty(maTL))
                {
                    query = query.Where(tl => tl.MATL.Contains(maTL));
                }

                if (!string.IsNullOrEmpty(tenTL))
                {
                    query = query.Where(tl => tl.TENTL.Contains(tenTL));
                }

                return query.ToList();
            }
        }
    }
}
