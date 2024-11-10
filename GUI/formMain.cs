using BUS;
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

    public partial class formMain : Form

    {
        private int userId;
        
     BUSTaiKhoan busTk = new BUSTaiKhoan();
        public formMain(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          string temp = busTk.GetLoaiTKById(userId);
            string hoten = busTk.GetNameById(userId);
            if (temp == "AD001  ")
            {
                labelChaoMung.Text = "Chào mừng admin " + hoten;

            }
            else
            {
                labelChaoMung.Text = "Chào mừng thủ thư " + hoten;
                tạoTKThủThưToolStripMenuItem.Visible = false;
                qLyThủToolStripMenuItem.Visible = false;
                
            }
        }
        

        private void gridTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            formLogin f = new formLogin();
            f.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void labelChaoMung_Click(object sender, EventArgs e)
        {

        }

        private void tìmSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quyĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
            
        {
            string temp = busTk.GetLoaiTKById(userId);
            formQuyDinh f = new formQuyDinh(temp);  
            f.Show();
            
        }

        private void thayĐổiQuyĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
           string temp= busTk.GetLoaiTKById(userId);
            formQuyDinh f = new formQuyDinh(temp);
            f.Show();
            
        }

        private void tạoTKThủThưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formTaoTK f = new formTaoTK();
            f.Show();
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void qLySáchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void qLyThủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fromQLYThuThu f = new fromQLYThuThu();
            f.Show();
        }

        private void qLyĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formQLYDocGia f = new formQLYDocGia(userId);
            f.Show();
        }
    }
}
