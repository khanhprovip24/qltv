namespace GUI
{
    partial class FormNXB
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
            this.lbQuanLyNhaXuatBan = new System.Windows.Forms.Label();
            this.lbTimKiemNXB = new System.Windows.Forms.Label();
            this.cbTimKiemNXB = new System.Windows.Forms.ComboBox();
            this.btnTimKiemNXB = new System.Windows.Forms.Button();
            this.gridViewNXB = new System.Windows.Forms.DataGridView();
            this.grbThongTinNXB = new System.Windows.Forms.GroupBox();
            this.grbChiTietNXB = new System.Windows.Forms.GroupBox();
            this.txtDiaChiNXB = new System.Windows.Forms.TextBox();
            this.txtTenNXB = new System.Windows.Forms.TextBox();
            this.txtMaNXB = new System.Windows.Forms.TextBox();
            this.lbDiaChiNXB = new System.Windows.Forms.Label();
            this.lbTenNXB = new System.Windows.Forms.Label();
            this.lbMaNXB = new System.Windows.Forms.Label();
            this.btnThemNXB = new System.Windows.Forms.Button();
            this.btnSuaNXB = new System.Windows.Forms.Button();
            this.btnXoaNXB = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuuNXB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNXB)).BeginInit();
            this.grbThongTinNXB.SuspendLayout();
            this.grbChiTietNXB.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbQuanLyNhaXuatBan
            // 
            this.lbQuanLyNhaXuatBan.AutoSize = true;
            this.lbQuanLyNhaXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuanLyNhaXuatBan.Location = new System.Drawing.Point(282, 9);
            this.lbQuanLyNhaXuatBan.Name = "lbQuanLyNhaXuatBan";
            this.lbQuanLyNhaXuatBan.Size = new System.Drawing.Size(281, 31);
            this.lbQuanLyNhaXuatBan.TabIndex = 0;
            this.lbQuanLyNhaXuatBan.Text = "Quản lí nhà xuất bản";
            // 
            // lbTimKiemNXB
            // 
            this.lbTimKiemNXB.AutoSize = true;
            this.lbTimKiemNXB.Location = new System.Drawing.Point(76, 83);
            this.lbTimKiemNXB.Name = "lbTimKiemNXB";
            this.lbTimKiemNXB.Size = new System.Drawing.Size(114, 13);
            this.lbTimKiemNXB.TabIndex = 1;
            this.lbTimKiemNXB.Text = "Tìm kiếm nhà xuất bản";
            // 
            // cbTimKiemNXB
            // 
            this.cbTimKiemNXB.FormattingEnabled = true;
            this.cbTimKiemNXB.Location = new System.Drawing.Point(218, 80);
            this.cbTimKiemNXB.Name = "cbTimKiemNXB";
            this.cbTimKiemNXB.Size = new System.Drawing.Size(237, 21);
            this.cbTimKiemNXB.TabIndex = 2;
            // 
            // btnTimKiemNXB
            // 
            this.btnTimKiemNXB.Location = new System.Drawing.Point(488, 78);
            this.btnTimKiemNXB.Name = "btnTimKiemNXB";
            this.btnTimKiemNXB.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiemNXB.TabIndex = 3;
            this.btnTimKiemNXB.Text = "Tìm kiếm";
            this.btnTimKiemNXB.UseVisualStyleBackColor = true;
            this.btnTimKiemNXB.Click += new System.EventHandler(this.btnTimKiemNXB_Click);
            // 
            // gridViewNXB
            // 
            this.gridViewNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewNXB.Location = new System.Drawing.Point(6, 19);
            this.gridViewNXB.Name = "gridViewNXB";
            this.gridViewNXB.Size = new System.Drawing.Size(419, 150);
            this.gridViewNXB.TabIndex = 4;
            this.gridViewNXB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewNXB_CellContentClick);
            // 
            // grbThongTinNXB
            // 
            this.grbThongTinNXB.Controls.Add(this.gridViewNXB);
            this.grbThongTinNXB.Location = new System.Drawing.Point(30, 135);
            this.grbThongTinNXB.Name = "grbThongTinNXB";
            this.grbThongTinNXB.Size = new System.Drawing.Size(433, 180);
            this.grbThongTinNXB.TabIndex = 5;
            this.grbThongTinNXB.TabStop = false;
            this.grbThongTinNXB.Text = "Thông tin nhà xuất bản";
            // 
            // grbChiTietNXB
            // 
            this.grbChiTietNXB.Controls.Add(this.txtDiaChiNXB);
            this.grbChiTietNXB.Controls.Add(this.txtTenNXB);
            this.grbChiTietNXB.Controls.Add(this.txtMaNXB);
            this.grbChiTietNXB.Controls.Add(this.lbDiaChiNXB);
            this.grbChiTietNXB.Controls.Add(this.lbTenNXB);
            this.grbChiTietNXB.Controls.Add(this.lbMaNXB);
            this.grbChiTietNXB.Location = new System.Drawing.Point(487, 135);
            this.grbChiTietNXB.Name = "grbChiTietNXB";
            this.grbChiTietNXB.Size = new System.Drawing.Size(285, 124);
            this.grbChiTietNXB.TabIndex = 6;
            this.grbChiTietNXB.TabStop = false;
            this.grbChiTietNXB.Text = "Chi tiết nhà xuất bản";
            // 
            // txtDiaChiNXB
            // 
            this.txtDiaChiNXB.Location = new System.Drawing.Point(114, 87);
            this.txtDiaChiNXB.Name = "txtDiaChiNXB";
            this.txtDiaChiNXB.Size = new System.Drawing.Size(146, 20);
            this.txtDiaChiNXB.TabIndex = 7;
            // 
            // txtTenNXB
            // 
            this.txtTenNXB.Location = new System.Drawing.Point(114, 58);
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.Size = new System.Drawing.Size(100, 20);
            this.txtTenNXB.TabIndex = 6;
            // 
            // txtMaNXB
            // 
            this.txtMaNXB.Location = new System.Drawing.Point(114, 32);
            this.txtMaNXB.Name = "txtMaNXB";
            this.txtMaNXB.Size = new System.Drawing.Size(100, 20);
            this.txtMaNXB.TabIndex = 5;
            // 
            // lbDiaChiNXB
            // 
            this.lbDiaChiNXB.AutoSize = true;
            this.lbDiaChiNXB.Location = new System.Drawing.Point(36, 87);
            this.lbDiaChiNXB.Name = "lbDiaChiNXB";
            this.lbDiaChiNXB.Size = new System.Drawing.Size(40, 13);
            this.lbDiaChiNXB.TabIndex = 4;
            this.lbDiaChiNXB.Text = "Địa chỉ";
            // 
            // lbTenNXB
            // 
            this.lbTenNXB.AutoSize = true;
            this.lbTenNXB.Location = new System.Drawing.Point(36, 61);
            this.lbTenNXB.Name = "lbTenNXB";
            this.lbTenNXB.Size = new System.Drawing.Size(26, 13);
            this.lbTenNXB.TabIndex = 3;
            this.lbTenNXB.Text = "Tên";
            // 
            // lbMaNXB
            // 
            this.lbMaNXB.AutoSize = true;
            this.lbMaNXB.Location = new System.Drawing.Point(36, 33);
            this.lbMaNXB.Name = "lbMaNXB";
            this.lbMaNXB.Size = new System.Drawing.Size(22, 13);
            this.lbMaNXB.TabIndex = 2;
            this.lbMaNXB.Text = "Mã";
            // 
            // btnThemNXB
            // 
            this.btnThemNXB.Location = new System.Drawing.Point(241, 390);
            this.btnThemNXB.Name = "btnThemNXB";
            this.btnThemNXB.Size = new System.Drawing.Size(75, 23);
            this.btnThemNXB.TabIndex = 7;
            this.btnThemNXB.Text = "Thêm";
            this.btnThemNXB.UseVisualStyleBackColor = true;
            this.btnThemNXB.Click += new System.EventHandler(this.btnThemNXB_Click);
            // 
            // btnSuaNXB
            // 
            this.btnSuaNXB.Location = new System.Drawing.Point(348, 390);
            this.btnSuaNXB.Name = "btnSuaNXB";
            this.btnSuaNXB.Size = new System.Drawing.Size(75, 23);
            this.btnSuaNXB.TabIndex = 8;
            this.btnSuaNXB.Text = "Sửa";
            this.btnSuaNXB.UseVisualStyleBackColor = true;
            this.btnSuaNXB.Click += new System.EventHandler(this.btnSuaNXB_Click);
            // 
            // btnXoaNXB
            // 
            this.btnXoaNXB.Location = new System.Drawing.Point(461, 390);
            this.btnXoaNXB.Name = "btnXoaNXB";
            this.btnXoaNXB.Size = new System.Drawing.Size(75, 23);
            this.btnXoaNXB.TabIndex = 9;
            this.btnXoaNXB.Text = "Xoá";
            this.btnXoaNXB.UseVisualStyleBackColor = true;
            this.btnXoaNXB.Click += new System.EventHandler(this.btnXoaNXB_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(672, 390);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuuNXB
            // 
            this.btnLuuNXB.Location = new System.Drawing.Point(570, 390);
            this.btnLuuNXB.Name = "btnLuuNXB";
            this.btnLuuNXB.Size = new System.Drawing.Size(75, 23);
            this.btnLuuNXB.TabIndex = 12;
            this.btnLuuNXB.Text = "Lưu";
            this.btnLuuNXB.UseVisualStyleBackColor = true;
            this.btnLuuNXB.Click += new System.EventHandler(this.btnLuuNXB_Click);
            // 
            // FormNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 435);
            this.Controls.Add(this.btnLuuNXB);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoaNXB);
            this.Controls.Add(this.btnSuaNXB);
            this.Controls.Add(this.btnThemNXB);
            this.Controls.Add(this.grbChiTietNXB);
            this.Controls.Add(this.grbThongTinNXB);
            this.Controls.Add(this.btnTimKiemNXB);
            this.Controls.Add(this.cbTimKiemNXB);
            this.Controls.Add(this.lbTimKiemNXB);
            this.Controls.Add(this.lbQuanLyNhaXuatBan);
            this.Name = "FormNXB";
            this.Text = "FormNXB";
            this.Load += new System.EventHandler(this.FormNXB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNXB)).EndInit();
            this.grbThongTinNXB.ResumeLayout(false);
            this.grbChiTietNXB.ResumeLayout(false);
            this.grbChiTietNXB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbQuanLyNhaXuatBan;
        private System.Windows.Forms.Label lbTimKiemNXB;
        private System.Windows.Forms.ComboBox cbTimKiemNXB;
        private System.Windows.Forms.Button btnTimKiemNXB;
        private System.Windows.Forms.DataGridView gridViewNXB;
        private System.Windows.Forms.GroupBox grbThongTinNXB;
        private System.Windows.Forms.GroupBox grbChiTietNXB;
        private System.Windows.Forms.TextBox txtDiaChiNXB;
        private System.Windows.Forms.TextBox txtTenNXB;
        private System.Windows.Forms.TextBox txtMaNXB;
        private System.Windows.Forms.Label lbDiaChiNXB;
        private System.Windows.Forms.Label lbTenNXB;
        private System.Windows.Forms.Label lbMaNXB;
        private System.Windows.Forms.Button btnThemNXB;
        private System.Windows.Forms.Button btnSuaNXB;
        private System.Windows.Forms.Button btnXoaNXB;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuuNXB;
    }
}