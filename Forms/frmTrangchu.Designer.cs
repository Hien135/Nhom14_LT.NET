namespace Nhom14_LT.NET
{
    partial class frmTrangchu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchTruyệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuMượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem,
            this.phiếuToolStripMenuItem,
            this.báoCáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(900, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sáchTruyệnToolStripMenuItem,
            this.nhânViênToolStripMenuItem,
            this.kháchHàngToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // sáchTruyệnToolStripMenuItem
            // 
            this.sáchTruyệnToolStripMenuItem.Name = "sáchTruyệnToolStripMenuItem";
            this.sáchTruyệnToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
            this.sáchTruyệnToolStripMenuItem.Text = "Sách truyện";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            // 
            // phiếuToolStripMenuItem
            // 
            this.phiếuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phiếuMượnToolStripMenuItem,
            this.phiếuNhậpToolStripMenuItem});
            this.phiếuToolStripMenuItem.Name = "phiếuToolStripMenuItem";
            this.phiếuToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.phiếuToolStripMenuItem.Text = "Phiếu";
            // 
            // phiếuMượnToolStripMenuItem
            // 
            this.phiếuMượnToolStripMenuItem.Name = "phiếuMượnToolStripMenuItem";
            this.phiếuMượnToolStripMenuItem.Size = new System.Drawing.Size(210, 34);
            this.phiếuMượnToolStripMenuItem.Text = "Phiếu mượn";
            // 
            // phiếuNhậpToolStripMenuItem
            // 
            this.phiếuNhậpToolStripMenuItem.Name = "phiếuNhậpToolStripMenuItem";
            this.phiếuNhậpToolStripMenuItem.Size = new System.Drawing.Size(210, 34);
            this.phiếuNhậpToolStripMenuItem.Text = "Phiếu nhập";
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // frmTrangchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTrangchu";
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.frmTrangchu_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sáchTruyệnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuMượnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
    }
}

