namespace GUI
{
    partial class formChiTietMuon
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbMaPM = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtMaPM = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.griChiTiet = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbMaPM);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(262, 496);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 105);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm mã phiếu";
            // 
            // cbbMaPM
            // 
            this.cbbMaPM.FormattingEnabled = true;
            this.cbbMaPM.Location = new System.Drawing.Point(162, 44);
            this.cbbMaPM.Name = "cbbMaPM";
            this.cbbMaPM.Size = new System.Drawing.Size(206, 30);
            this.cbbMaPM.TabIndex = 8;
            this.cbbMaPM.SelectedIndexChanged += new System.EventHandler(this.cbbMaPM_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTenSach);
            this.groupBox1.Controls.Add(this.txtMaSach);
            this.groupBox1.Controls.Add(this.txtMaPM);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(939, 256);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(282, 155);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(216, 28);
            this.txtTenSach.TabIndex = 21;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(282, 109);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(216, 28);
            this.txtMaSach.TabIndex = 20;
            // 
            // txtMaPM
            // 
            this.txtMaPM.Location = new System.Drawing.Point(282, 64);
            this.txtMaPM.Name = "txtMaPM";
            this.txtMaPM.Size = new System.Drawing.Size(216, 28);
            this.txtMaPM.TabIndex = 19;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(765, 163);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(124, 33);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(585, 161);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(124, 35);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(585, 112);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 33);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(765, 112);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 36);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(282, 199);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(216, 28);
            this.txtSoLuong.TabIndex = 14;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tên sách :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mã Sách :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mã phiếu mượn :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Số lượng :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // griChiTiet
            // 
            this.griChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griChiTiet.Location = new System.Drawing.Point(13, 13);
            this.griChiTiet.Name = "griChiTiet";
            this.griChiTiet.RowHeadersWidth = 51;
            this.griChiTiet.RowTemplate.Height = 24;
            this.griChiTiet.Size = new System.Drawing.Size(938, 195);
            this.griChiTiet.TabIndex = 13;
            this.griChiTiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.griChiTiet_CellClick);
            // 
            // formChiTietMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 633);
            this.Controls.Add(this.griChiTiet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "formChiTietMuon";
            this.Text = "formChiTietMuon";
            this.Load += new System.EventHandler(this.formChiTietMuon_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griChiTiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.DataGridView griChiTiet;
        private System.Windows.Forms.ComboBox cbbMaPM;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtMaPM;
    }
}