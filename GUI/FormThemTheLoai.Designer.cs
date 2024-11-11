namespace GUI
{
    partial class FormThemTheLoai
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtMaTL;
        private System.Windows.Forms.TextBox txtTenTL;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMaTL;
        private System.Windows.Forms.Label lblTenTL;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtMaTL = new System.Windows.Forms.TextBox();
            this.txtTenTL = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMaTL = new System.Windows.Forms.Label();
            this.lblTenTL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMaTL
            // 
            this.txtMaTL.Location = new System.Drawing.Point(181, 30);
            this.txtMaTL.Name = "txtMaTL";
            this.txtMaTL.ReadOnly = true;
            this.txtMaTL.Size = new System.Drawing.Size(200, 26);
            this.txtMaTL.TabIndex = 0;
            // 
            // txtTenTL
            // 
            this.txtTenTL.Location = new System.Drawing.Point(181, 85);
            this.txtTenTL.Name = "txtTenTL";
            this.txtTenTL.Size = new System.Drawing.Size(200, 26);
            this.txtTenTL.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(107, 136);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 39);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(232, 136);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 39);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Return";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMaTL
            // 
            this.lblMaTL.AutoSize = true;
            this.lblMaTL.Location = new System.Drawing.Point(30, 30);
            this.lblMaTL.Name = "lblMaTL";
            this.lblMaTL.Size = new System.Drawing.Size(147, 20);
            this.lblMaTL.TabIndex = 4;
            this.lblMaTL.Text = "Mã Thể Loại (new) :";
            // 
            // lblTenTL
            // 
            this.lblTenTL.AutoSize = true;
            this.lblTenTL.Location = new System.Drawing.Point(30, 85);
            this.lblTenTL.Name = "lblTenTL";
            this.lblTenTL.Size = new System.Drawing.Size(152, 20);
            this.lblTenTL.TabIndex = 5;
            this.lblTenTL.Text = "Tên Thể Loại (new) :";
            // 
            // FormAddTheLoai
            // 
            this.ClientSize = new System.Drawing.Size(431, 217);
            this.Controls.Add(this.lblTenTL);
            this.Controls.Add(this.lblMaTL);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTenTL);
            this.Controls.Add(this.txtMaTL);
            this.Name = "FormAddTheLoai";
            this.Text = "Thêm Thể Loại";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}