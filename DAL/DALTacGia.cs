using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL
{
    public class DALTacGia
    {
        // Lấy danh sách tác giả chỉ với mã và tên
        public List<ThongTinTacGia> LayDanhSachTacGia()
        {
            using (var context = new QUANLYTHUVIENEntities2())
            {
                var query = from tg in context.TACGIAs
                            select new ThongTinTacGia
                            {
                                MaTacGia = tg.MATACGIA,
                                TenTacGia = tg.TENTACGIA
                            };
                return query.ToList();
            }
        }


        // Thêm tác giả mới
        public void ThemTacGia(TACGIA tacGia)
        {
            using (var context = new QUANLYTHUVIENEntities2())
            {
                context.TACGIAs.Add(tacGia);
                context.SaveChanges();
            }
        }

        // Cập nhật thông tin tác giả
        public void SuaTacGia(TACGIA tacGia)
        {
            using (var context = new QUANLYTHUVIENEntities2())
            {
                var tg = context.TACGIAs.FirstOrDefault(x => x.MATACGIA == tacGia.MATACGIA);
                if (tg != null)
                {
                    tg.TENTACGIA = tacGia.TENTACGIA;
                    context.SaveChanges();
                }
            }
        }

        // Xóa tác giả
        public void XoaTacGia(int maTacGia)
        {
            using (var context = new QUANLYTHUVIENEntities2())
            {
                var tg = context.TACGIAs.FirstOrDefault(x => x.MATACGIA == maTacGia);
                if (tg != null)
                {
                    context.TACGIAs.Remove(tg);
                    context.SaveChanges();
                }
            }
        }

        // Tìm kiếm tác giả theo tên
        public List<ThongTinTacGia> TimKiemTacGia(string searchTerm)
        {
            using (var context = new QUANLYTHUVIENEntities2())
            {
                var query = from tg in context.TACGIAs
                            where tg.TENTACGIA.Contains(searchTerm) // Tìm kiếm tên chứa từ khóa
                            select new ThongTinTacGia
                            {
                                MaTacGia = tg.MATACGIA,
                                TenTacGia = tg.TENTACGIA
                            };
                return query.ToList();
            }
        }
        public int nextMaTacGia()
        {
            using (var context = new QUANLYTHUVIENEntities2())
            {
                int? maxId = context.TACGIAs.Max(x => (int?)x.MATACGIA);
                return (maxId ?? 0) + 1;
            }
        }

    }
}
