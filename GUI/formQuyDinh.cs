using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace GUI
{
    public partial class formQuyDinh : Form
    {
        string temp;
        public formQuyDinh(string temp)
        {
            InitializeComponent();
                this.temp = temp;
        }

        private void formQuyDinh_Load(object sender, EventArgs e)
        {
            if(temp == "AD001  ")
            {
                richTextBoxQD.ReadOnly = false;
                btnLuuQD.Visible = true;
            }
            else
            {
                richTextBoxQD.ReadOnly = true;
                btnLuuQD.Visible = false;
            }
            // Load nội dung từ tệp khi form được tải
            string filePath = "quydinh.txt";
            if (File.Exists(filePath))
            {
                richTextBoxQD.Text = File.ReadAllText(filePath);
            }
        }

        private void btnLuuQD_Click(object sender, EventArgs e)
        {
            try
            {
                // Đường dẫn tệp nơi bạn muốn lưu nội dung
                string filePath = "quydinh.txt";

                // Lưu nội dung của txtQuyDinh vào tệp
                File.WriteAllText(filePath, richTextBoxQD.Text);

                MessageBox.Show("Lưu quy định thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi lưu quy định: " + ex.Message);
            }
        }
    }
}
