using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSChiTietMuon
    {
        private static BUSChiTietMuon instance;
        
            public static BUSChiTietMuon Instance
        {
            get
            {
                if (instance == null)
                    instance = new BUSChiTietMuon();
                return instance;
            }
            private set { instance = value; }
        }
        public List<CHITIETMUON> GetListCTM()
        {
            return DAL.DALChiTietMuon.Instance.GetListCTM();
        }
        public void AddCTM(CHITIETMUON ctm)
        {
            DAL.DALChiTietMuon.Instance.AddCTM(ctm);
        }
        //new
        public void EditCTM_2(CHITIETMUON currentCTM, CHITIETMUON newCTM)
        {
            DALChiTietMuon.Instance.EditCTM_2(currentCTM, newCTM);
        }
        public void EditCTM(CHITIETMUON ctm)
        {
            DAL.DALChiTietMuon.Instance.EditCTM(ctm);
        }
        public void DeleteCTM(int mapm, int masach)
        {
            DAL.DALChiTietMuon.Instance.DeleteCTM(mapm, masach);
        }
    }
}
