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
    public partial class formTaoPhieu : Form
    {
        BUSPhieuMuon busPM = new BUSPhieuMuon();
        BUSDocGia busDG = new BUSDocGia();
        public formTaoPhieu()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void an()
        {

            txtMaPhieu.Enabled = false;
            cbbTenDG.Enabled = false;
            cbbMaDG.Enabled = false;
            cbbTT.Enabled = false;
            dateMuon.Enabled = false;
            dateTra.Enabled = false;
        }
        public void hien()
        {
            txtMaPhieu.Enabled = true;
            cbbTenDG.Enabled = true;
            cbbMaDG.Enabled = true;
            cbbTT.Enabled = true;
            dateMuon.Enabled = true;
            dateTra.Enabled = true;
        }

        private void themTenDG()
        {
            // Thêm cột mới để hiển thị tên độc giả
            

            // Lặp qua từng hàng và gán tên độc giả vào cột mới
            foreach (DataGridViewRow row in gridPhieu.Rows)
            {
                int maDG = (int)row.Cells["MADG"].Value;
                string tenDocGia = busDG.GetNameByID(maDG);
                row.Cells["TenDocGia"].Value = tenDocGia;
            }
        }
        private void formTaoPhieu_Load(object sender, EventArgs e)
        {
          
           
        
        gridPhieu.DataSource = busPM.GetAllPhieuMuon();
            gridPhieu.Columns["DOCGIA"].Visible = false;
            gridPhieu.Columns["CHITIETMUONs"].Visible = false;
            DataGridViewTextBoxColumn tenDocGiaColumn = new DataGridViewTextBoxColumn();
            tenDocGiaColumn.Name = "TenDocGia";
            tenDocGiaColumn.HeaderText = "Tên Độc Giả";
            gridPhieu.Columns.Add(tenDocGiaColumn);
            themTenDG();
            an();
        }


        private void gridPhieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            hien();
            if (gridPhieu.CurrentRow != null)
            {
                txtMaPhieu.Text = gridPhieu.CurrentRow.Cells["MAPM"]?.Value?.ToString() ?? string.Empty;
                cbbTenDG.Text = busDG.GetNameByID(int.Parse(gridPhieu.CurrentRow.Cells["MADG"]?.Value?.ToString() ?? "0"));
                cbbMaDG.Text = gridPhieu.CurrentRow.Cells["MADG"]?.Value?.ToString() ?? string.Empty;
                cbbTT.Text = gridPhieu.CurrentRow.Cells["TINHTRANG"]?.Value?.ToString() ?? string.Empty;
                dateMuon.Text = gridPhieu.CurrentRow.Cells["NGAYMUON"]?.Value?.ToString() ?? string.Empty;
                dateTra.Text = gridPhieu.CurrentRow.Cells["NGAYTRA"]?.Value?.ToString() ?? string.Empty;
                txtTSS.Text = gridPhieu.CurrentRow.Cells["TONGSO_SACH"]?.Value?.ToString() ?? string.Empty;
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
           formTaoPhieu2 f = new formTaoPhieu2();
            f.ShowDialog();
            gridPhieu.DataSource = busPM.GetAllPhieuMuon();
            themTenDG();
            gridPhieu.Refresh();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            PHIEUMUON pm = new PHIEUMUON
            {
                MAPM = int.Parse(txtMaPhieu.Text),
                MADG = int.Parse(cbbMaDG.Text),
                NGAYMUON = DateTime.Parse(dateMuon.Text),
                NGAYTRA = DateTime.Parse(dateTra.Text),
                TINHTRANG = cbbTT.Text,
                TONGSO_SACH = int.Parse(txtTSS.Text)

            };
            busPM.UpdatePhieuMuon(pm);
            busDG.updateDG(new DOCGIA
            {
                MADG = int.Parse(cbbMaDG.Text),
                TENDG = cbbTenDG.Text
            });
            gridPhieu.DataSource = busPM.GetAllPhieuMuon();
            themTenDG();
            gridPhieu.Refresh();
            an();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(gridPhieu.CurrentRow != null)
            {
                PHIEUMUON pm = gridPhieu.CurrentRow.DataBoundItem as PHIEUMUON;
                busPM.DeletePhieuMuon(pm);
                gridPhieu.DataSource = busPM.GetAllPhieuMuon();
                  MessageBox.Show("đã xóa thành công");
                gridPhieu.Refresh();
                an();

            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu mượn để xóa.");
            }
            themTenDG();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            PHIEUMUON pm = new PHIEUMUON
            {
                MADG = (int)gridPhieu.CurrentRow.Cells["MADG"].Value,
                NGAYMUON = DateTime.Parse(dateMuon.Text),
                NGAYTRA = DateTime.Parse(dateTra.Text),
                TINHTRANG = cbbTT.Text

            };
            btnLuu.Enabled = false;
            busPM.AddPhieuMuon(pm);
            gridPhieu.DataSource = busPM.GetAllPhieuMuon();
       
            gridPhieu.Refresh();
            themTenDG();
            an();
        }

        private void cbbMaDG_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbTenDG.Text = busDG.GetNameByID(int.Parse(cbbMaDG.Text));
        }

        private void gridPhieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int searchValue;
            if (radioButtonMaDG.Checked)
            {
                if (int.TryParse(txtTimKiem.Text, out searchValue))
                {
                    gridPhieu.DataSource = busPM.GetPhieuMuonByMaDocGia(searchValue);
                    themTenDG();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập một số hợp lệ.");
                    gridPhieu.DataSource = busPM.GetAllPhieuMuon();
                    themTenDG();
                }
            }
            else if (radioButtonMaPhieu.Checked)
            {
                if (int.TryParse(txtTimKiem.Text, out searchValue))
                {
                    gridPhieu.DataSource = busPM.GetPhieuMuonByMaPM(searchValue);
                    themTenDG();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập một số hợp lệ.");
                    gridPhieu.DataSource = busPM.GetAllPhieuMuon();
                    themTenDG();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một trong hai phương thức tìm kiếm.");
            }
        }

    }
}
