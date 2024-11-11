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
    public partial class FormNXB : Form
    {
        private BUSNXB bll = new BUSNXB();
        private bool isAddingNew = false;
        public FormNXB()
        {
            InitializeComponent();
        }

        private void FormNXB_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            txtMaNXB.ReadOnly = true;
            txtTenNXB.ReadOnly = true;
            txtDiaChiNXB.ReadOnly = true;
            var nhaXuatBan = bll.LayDanhSachNXB();
            gridViewNXB.DataSource = nhaXuatBan;
            gridViewNXB.Columns["MaNXB"].HeaderText = "Mã NXB";
            gridViewNXB.Columns["TenNXB"].HeaderText = "Tên NXB";
            gridViewNXB.Columns["DiaChiNXB"].HeaderText = "Địa chỉ NXB";
        }

        private void btnThemNXB_Click(object sender, EventArgs e)
        {
            txtMaNXB.Text = string.Empty;
            txtTenNXB.Text = string.Empty;
            txtDiaChiNXB.Text = string.Empty;
            txtMaNXB.ReadOnly = true;
            txtTenNXB.ReadOnly = false;
            txtDiaChiNXB.ReadOnly = false;
            isAddingNew = true;
            
        }

        private void btnSuaNXB_Click(object sender, EventArgs e)
        {
            txtTenNXB.ReadOnly = false;
            txtDiaChiNXB.ReadOnly = false;
            isAddingNew = false;
        }

        private void btnXoaNXB_Click(object sender, EventArgs e)
        {
            int maNXB = Convert.ToInt32(txtMaNXB.Text);
            bll.XoaNXB(maNXB);
            LoadData();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuuNXB_Click(object sender, EventArgs e)
        {
            if (isAddingNew)
            {
                var nhaXuatBan = new NHAXUATBAN
                {
                    TENNXB = txtTenNXB.Text,
                    DIACHI = txtDiaChiNXB.Text,
                };
                bll.ThemNXB(nhaXuatBan);
                isAddingNew = false;
                LoadData();
            }
            else
            {
                var nhaXuatBan = new NHAXUATBAN
                {
                    MANXB = Convert.ToInt32(txtMaNXB.Text),
                    TENNXB = txtTenNXB.Text,
                    DIACHI = txtDiaChiNXB.Text
                };
                bll.SuaNXB(nhaXuatBan);
                LoadData();
            }
        }

        private void gridViewNXB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNXB.Text = gridViewNXB.CurrentRow.Cells["MaNXB"].Value.ToString();
            txtTenNXB.Text = gridViewNXB.CurrentRow.Cells["TenNXB"].Value.ToString();
            txtDiaChiNXB.Text = gridViewNXB.CurrentRow.Cells["DiaChiNXB"].Value.ToString();
            txtMaNXB.ReadOnly = true;
            txtTenNXB.ReadOnly = true;
            txtDiaChiNXB.ReadOnly = true;
            isAddingNew = false;
        }

        private void btnTimKiemNXB_Click(object sender, EventArgs e)
        {
            string searchTerm = cbTimKiemNXB.Text;
            var nhaXuatBans = bll.TimKiemNhaXuatBan(searchTerm);
            gridViewNXB.DataSource = nhaXuatBans;
            if (!cbTimKiemNXB.Items.Contains(searchTerm))
            {
                cbTimKiemNXB.Items.Add(searchTerm);
            }
        }



    }
}
