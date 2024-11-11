using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DTO;

namespace DAL
{
    public class DALSach
    {
        private static DALSach instance;

        public static DALSach Instance
        {
            get
            {
                if (instance == null)
                    instance = new DALSach();
                return instance;
            }
        }

        public List<SACH> GetAllBooks()
        {
            using (var context = new QUANLYTHUVIENEntities2())
            {
                context.Configuration.LazyLoadingEnabled = false;
                return context.SACHes
                    .Include(s => s.NHAXUATBAN)
                    .Include(s => s.TACGIA)
                    .Include(s => s.THELOAI)
                    .ToList();
            }
        }

        public void AddBook(SACH book)
        {
            using (var context = new QUANLYTHUVIENEntities2())
            {
                context.SACHes.Add(book);
                context.SaveChanges();
            }
        }

        public void UpdateBook(SACH book)
        {
            using (var context = new QUANLYTHUVIENEntities2())
            {
                var existingBook = context.SACHes.Find(book.MASACH);
                if (existingBook != null)
                {
                    existingBook.TENSACH = book.TENSACH;
                    existingBook.MOTA = book.MOTA;
                    existingBook.MATL = book.MATL;
                    existingBook.MANXB = book.MANXB;
                    existingBook.MATACGIA = book.MATACGIA;
                    existingBook.SOLUONG = book.SOLUONG;
                    existingBook.DONGIA = book.DONGIA;
                    context.SaveChanges();
                }
            }
        }

        public void DeleteBook(int maSach)
        {
            using (var context = new QUANLYTHUVIENEntities2())
            {
                var book = context.SACHes.Find(maSach);
                if (book != null)
                {
                    context.SACHes.Remove(book);
                    context.SaveChanges();
                }
            }
        }

        public List<SACH> SearchBooks(string maSach, string tenSach, string maTL, string maNXB, string maTacGia)
        {
            using (var context = new QUANLYTHUVIENEntities2())
            {
                var query = context.SACHes.AsQueryable();

                if (!string.IsNullOrEmpty(maSach))
                {
                    int maSachInt = int.Parse(maSach);
                    query = query.Where(b => b.MASACH == maSachInt);
                }

                if (!string.IsNullOrEmpty(tenSach))
                {
                    query = query.Where(b => b.TENSACH.Contains(tenSach));
                }

                if (!string.IsNullOrEmpty(maTL))
                {
                    query = query.Where(b => b.MATL.Contains(maTL));
                }

                if (!string.IsNullOrEmpty(maNXB))
                {
                    int maNXBInt = int.Parse(maNXB);
                    query = query.Where(b => b.MANXB == maNXBInt);
                }

                if (!string.IsNullOrEmpty(maTacGia))
                {
                    int maTacGiaInt = int.Parse(maTacGia);
                    query = query.Where(b => b.MATACGIA == maTacGiaInt);
                }

                return query.ToList();
            }
        }

        public List<int> GetAllBookIds()
        {
            using (var context = new QUANLYTHUVIENEntities2())
            {
                return context.SACHes.Select(s => s.MASACH).ToList();
            }
        }

        public List<string> GetAllCategoryIds()
        {
            using (var context = new QUANLYTHUVIENEntities2())
            {
                return context.THELOAIs.Select(t => t.MATL).ToList();
            }
        }

        public List<int> GetAllPublisherIds()
        {
            using (var context = new QUANLYTHUVIENEntities2())
            {
                return context.NHAXUATBANs.Select(n => n.MANXB).ToList();
            }
        }

        public List<int> GetAllAuthorIds()
        {
            using (var context = new QUANLYTHUVIENEntities2())
            {
                return context.TACGIAs.Select(t => t.MATACGIA).ToList();
            }
        }
    }
}
