using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BusSach
    {
        private static BusSach _instance;
        public static BusSach Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BusSach();
                return _instance;
            }
        }

        public List<SACH> GetAllBooks()
        {
            return DALSach.Instance.GetAllBooks();
        }

        public void AddBook(SACH book)
        {
            DALSach.Instance.AddBook(book);
        }

        public void UpdateBook(SACH book)
        {
            DALSach.Instance.UpdateBook(book);
        }

        public void DeleteBook(int maSach)
        {
            DALSach.Instance.DeleteBook(maSach);
        }

        public List<SACH> SearchBooks(string maSach, string tenSach, string maTL, string maNXB, string maTacGia)
        {
            return DALSach.Instance.SearchBooks(maSach, tenSach, maTL, maNXB, maTacGia);
        }

        public List<int> GetAllBookIds()
        {
            return DALSach.Instance.GetAllBookIds();
        }

        public List<string> GetAllCategoryIds()
        {
            return DALSach.Instance.GetAllCategoryIds();
        }

        public List<int> GetAllPublisherIds()
        {
            return DALSach.Instance.GetAllPublisherIds();
        }

        public List<int> GetAllAuthorIds()
        {
            return DALSach.Instance.GetAllAuthorIds();
        }
    }
}
