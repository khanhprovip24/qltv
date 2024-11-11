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
    public partial class FormThemSach : Form
    {
        public FormThemSach()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn thêm không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (int.TryParse(cbbMaNXB.Text, out int maNXB) &&
                        int.TryParse(cbbMaTacGia.Text, out int maTacGia) &&
                        int.TryParse(txtSoLuong.Text, out int soLuong) &&
                        double.TryParse(txtDonGia.Text, out double donGia) &&
                        int.TryParse(txtMaSach.Text, out int maSach))
                    {
                        // Kiểm tra xem mã sách đã tồn tại hay chưa
                        var allBookIds = BusSach.Instance.GetAllBookIds();
                        if (allBookIds.Contains(maSach))
                        {
                            MessageBox.Show($"Mã sách {maSach} đã tồn tại. Vui lòng nhập mã sách khác.");
                            return;
                        }

                        SACH book = new SACH
                        {
                            MASACH = maSach,
                            TENSACH = txtTenSach.Text,
                            MOTA = txtMoTa.Text,
                            MATL = cbbMaTL.Text,
                            MANXB = maNXB,
                            MATACGIA = maTacGia,
                            SOLUONG = soLuong,
                            DONGIA = donGia
                        };
                        BusSach.Instance.AddBook(book);
                        MessageBox.Show("Thêm sách thành công!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập đúng định dạng cho các trường số.");
                    }
                }
                else
                {
                    // Quay về form addbook
                    this.Show();
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "Lỗi: " + ex.Message;
                Exception innerEx = ex.InnerException;
                while (innerEx != null)
                {
                    errorMessage += "\nChi tiết: " + innerEx.Message;
                    innerEx = innerEx.InnerException;
                }
                MessageBox.Show(errorMessage);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                // Quay về form addbook
                this.Show();
            }
        }

        private void FormAddBook_Load(object sender, EventArgs e)
        {
            cbbMaTL.DataSource = BusSach.Instance.GetAllCategoryIds();
            cbbMaNXB.DataSource = BusSach.Instance.GetAllPublisherIds();
            cbbMaTacGia.DataSource = BusSach.Instance.GetAllAuthorIds();

            // Đặt SelectedIndex của các combobox là -1
            cbbMaTL.SelectedIndex = -1;
            cbbMaNXB.SelectedIndex = -1;
            cbbMaTacGia.SelectedIndex = -1;

            // Tự sinh mã sách mới
            var allBookIds = BusSach.Instance.GetAllBookIds();
            if (allBookIds != null && allBookIds.Count > 0)
            {
                int maxId = int.MinValue;
                foreach (var id in allBookIds)
                {
                    if (id > maxId)
                    {
                        maxId = id;
                    }
                }
                string newBookId = (maxId + 1).ToString();
                txtMaSach.Text = newBookId;
            }
            else
            {
                txtMaSach.Text = "1"; // Nếu không có mã sách nào, bắt đầu từ 1
            }
        }
    }
}
