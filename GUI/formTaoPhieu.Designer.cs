namespace GUI
{
    partial class formTaoPhieu
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
            this.gridPhieu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbTenDG = new System.Windows.Forms.TextBox();
            this.cbbMaDG = new System.Windows.Forms.TextBox();
            this.txtTSS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.cbbTT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dateTra = new System.Windows.Forms.DateTimePicker();
            this.dateMuon = new System.Windows.Forms.DateTimePicker();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonMaPhieu = new System.Windows.Forms.RadioButton();
            this.radioButtonMaDG = new System.Windows.Forms.RadioButton();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhieu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridPhieu
            // 
            this.gridPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPhieu.Location = new System.Drawing.Point(12, 12);
            this.gridPhieu.Name = "gridPhieu";
            this.gridPhieu.RowHeadersWidth = 51;
            this.gridPhieu.RowTemplate.Height = 24;
            this.gridPhieu.Size = new System.Drawing.Size(1031, 200);
            this.gridPhieu.TabIndex = 0;
            this.gridPhieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPhieu_CellClick);
            this.gridPhieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPhieu_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã phiếu mượn :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mã độc giả :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(527, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ngày trả :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(504, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ngày mượn :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbTenDG);
            this.groupBox1.Controls.Add(this.cbbMaDG);
            this.groupBox1.Controls.Add(this.txtTSS);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.cbbTT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.dateTra);
            this.groupBox1.Controls.Add(this.dateMuon);
            this.groupBox1.Controls.Add(this.txtMaPhieu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1027, 344);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbbTenDG
            // 
            this.cbbTenDG.Location = new System.Drawing.Point(215, 149);
            this.cbbTenDG.Name = "cbbTenDG";
            this.cbbTenDG.Size = new System.Drawing.Size(200, 28);
            this.cbbTenDG.TabIndex = 28;
            // 
            // cbbMaDG
            // 
            this.cbbMaDG.Location = new System.Drawing.Point(215, 101);
            this.cbbMaDG.Name = "cbbMaDG";
            this.cbbMaDG.Size = new System.Drawing.Size(200, 28);
            this.cbbMaDG.TabIndex = 27;
            // 
            // txtTSS
            // 
            this.txtTSS.Location = new System.Drawing.Point(632, 149);
            this.txtTSS.Name = "txtTSS";
            this.txtTSS.Size = new System.Drawing.Size(189, 28);
            this.txtTSS.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(497, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 22);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tổng số sách: ";
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Location = new System.Drawing.Point(248, 282);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(103, 34);
            this.btnLuu.TabIndex = 24;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cbbTT
            // 
            this.cbbTT.FormattingEnabled = true;
            this.cbbTT.Items.AddRange(new object[] {
            "Hết hạn",
            "Trễ hạn",
            "Đang mượn"});
            this.cbbTT.Location = new System.Drawing.Point(215, 200);
            this.cbbTT.Name = "cbbTT";
            this.cbbTT.Size = new System.Drawing.Size(200, 30);
            this.cbbTT.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tình trạng :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(56, 282);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(145, 35);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "Thêm phiếu ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(830, 280);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 36);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(418, 282);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(117, 36);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(611, 281);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(121, 36);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dateTra
            // 
            this.dateTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTra.Location = new System.Drawing.Point(621, 99);
            this.dateTra.Name = "dateTra";
            this.dateTra.Size = new System.Drawing.Size(200, 28);
            this.dateTra.TabIndex = 15;
            // 
            // dateMuon
            // 
            this.dateMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateMuon.Location = new System.Drawing.Point(621, 48);
            this.dateMuon.Name = "dateMuon";
            this.dateMuon.Size = new System.Drawing.Size(200, 28);
            this.dateMuon.TabIndex = 14;
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Enabled = false;
            this.txtMaPhieu.Location = new System.Drawing.Point(215, 42);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.ReadOnly = true;
            this.txtMaPhieu.Size = new System.Drawing.Size(200, 28);
            this.txtMaPhieu.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên độc giả :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonMaPhieu);
            this.groupBox2.Controls.Add(this.radioButtonMaDG);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 587);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1028, 124);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // radioButtonMaPhieu
            // 
            this.radioButtonMaPhieu.AutoSize = true;
            this.radioButtonMaPhieu.Location = new System.Drawing.Point(185, 73);
            this.radioButtonMaPhieu.Name = "radioButtonMaPhieu";
            this.radioButtonMaPhieu.Size = new System.Drawing.Size(179, 26);
            this.radioButtonMaPhieu.TabIndex = 9;
            this.radioButtonMaPhieu.TabStop = true;
            this.radioButtonMaPhieu.Text = "Tìm theo mã phiếu";
            this.radioButtonMaPhieu.UseVisualStyleBackColor = true;
            // 
            // radioButtonMaDG
            // 
            this.radioButtonMaDG.AutoSize = true;
            this.radioButtonMaDG.Location = new System.Drawing.Point(185, 26);
            this.radioButtonMaDG.Name = "radioButtonMaDG";
            this.radioButtonMaDG.Size = new System.Drawing.Size(162, 26);
            this.radioButtonMaDG.TabIndex = 8;
            this.radioButtonMaDG.TabStop = true;
            this.radioButtonMaDG.Text = "Tìm theo mã DG";
            this.radioButtonMaDG.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(725, 44);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(118, 30);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(380, 46);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(304, 28);
            this.txtTimKiem.TabIndex = 6;
            // 
            // formTaoPhieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 732);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridPhieu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "formTaoPhieu";
            this.Text = "formTaoPhieu";
            this.Load += new System.EventHandler(this.formTaoPhieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPhieu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPhieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DateTimePicker dateTra;
        private System.Windows.Forms.DateTimePicker dateMuon;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonMaPhieu;
        private System.Windows.Forms.RadioButton radioButtonMaDG;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cbbTT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtTSS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cbbTenDG;
        private System.Windows.Forms.TextBox cbbMaDG;
    }
}