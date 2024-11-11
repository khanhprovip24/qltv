using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSNXB
    {
        private DALNXB NhaXuatBan = new DALNXB();

        public List<ThongTinNXB> LayDanhSachNXB()
        {
            return NhaXuatBan.LayDanhSachNXB();
        }

        public void ThemNXB(NHAXUATBAN nhaXuatBan)
        {
            NhaXuatBan.ThemNXB(nhaXuatBan);
        }

        public void SuaNXB(NHAXUATBAN nhaXuatBan)
        {
            NhaXuatBan.SuaNXB(nhaXuatBan);
        }

        public void XoaNXB(int maTacGia)
        {
            NhaXuatBan.XoaNXB(maTacGia);
        }

        public List<ThongTinNXB> TimKiemNhaXuatBan(string searchTerm)
        {
            return NhaXuatBan.TimKiemNXB(searchTerm);
        }
    }
}
