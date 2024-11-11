using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALPhieuMuon
    {
        private static DALPhieuMuon instance;
        public static DALPhieuMuon Instance
        {
            get
            {
                if (instance == null)
                    instance = new DALPhieuMuon();
                return instance;
            }
            private set { instance = value; }
        }
        public List<PHIEUMUON> GetAllPhieuMuon()
        {
            QUANLYTHUVIENEntities2 db = new QUANLYTHUVIENEntities2();
            return db.PHIEUMUONs.ToList();
        }
        public void UpdatePhieuMuon(PHIEUMUON pm)
        {
            QUANLYTHUVIENEntities2 db = new QUANLYTHUVIENEntities2();
            var existingEntity = db.Set<PHIEUMUON>().Local.FirstOrDefault(e => e.MAPM == pm.MAPM);
            if (existingEntity != null)
            {
                db.Entry(existingEntity).State = System.Data.Entity.EntityState.Detached;
            }
            db.Entry(pm).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void DeletePhieuMuon(PHIEUMUON pm)
        {
            var context = QUANLYTHUVIENEntities2.Instance;
            if (context.Entry(pm).State == EntityState.Detached)
            {
                context.PHIEUMUONs.Attach(pm);
            }
            context.PHIEUMUONs.Remove(pm);
            context.SaveChanges();
        }



        public void AddPhieuMuon(PHIEUMUON pm)
        {
            QUANLYTHUVIENEntities2 db = new QUANLYTHUVIENEntities2();
            db.PHIEUMUONs.Add(pm);
            db.SaveChanges();
        }
    }
}
