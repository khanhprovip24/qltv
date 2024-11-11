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
    public partial class fromQLYThuThu : Form
    {
        BUSTaiKhoan busTK = new BUSTaiKhoan();
        public fromQLYThuThu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (gridThuThu.CurrentRow != null)
            {
                TAIKHOAN tk = gridThuThu.CurrentRow.DataBoundItem as TAIKHOAN;
                busTK.DeleteTaiKhoan(tk);
                MessageBox.Show("Độc giả đã được xóa thành công!");

                gridThuThu.DataSource = busTK.GetAllTKThuThu();
                gridThuThu.Refresh(); 
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để xóa.");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void fromQLYThuThu_Load(object sender, EventArgs e)
        {
            gridThuThu.DataSource = busTK.GetAllTKThuThu();
           
            gridThuThu.Columns["MALOAITK"].Visible = false; // Ẩn cột MALOAITK nếu không cần thiết
            gridThuThu.Columns["DOCGIAs"].Visible = false; // Ẩn cột DOCGIAs nếu không cần thiết
            gridThuThu.Columns["LOAITAIKHOAN"].Visible = false; // Ẩn cột LOAITAIKHOAN nếu không cần thiết
            gridThuThu.Columns["DOCGIAs"].Visible = false; 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridThuThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtDiaChi.Text = gridThuThu.CurrentRow.Cells["DIACHI"].Value.ToString();
            //txtEmail.Text = gridThuThu.CurrentRow.Cells["EMAIL"].Value.ToString();
            //txtHoTen.Text = gridThuThu.CurrentRow.Cells["HOTEN"].Value.ToString();
            //txtNgayDK.Text = gridThuThu.CurrentRow.Cells["NGAYDANGKY"].Value.ToString();
            //txtSDT.Text = gridThuThu.CurrentRow.Cells["SDT"].Value.ToString();
            //txtTenDN.Text = gridThuThu.CurrentRow.Cells["TENDN"].Value.ToString();
            //txtMatKhau.Text = gridThuThu.CurrentRow.Cells["MATKHAU"].Value.ToString();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (gridThuThu.CurrentRow != null)
            {
                int matk = (int)gridThuThu.CurrentRow.Cells["MATK"].Value;

                TAIKHOAN taiKhoan = new TAIKHOAN
                {
                    MATK = matk,
                    TENDN = txtTenDN.Text,
                    MATKHAU = txtMatKhau.Text,
                    HOTEN = txtHoTen.Text,
                    DIACHI = txtDiaChi.Text,
                    NGAYDANGKY = DateTime.Parse(txtNgayDK.Text),
                    TRANGTHAI = true, // Hoặc giá trị khác nếu cần
                    EMAIL = txtEmail.Text,
                    SDT = txtSDT.Text
                };

                busTK.UpdateTaiKhoan(taiKhoan);
                MessageBox.Show("Tài khoản đã được cập nhật thành công!");

                // Cập nhật lại dữ liệu trong gridThuThu
                gridThuThu.DataSource = busTK.GetAllTKThuThu();
                gridThuThu.Refresh(); // Làm mới gridThuThu để hiển thị dữ liệu mới
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để cập nhật.");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (radioButtonMA.Checked)
            {
                gridThuThu.DataSource = busTK.GetAllTKThuThu().Where(p => p.MATK.ToString().Contains(txtTimKiem.Text)).ToList();
            }
            else if (radioButtonTEN.Checked)
            {
                gridThuThu.DataSource = busTK.GetAllTKThuThu().Where(p => p.TENDN.Contains(txtTimKiem.Text)).ToList();
            }
        }

        private void gridThuThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDiaChi.Text = gridThuThu.CurrentRow.Cells["DIACHI"].Value.ToString();
            txtEmail.Text = gridThuThu.CurrentRow.Cells["EMAIL"].Value.ToString();
            txtHoTen.Text = gridThuThu.CurrentRow.Cells["HOTEN"].Value.ToString();
            txtNgayDK.Text = gridThuThu.CurrentRow.Cells["NGAYDANGKY"].Value.ToString();
            txtSDT.Text = gridThuThu.CurrentRow.Cells["SDT"].Value.ToString();
            txtTenDN.Text = gridThuThu.CurrentRow.Cells["TENDN"].Value.ToString();
            txtMatKhau.Text = gridThuThu.CurrentRow.Cells["MATKHAU"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
    }
}

