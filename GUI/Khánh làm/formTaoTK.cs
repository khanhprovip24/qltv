using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
    public partial class formTaoTK : Form
    {
        BUSTaiKhoan busTK = new BUSTaiKhoan();
        public formTaoTK()
        {
            InitializeComponent();
            txtEmail.Validating += new CancelEventHandler(txtEmail_Validating);
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string email = txtEmail.Text;
            if (!IsValidEmail(email))
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProvider1.SetError(txtEmail, "Email không hợp lệ");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, null);
            }
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra các ô TextBox
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Email không được để trống");
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }

            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                errorProvider1.SetError(txtSDT, "Số điện thoại không được để trống");
            }
            else
            {
                errorProvider1.SetError(txtSDT, null);
            }

            if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text))
            {
                errorProvider1.SetError(txtTaiKhoan, "Tài khoản không được để trống");
            }
            else
            {
                errorProvider1.SetError(txtTaiKhoan, null);
            }

            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                errorProvider1.SetError(txtDiaChi, "Địa chỉ không được để trống");
            }
            else
            {
                errorProvider1.SetError(txtDiaChi, null);
            }

            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                errorProvider1.SetError(txtMatKhau, "Mật khẩu không được để trống");
            }
            else
            {
                errorProvider1.SetError(txtMatKhau, null);
            }

            if (string.IsNullOrWhiteSpace(txtNhapLai.Text))
            {
                errorProvider1.SetError(txtNhapLai, "Mật khẩu không được để trống");
            }
            else
            {
                errorProvider1.SetError(txtNhapLai, null);
            }

            if (txtMatKhau.Text != txtNhapLai.Text)
            {
                errorProvider1.SetError(txtNhapLai, "Mật khẩu không khớp");
            }
            else
            {
                var taiKhoan = new TAIKHOAN
                {
                    TENDN = txtTaiKhoan.Text,
                    MATKHAU = txtMatKhau.Text,
                    HOTEN = txtHoTen.Text,
                    DIACHI = txtDiaChi.Text,
                    SDT = txtSDT.Text,
                    EMAIL = txtEmail.Text,
                    MALOAITK = "TH001",
                    NGAYDANGKY = DateTime.Now,
                    TRANGTHAI = true

                };

                busTK.AddTaiKhoan(taiKhoan);
                MessageBox.Show("Tài khoản đã được tạo thành công!");
                this.Hide();
                errorProvider1.SetError(txtNhapLai, null);
            }

            
               
            
    }

        private void formTaoTK_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxMK_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = checkBoxMK.Checked ? '\0' : '*';
            txtNhapLai.PasswordChar = checkBoxMK.Checked ? '\0' : '*';
        }
    }
}
