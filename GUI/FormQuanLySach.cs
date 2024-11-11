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
using BUS;

namespace GUI
{
    public partial class FormQuanLySach : Form
    {
        private string originalMaTL;

        public FormQuanLySach()
        {
            InitializeComponent();
            LoadData();
            btnSua.Enabled = false; // Disable the edit button initially
            btnXoa.Enabled = false; // Disable the delete button initially
            dgvSach.CellDoubleClick += dgvSach_CellDoubleClick; // Add the double-click event handler
            dgvSach.SelectionChanged += dgvSach_SelectionChanged; // Add the selection changed event handler
            cbbMaTL.TextChanged += cbbMaTL_TextChanged; // Add the TextChanged event handler
        }

        private void LoadData()
        {
            var books = BusSach.Instance.GetAllBooks();
            var bookList = books.Select(b => new
            {
                b.MASACH,
                b.TENSACH,
                b.MOTA,
                b.MATL,
                b.MANXB,
                b.MATACGIA,
                b.SOLUONG,
                b.DONGIA
            }).ToList();
            dgvSach.DataSource = bookList;
            ResetInputFields();
        }
        private void LoadComboBoxData()
        {
            cbbMaSach.DataSource = BusSach.Instance.GetAllBookIds();
            cbbMaTL.DataSource = BusSach.Instance.GetAllCategoryIds();
            cbbMaNXB.DataSource = BusSach.Instance.GetAllPublisherIds();
            cbbMaTacGia.DataSource = BusSach.Instance.GetAllAuthorIds();
        }

        private void ResetInputFields()
        {
            cbbMaSach.SelectedIndex = -1;
            txtTenSach.Clear();
            txtMoTa.Clear();
            cbbMaTL.SelectedIndex = -1;
            cbbMaNXB.SelectedIndex = -1;
            cbbMaTacGia.SelectedIndex = -1;
            txtSoLuong.Clear();
            txtDonGia.Clear();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            originalMaTL = string.Empty;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemSach formAddBook = new FormThemSach();
            formAddBook.FormClosed += (s, args) => LoadData(); // Reload data when the form is closed
            formAddBook.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin sách này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SACH book = new SACH
                    {
                        MASACH = int.Parse(cbbMaSach.Text),
                        TENSACH = txtTenSach.Text,
                        MOTA = txtMoTa.Text,
                        MATL = cbbMaTL.Text,
                        MANXB = int.Parse(cbbMaNXB.Text),
                        MATACGIA = int.Parse(cbbMaTacGia.Text),
                        SOLUONG = int.Parse(txtSoLuong.Text),
                        DONGIA = double.Parse(txtDonGia.Text)
                    };
                    BusSach.Instance.UpdateBook(book);
                    LoadData();
                    MessageBox.Show("Cập nhật sách thành công!");
                    ResetInputFields(); // Gọi hàm ResetInputFields() sau khi cập nhật thành công
                    // Cho phép truy cập lại combobox mã thể loại
                    cbbMaTL.Enabled = true;

                    // Kích hoạt lại các nút khác
                    btnThem.Enabled = true;
                    btnCapNhat.Enabled = true;
                    btnTimKiem.Enabled = true;
                    btnThoat.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSach.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Bạn có muốn xóa sách này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int maSach = int.Parse(dgvSach.SelectedRows[0].Cells["MASACH"].Value.ToString());
                        BusSach.Instance.DeleteBook(maSach);
                        LoadData();
                        MessageBox.Show("Xóa sách thành công!");
                        ResetInputFields(); // Gọi hàm ResetInputFields() sau khi xóa thành công

                        // Kích hoạt lại các nút khác
                        btnThem.Enabled = true;
                        btnCapNhat.Enabled = true;
                        btnTimKiem.Enabled = true;
                        btnThoat.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
                else
                {
                    btnXoa.Enabled = false; // Disable delete button if user cancels deletion
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBoxData();
            ResetInputFields();
            cbbMaTL.Enabled = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbbMaTL.Text))
            {
                MessageBox.Show("Vui lòng chọn mã thể loại để tìm kiếm.");
                return;
            }

            string maSach = cbbMaSach.Text;
            string tenSach = txtTenSach.Text;
            string maTL = cbbMaTL.Text;
            string maNXB = cbbMaNXB.Text;
            string maTacGia = cbbMaTacGia.Text;

            var books = BusSach.Instance.SearchBooks(maSach, tenSach, maTL, maNXB, maTacGia);
            dgvSach.DataSource = books;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close(); // Close the current form
                              // Optionally, you can add code here to navigate back to the main form if needed
            }
        }

        private void dgvSach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (MessageBox.Show("Bạn có muốn sửa thông tin sách này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataGridViewRow row = dgvSach.Rows[e.RowIndex];
                    cbbMaSach.Text = row.Cells["MASACH"].Value.ToString();
                    txtTenSach.Text = row.Cells["TENSACH"].Value.ToString();
                    txtMoTa.Text = row.Cells["MOTA"].Value.ToString();
                    cbbMaTL.Text = row.Cells["MATL"].Value.ToString();
                    cbbMaNXB.Text = row.Cells["MANXB"].Value.ToString();
                    cbbMaTacGia.Text = row.Cells["MATACGIA"].Value.ToString();
                    txtSoLuong.Text = row.Cells["SOLUONG"].Value.ToString();
                    txtDonGia.Text = row.Cells["DONGIA"].Value.ToString();
                    btnSua.Enabled = true;
                    // Lưu giá trị ban đầu của Mã Thể Loại
                    originalMaTL = cbbMaTL.Text;
                    // Ẩn combobox mã thể loại
                    cbbMaTL.Enabled = false;

                    // Vô hiệu hóa các nút khác
                    btnThem.Enabled = false;
                    btnCapNhat.Enabled = false;
                    btnTimKiem.Enabled = false;
                    btnThoat.Enabled = false;
                }
            }
        }

        private void dgvSach_SelectionChanged(object sender, EventArgs e)
        {
            // Enable delete button if a row is selected
            btnXoa.Enabled = dgvSach.SelectedRows.Count > 0;
        }

        private void cbbMaTL_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(originalMaTL) && cbbMaTL.Text != originalMaTL)
            {
                MessageBox.Show("Bạn không được sửa mã thể loại ở đây. Vui lòng nhập lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbMaTL.Text = originalMaTL;
                cbbMaTL.Focus();
            }
        }

        private void cbbMaSach_DropDown(object sender, EventArgs e)
        {
            cbbMaSach.DataSource = BusSach.Instance.GetAllBookIds();
        }

        private void cbbMaTL_DropDown(object sender, EventArgs e)
        {
            cbbMaTL.DataSource = BusSach.Instance.GetAllCategoryIds();
        }

        private void cbbMaNXB_DropDown(object sender, EventArgs e)
        {
            cbbMaNXB.DataSource = BusSach.Instance.GetAllPublisherIds();
        }

        private void cbbMaTacGia_DropDown(object sender, EventArgs e)
        {
            cbbMaTacGia.DataSource = BusSach.Instance.GetAllAuthorIds();
        }
    }
}
