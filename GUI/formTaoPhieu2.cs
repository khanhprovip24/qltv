using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class formTaoPhieu2 : Form
    {
        BUSDocGia busDG= new BUSDocGia();
        BUSPhieuMuon busPM = new BUSPhieuMuon();
        public formTaoPhieu2()
        {
            InitializeComponent();
        }

        private void formTaoPhieu2_Load(object sender, EventArgs e)
        {
            cbbMaDG.DataSource = busDG.GetAllDGId();
            txtMaPhieu.Text = busPM.GetNextId().ToString();
        }

        private void cbbMaDG_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbTenDG.Text = busDG.GetNameByID(int.Parse(cbbMaDG.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tongSoSach;
            if (dateMuon.Value > dateTra.Value)
            {
                MessageBox.Show("Ngày mượn không thể lớn hơn ngày trả.");
                return;
            }
            if (int.TryParse(txtTSS.Text, out tongSoSach))
            {
                PHIEUMUON pm = new PHIEUMUON()
                {
                    MADG = int.Parse(cbbMaDG.Text),
                    NGAYMUON = dateMuon.Value,
                    NGAYTRA = dateTra.Value,
                    TINHTRANG = cbbTT.Text,
                    TONGSO_SACH = tongSoSach
                };
                busPM.AddPhieuMuon(pm);
                this.Close();
            }
            else
            {
                // Xử lý trường hợp không thể chuyển đổi
                MessageBox.Show("Tổng số sách không hợp lệ.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
