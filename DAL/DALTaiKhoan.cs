using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class DALTaiKhoan 
    {
        private static DALTaiKhoan instance;
        //Đảm bảo rằng chỉ có một thể hiện duy nhất của lớp DALNguoiDung tồn tại trong suốt vòng đời của ứng dụng.
        public static DALTaiKhoan Instance
        {
            get
            {
                if (instance == null) instance = new DALTaiKhoan();
                return instance;
            }
            set => instance = value;
        }
        public List<TAIKHOAN> GetAllTaiKhoan()
        {
            return QUANLYTHUVIENEntities2.Instance.TAIKHOANs.ToList();
        }
        public void AddTaiKhoan(TAIKHOAN taiKhoan)
        {
            QUANLYTHUVIENEntities2.Instance.TAIKHOANs.Add(taiKhoan);
            QUANLYTHUVIENEntities2.Instance.SaveChanges();
        }
        public List<TAIKHOAN> GetAllTKThuThu()
        {
            return QUANLYTHUVIENEntities2.Instance.TAIKHOANs.Where(p => p.MALOAITK == "TH001").ToList();
        }
        public void DeleteTaiKhoan(TAIKHOAN tk)
        {
           QUANLYTHUVIENEntities2.Instance.TAIKHOANs.Remove(tk);
            QUANLYTHUVIENEntities2.Instance.SaveChanges();
        }
        public void UpdateTaiKhoan(TAIKHOAN tk)
        {
            var existingEntity = QUANLYTHUVIENEntities2.Instance.Set<TAIKHOAN>().Find(tk.MATK);
            if (existingEntity != null)
            {
                // Chỉ cập nhật các thuộc tính không null hoặc không phải giá trị mặc định
                if (!string.IsNullOrEmpty(tk.TENDN)) existingEntity.TENDN = tk.TENDN;
                if (!string.IsNullOrEmpty(tk.MATKHAU)) existingEntity.MATKHAU = tk.MATKHAU;
                if (tk.NGAYDANGKY.HasValue) existingEntity.NGAYDANGKY = tk.NGAYDANGKY;
                if (tk.TRANGTHAI.HasValue) existingEntity.TRANGTHAI = tk.TRANGTHAI;
                if (!string.IsNullOrEmpty(tk.MALOAITK)) existingEntity.MALOAITK = tk.MALOAITK;
                if (!string.IsNullOrEmpty(tk.HOTEN)) existingEntity.HOTEN = tk.HOTEN;
                if (!string.IsNullOrEmpty(tk.EMAIL)) existingEntity.EMAIL = tk.EMAIL;
                if (!string.IsNullOrEmpty(tk.SDT)) existingEntity.SDT = tk.SDT;
                if (!string.IsNullOrEmpty(tk.DIACHI)) existingEntity.DIACHI = tk.DIACHI;
            }
            else
            {
                QUANLYTHUVIENEntities2.Instance.Entry(tk).State = System.Data.Entity.EntityState.Modified;
            }
            QUANLYTHUVIENEntities2.Instance.SaveChanges();
        }



    }


}

