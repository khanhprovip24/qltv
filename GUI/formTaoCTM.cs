using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class formTaoCTM : Form
    {
        BUSChiTietMuon busctm = new BUSChiTietMuon();
        BUSPhieuMuon  buspm = new BUSPhieuMuon();
        BUSDocGia busDG = new BUSDocGia();
        BusSach bs = new BusSach();
        public formTaoCTM()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(bs.GetSoLuongByID(int.Parse(cbbMaSach.Text)) < int.Parse(txtSoLuong.Text))
            {
                MessageBox.Show("Số lượng sách không đủ");
                return;
            }
            CHITIETMUON ctm = new CHITIETMUON()
            {
                MAPM = int.Parse(cbbMaPM.Text),
                MASACH = int.Parse(cbbMaSach.Text),
                SOLUONG = int.Parse(txtSoLuong.Text)

            };
            SACH sach = bs.GetAllBooks().FirstOrDefault(s => s.MASACH == int.Parse(cbbMaSach.Text));
            if (sach != null)
            {
                sach.SOLUONG -= int.Parse(txtSoLuong.Text);
                bs.UpdateBook(sach);
            }
            busctm.AddCTM(ctm);
            this.Close();   
        }

        private void formTaoCTM_Load(object sender, EventArgs e)
        {
            cbbMaPM.DataSource = buspm.GetMaPMByStatus("Đang mượn");
            cbbMaSach.DataSource = bs.GetAllBookIds();
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbMaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            int masach = int.Parse(cbbMaSach.Text);
            txtSach.Text =bs.GetNameByID(masach);
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If not, suppress the key press event
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbMaPM_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maDG=buspm.GetMaDGByMaPhieu(int.Parse(cbbMaPM.Text));
            txtDocGia.Text = busDG.GetNameByID(maDG);
        }
    }
}
