namespace GUI
{
    partial class FormTacGia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbHeaderTacGia = new System.Windows.Forms.Label();
            this.lbTimKiemTacGia = new System.Windows.Forms.Label();
            this.cbTimKiemTacGia = new System.Windows.Forms.ComboBox();
            this.btnTimKiemTacGia = new System.Windows.Forms.Button();
            this.gridViewTacGia = new System.Windows.Forms.DataGridView();
            this.btnThemTacGia = new System.Windows.Forms.Button();
            this.btnSuaTacGia = new System.Windows.Forms.Button();
            this.btnXoaTacGia = new System.Windows.Forms.Button();
            this.grbThongTinTacGia = new System.Windows.Forms.GroupBox();
            this.grbChiTietTacGia = new System.Windows.Forms.GroupBox();
            this.btnLuuTacGia = new System.Windows.Forms.Button();
            this.lbMaTacGia = new System.Windows.Forms.Label();
            this.lbTenTacGia = new System.Windows.Forms.Label();
            this.txtMaTacGia = new System.Windows.Forms.TextBox();
            this.txtTenTacGia = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTacGia)).BeginInit();
            this.grbThongTinTacGia.SuspendLayout();
            this.grbChiTietTacGia.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHeaderTacGia
            // 
            this.lbHeaderTacGia.AutoSize = true;
            this.lbHeaderTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeaderTacGia.Location = new System.Drawing.Point(194, 9);
            this.lbHeaderTacGia.Name = "lbHeaderTacGia";
            this.lbHeaderTacGia.Size = new System.Drawing.Size(239, 31);
            this.lbHeaderTacGia.TabIndex = 0;
            this.lbHeaderTacGia.Text = "Thông tin tác giả ";
            // 
            // lbTimKiemTacGia
            // 
            this.lbTimKiemTacGia.AutoSize = true;
            this.lbTimKiemTacGia.Location = new System.Drawing.Point(50, 81);
            this.lbTimKiemTacGia.Name = "lbTimKiemTacGia";
            this.lbTimKiemTacGia.Size = new System.Drawing.Size(84, 13);
            this.lbTimKiemTacGia.TabIndex = 1;
            this.lbTimKiemTacGia.Text = "Tìm kiếm tác giả";
            // 
            // cbTimKiemTacGia
            // 
            this.cbTimKiemTacGia.FormattingEnabled = true;
            this.cbTimKiemTacGia.Location = new System.Drawing.Point(161, 78);
            this.cbTimKiemTacGia.Name = "cbTimKiemTacGia";
            this.cbTimKiemTacGia.Size = new System.Drawing.Size(144, 21);
            this.cbTimKiemTacGia.TabIndex = 2;
            // 
            // btnTimKiemTacGia
            // 
            this.btnTimKiemTacGia.Location = new System.Drawing.Point(331, 76);
            this.btnTimKiemTacGia.Name = "btnTimKiemTacGia";
            this.btnTimKiemTacGia.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiemTacGia.TabIndex = 3;
            this.btnTimKiemTacGia.Text = "Tìm kiếm";
            this.btnTimKiemTacGia.UseVisualStyleBackColor = true;
            this.btnTimKiemTacGia.Click += new System.EventHandler(this.btnTimKiemTacGia_Click);
            // 
            // gridViewTacGia
            // 
            this.gridViewTacGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewTacGia.Location = new System.Drawing.Point(12, 19);
            this.gridViewTacGia.Name = "gridViewTacGia";
            this.gridViewTacGia.Size = new System.Drawing.Size(237, 199);
            this.gridViewTacGia.TabIndex = 4;
            this.gridViewTacGia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewTacGia_CellContentClick);
            // 
            // btnThemTacGia
            // 
            this.btnThemTacGia.Location = new System.Drawing.Point(41, 379);
            this.btnThemTacGia.Name = "btnThemTacGia";
            this.btnThemTacGia.Size = new System.Drawing.Size(75, 23);
            this.btnThemTacGia.TabIndex = 5;
            this.btnThemTacGia.Text = "Thêm";
            this.btnThemTacGia.UseVisualStyleBackColor = true;
            this.btnThemTacGia.Click += new System.EventHandler(this.btnThemTacGia_Click);
            // 
            // btnSuaTacGia
            // 
            this.btnSuaTacGia.Location = new System.Drawing.Point(152, 379);
            this.btnSuaTacGia.Name = "btnSuaTacGia";
            this.btnSuaTacGia.Size = new System.Drawing.Size(75, 23);
            this.btnSuaTacGia.TabIndex = 6;
            this.btnSuaTacGia.Text = "Sửa";
            this.btnSuaTacGia.UseVisualStyleBackColor = true;
            this.btnSuaTacGia.Click += new System.EventHandler(this.btnSuaTacGia_Click);
            // 
            // btnXoaTacGia
            // 
            this.btnXoaTacGia.Location = new System.Drawing.Point(261, 379);
            this.btnXoaTacGia.Name = "btnXoaTacGia";
            this.btnXoaTacGia.Size = new System.Drawing.Size(75, 23);
            this.btnXoaTacGia.TabIndex = 7;
            this.btnXoaTacGia.Text = "Xoá";
            this.btnXoaTacGia.UseVisualStyleBackColor = true;
            this.btnXoaTacGia.Click += new System.EventHandler(this.btnXoaTacGia_Click);
            // 
            // grbThongTinTacGia
            // 
            this.grbThongTinTacGia.Controls.Add(this.gridViewTacGia);
            this.grbThongTinTacGia.Location = new System.Drawing.Point(41, 124);
            this.grbThongTinTacGia.Name = "grbThongTinTacGia";
            this.grbThongTinTacGia.Size = new System.Drawing.Size(264, 234);
            this.grbThongTinTacGia.TabIndex = 8;
            this.grbThongTinTacGia.TabStop = false;
            this.grbThongTinTacGia.Text = "Thông tin tác giả";
            // 
            // grbChiTietTacGia
            // 
            this.grbChiTietTacGia.Controls.Add(this.txtTenTacGia);
            this.grbChiTietTacGia.Controls.Add(this.txtMaTacGia);
            this.grbChiTietTacGia.Controls.Add(this.lbTenTacGia);
            this.grbChiTietTacGia.Controls.Add(this.lbMaTacGia);
            this.grbChiTietTacGia.Location = new System.Drawing.Point(331, 124);
            this.grbChiTietTacGia.Name = "grbChiTietTacGia";
            this.grbChiTietTacGia.Size = new System.Drawing.Size(215, 130);
            this.grbChiTietTacGia.TabIndex = 9;
            this.grbChiTietTacGia.TabStop = false;
            this.grbChiTietTacGia.Text = "Chi tiết tác giả";
            // 
            // btnLuuTacGia
            // 
            this.btnLuuTacGia.Location = new System.Drawing.Point(371, 379);
            this.btnLuuTacGia.Name = "btnLuuTacGia";
            this.btnLuuTacGia.Size = new System.Drawing.Size(75, 23);
            this.btnLuuTacGia.TabIndex = 10;
            this.btnLuuTacGia.Text = "Lưu";
            this.btnLuuTacGia.UseVisualStyleBackColor = true;
            this.btnLuuTacGia.Click += new System.EventHandler(this.btnLuuTacGia_Click);
            // 
            // lbMaTacGia
            // 
            this.lbMaTacGia.AutoSize = true;
            this.lbMaTacGia.Location = new System.Drawing.Point(15, 46);
            this.lbMaTacGia.Name = "lbMaTacGia";
            this.lbMaTacGia.Size = new System.Drawing.Size(57, 13);
            this.lbMaTacGia.TabIndex = 0;
            this.lbMaTacGia.Text = "Mã tác giả";
            // 
            // lbTenTacGia
            // 
            this.lbTenTacGia.AutoSize = true;
            this.lbTenTacGia.Location = new System.Drawing.Point(15, 77);
            this.lbTenTacGia.Name = "lbTenTacGia";
            this.lbTenTacGia.Size = new System.Drawing.Size(61, 13);
            this.lbTenTacGia.TabIndex = 1;
            this.lbTenTacGia.Text = "Tên tác giả";
            // 
            // txtMaTacGia
            // 
            this.txtMaTacGia.Location = new System.Drawing.Point(92, 43);
            this.txtMaTacGia.Name = "txtMaTacGia";
            this.txtMaTacGia.Size = new System.Drawing.Size(100, 20);
            this.txtMaTacGia.TabIndex = 2;
            // 
            // txtTenTacGia
            // 
            this.txtTenTacGia.Location = new System.Drawing.Point(92, 70);
            this.txtTenTacGia.Name = "txtTenTacGia";
            this.txtTenTacGia.Size = new System.Drawing.Size(100, 20);
            this.txtTenTacGia.TabIndex = 3;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(471, 379);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FormTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuuTacGia);
            this.Controls.Add(this.grbChiTietTacGia);
            this.Controls.Add(this.grbThongTinTacGia);
            this.Controls.Add(this.btnXoaTacGia);
            this.Controls.Add(this.btnTimKiemTacGia);
            this.Controls.Add(this.btnSuaTacGia);
            this.Controls.Add(this.btnThemTacGia);
            this.Controls.Add(this.cbTimKiemTacGia);
            this.Controls.Add(this.lbTimKiemTacGia);
            this.Controls.Add(this.lbHeaderTacGia);
            this.Name = "FormTacGia";
            this.Text = "FormTacGia";
            this.Load += new System.EventHandler(this.FormTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTacGia)).EndInit();
            this.grbThongTinTacGia.ResumeLayout(false);
            this.grbChiTietTacGia.ResumeLayout(false);
            this.grbChiTietTacGia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHeaderTacGia;
        private System.Windows.Forms.Label lbTimKiemTacGia;
        private System.Windows.Forms.ComboBox cbTimKiemTacGia;
        private System.Windows.Forms.Button btnTimKiemTacGia;
        private System.Windows.Forms.DataGridView gridViewTacGia;
        private System.Windows.Forms.Button btnThemTacGia;
        private System.Windows.Forms.Button btnSuaTacGia;
        private System.Windows.Forms.Button btnXoaTacGia;
        private System.Windows.Forms.GroupBox grbThongTinTacGia;
        private System.Windows.Forms.GroupBox grbChiTietTacGia;
        private System.Windows.Forms.TextBox txtTenTacGia;
        private System.Windows.Forms.TextBox txtMaTacGia;
        private System.Windows.Forms.Label lbTenTacGia;
        private System.Windows.Forms.Label lbMaTacGia;
        private System.Windows.Forms.Button btnLuuTacGia;
        private System.Windows.Forms.Button btnThoat;
    }
}