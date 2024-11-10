using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSTaiKhoan
    {
        DALTaiKhoan dalTK = new DALTaiKhoan();
        private static BUSTaiKhoan instance;
        public static BUSTaiKhoan Instance
        {
            get
            {
                if (instance == null) instance = new BUSTaiKhoan();
                return instance;
            }
            set => instance = value;
        }
        

        public List<TAIKHOAN> GetAllTaiKhoan()
        {
            return dalTK.GetAllTaiKhoan();
        }
        public string GetNameById(int id)
        {
         List<TAIKHOAN>  ds = dalTK.GetAllTaiKhoan();
            foreach (var item in ds)
            {
                if (item.MATK == id)
                {
                    return item.HOTEN;
                }
            }
            return null;
        }
        public string GetLoaiTKById(int id)
        {
            List<TAIKHOAN> ds = dalTK.GetAllTaiKhoan();
            foreach (var item in ds)
            {
                if (item.MATK == id)
                {
                    return item.MALOAITK;
                }
            }
            return null;
        }
        public void AddTaiKhoan(TAIKHOAN taiKhoan)
        {
            dalTK.AddTaiKhoan(taiKhoan);
        }
        public List<TAIKHOAN> GetAllTKThuThu()
        {
            return dalTK.GetAllTKThuThu();
        }
        public void DeleteTaiKhoan(TAIKHOAN dg)
        {
            dalTK.DeleteTaiKhoan(dg);
        }
        public void UpdateTaiKhoan(TAIKHOAN taiKhoan)
        {
            dalTK.UpdateTaiKhoan(taiKhoan);
        }

    }
}
