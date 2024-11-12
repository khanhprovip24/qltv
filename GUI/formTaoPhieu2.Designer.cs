namespace GUI
{
    partial class formTaoPhieu2
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
            this.txtTSS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbTT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbTenDG = new System.Windows.Forms.ComboBox();
            this.cbbMaDG = new System.Windows.Forms.ComboBox();
            this.dateTra = new System.Windows.Forms.DateTimePicker();
            this.dateMuon = new System.Windows.Forms.DateTimePicker();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTSS
            // 
            this.txtTSS.Location = new System.Drawing.Point(736, 331);
            this.txtTSS.Margin = new System.Windows.Forms.Padding(4);
            this.txtTSS.Name = "txtTSS";
            this.txtTSS.Size = new System.Drawing.Size(249, 28);
            this.txtTSS.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(581, 336);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 22);
            this.label4.TabIndex = 39;
            this.label4.Text = "Tổng số sách: ";
            // 
            // cbbTT
            // 
            this.cbbTT.FormattingEnabled = true;
            this.cbbTT.Items.AddRange(new object[] {
            "Hết hạn",
            "Trễ hạn",
            "Đang mượn"});
            this.cbbTT.Location = new System.Drawing.Point(242, 388);
            this.cbbTT.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTT.Name = "cbbTT";
            this.cbbTT.Size = new System.Drawing.Size(249, 30);
            this.cbbTT.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 388);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tình trạng :";
            // 
            // cbbTenDG
            // 
            this.cbbTenDG.Enabled = false;
            this.cbbTenDG.FormattingEnabled = true;
            this.cbbTenDG.Location = new System.Drawing.Point(242, 294);
            this.cbbTenDG.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTenDG.Name = "cbbTenDG";
            this.cbbTenDG.Size = new System.Drawing.Size(249, 30);
            this.cbbTenDG.TabIndex = 36;
            // 
            // cbbMaDG
            // 
            this.cbbMaDG.FormattingEnabled = true;
            this.cbbMaDG.Location = new System.Drawing.Point(242, 184);
            this.cbbMaDG.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMaDG.Name = "cbbMaDG";
            this.cbbMaDG.Size = new System.Drawing.Size(249, 30);
            this.cbbMaDG.TabIndex = 35;
            this.cbbMaDG.SelectedIndexChanged += new System.EventHandler(this.cbbMaDG_SelectedIndexChanged);
            // 
            // dateTra
            // 
            this.dateTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTra.Location = new System.Drawing.Point(736, 263);
            this.dateTra.Margin = new System.Windows.Forms.Padding(4);
            this.dateTra.Name = "dateTra";
            this.dateTra.Size = new System.Drawing.Size(249, 28);
            this.dateTra.TabIndex = 34;
            // 
            // dateMuon
            // 
            this.dateMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateMuon.Location = new System.Drawing.Point(736, 192);
            this.dateMuon.Margin = new System.Windows.Forms.Padding(4);
            this.dateMuon.Name = "dateMuon";
            this.dateMuon.Size = new System.Drawing.Size(249, 28);
            this.dateMuon.TabIndex = 33;
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Enabled = false;
            this.txtMaPhieu.Location = new System.Drawing.Point(242, 95);
            this.txtMaPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.ReadOnly = true;
            this.txtMaPhieu.Size = new System.Drawing.Size(249, 28);
            this.txtMaPhieu.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 294);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "Tên độc giả :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(590, 192);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 22);
            this.label8.TabIndex = 30;
            this.label8.Text = "Ngày mượn :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(619, 263);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 22);
            this.label7.TabIndex = 29;
            this.label7.Text = "Ngày trả :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 22);
            this.label6.TabIndex = 28;
            this.label6.Text = "Mã độc giả :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 22);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mã phiếu mượn :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 451);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 45);
            this.button1.TabIndex = 41;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(614, 451);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 45);
            this.button2.TabIndex = 42;
            this.button2.Text = "thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // formTaoPhieu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 530);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTSS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbTT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbTenDG);
            this.Controls.Add(this.cbbMaDG);
            this.Controls.Add(this.dateTra);
            this.Controls.Add(this.dateMuon);
            this.Controls.Add(this.txtMaPhieu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formTaoPhieu2";
            this.Text = "formTaoPhieu2";
            this.Load += new System.EventHandler(this.formTaoPhieu2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTSS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbTT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbTenDG;
        private System.Windows.Forms.ComboBox cbbMaDG;
        private System.Windows.Forms.DateTimePicker dateTra;
        private System.Windows.Forms.DateTimePicker dateMuon;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}