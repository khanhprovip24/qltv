using System.Collections.Generic;
using DTO;
using DAL;

namespace BUS
{
    public class BUSTheLoaiSach
    {
        private static BUSTheLoaiSach instance;

        public static BUSTheLoaiSach Instance
        {
            get
            {
                if (instance == null)
                    instance = new BUSTheLoaiSach();
                return instance;
            }
        }

        public List<THELOAI> GetAllTheLoai()
        {
            return DALTheLoaiSach.Instance.GetAllTheLoai();
        }

        public void AddTheLoai(THELOAI theLoai)
        {
            DALTheLoaiSach.Instance.AddTheLoai(theLoai);
        }

        public void UpdateTheLoai(THELOAI theLoai)
        {
            DALTheLoaiSach.Instance.UpdateTheLoai(theLoai);
        }

        public void DeleteTheLoai(string maTL)
        {
            DALTheLoaiSach.Instance.DeleteTheLoai(maTL);
        }

        public List<THELOAI> SearchTheLoai(string maTL, string tenTL)
        {
            return DALTheLoaiSach.Instance.SearchTheLoai(maTL, tenTL);
        }
    }
}
