namespace QuanLyKhoHang
{
    partial class frmXuatHang
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
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiemSP = new System.Windows.Forms.TextBox();
            this.grvKQTimKiem = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoLuongMua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemMoiHang = new System.Windows.Forms.Button();
            this.btnHuyThemHang = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvKQTimKiem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(398, 9);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(151, 23);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm kiếm sản phẩm ";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiemSP
            // 
            this.txtTimKiemSP.Location = new System.Drawing.Point(155, 12);
            this.txtTimKiemSP.Name = "txtTimKiemSP";
            this.txtTimKiemSP.Size = new System.Drawing.Size(237, 20);
            this.txtTimKiemSP.TabIndex = 1;
            // 
            // grvKQTimKiem
            // 
            this.grvKQTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvKQTimKiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TenSanPham,
            this.SoLuongTon});
            this.grvKQTimKiem.Location = new System.Drawing.Point(175, 50);
            this.grvKQTimKiem.Name = "grvKQTimKiem";
            this.grvKQTimKiem.Size = new System.Drawing.Size(349, 150);
            this.grvKQTimKiem.TabIndex = 2;
            this.grvKQTimKiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvKQTimKiem_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSoLuongMua);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenHang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaHang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(109, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 153);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thêm hàng ";
            // 
            // txtSoLuongMua
            // 
            this.txtSoLuongMua.Location = new System.Drawing.Point(340, 73);
            this.txtSoLuongMua.Name = "txtSoLuongMua";
            this.txtSoLuongMua.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuongMua.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số Lượng Mua :";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(130, 73);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.ReadOnly = true;
            this.txtTenHang.Size = new System.Drawing.Size(100, 20);
            this.txtTenHang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên hàng";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(209, 19);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.ReadOnly = true;
            this.txtMaHang.Size = new System.Drawing.Size(206, 20);
            this.txtMaHang.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hàng :";
            // 
            // btnThemMoiHang
            // 
            this.btnThemMoiHang.Location = new System.Drawing.Point(420, 385);
            this.btnThemMoiHang.Name = "btnThemMoiHang";
            this.btnThemMoiHang.Size = new System.Drawing.Size(107, 42);
            this.btnThemMoiHang.TabIndex = 4;
            this.btnThemMoiHang.Text = "Thêm ";
            this.btnThemMoiHang.UseVisualStyleBackColor = true;
            this.btnThemMoiHang.Click += new System.EventHandler(this.btnThemMoiHang_Click);
            // 
            // btnHuyThemHang
            // 
            this.btnHuyThemHang.Location = new System.Drawing.Point(550, 385);
            this.btnHuyThemHang.Name = "btnHuyThemHang";
            this.btnHuyThemHang.Size = new System.Drawing.Size(107, 42);
            this.btnHuyThemHang.TabIndex = 4;
            this.btnHuyThemHang.Text = "Đóng";
            this.btnHuyThemHang.UseVisualStyleBackColor = true;
            this.btnHuyThemHang.Click += new System.EventHandler(this.btnHuyThemHang_Click);
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
            // frmXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 439);
            this.Controls.Add(this.btnHuyThemHang);
            this.Controls.Add(this.btnThemMoiHang);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grvKQTimKiem);
            this.Controls.Add(this.txtTimKiemSP);
            this.Controls.Add(this.btnTimKiem);
            this.Name = "frmXuatHang";
            this.Text = "frmXuatHang";
            this.Load += new System.EventHandler(this.frmXuatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvKQTimKiem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiemSP;
        private System.Windows.Forms.DataGridView grvKQTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoLuongMua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemMoiHang;
        private System.Windows.Forms.Button btnHuyThemHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTon;
    }
}