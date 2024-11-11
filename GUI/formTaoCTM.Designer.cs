namespace GUI
{
    partial class formTaoCTM
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
            this.cbbMaPM = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSach = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbbMaSach = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDocGia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbbMaPM
            // 
            this.cbbMaPM.FormattingEnabled = true;
            this.cbbMaPM.Location = new System.Drawing.Point(340, 73);
            this.cbbMaPM.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMaPM.Name = "cbbMaPM";
            this.cbbMaPM.Size = new System.Drawing.Size(134, 30);
            this.cbbMaPM.TabIndex = 0;
            this.cbbMaPM.SelectedIndexChanged += new System.EventHandler(this.cbbMaPM_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Phiếu Mượn :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sách :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã sách :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 216);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số lượng mượn : ";
            // 
            // txtSach
            // 
            this.txtSach.Location = new System.Drawing.Point(340, 167);
            this.txtSach.Name = "txtSach";
            this.txtSach.ReadOnly = true;
            this.txtSach.Size = new System.Drawing.Size(279, 28);
            this.txtSach.TabIndex = 7;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(340, 216);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(279, 28);
            this.txtSoLuong.TabIndex = 9;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(542, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Thoát ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 40);
            this.button2.TabIndex = 11;
            this.button2.Text = "Thêm ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbbMaSach
            // 
            this.cbbMaSach.FormattingEnabled = true;
            this.cbbMaSach.Location = new System.Drawing.Point(340, 117);
            this.cbbMaSach.Name = "cbbMaSach";
            this.cbbMaSach.Size = new System.Drawing.Size(134, 30);
            this.cbbMaSach.TabIndex = 12;
            this.cbbMaSach.SelectedIndexChanged += new System.EventHandler(this.cbbMaSach_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tên độc giả mượn sách :";
            // 
            // txtDocGia
            // 
            this.txtDocGia.Location = new System.Drawing.Point(340, 283);
            this.txtDocGia.Name = "txtDocGia";
            this.txtDocGia.ReadOnly = true;
            this.txtDocGia.Size = new System.Drawing.Size(279, 28);
            this.txtDocGia.TabIndex = 14;
            // 
            // formTaoCTM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 411);
            this.Controls.Add(this.txtDocGia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbMaSach);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtSach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbMaPM);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formTaoCTM";
            this.Text = "formChiTietMuo";
            this.Load += new System.EventHandler(this.formTaoCTM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbMaPM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSach;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbbMaSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDocGia;
    }
}