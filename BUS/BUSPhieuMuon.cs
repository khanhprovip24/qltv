using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUSPhieuMuon
    {
        private static BUSPhieuMuon instance;
        public static BUSPhieuMuon Instance
        {
            get
            {
                if (instance == null)
                    instance = new BUSPhieuMuon();
                return instance;
            }
            private set { instance = value; }
        }
        public List<PHIEUMUON> GetAllPhieuMuon()
        {
            return DALPhieuMuon.Instance.GetAllPhieuMuon();
        }
        public void UpdatePhieuMuon(PHIEUMUON pm)
        {
            DALPhieuMuon.Instance.UpdatePhieuMuon(pm);
        }
        public void DeletePhieuMuon(PHIEUMUON pm)
        {
            DALPhieuMuon.Instance.DeletePhieuMuon(pm);
        }
        public void AddPhieuMuon(PHIEUMUON pm)
        {
            DALPhieuMuon.Instance.AddPhieuMuon(pm);
        }
        public int GetNextId()
        {
            return DALPhieuMuon.Instance.GetNextId();
        }

        public List<PHIEUMUON> GetPhieuMuonByMaPM(int maPM)
        {
            return DALPhieuMuon.Instance.GetPhieuMuonByMaPM(maPM);
        }
        public List<PHIEUMUON> GetPhieuMuonByMaDocGia(int maDG)
        {
            return DALPhieuMuon.Instance.GetPhieuMuonByMaDocGia(maDG);
        }
        public List<int> GetAllMaPM()
        {
            return DALPhieuMuon.Instance.GetAllMaPM();
        }
        public int GetMaDGByMaPhieu(int maPM)
        {
            return DALPhieuMuon.Instance.GetMaDGByMaPhieu(maPM);
        }
        public void UpdateLateStatus()
        {
          DALPhieuMuon.Instance.UpdateLateStatus();
        }
        public List<CHITIETMUON> GetChiTietMuonsByMaPhieu(int maPhieu)
        {
           return DALPhieuMuon.Instance.GetChiTietMuonsByMaPhieu(maPhieu);
        }
        public void DeleteChiTietMuon(int maPM, int maSach)
        {
            DALPhieuMuon.Instance.DeleteChiTietMuon(maPM, maSach);
        }
        public PHIEUMUON Get1PhieuMuonByMaPM(int mapm)
        {
           return DALPhieuMuon.Instance.Get1PhieuMuonByMaPM(mapm);
        }
        public List<int> GetMaPMByStatus(string status)
        {
            return DALPhieuMuon.Instance.GetMaPMByStatus(status);
        }
    }
}
