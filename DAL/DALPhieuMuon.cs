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
            using (var db = new QUANLYTHUVIENEntities2())
            {
                var existingEntity = db.PHIEUMUONs.AsNoTracking().FirstOrDefault(e => e.MAPM == pm.MAPM);
                if (existingEntity != null)
                {
                    db.PHIEUMUONs.Attach(existingEntity);
                    db.Entry(existingEntity).CurrentValues.SetValues(pm);
                    db.SaveChanges();
                }
            }
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
            int? maxId = QUANLYTHUVIENEntities2.Instance.PHIEUMUONs.Max(x => (int?)x.MAPM);
            return (maxId ?? 0) + 1;
        }

        public List<PHIEUMUON> GetPhieuMuonByMaDocGia(int madg)
        {
            QUANLYTHUVIENEntities2 db = new QUANLYTHUVIENEntities2();
            return db.PHIEUMUONs.Where(x => x.MADG == madg).ToList();
        }

        public PHIEUMUON Get1PhieuMuonByMaPM(int maPM)
        {
            QUANLYTHUVIENEntities2 db = new QUANLYTHUVIENEntities2();
            return db.PHIEUMUONs.Where(x => x.MAPM == maPM).FirstOrDefault();
        }
        public List<PHIEUMUON> GetPhieuMuonByMaPM(int maPM)
        {
            QUANLYTHUVIENEntities2 db = new QUANLYTHUVIENEntities2();
            return db.PHIEUMUONs.Where(x => x.MAPM == maPM).ToList();
        }
        public List<int> GetAllMaPM()
        {
            QUANLYTHUVIENEntities2 db = new QUANLYTHUVIENEntities2();
            return db.PHIEUMUONs.Select(x => x.MAPM).ToList();
        }
        public int GetMaDGByMaPhieu(int maPM)
        {
            QUANLYTHUVIENEntities2 db = new QUANLYTHUVIENEntities2();
            return db.PHIEUMUONs.Where(x => x.MAPM == maPM).Select(x => x.MADG).FirstOrDefault().GetValueOrDefault();
        }
        public void UpdateLateStatus()
        {
            var today = DateTime.Today;
            var chiTietMuons = QUANLYTHUVIENEntities2.Instance.PHIEUMUONs.ToList();

            foreach (var ctm in chiTietMuons)
            {
                if (ctm.NGAYTRA < today && ctm.TINHTRANG == "Đang mượn")
                {
                    ctm.TINHTRANG = "Trễ hạn";
                }
            }

            QUANLYTHUVIENEntities2.Instance.SaveChanges();
        }
        public List<CHITIETMUON> GetChiTietMuonsByMaPhieu(int maPhieu)
        {
            QUANLYTHUVIENEntities2 db = new QUANLYTHUVIENEntities2();
            return db.CHITIETMUONs.Where(x => x.MAPM == maPhieu).ToList();
        }
        public void DeleteChiTietMuon(int maPM, int maSach)
        {
            var context = QUANLYTHUVIENEntities2.Instance;
            var existingEntity = context.CHITIETMUONs.Find(maPM, maSach);
            if (existingEntity != null)
            {
                context.CHITIETMUONs.Remove(existingEntity);
                context.SaveChanges();
            }
        }
        public List<int> GetMaPMByStatus(string status)
        {
            using (var context = new QUANLYTHUVIENEntities2())
            {
                return context.PHIEUMUONs
                    .Where(pm => pm.TINHTRANG == status)
                    .Select(pm => pm.MAPM)
                    .ToList();
            }
        }

    }
}
