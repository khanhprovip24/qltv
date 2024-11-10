namespace GUI
{
    partial class formQuyDinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formQuyDinh));
            this.btnLuuQD = new System.Windows.Forms.Button();
            this.richTextBoxQD = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnLuuQD
            // 
            this.btnLuuQD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuQD.Location = new System.Drawing.Point(401, 726);
            this.btnLuuQD.Name = "btnLuuQD";
            this.btnLuuQD.Size = new System.Drawing.Size(176, 43);
            this.btnLuuQD.TabIndex = 1;
            this.btnLuuQD.Text = "Lưu lại quy định";
            this.btnLuuQD.UseVisualStyleBackColor = true;
            this.btnLuuQD.Click += new System.EventHandler(this.btnLuuQD_Click);
            // 
            // richTextBoxQD
            // 
            this.richTextBoxQD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxQD.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxQD.Name = "richTextBoxQD";
            this.richTextBoxQD.Size = new System.Drawing.Size(1196, 708);
            this.richTextBoxQD.TabIndex = 2;
            this.richTextBoxQD.Text = resources.GetString("richTextBoxQD.Text");
            // 
            // formQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 781);
            this.Controls.Add(this.richTextBoxQD);
            this.Controls.Add(this.btnLuuQD);
            this.Name = "formQuyDinh";
            this.Text = "formQuyDinh";
            this.Load += new System.EventHandler(this.formQuyDinh_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLuuQD;
        private System.Windows.Forms.RichTextBox richTextBoxQD;
    }
}