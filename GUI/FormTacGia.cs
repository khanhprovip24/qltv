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
    public partial class FormTacGia : Form
    {
        private BUSTacGia bll = new BUSTacGia();

        private bool isAddingNew = false; // Cờ để kiểm tra trạng thái thêm mới
        public FormTacGia()
        {
            InitializeComponent();
        }

        private void FormTacGia_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // Tải dữ liệu tác giả vào DataGridView
        private void LoadData()
        {
            txtMaTacGia.ReadOnly = true;
            txtTenTacGia.ReadOnly = true;
            var tacGias = bll.LayDanhSachTacGia();
            gridViewTacGia.DataSource = tacGias;
            gridViewTacGia.Columns["MaTacGia"].HeaderText = "Mã Tác Giả";
            gridViewTacGia.Columns["TenTacGia"].HeaderText = "Tên Tác Giả";
        }

        private void btnThemTacGia_Click(object sender, EventArgs e)
        {
            txtMaTacGia.Text = string.Empty;
            txtTenTacGia.Text = string.Empty;
            txtMaTacGia.ReadOnly = true;// Khóa mã tác giả khi thêm mới
            txtTenTacGia.ReadOnly = false;
            isAddingNew = true;  // Đặt cờ trạng thái thêm mới
        
        }

        private void btnSuaTacGia_Click(object sender, EventArgs e)
        {
            txtMaTacGia.ReadOnly = true;  // Khóa mã tác giả khi chỉnh sửa
            txtTenTacGia.ReadOnly = false;
            isAddingNew = false;  // Đặt lại cờ trạng thái (đang ở chế độ chỉnh sửa)
        }

        private void btnXoaTacGia_Click(object sender, EventArgs e)
        {
            int maTacGia = Convert.ToInt32(txtMaTacGia.Text);
            bll.XoaTacGia(maTacGia);
            LoadData();  // Tải lại dữ liệu sau khi xóa
        }

        private void gridViewTacGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaTacGia.Text = gridViewTacGia.CurrentRow.Cells["MaTacGia"].Value.ToString();
            txtTenTacGia.Text = gridViewTacGia.CurrentRow.Cells["TenTacGia"].Value.ToString();
            txtMaTacGia.ReadOnly = true; // Khóa mã tác giả khi chọn từ DataGridView
            txtTenTacGia.ReadOnly = true;
            isAddingNew = false;  // Đặt lại cờ trạng thái
        }

        private void btnTimKiemTacGia_Click(object sender, EventArgs e)
        {
            string searchTerm = cbTimKiemTacGia.Text;
            var tacGias = bll.TimKiemTacGia(searchTerm);
            gridViewTacGia.DataSource = tacGias;

            if (!cbTimKiemTacGia.Items.Contains(searchTerm))
            {
                cbTimKiemTacGia.Items.Add(searchTerm);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuuTacGia_Click(object sender, EventArgs e)
        {
            if (isAddingNew) // Nếu đang ở chế độ thêm mới
            {
                var tacGia = new TACGIA
                {
                    TENTACGIA = txtTenTacGia.Text
                };
                bll.ThemTacGia(tacGia);
                isAddingNew = false; // Đặt lại cờ trạng thái
                LoadData();  // Tải lại dữ liệu sau khi thêm
            }
            else // Nếu ở chế độ chỉnh sửa
            {
                var tacGia = new TACGIA
                {
                    MATACGIA = Convert.ToInt32(txtMaTacGia.Text),
                    TENTACGIA = txtTenTacGia.Text
                };
                bll.SuaTacGia(tacGia);
                LoadData();  // Tải lại dữ liệu sau khi sửa
            }
        }
    }
}
