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
        BUSPhieuMuon buspm = new BUSPhieuMuon();
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
            // Kiểm tra các trường thông tin không được để trống
            if (string.IsNullOrWhiteSpace(cbbMaPM.Text) ||
                string.IsNullOrWhiteSpace(cbbMaSach.Text) ||
                string.IsNullOrWhiteSpace(txtSoLuong.Text) ||
                string.IsNullOrWhiteSpace(txtSach.Text) ||
                string.IsNullOrWhiteSpace(cbbMaTheLoai.Text) ||
                string.IsNullOrWhiteSpace(txtDocGia.Text)) // Loại bỏ kiểm tra txtTenTheLoai
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            // Kiểm tra số lượng phải là số nguyên dương hợp lệ
            if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải là một số nguyên dương.");
                return;
            }

            // Kiểm tra số lượng sách có đủ không
            if (bs.GetSoLuongByID(int.Parse(cbbMaSach.Text)) < soLuong)
            {
                MessageBox.Show("Số lượng sách không đủ");
                return;
            }

            // Tạo đối tượng CHITIETMUON mới
            CHITIETMUON ctm = new CHITIETMUON()
            {
                MAPM = int.Parse(cbbMaPM.Text),
                MASACH = int.Parse(cbbMaSach.Text),
                SOLUONG = soLuong
            };

            // Cập nhật số lượng sách
            SACH sach = bs.GetAllBooks().FirstOrDefault(s => s.MASACH == int.Parse(cbbMaSach.Text));
            if (sach != null)
            {
                sach.SOLUONG -= soLuong;
                bs.UpdateBook(sach);
            }

            // Thêm CHITIETMUON mới vào cơ sở dữ liệu
            busctm.AddCTM(ctm);
            this.Close();
        }

        private void formTaoCTM_Load(object sender, EventArgs e)
        {
            // Lấy danh sách mã phiếu mượn có trạng thái "Đang mượn"
            List<int> maPMList = BUSPhieuMuon.Instance.GetMaPMByStatus("Đang mượn");
            if (maPMList != null && maPMList.Count > 0)
            {
                cbbMaPM.DataSource = maPMList;
            }
            else
            {
                MessageBox.Show("Không có phiếu mượn nào đang mượn.");
            }

            // Debug: In ra danh sách mã phiếu mượn
            foreach (var maPM in maPMList)
            {
                Console.WriteLine("Mã phiếu mượn: " + maPM);
            }

            // Lấy danh sách mã sách
            List<int> maSachList = bs.GetAllBookIds();
            if (maSachList != null && maSachList.Count > 0)
            {
                cbbMaSach.DataSource = maSachList;
            }
            else
            {
                MessageBox.Show("Không có sách nào.");
            }

            // Lấy danh sách mã thể loại
            List<string> maTheLoaiList = bs.GetAllCategoryIds();
            if (maTheLoaiList != null && maTheLoaiList.Count > 0)
            {
                cbbMaTheLoai.DataSource = maTheLoaiList;
            }
            else
            {
                MessageBox.Show("Không có thể loại nào.");
            }
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbMaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            int masach = int.Parse(cbbMaSach.Text);
            txtSach.Text = bs.GetNameByID(masach);
            // Load mã thể loại và tên thể loại tương ứng với mã sách
            SACH sach = bs.GetAllBooks().FirstOrDefault(s => s.MASACH == masach);
            if (sach != null)
            {
                // Kiểm tra và tách phần số từ mã thể loại
                string matlString = sach.MATL;
                if (matlString.StartsWith("TL") && int.TryParse(matlString.Substring(2), out int matl))
                {
                    cbbMaTheLoai.Text = matlString;
                    // Loại bỏ cập nhật txtTenTheLoai
                }
                else
                {
                    MessageBox.Show("Mã thể loại không hợp lệ.");
                }
            }
        }

        private void cbbMaTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string matlString = cbbMaTheLoai.Text;
            if (matlString.StartsWith("TL") && int.TryParse(matlString.Substring(2), out int matl))
            {
                // Loại bỏ cập nhật txtTenTheLoai
            }
            else
            {
                MessageBox.Show("Mã thể loại không hợp lệ.");
            }
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
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có muốn quay về không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra kết quả của hộp thoại xác nhận
            if (result == DialogResult.Yes)
            {
                // Đóng form nếu người dùng chọn "Yes"
                this.Close();
            }
            // Nếu người dùng chọn "No", không làm gì cả và form vẫn mở
        }

        private void cbbMaPM_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maDG = buspm.GetMaDGByMaPhieu(int.Parse(cbbMaPM.Text));
            txtDocGia.Text = busDG.GetNameByID(maDG);
        }

        private void dtpNgayMuon_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
