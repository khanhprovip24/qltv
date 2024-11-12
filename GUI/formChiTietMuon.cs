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
    public partial class formChiTietMuon : Form
    {
        BUSChiTietMuon busCTM = new BUSChiTietMuon();
        BusSach busSach = new BusSach();
        BUSPhieuMuon busPM = new BUSPhieuMuon();
        BUSDocGia busDG = new BUSDocGia();
        public formChiTietMuon()
        {
            InitializeComponent();
        }

        private void formChiTietMuon_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBoxData();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void LoadData()
        {
            griChiTiet.DataSource = busCTM.GetListCTM();
            griChiTiet.Columns["PHIEUMUON"].Visible = false;
            griChiTiet.Columns["SACH"].Visible = false;

            // Thêm các cột mới
            AddColumns();
            // Gán dữ liệu cho các cột mới
            PopulateAdditionalColumns();
        }
        private void LoadComboBoxData()
        {
            cbbMaPM.DataSource = busPM.GetAllMaPM();
            cbbMaPM.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbMaPM.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void AddColumns()
        {
            if (!griChiTiet.Columns.Contains("TenDocGia"))
            {
                griChiTiet.Columns.Add("TenDocGia", "Tên Độc Giả");
            }
            if (!griChiTiet.Columns.Contains("MaTheLoai"))
            {
                griChiTiet.Columns.Add("MaTheLoai", "Mã Thể Loại");
            }
            if (!griChiTiet.Columns.Contains("TenTheLoai"))
            {
                griChiTiet.Columns.Add("TenTheLoai", "Tên Thể Loại");
            }
            if (!griChiTiet.Columns.Contains("TenSach"))
            {
                griChiTiet.Columns.Add("TenSach", "Tên Sách");
            }
            if (!griChiTiet.Columns.Contains("NgayMuon"))
            {
                griChiTiet.Columns.Add("NgayMuon", "Ngày Mượn");
            }
            if (!griChiTiet.Columns.Contains("NgayTra"))
            {
                griChiTiet.Columns.Add("NgayTra", "Ngày Trả");
            }
            if (!griChiTiet.Columns.Contains("TinhTrang"))
            {
                griChiTiet.Columns.Add("TinhTrang", "Tình Trạng");
            }
        }

        private void PopulateAdditionalColumns()
        {
            // Đảm bảo các cột đã được thêm vào
            AddColumns();

            foreach (DataGridViewRow row in griChiTiet.Rows)
            {
                try
                {
                    if (row.Cells["MASACH"].Value != null && row.Cells["MAPM"].Value != null)
                    {
                        int maSach = (int)row.Cells["MASACH"].Value;
                        int maPM = (int)row.Cells["MAPM"].Value;

                        // Lấy tên sách
                        string tenSach = busSach.GetNameByID(maSach);
                        if (tenSach != null)
                        {
                            row.Cells["TenSach"].Value = tenSach;
                        }
                        else
                        {
                            throw new Exception("Tên sách không tồn tại.");
                        }

                        // Lấy thông tin phiếu mượn
                        PHIEUMUON phieuMuon = busPM.Get1PhieuMuonByMaPM(maPM);
                        if (phieuMuon != null)
                        {
                            row.Cells["NgayMuon"].Value = phieuMuon.NGAYMUON;
                            row.Cells["NgayTra"].Value = phieuMuon.NGAYTRA;
                            row.Cells["TinhTrang"].Value = phieuMuon.TINHTRANG;

                            // Lấy tên độc giả
                            if (phieuMuon.MADG.HasValue)
                            {
                                string tenDocGia = busDG.GetNameByID(phieuMuon.MADG.Value);
                                if (tenDocGia != null)
                                {
                                    row.Cells["TenDocGia"].Value = tenDocGia;
                                }
                                else
                                {
                                    throw new Exception("Tên độc giả không tồn tại.");
                                }
                            }
                        }
                        else
                        {
                            throw new Exception("Thông tin phiếu mượn không tồn tại.");
                        }

                        // Lấy thông tin thể loại
                        SACH sach = busSach.GetAllBooks().FirstOrDefault(s => s.MASACH == maSach);
                        if (sach != null)
                        {
                            string tenTheLoai = sach.THELOAI?.TENTL;
                            string maTheLoai = sach.THELOAI?.MATL;
                            if (tenTheLoai != null)
                            {
                                row.Cells["TenTheLoai"].Value = tenTheLoai;
                            }
                            else
                            {
                                throw new Exception("Tên thể loại không tồn tại.");
                            }
                            if (maTheLoai != null)
                            {
                                row.Cells["MaTheLoai"].Value = maTheLoai;
                            }
                            else
                            {
                                throw new Exception("Mã thể loại không tồn tại.");
                            }
                        }
                        else
                        {
                            throw new Exception("Thông tin sách không tồn tại.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi ở dòng {row.Index + 1}: {ex.Message}", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            formTaoCTM f = new formTaoCTM();
            f.ShowDialog();
            griChiTiet.DataSource = busCTM.GetListCTM();
            PopulateAdditionalColumns();
            griChiTiet.Refresh();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaPM.ReadOnly == false)
            {
                MessageBox.Show("Không được phép sửa mã phiếu mượn ở đây.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(txtSoLuong.Text, out int soLuong) && soLuong >= 0)
            {
                int maSachCu = int.Parse(griChiTiet.CurrentRow.Cells["MASACH"].Value.ToString());
                int maSachMoi = int.Parse(txtMaSach.Text);

                if (maSachCu != maSachMoi)
                {
                    var result = MessageBox.Show($"Bạn có muốn thay đổi cuốn sách cũ (mã: {maSachCu}) thành cuốn sách mới (mã: {maSachMoi}) không?", "Xác nhận thay đổi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        var sachMoi = busSach.GetAllBooks().FirstOrDefault(s => s.MASACH == maSachMoi);
                        if (sachMoi == null)
                        {
                            MessageBox.Show($"Cuốn sách mới có mã {maSachMoi} không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Cập nhật thông tin sách mới lên các TextBox
                        txtMaTheLoai.Text = sachMoi.THELOAI.MATL;
                        txtTenSach.Text = sachMoi.TENSACH;
                        txtTenTheLoai.Text = sachMoi.THELOAI.TENTL;

                        var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn thay đổi không?", "Xác nhận thay đổi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (confirmResult != DialogResult.Yes)
                        {
                            return;
                        }
                    }
                    else
                    {
                        return;
                    }
                }

                if (!IsValidQuantity(maSachMoi, soLuong, out string errorMessage))
                {
                    MessageBox.Show(errorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                CHITIETMUON currentCTM = new CHITIETMUON()
                {
                    MAPM = int.Parse(txtMaPM.Text),
                    MASACH = maSachCu,
                    SOLUONG = int.Parse(griChiTiet.CurrentRow.Cells["SOLUONG"].Value.ToString())
                };

                CHITIETMUON newCTM = new CHITIETMUON()
                {
                    MAPM = int.Parse(txtMaPM.Text),
                    MASACH = maSachMoi,
                    SOLUONG = soLuong
                };

                busCTM.EditCTM_2(currentCTM, newCTM);

                PHIEUMUON phieuMuon = busPM.Get1PhieuMuonByMaPM(newCTM.MAPM);
                if (phieuMuon != null)
                {
                    phieuMuon.NGAYMUON = dtpNgayMuon.Value;
                    phieuMuon.NGAYTRA = dtpNgayTra.Value;
                    phieuMuon.TINHTRANG = txtTinhTrang.Text;
                    busPM.UpdatePhieuMuon(phieuMuon);
                }

                // Refresh DataGridView
                griChiTiet.DataSource = busCTM.GetListCTM();
                PopulateAdditionalColumns();
                griChiTiet.Refresh();

                MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Số lượng phải là một số nguyên dương.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnThoat.Enabled = true;
            btnTim.Enabled = true;
            btnSua.Enabled = false;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn xóa chi tiết này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                busCTM.DeleteCTM(int.Parse(txtMaPM.Text), int.Parse(txtMaSach.Text));
                griChiTiet.DataSource = busCTM.GetListCTM();
                PopulateAdditionalColumns();
                griChiTiet.Refresh();
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void griChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.griChiTiet.Rows[e.RowIndex];
                txtMaPM.Text = row.Cells["MAPM"].Value.ToString();
                txtMaSach.Text = row.Cells["MASACH"].Value.ToString();
                txtSoLuong.Text = row.Cells["SOLUONG"].Value.ToString();
                txtTenSach.Text = busSach.GetNameByID(int.Parse(txtMaSach.Text));
                txtTenDocGia.Text = row.Cells["TenDocGia"].Value.ToString();
                dtpNgayMuon.Value = Convert.ToDateTime(row.Cells["NgayMuon"].Value);
                dtpNgayTra.Value = Convert.ToDateTime(row.Cells["NgayTra"].Value);
                txtTinhTrang.Text = row.Cells["TinhTrang"].Value.ToString();
                txtTenTheLoai.Text = row.Cells["TenTheLoai"].Value.ToString();
                txtMaTheLoai.Text = row.Cells["MaTheLoai"].Value.ToString();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int maPM;
            if (int.TryParse(cbbMaPM.Text, out maPM))
            {
                var result = busCTM.GetListCTM().Where(x => x.MAPM == maPM).ToList();
                if (result.Any())
                {
                    griChiTiet.DataSource = result;
                    PopulateAdditionalColumns();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phiếu mượn với mã này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã phiếu mượn hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Reload data
            LoadData();
            LoadComboBoxData();

            // Clear input fields
            txtMaPM.Clear();
            txtMaSach.Clear();
            txtSoLuong.Clear();
            txtTenSach.Clear();
            txtTenDocGia.Clear();
            dtpNgayMuon.Value = DateTime.Now;
            dtpNgayTra.Value = DateTime.Now;
            txtTinhTrang.Clear();
            txtMaTheLoai.Clear();
            txtTenTheLoai.Clear();

            // Disable buttons
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void griChiTiet_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn sửa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow row = griChiTiet.Rows[e.RowIndex];
                    txtMaPM.Text = row.Cells["MAPM"].Value.ToString();
                    txtMaSach.Text = row.Cells["MASACH"].Value.ToString();
                    txtSoLuong.Text = row.Cells["SOLUONG"].Value.ToString();
                    txtTenSach.Text = busSach.GetNameByID(int.Parse(txtMaSach.Text));
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;

                    // Hiển thị thêm thông tin chi tiết
                    int maPM = int.Parse(txtMaPM.Text);
                    PHIEUMUON phieuMuon = busPM.Get1PhieuMuonByMaPM(maPM);
                    if (phieuMuon != null)
                    {
                        txtTenDocGia.Text = busDG.GetNameByID(phieuMuon.MADG.Value);
                        dtpNgayMuon.Value = phieuMuon.NGAYMUON ?? DateTime.Now; // Use DateTime.Now as default if NGAYMUON is null
                        dtpNgayTra.Value = phieuMuon.NGAYTRA ?? DateTime.Now; // Use DateTime.Now as default if NGAYTRA is null
                        txtTinhTrang.Text = phieuMuon.TINHTRANG;
                    }

                    int maSach = int.Parse(txtMaSach.Text);
                    SACH sach = busSach.GetAllBooks().FirstOrDefault(s => s.MASACH == maSach);
                    if (sach != null)
                    {
                        txtMaTheLoai.Text = sach.THELOAI.MATL;
                        txtTenTheLoai.Text = sach.THELOAI.TENTL;
                    }
                    // Vô hiệu hóa các nút khác
                    btnThem.Enabled = false;
                    btnXoa.Enabled = false;
                    btnThoat.Enabled = false;
                    btnTim.Enabled = false;

                    // Kích hoạt nút sửa
                    btnSua.Enabled = true;
                }
            }
        }
       

        //kiểm tra
        private bool IsValidBookInfo(string maTheLoai, string tenSach, int soLuong, string tenTheLoai, out string errorMessage)
        {
            errorMessage = string.Empty;
            var sach = busSach.GetAllBooks().FirstOrDefault(s => s.THELOAI.MATL == maTheLoai && s.TENSACH == tenSach && s.SOLUONG == soLuong && s.THELOAI.TENTL == tenTheLoai);

            if (sach == null)
            {
                if (!busSach.GetAllBooks().Any(s => s.THELOAI.MATL == maTheLoai))
                {
                    errorMessage = "Mã thể loại không tồn tại.";
                }
                else if (!busSach.GetAllBooks().Any(s => s.TENSACH == tenSach))
                {
                    errorMessage = "Tên sách không tồn tại.";
                }
                else if (!busSach.GetAllBooks().Any(s => s.SOLUONG == soLuong))
                {
                    errorMessage = "Số lượng sách không hợp lệ.";
                }
                else if (!busSach.GetAllBooks().Any(s => s.THELOAI.TENTL == tenTheLoai))
                {
                    errorMessage = "Tên thể loại không tồn tại.";
                }
                else
                {
                    errorMessage = "Thông tin sách không hợp lệ.";
                }
                return false;
            }
            return true;
        }

        private bool IsValidQuantity(int maSach, int soLuong, out string errorMessage)
        {
            errorMessage = string.Empty;
            int soLuongHienCo = busSach.GetSoLuongByID(maSach);

            if (soLuong > soLuongHienCo)
            {
                errorMessage = $"Số lượng sách không đủ. Số lượng hiện có: {soLuongHienCo}.";
                return false;
            }

            return true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        //private void cbbMaPM_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cbbMaPM.SelectedIndex != -1)
        //    {
        //        griChiTiet.DataSource = busCTM.GetListCTM().Where(x => x.MAPM == int.Parse(cbbMaPM.Text)).ToList();
        //        PopulateAdditionalColumns();
        //    }
        //}


    }
}

