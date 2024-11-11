using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class FormThemTheLoai : Form
    {
        public FormThemTheLoai()
        {
            InitializeComponent();
            LoadMaTL();
        }

        private void LoadMaTL()
        {
            var allTheLoai = BUSTheLoaiSach.Instance.GetAllTheLoai();
            if (allTheLoai.Count > 0)
            {
                var lastMaTL = allTheLoai[allTheLoai.Count - 1].MATL;
                if (lastMaTL.StartsWith("TL") && int.TryParse(lastMaTL.Substring(2), out int lastNumber))
                {
                    var newNumber = lastNumber + 1;
                    var newMaTL = "TL" + newNumber.ToString("D3"); // Đảm bảo định dạng TLxxx với xxx là số có 3 chữ số
                    txtMaTL.Text = newMaTL;
                }
                else
                {
                    MessageBox.Show("Mã thể loại cuối cùng không hợp lệ. Vui lòng kiểm tra lại dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaTL.Text = "TL00X"; // Đặt giá trị mặc định nếu không thể chuyển đổi
                }
            }
            else
            {
                txtMaTL.Text = "TL00X";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaTL.Text) || string.IsNullOrWhiteSpace(txtTenTL.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bạn có muốn lưu thông tin này không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                THELOAI theLoai = new THELOAI
                {
                    MATL = txtMaTL.Text,
                    TENTL = txtTenTL.Text
                };

                BUSTheLoaiSach.Instance.AddTheLoai(theLoai);
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
