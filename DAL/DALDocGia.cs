﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  class DALDocGia
    {
        private static DALDocGia instance;
        public static DALDocGia Instance
        {
            get
            {
                if (instance == null) instance = new DALDocGia();
                return instance;
            }
            set => instance = value;
        }
        public List<DOCGIA> GetAllDocGia()
        {
            return QUANLYTHUVIENEntities2.Instance.DOCGIAs.ToList();
        }
        public void deleteDocGia(DOCGIA dg)
        {
            QUANLYTHUVIENEntities2.Instance.DOCGIAs.Remove(dg);
            QUANLYTHUVIENEntities2.Instance.SaveChanges();
        }
        public void updateDG(DOCGIA dg)
        {
            var existingEntity = QUANLYTHUVIENEntities2.Instance.Set<DOCGIA>().Local.FirstOrDefault(e => e.MADG == dg.MADG);
            if (existingEntity != null)
            {
                QUANLYTHUVIENEntities2.Instance.Entry(existingEntity).State = System.Data.Entity.EntityState.Detached;
            }
            QUANLYTHUVIENEntities2.Instance.Entry(dg).State = System.Data.Entity.EntityState.Modified;
            QUANLYTHUVIENEntities2.Instance.SaveChanges();
        }

        public void AddDocGia(DOCGIA docGia)
        {
           QUANLYTHUVIENEntities2.Instance.DOCGIAs.Add(docGia);
            QUANLYTHUVIENEntities2.Instance.SaveChanges();

        }
        public string GetNameByID(int id)
        {
            return QUANLYTHUVIENEntities2.Instance.DOCGIAs.Where(x => x.MADG == id).Select(x => x.TENDG).FirstOrDefault();
        }
        public List<int> GetAllDGId()
        {
            return QUANLYTHUVIENEntities2.Instance.DOCGIAs.Select(x => x.MADG).ToList();
        }
        public int GetDGNextId()
        {
            using (var context = new QUANLYTHUVIENEntities2())
            {
                int? maxId = context.DOCGIAs.Max(x => (int?)x.MADG);
                return (maxId ?? 0) + 1;
            }
        }

    }
}
