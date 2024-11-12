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
    public partial class formQLYDocGia : Form
    {
        int userid;
        BUSDocGia busDG=new BUSDocGia();
        public formQLYDocGia(int userid)
        {
            InitializeComponent();
            this.userid = userid;
        }

        private void formQLYDocGia_Load(object sender, EventArgs e)
        {
            gridDocGia.DataSource = busDG.GetAllDocGia();

            gridDocGia.Columns["PHIEUMUONS"].Visible = false; // Ẩn cột PHIEUMUONS nếu không cần thiết
            gridDocGia.Columns["TAIKHOAN"].Visible = false; // Ẩn cột TAIKHOAN nếu không cần thiết
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDiaChi.Text = gridDocGia.CurrentRow.Cells["DIACHI"].Value.ToString();
            txtEmail.Text = gridDocGia.CurrentRow.Cells["EMAIL"].Value.ToString();
            txtMa.Text = gridDocGia.CurrentRow.Cells["MADG"].Value.ToString();
            txtTen.Text = gridDocGia.CurrentRow.Cells["TENDG"].Value.ToString();
            txtSDT.Text = gridDocGia.CurrentRow.Cells["SDT"].Value.ToString();
            comboBoxGT.Text = gridDocGia.CurrentRow.Cells["GIOITINH"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            if (gridDocGia.CurrentRow != null)
            {
               DOCGIA dg=gridDocGia.CurrentRow.DataBoundItem as DOCGIA;
                busDG.deleteDocGia(dg);
                MessageBox.Show("Độc giả đã được xóa thành công!");

                // Cập nhật lại dữ liệu trong gridDocGia
                gridDocGia.DataSource = busDG.GetAllDocGia();
                gridDocGia.Refresh(); // Làm mới gridDocGia để hiển thị dữ liệu mới
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một độc giả để xóa.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            txtMa.ReadOnly = true ;
            if (gridDocGia.CurrentRow != null)
            {
                int madg = (int)gridDocGia.CurrentRow.Cells["MADG"].Value;

                DOCGIA docGia = new DOCGIA
                {
                    MADG = madg,
                    TENDG = txtTen.Text,
                    EMAIL = txtEmail.Text,
                    SDT = txtSDT.Text,
                    GIOITINH = comboBoxGT.Text,
                    DIACHI = txtDiaChi.Text,
                    MATK = userid
                };

                busDG.updateDG(docGia);
                MessageBox.Show("Độc giả đã được cập nhật thành công!");

                // Cập nhật lại dữ liệu trong gridDocGia
                gridDocGia.DataSource = busDG.GetAllDocGia();
                gridDocGia.Refresh(); // Làm mới gridDocGia để hiển thị dữ liệu mới
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một độc giả để cập nhật.");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string id = busDG.GetDGNextId().ToString();
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtMa.Text = id;
            txtTen.Text = "";
            txtSDT.Text = "";
            comboBoxGT.Text = "";
            txtMa.ReadOnly = true;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtTen.Text == "" || txtEmail.Text == "" || txtSDT.Text == "" || comboBoxGT.Text == "" || txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            var docGia = new DOCGIA
            {
                TENDG = txtTen.Text,
                EMAIL = txtEmail.Text,
                SDT = txtSDT.Text,
                GIOITINH = comboBoxGT.Text,
                DIACHI = txtDiaChi.Text,
                MATK= userid
            };
            busDG.AddDocGia(docGia);
            MessageBox.Show("Dữ liệu đã được lưu thành công!");
            btnLuu.Enabled = false;
            gridDocGia.DataSource = busDG.GetAllDocGia();   
            gridDocGia.Refresh();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(radioButtonMA.Checked)
            {
                gridDocGia.DataSource = busDG.GetAllDocGia().Where(p => p.MADG.ToString().Contains(txtTimKiem.Text)).ToList();
            }
            else if (radioButtonTEN.Checked)
            {
                gridDocGia.DataSource = busDG.GetAllDocGia().Where(p => p.TENDG.Contains(txtTimKiem.Text)).ToList();
            }
        }

        private void radioButtonTEN_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonMA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
