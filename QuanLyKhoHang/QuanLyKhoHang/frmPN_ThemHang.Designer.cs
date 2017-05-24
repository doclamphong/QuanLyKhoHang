namespace QuanLyKhoHang
{
    partial class frmPN_ThemHang
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
            this.grvPN_KQTimKiem = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPN_TimKiemSP = new System.Windows.Forms.TextBox();
            this.btnPN_TimKiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPN_SoLuongNhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPN_TenHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPN_MaHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPN_HuyThemHang = new System.Windows.Forms.Button();
            this.btnPN_ThemMoiHang = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPN_GiaNhap = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grvPN_KQTimKiem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grvPN_KQTimKiem
            // 
            this.grvPN_KQTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvPN_KQTimKiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TenSanPham,
            this.SoLuongTon});
            this.grvPN_KQTimKiem.Location = new System.Drawing.Point(118, 45);
            this.grvPN_KQTimKiem.Name = "grvPN_KQTimKiem";
            this.grvPN_KQTimKiem.Size = new System.Drawing.Size(349, 150);
            this.grvPN_KQTimKiem.TabIndex = 7;
            this.grvPN_KQTimKiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvPN_KQTimKiem_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã Sản Phẩm";
            this.ID.Name = "ID";
            // 
            // TenSanPham
            // 
            this.TenSanPham.DataPropertyName = "TenSanPham";
            this.TenSanPham.HeaderText = "Tên sản phẩm";
            this.TenSanPham.Name = "TenSanPham";
            // 
            // SoLuongTon
            // 
            this.SoLuongTon.DataPropertyName = "SoLuongTon";
            this.SoLuongTon.HeaderText = "Lượng Hàng Trong Kho";
            this.SoLuongTon.Name = "SoLuongTon";
            // 
            // txtPN_TimKiemSP
            // 
            this.txtPN_TimKiemSP.Location = new System.Drawing.Point(98, 7);
            this.txtPN_TimKiemSP.Name = "txtPN_TimKiemSP";
            this.txtPN_TimKiemSP.Size = new System.Drawing.Size(237, 20);
            this.txtPN_TimKiemSP.TabIndex = 6;
            // 
            // btnPN_TimKiem
            // 
            this.btnPN_TimKiem.Location = new System.Drawing.Point(341, 4);
            this.btnPN_TimKiem.Name = "btnPN_TimKiem";
            this.btnPN_TimKiem.Size = new System.Drawing.Size(151, 23);
            this.btnPN_TimKiem.TabIndex = 5;
            this.btnPN_TimKiem.Text = "Tìm kiếm sản phẩm ";
            this.btnPN_TimKiem.UseVisualStyleBackColor = true;
            this.btnPN_TimKiem.Click += new System.EventHandler(this.btnPN_TimKiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPN_GiaNhap);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPN_SoLuongNhap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPN_TenHang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPN_MaHang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(52, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 126);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thêm hàng ";
            // 
            // txtPN_SoLuongNhap
            // 
            this.txtPN_SoLuongNhap.Location = new System.Drawing.Point(266, 81);
            this.txtPN_SoLuongNhap.Name = "txtPN_SoLuongNhap";
            this.txtPN_SoLuongNhap.Size = new System.Drawing.Size(100, 20);
            this.txtPN_SoLuongNhap.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số Lượng Nhập :";
            // 
            // txtPN_TenHang
            // 
            this.txtPN_TenHang.Location = new System.Drawing.Point(66, 81);
            this.txtPN_TenHang.Name = "txtPN_TenHang";
            this.txtPN_TenHang.ReadOnly = true;
            this.txtPN_TenHang.Size = new System.Drawing.Size(100, 20);
            this.txtPN_TenHang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên hàng";
            // 
            // txtPN_MaHang
            // 
            this.txtPN_MaHang.Location = new System.Drawing.Point(191, 27);
            this.txtPN_MaHang.Name = "txtPN_MaHang";
            this.txtPN_MaHang.ReadOnly = true;
            this.txtPN_MaHang.Size = new System.Drawing.Size(206, 20);
            this.txtPN_MaHang.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hàng :";
            // 
            // btnPN_HuyThemHang
            // 
            this.btnPN_HuyThemHang.Location = new System.Drawing.Point(458, 341);
            this.btnPN_HuyThemHang.Name = "btnPN_HuyThemHang";
            this.btnPN_HuyThemHang.Size = new System.Drawing.Size(107, 42);
            this.btnPN_HuyThemHang.TabIndex = 9;
            this.btnPN_HuyThemHang.Text = "Đóng";
            this.btnPN_HuyThemHang.UseVisualStyleBackColor = true;
            this.btnPN_HuyThemHang.Click += new System.EventHandler(this.btnPN_HuyThemHang_Click);
            // 
            // btnPN_ThemMoiHang
            // 
            this.btnPN_ThemMoiHang.Location = new System.Drawing.Point(328, 341);
            this.btnPN_ThemMoiHang.Name = "btnPN_ThemMoiHang";
            this.btnPN_ThemMoiHang.Size = new System.Drawing.Size(107, 42);
            this.btnPN_ThemMoiHang.TabIndex = 10;
            this.btnPN_ThemMoiHang.Text = "Thêm ";
            this.btnPN_ThemMoiHang.UseVisualStyleBackColor = true;
            this.btnPN_ThemMoiHang.Click += new System.EventHandler(this.btnPN_ThemMoiHang_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá :";
            // 
            // txtPN_GiaNhap
            // 
            this.txtPN_GiaNhap.Location = new System.Drawing.Point(428, 81);
            this.txtPN_GiaNhap.Name = "txtPN_GiaNhap";
            this.txtPN_GiaNhap.Size = new System.Drawing.Size(100, 20);
            this.txtPN_GiaNhap.TabIndex = 1;
            // 
            // frmPN_ThemHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 429);
            this.Controls.Add(this.grvPN_KQTimKiem);
            this.Controls.Add(this.txtPN_TimKiemSP);
            this.Controls.Add(this.btnPN_TimKiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPN_HuyThemHang);
            this.Controls.Add(this.btnPN_ThemMoiHang);
            this.Name = "frmPN_ThemHang";
            this.Text = "frmPN_ThemHang";
            this.Load += new System.EventHandler(this.frmPN_ThemHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvPN_KQTimKiem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvPN_KQTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTon;
        private System.Windows.Forms.TextBox txtPN_TimKiemSP;
        private System.Windows.Forms.Button btnPN_TimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPN_SoLuongNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPN_TenHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPN_MaHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPN_HuyThemHang;
        private System.Windows.Forms.Button btnPN_ThemMoiHang;
        private System.Windows.Forms.TextBox txtPN_GiaNhap;
        private System.Windows.Forms.Label label4;
    }
}