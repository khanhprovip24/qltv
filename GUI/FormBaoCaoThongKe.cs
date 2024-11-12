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
using DTO;
using ClosedXML.Excel;
using System.IO;

namespace GUI
{
    public partial class FormBaoCaoThongKe : Form
    {
        BUSPhieuMuon buspm = new BUSPhieuMuon();
        BUSDocGia busDG = new BUSDocGia();
        BusSach bs = new BusSach();
        public FormBaoCaoThongKe()
        {
            InitializeComponent();
            LoadComboBox();
        }

        private void LoadComboBox()
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle comboBox2 selection change if needed
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle comboBox1 selection change if needed
        }

        
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ExportPhieuMuonToExcel()
        {
            var phieuMuons = buspm.GetAllPhieuMuon();
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("PhieuMuons");
                worksheet.Cell(1, 1).Value = "MAPM";
                worksheet.Cell(1, 2).Value = "MADG";
                worksheet.Cell(1, 3).Value = "NGAYMUON";
                worksheet.Cell(1, 4).Value = "NGAYTRA";
                worksheet.Cell(1, 5).Value = "TINHTRANG";
                worksheet.Cell(1, 6).Value = "TONGSO_SACH";

                for (int i = 0; i < phieuMuons.Count; i++)
                {
                    worksheet.Cell(i + 2, 1).Value = phieuMuons[i].MAPM;
                    worksheet.Cell(i + 2, 2).Value = phieuMuons[i].MADG;
                    worksheet.Cell(i + 2, 3).Value = phieuMuons[i].NGAYMUON;
                    worksheet.Cell(i + 2, 4).Value = phieuMuons[i].NGAYTRA;
                    worksheet.Cell(i + 2, 5).Value = phieuMuons[i].TINHTRANG;
                    worksheet.Cell(i + 2, 6).Value = phieuMuons[i].TONGSO_SACH;
                }

                string filePath = @"D:\BTL-qltv\phieumuon.xlsx";
                workbook.SaveAs(filePath);
            }
            MessageBox.Show("Xuất dữ liệu Phiếu mượn thành công!");
        }

        public void ExportSachToExcel()
        {
            var sachs = bs.GetAllBooks();
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Sachs");
                worksheet.Cell(1, 1).Value = "MASACH";
                worksheet.Cell(1, 2).Value = "TENSACH";
                worksheet.Cell(1, 3).Value = "MOTA";
                worksheet.Cell(1, 4).Value = "MATL";
                worksheet.Cell(1, 5).Value = "MANXB";
                worksheet.Cell(1, 6).Value = "MATACGIA";
                worksheet.Cell(1, 7).Value = "SOLUONG";
                worksheet.Cell(1, 8).Value = "DONGIA";

                for (int i = 0; i < sachs.Count; i++)
                {
                    worksheet.Cell(i + 2, 1).Value = sachs[i].MASACH;
                    worksheet.Cell(i + 2, 2).Value = sachs[i].TENSACH;
                    worksheet.Cell(i + 2, 3).Value = sachs[i].MOTA;
                    worksheet.Cell(i + 2, 4).Value = sachs[i].MATL;
                    worksheet.Cell(i + 2, 5).Value = sachs[i].MANXB;
                    worksheet.Cell(i + 2, 6).Value = sachs[i].MATACGIA;
                    worksheet.Cell(i + 2, 7).Value = sachs[i].SOLUONG;
                    worksheet.Cell(i + 2, 8).Value = sachs[i].DONGIA;
                }

                string filePath = @"D:\BTL-qltv\sach.xlsx";
                workbook.SaveAs(filePath);
            }
            MessageBox.Show("Xuất dữ liệu Sách thành công!");
        }


        public void ExportDocGiaToExcel()
        {
            var docGias = busDG.GetAllDocGia();
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("DocGias");
                worksheet.Cell(1, 1).Value = "MADG";
                worksheet.Cell(1, 2).Value = "TENDG";
                worksheet.Cell(1, 3).Value = "EMAIL";
                worksheet.Cell(1, 4).Value = "SDT";
                worksheet.Cell(1, 5).Value = "GIOITINH";
                worksheet.Cell(1, 6).Value = "DIACHI";

                for (int i = 0; i < docGias.Count; i++)
                {
                    worksheet.Cell(i + 2, 1).Value = docGias[i].MADG;
                    worksheet.Cell(i + 2, 2).Value = docGias[i].TENDG;
                    worksheet.Cell(i + 2, 3).Value = docGias[i].EMAIL;
                    worksheet.Cell(i + 2, 4).Value = docGias[i].SDT;
                    worksheet.Cell(i + 2, 5).Value = docGias[i].GIOITINH;
                    worksheet.Cell(i + 2, 6).Value = docGias[i].DIACHI;
                }

                string filePath = @"D:\BTL-qltv\docgia.xlsx";
                workbook.SaveAs(filePath);
            }
            MessageBox.Show("Xuất dữ liệu Độc giả thành công!");
        }

        private void In_Click(object sender, EventArgs e)
        {
            string selectedValue = cbbTK.SelectedItem.ToString();

            switch (selectedValue)
            {
                case "Phieu muon":
                    ExportPhieuMuonToExcel();
                    break;
                case "Sach":
                    ExportSachToExcel();
                    break;
                case "Doc gia":
                    ExportDocGiaToExcel();
                    break;
                default:
                    MessageBox.Show("Vui lòng chọn nội dung hợp lệ.");
                    break;
            }
        }
    }
}
