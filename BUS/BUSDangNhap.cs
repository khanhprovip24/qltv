using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSDangNhap
    {
        private static BUSDangNhap instance;
        public static BUSDangNhap Instance
        {
            get
            {
                if (instance == null) instance = new BUSDangNhap();
                return instance;
            }
            set => instance = value;
        }
        private DALTaiKhoan dalTK = new DALTaiKhoan();
        public int checkLogin(string username, string password)
        {
          List<TAIKHOAN> listTaiKhoan = dalTK.GetAllTaiKhoan();
            foreach (var user in listTaiKhoan)
            {
                if (user.TENDN == username )
                {
                    if(user.MATKHAU == password) { return user.MATK; }
                    
                }
            }   
            return -1;
        }
    }
}
