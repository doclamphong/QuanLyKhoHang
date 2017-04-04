namespace QuanLyKhoHang
{
    partial class frmHome
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.DangnhapMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NhaphangMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XuathangMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThongkeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DangnhapMenuItem,
            this.NhaphangMenuItem,
            this.XuathangMenuItem,
            this.ThongkeMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(586, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // DangnhapMenuItem
            // 
            this.DangnhapMenuItem.Name = "DangnhapMenuItem";
            this.DangnhapMenuItem.Size = new System.Drawing.Size(79, 20);
            this.DangnhapMenuItem.Text = "Đăng Nhập";
            this.DangnhapMenuItem.Click += new System.EventHandler(this.DangnhapMenuItem_Click);
            // 
            // NhaphangMenuItem
            // 
            this.NhaphangMenuItem.Name = "NhaphangMenuItem";
            this.NhaphangMenuItem.Size = new System.Drawing.Size(80, 20);
            this.NhaphangMenuItem.Text = "Nhập Hàng";
            this.NhaphangMenuItem.Click += new System.EventHandler(this.NhaphangMenuItem_Click);
            // 
            // XuathangMenuItem
            // 
            this.XuathangMenuItem.Name = "XuathangMenuItem";
            this.XuathangMenuItem.Size = new System.Drawing.Size(75, 20);
            this.XuathangMenuItem.Text = "Xuất Hàng";
            this.XuathangMenuItem.Click += new System.EventHandler(this.XuathangMenuItem_Click);
            // 
            // ThongkeMenuItem
            // 
            this.ThongkeMenuItem.Name = "ThongkeMenuItem";
            this.ThongkeMenuItem.Size = new System.Drawing.Size(70, 20);
            this.ThongkeMenuItem.Text = "Thống Kê";
            this.ThongkeMenuItem.Click += new System.EventHandler(this.ThongkeMenuItem_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 329);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "frmHome";
            this.Text = "Quản lý kho hàng";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem DangnhapMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NhaphangMenuItem;
        private System.Windows.Forms.ToolStripMenuItem XuathangMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThongkeMenuItem;
    }
}

