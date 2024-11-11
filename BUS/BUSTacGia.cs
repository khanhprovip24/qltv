using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUSTacGia
    {
        private DALTacGia TacGia = new DALTacGia();

        // Lấy danh sách tác giả kèm theo số sách đã xuất bản và số lượng sách đang mượn
        public List<ThongTinTacGia> LayDanhSachTacGia()
        {
            return TacGia.LayDanhSachTacGia();
        }

        // Thêm tác giả
        public void ThemTacGia(TACGIA tacGia)
        {
            TacGia.ThemTacGia(tacGia);
        }

        // Sửa tác giả
        public void SuaTacGia(TACGIA tacGia)
        {
            TacGia.SuaTacGia(tacGia);
        }

        // Xóa tác giả
        public void XoaTacGia(int maTacGia)
        {
            TacGia.XoaTacGia(maTacGia);
        }

        // Tìm kiếm tác giả
        public List<ThongTinTacGia> TimKiemTacGia(string searchTerm)
        {
            return TacGia.TimKiemTacGia(searchTerm);
        }
    }
}
