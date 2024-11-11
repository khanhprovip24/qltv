using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALChiTietMuon
    {
        private static DALChiTietMuon instance;
        public static DALChiTietMuon Instance
        {
            get
            {
                if (instance == null)
                    instance = new DALChiTietMuon();
                return instance;
            }
            private set { instance = value; }
        }
        public List<CHITIETMUON> GetListCTM()
        {
           return QUANLYTHUVIENEntities2.Instance.CHITIETMUONs.ToList();
        }
        public void AddCTM(CHITIETMUON ctm)
        {
            var existingEntry = QUANLYTHUVIENEntities2.Instance.CHITIETMUONs
                .FirstOrDefault(e => e.MAPM == ctm.MAPM && e.MASACH == ctm.MASACH);

            if (existingEntry == null)
            {
                QUANLYTHUVIENEntities2.Instance.CHITIETMUONs.Add(ctm);
                QUANLYTHUVIENEntities2.Instance.SaveChanges();
            }
            else
            {
                // Xử lý trường hợp mục đã tồn tại
                // Ví dụ, bạn có thể muốn cập nhật mục hiện có
                existingEntry.SOLUONG = ctm.SOLUONG; // Cập nhật số lượng hoặc các thuộc tính khác nếu cần
                QUANLYTHUVIENEntities2.Instance.SaveChanges();
            }
        }




        public void EditCTM(CHITIETMUON ctm)
        {
            var ctmEdit = QUANLYTHUVIENEntities2.Instance.CHITIETMUONs.Find(ctm.MAPM, ctm.MASACH);
            ctmEdit.SOLUONG = ctm.SOLUONG;
            QUANLYTHUVIENEntities2.Instance.SaveChanges();
        }
        public void DeleteCTM(int mapm, int masach)
        {
            var ctmDel = QUANLYTHUVIENEntities2.Instance.CHITIETMUONs.Find(mapm, masach);
            QUANLYTHUVIENEntities2.Instance.CHITIETMUONs.Remove(ctmDel);
            QUANLYTHUVIENEntities2.Instance.SaveChanges();
        }

    }
}
