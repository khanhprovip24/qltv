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
using System.Globalization;

namespace GUI
{
    public partial class FormTheLoaiSach : Form
    {
        
        public FormTheLoaiSach()
        {
            InitializeComponent();
            LoadData();
            LoadComboBoxData();
            cmbMaTL.DropDown += new EventHandler(cmbMaTL_DropDown);
            dataGridView1.CellDoubleClick += new DataGridViewCellEventHandler(dataGridView1_CellDoubleClick);
            dataGridView1.SelectionChanged += new EventHandler(dataGridView1_SelectionChanged);
            btnDelete.Enabled = false; // Disable delete button initially
        }

        private void LoadData()
        {
            dataGridView1.DataSource = BUSTheLoaiSach.Instance.GetAllTheLoai();
            dataGridView1.Columns["saches"].Visible = false; // Ẩn cột "saches"
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Mở rộng độ dài của các cột
        }

        private void LoadComboBoxData()
        {
            cmbMaTL.DisplayMember = "MATL";
            cmbMaTL.ValueMember = "MATL";
            cmbMaTL.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbMaTL.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUpdateMaTL.Text) || string.IsNullOrWhiteSpace(txtUpdateTenTL.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin vào cả 2 ô.");
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật không? Thao tác này không thể khôi phục.", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    THELOAI theLoai = new THELOAI
                    {
                        MATL = txtUpdateMaTL.Text,
                        TENTL = txtUpdateTenTL.Text
                    };

                    BUSTheLoaiSach.Instance.UpdateTheLoai(theLoai);
                    MessageBox.Show("Cập nhật thành công!");
                    LoadData();
                    txtUpdateMaTL.Clear();
                    txtUpdateTenTL.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật thất bại: " + ex.Message);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormThemTheLoai formAddTheLoai = new FormThemTheLoai();
            formAddTheLoai.FormClosed += (s, args) =>
            {
                LoadData();
                LoadComboBoxData();
            };
            formAddTheLoai.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Bạn có muốn xóa dòng này không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string maTL = dataGridView1.SelectedRows[0].Cells["MATL"].Value.ToString();
                    BUSTheLoaiSach.Instance.DeleteTheLoai(maTL);
                    LoadData();
                    LoadComboBoxData();
                    btnDelete.Enabled = false; // Disable delete button after deletion
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string maTL = cmbMaTL.Text.Trim();
            string tenTL = txtTenTL.Text.Trim();

            if (string.IsNullOrEmpty(maTL) && string.IsNullOrEmpty(tenTL))
            {
                MessageBox.Show("Vui lòng nhập mã thể loại hoặc tên thể loại để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dataGridView1.DataSource = BUSTheLoaiSach.Instance.SearchTheLoai(maTL, tenTL);
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBoxData();

            // Xóa nội dung trong các ô nhập liệu
            txtTenTL.Clear();
            txtUpdateMaTL.Clear();
            txtUpdateTenTL.Clear();

            // Đặt lại ComboBox về trạng thái không chọn
            cmbMaTL.SelectedIndex = -1;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát ra để về lại menu chính không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close(); // Đóng form hiện tại để quay lại menu chính
            }
        }



        private void cmbMaTL_DropDown(object sender, EventArgs e)
        {
            cmbMaTL.DataSource = BUSTheLoaiSach.Instance.GetAllTheLoai();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var result = MessageBox.Show("Bạn có muốn sửa không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Populate the update text boxes with the selected row data
                    txtUpdateMaTL.Text = dataGridView1.Rows[e.RowIndex].Cells["MATL"].Value.ToString();
                    txtUpdateTenTL.Text = dataGridView1.Rows[e.RowIndex].Cells["TENTL"].Value.ToString();
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Enable delete button if a row is selected
            btnDelete.Enabled = dataGridView1.SelectedRows.Count > 0;
        }

        private void FormTheLoaiSach_Load(object sender, EventArgs e)
        {

        }
    }
}
