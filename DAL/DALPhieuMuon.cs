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
            var existingEntity = context.PHIEUMUONs.Find(pm.MAPM);
            if (existingEntity != null)
            {
                context.PHIEUMUONs.Remove(existingEntity);
                context.SaveChanges();
            }
        }




        public void AddPhieuMuon(PHIEUMUON pm)
        {
            QUANLYTHUVIENEntities2 db = new QUANLYTHUVIENEntities2();
            db.PHIEUMUONs.Add(pm);
            db.SaveChanges();
        }
        public int GetNextId()
        {
            return QUANLYTHUVIENEntities2.Instance.PHIEUMUONs.Max(x => x.MAPM) + 1;
        }
        public List<PHIEUMUON> GetPhieuMuonByMaDocGia(int madg)
        {
            QUANLYTHUVIENEntities2 db = new QUANLYTHUVIENEntities2();
            return db.PHIEUMUONs.Where(x => x.MADG == madg).ToList();
        }
        public List<PHIEUMUON> GetPhieuMuonByMaPM(int maPM)
        {
            QUANLYTHUVIENEntities2 db = new QUANLYTHUVIENEntities2();
            return db.PHIEUMUONs.Where(x => x.MAPM == maPM).ToList();
        }
    }
}
