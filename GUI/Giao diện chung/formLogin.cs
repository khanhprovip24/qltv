using BUS;
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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }
        private void resetTextboxs()
        {
            txtMatKhau.Clear();
            txtTaiKhoan.Clear();
            txtTaiKhoan.Focus();
        }
        private void checkBoxHienMK_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = checkBoxHienMK.Checked ? '\0' : '*';
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
           BUSDangNhap busDN=new BUSDangNhap();
            int result = busDN.checkLogin(txtTaiKhoan.Text, txtMatKhau.Text);
            if (result != -1)
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                formMain f = new formMain(result);
                f.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
                resetTextboxs();
            }
        }
        }
    }

