using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.Entity;

namespace DAL
{
    public class DALNXB
    {
        public List<ThongTinNXB> LayDanhSachNXB()
        {
            using (var context = new QUANLYTHUVIENEntities2())
            {
                var query = from nxb in context.NHAXUATBANs
                            select new ThongTinNXB
                            {
                                MaNXB = nxb.MANXB,
                                TenNXB = nxb.TENNXB,
                                DiaChiNXB = nxb.DIACHI 
                            };
                return query.ToList();
            }
        }

        public void ThemNXB(NHAXUATBAN nhaXuatBan)
        {
            using (var context = new QUANLYTHUVIENEntities2())
            {
                context.NHAXUATBANs.Add(nhaXuatBan);
                context.SaveChanges();
            }
        }

        public void SuaNXB(NHAXUATBAN nhaXuatBan)
        {
            using (var context = new QUANLYTHUVIENEntities2())
            {
                var nxb = context.NHAXUATBANs.FirstOrDefault(x => x.MANXB == nhaXuatBan.MANXB);
                if (nxb != null)
                {
                    nxb.TENNXB = nhaXuatBan.TENNXB;
                    context.SaveChanges();
                }
            }
        }

        public void XoaNXB(int maNXB)
        {
            using(var context = new QUANLYTHUVIENEntities2())
            {
                var nxb = context.NHAXUATBANs.FirstOrDefault(x => x.MANXB == maNXB);
                if(nxb != null)
                {
                    context.NHAXUATBANs.Remove(nxb);
                    context.SaveChanges();
                }
            }
        }

        public List<ThongTinNXB> TimKiemNXB(string searchTerm)
        {
            using (var context = new QUANLYTHUVIENEntities2())
            {
                var query = from nxb in context.NHAXUATBANs
                            where nxb.TENNXB.Contains(searchTerm)
                            select new ThongTinNXB
                            {
                                MaNXB = nxb.MANXB,
                                TenNXB = nxb.TENNXB,
                                DiaChiNXB = nxb.DIACHI
                            };
                return query.ToList();
            }
        }
    }
}
