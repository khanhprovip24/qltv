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
    public partial class formChiTietMuon : Form
    {
        BUSChiTietMuon busCTM =new BUSChiTietMuon();
        BusSach busSach = new BusSach();
        BUSPhieuMuon busPM = new BUSPhieuMuon();
        public formChiTietMuon()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void themTenSach()
        {
            // Ensure the column "TenSach" exists
            if (!griChiTiet.Columns.Contains("TenSach"))
            {
                griChiTiet.Columns.Add("TenSach", "TenSach");
            }

            foreach (DataGridViewRow row in griChiTiet.Rows)
            {
                int ms = (int)row.Cells["MASACH"].Value;
                string tenSach = busSach.GetNameByID(ms);
                row.Cells["TenSach"].Value = tenSach;
            }
        }


        private void formChiTietMuon_Load(object sender, EventArgs e)
        {
            cbbMaPM.DataSource = busPM.GetAllMaPM();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            griChiTiet.DataSource = busCTM.GetListCTM();
            griChiTiet.Columns["PHIEUMUON"].Visible = false;
            griChiTiet.Columns["SACH"].Visible = false;
            
            themTenSach();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            formTaoCTM f = new formTaoCTM();
            f.ShowDialog();
            griChiTiet.DataSource = busCTM.GetListCTM();
            themTenSach();
            griChiTiet.Refresh();
            themTenSach();
        }

        private void griChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPM.Text = griChiTiet.CurrentRow.Cells["MAPM"].Value.ToString();
            txtMaSach.Text = griChiTiet.CurrentRow.Cells["MASACH"].Value.ToString();
            txtSoLuong.Text = griChiTiet.CurrentRow.Cells["SOLUONG"].Value.ToString();
            txtTenSach.Text = busSach.GetNameByID(int.Parse(txtMaSach.Text));
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            CHITIETMUON pm = new CHITIETMUON()
            {
                MAPM = int.Parse(txtMaPM.Text),
                MASACH = int.Parse(txtMaSach.Text),
                SOLUONG = int.Parse(txtSoLuong.Text)
            };
            busCTM.EditCTM(pm);
            griChiTiet.DataSource = busCTM.GetListCTM();
            themTenSach();
            griChiTiet.Refresh();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn xóa chi tiết này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                busCTM.DeleteCTM(int.Parse(txtMaPM.Text), int.Parse(txtMaSach.Text));
                griChiTiet.DataSource = busCTM.GetListCTM();
                themTenSach();
                griChiTiet.Refresh();
            }
        }




        private void cbbMaPM_SelectedIndexChanged(object sender, EventArgs e)
        {
            griChiTiet.DataSource = busCTM.GetListCTM().Where(x => x.MAPM == int.Parse(cbbMaPM.Text)).ToList();
            themTenSach();
        }
    }
}
