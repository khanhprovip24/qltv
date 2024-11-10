namespace GUI
{
    partial class formMain
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.labelChaoMung = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoTKThủThưToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLySáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLyĐộcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLyThểLoạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLyTácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLyNhàXuấtBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLyThủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mượnTrảSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taoPhiếuMượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchTrảTrễToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoThốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quyĐịnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(683, 144);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // labelChaoMung
            // 
            this.labelChaoMung.AutoSize = true;
            this.labelChaoMung.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChaoMung.ForeColor = System.Drawing.Color.Red;
            this.labelChaoMung.Location = new System.Drawing.Point(79, 144);
            this.labelChaoMung.Name = "labelChaoMung";
            this.labelChaoMung.Size = new System.Drawing.Size(154, 32);
            this.labelChaoMung.TabIndex = 1;
            this.labelChaoMung.Text = "Chào mừng";
            this.labelChaoMung.Click += new System.EventHandler(this.labelChaoMung_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.mượnTrảSáchToolStripMenuItem,
            this.báoCáoThốngKêToolStripMenuItem,
            this.trợGiúpToolStripMenuItem,
            this.toolStripMenuItem1,
            this.quyĐịnhToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1122, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.thoátToolStripMenuItem,
            this.tạoTKThủThưToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng xuất";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // tạoTKThủThưToolStripMenuItem
            // 
            this.tạoTKThủThưToolStripMenuItem.Name = "tạoTKThủThưToolStripMenuItem";
            this.tạoTKThủThưToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.tạoTKThủThưToolStripMenuItem.Text = "Tạo TK Thủ Thư";
            this.tạoTKThủThưToolStripMenuItem.Click += new System.EventHandler(this.tạoTKThủThưToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qLySáchToolStripMenuItem,
            this.qLyĐộcGiảToolStripMenuItem,
            this.qLyThểLoạiToolStripMenuItem,
            this.qLyTácGiảToolStripMenuItem,
            this.qLyNhàXuấtBảnToolStripMenuItem,
            this.qLyThủToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // qLySáchToolStripMenuItem
            // 
            this.qLySáchToolStripMenuItem.Name = "qLySáchToolStripMenuItem";
            this.qLySáchToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.qLySáchToolStripMenuItem.Text = "QLy Sách";
            this.qLySáchToolStripMenuItem.Click += new System.EventHandler(this.qLySáchToolStripMenuItem_Click);
            // 
            // qLyĐộcGiảToolStripMenuItem
            // 
            this.qLyĐộcGiảToolStripMenuItem.Name = "qLyĐộcGiảToolStripMenuItem";
            this.qLyĐộcGiảToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.qLyĐộcGiảToolStripMenuItem.Text = "QLy Độc giả ";
            this.qLyĐộcGiảToolStripMenuItem.Click += new System.EventHandler(this.qLyĐộcGiảToolStripMenuItem_Click);
            // 
            // qLyThểLoạiToolStripMenuItem
            // 
            this.qLyThểLoạiToolStripMenuItem.Name = "qLyThểLoạiToolStripMenuItem";
            this.qLyThểLoạiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.qLyThểLoạiToolStripMenuItem.Text = "QLy Thể Loại";
            // 
            // qLyTácGiảToolStripMenuItem
            // 
            this.qLyTácGiảToolStripMenuItem.Name = "qLyTácGiảToolStripMenuItem";
            this.qLyTácGiảToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.qLyTácGiảToolStripMenuItem.Text = "QLy Tác Giả";
            // 
            // qLyNhàXuấtBảnToolStripMenuItem
            // 
            this.qLyNhàXuấtBảnToolStripMenuItem.Name = "qLyNhàXuấtBảnToolStripMenuItem";
            this.qLyNhàXuấtBảnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.qLyNhàXuấtBảnToolStripMenuItem.Text = "QLy Nhà Xuất bản";
            // 
            // qLyThủToolStripMenuItem
            // 
            this.qLyThủToolStripMenuItem.Name = "qLyThủToolStripMenuItem";
            this.qLyThủToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.qLyThủToolStripMenuItem.Text = "QLy Thủ Thư";
            this.qLyThủToolStripMenuItem.Click += new System.EventHandler(this.qLyThủToolStripMenuItem_Click);
            // 
            // mượnTrảSáchToolStripMenuItem
            // 
            this.mượnTrảSáchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taoPhiếuMượnToolStripMenuItem,
            this.sáchTrảTrễToolStripMenuItem});
            this.mượnTrảSáchToolStripMenuItem.Name = "mượnTrảSáchToolStripMenuItem";
            this.mượnTrảSáchToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.mượnTrảSáchToolStripMenuItem.Text = "Mượn Trả Sách";
            // 
            // taoPhiếuMượnToolStripMenuItem
            // 
            this.taoPhiếuMượnToolStripMenuItem.Name = "taoPhiếuMượnToolStripMenuItem";
            this.taoPhiếuMượnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.taoPhiếuMượnToolStripMenuItem.Text = "Tao phiếu mượn";
            // 
            // sáchTrảTrễToolStripMenuItem
            // 
            this.sáchTrảTrễToolStripMenuItem.Name = "sáchTrảTrễToolStripMenuItem";
            this.sáchTrảTrễToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sáchTrảTrễToolStripMenuItem.Text = "Sách trả trễ";
            // 
            // báoCáoThốngKêToolStripMenuItem
            // 
            this.báoCáoThốngKêToolStripMenuItem.Name = "báoCáoThốngKêToolStripMenuItem";
            this.báoCáoThốngKêToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.báoCáoThốngKêToolStripMenuItem.Text = "Báo Cáo Thống Kê";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 24);
            // 
            // quyĐịnhToolStripMenuItem
            // 
            this.quyĐịnhToolStripMenuItem.Name = "quyĐịnhToolStripMenuItem";
            this.quyĐịnhToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.quyĐịnhToolStripMenuItem.Text = "Quy Định";
            this.quyĐịnhToolStripMenuItem.Click += new System.EventHandler(this.quyĐịnhToolStripMenuItem_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources._242898969;
            this.ClientSize = new System.Drawing.Size(1122, 543);
            this.Controls.Add(this.labelChaoMung);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label labelChaoMung;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoTKThủThưToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLySáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLyĐộcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLyThểLoạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLyTácGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLyNhàXuấtBảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mượnTrảSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taoPhiếuMượnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sáchTrảTrễToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoThốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLyThủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quyĐịnhToolStripMenuItem;
    }
}