using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public  class BUSDocGia
    {
        DALDocGia dalDG=new DALDocGia();
        private static BUSDocGia instance;
        public static BUSDocGia Instance
        {
            get
            {
                if (instance == null) instance = new BUSDocGia();
                return instance;
            }
            set => instance = value;
        }
        public List<DOCGIA> GetAllDocGia()
        {
            return dalDG.GetAllDocGia();
        }
        public void deleteDocGia(DOCGIA madg)
        {
            dalDG.deleteDocGia(madg);
        }
        public void updateDG(DOCGIA dg)
        {
            dalDG.updateDG(dg);
        }
        public void AddDocGia(DOCGIA docGia)
        {
            dalDG.AddDocGia(docGia);
        }
        public string GetNameByID(int id)
        {
            return dalDG.GetNameByID(id);
        }
        public List<int> GetAllDGId()
        {
            return dalDG.GetAllDGId();
        }

    }
}
