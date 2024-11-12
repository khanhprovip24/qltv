namespace GUI
{
    partial class FormBaoCaoThongKe
    {
        private System.ComponentModel.IContainer components = null;

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
            this.cbbTK = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.In = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbTK
            // 
            this.cbbTK.FormattingEnabled = true;
            this.cbbTK.Items.AddRange(new object[] {
            "Phieu muon",
            "Sach",
            "Doc gia"});
            this.cbbTK.Location = new System.Drawing.Point(21, 42);
            this.cbbTK.Name = "cbbTK";
            this.cbbTK.Size = new System.Drawing.Size(185, 30);
            this.cbbTK.TabIndex = 0;
            this.cbbTK.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.In);
            this.groupBox1.Controls.Add(this.cbbTK);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(53, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 135);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            // 
            // In
            // 
            this.In.Location = new System.Drawing.Point(247, 27);
            this.In.Name = "In";
            this.In.Size = new System.Drawing.Size(105, 45);
            this.In.TabIndex = 1;
            this.In.Text = "In";
            this.In.UseVisualStyleBackColor = true;
            this.In.Click += new System.EventHandler(this.In_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormBaoCaoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 163);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormBaoCaoThongKe";
            this.Text = "FormBaoCaoThongKe";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbTK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button In;
    }
}