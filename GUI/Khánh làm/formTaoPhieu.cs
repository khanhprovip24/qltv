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
    public partial class formTaoPhieu : Form
    {
        BUSPhieuMuon busPM = new BUSPhieuMuon();
        BUSDocGia busDG = new BUSDocGia();
        public formTaoPhieu()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void an()
        {

            txtMaPhieu.Enabled = false;
            cbbTenDG.Enabled = false;
            cbbMaDG.Enabled = false;
            cbbTT.Enabled = false;
            dateMuon.Enabled = false;
            dateTra.Enabled = false;
        }
        public void hien()
        {
            txtMaPhieu.Enabled = true;
            cbbTenDG.Enabled = true;
            cbbMaDG.Enabled = true;
            cbbTT.Enabled = true;
            dateMuon.Enabled = true;
            dateTra.Enabled = true;
        }
        

        private void formTaoPhieu_Load(object sender, EventArgs e)
        {
            gridPhieu.DataSource = busPM.GetAllPhieuMuon();
            gridPhieu.Columns["DOCGIA"].Visible = false;
            gridPhieu.Columns["CHITIETMUONs"].Visible = false;
           an();
        }

        private void gridPhieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            hien();
            txtMaPhieu.Text=gridPhieu.CurrentRow.Cells["MAPM"].Value.ToString();
            cbbTenDG.Text =busDG.GetNameByID(int.Parse(gridPhieu.CurrentRow.Cells["MADG"].Value.ToString()));
            cbbMaDG.Text = gridPhieu.CurrentRow.Cells["MADG"].Value.ToString();
            cbbTT.Text = gridPhieu.CurrentRow.Cells["TINHTRANG"].Value.ToString();
            dateMuon.Text = gridPhieu.CurrentRow.Cells["NGAYMUON"].Value.ToString();
            dateTra.Text = gridPhieu.CurrentRow.Cells["NGAYTRA"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            hien();
            btnLuu.Enabled = true;
            txtMaPhieu.Text ="";
            cbbTenDG.Text = "";
            cbbMaDG.Text = "";
            cbbTT.Text = "";
            dateMuon.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            dateTra.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            PHIEUMUON pm = new PHIEUMUON
            {
                MAPM = int.Parse(txtMaPhieu.Text),
                MADG = int.Parse(cbbMaDG.Text),
                NGAYMUON = DateTime.Parse(dateMuon.Text),
                NGAYTRA = DateTime.Parse(dateTra.Text),
                TINHTRANG = cbbTT.Text

            };
            busPM.UpdatePhieuMuon(pm);
            gridPhieu.DataSource = busPM.GetAllPhieuMuon();
            gridPhieu.Refresh();
            an();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(gridPhieu.CurrentRow != null)
            {
                PHIEUMUON pm = gridPhieu.CurrentRow.DataBoundItem as PHIEUMUON;
                busPM.DeletePhieuMuon(pm);
                gridPhieu.DataSource = busPM.GetAllPhieuMuon();
                  MessageBox.Show("đã xóa thành công");
                gridPhieu.Refresh();
                an();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu mượn để xóa.");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            PHIEUMUON pm = new PHIEUMUON
            {
                MADG = (int)gridPhieu.CurrentRow.Cells["MADG"].Value,
                NGAYMUON = DateTime.Parse(dateMuon.Text),
                NGAYTRA = DateTime.Parse(dateTra.Text),
                TINHTRANG = cbbTT.Text

            };
            btnLuu.Enabled = false;
            busPM.AddPhieuMuon(pm);
            gridPhieu.DataSource = busPM.GetAllPhieuMuon();
            gridPhieu.Refresh();
            an();
        }
    }
}
