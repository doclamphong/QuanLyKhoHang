﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang
{
    public partial class frmXuatHang : Form
    {
        CT_PHIEUXUAT ctphieuxuat = null;

        public frmXuatHang(int idMaHD)
        {
            CenterToParent();
            ctphieuxuat = new CT_PHIEUXUAT();
            ctphieuxuat.id_phieuxuat = idMaHD;
            InitializeComponent();
        }
        private void frmXuatHang_Load(object sender, EventArgs e)
        {
            LoadSanPham();
        }
        private void btnThemMoiHang_Click(object sender, EventArgs e)
        {
            int id = ctphieuxuat.id_phieuxuat;
            int idhh = Convert.ToInt32(txtMaHang.Text);
           
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                CT_PHIEUXUAT ctpx1 = db.CT_PHIEUXUATs.Where(n => n.id_phieuxuat == id && n.id_hanghoa == idhh).SingleOrDefault();
                HANGHOA sp = db.HANGHOAs.Where(n => n.id_hanghoa == idhh).SingleOrDefault();
                if (ctpx1 != null)
                {
                    MessageBox.Show("Sản phẩm đã tồn tại trong đơn . Vui lòng chỉnh lại số lượng .");
                }
                else
                {
                   // ctphieuxuat.id_hanghoa = Convert.ToInt32(txtMaHang.Text);
                    string a = txtSoLuongMua.Text;
                    if (a == "")
                    {
                        ctphieuxuat.id_hanghoa = idhh;
                        ctphieuxuat.soluongxuat = 1;
                        sp.soluongton -= 1;
                        db.CT_PHIEUXUATs.InsertOnSubmit(ctphieuxuat);
                        db.SubmitChanges();
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        int sl = Convert.ToInt32(a);
                        if (sl > sp.soluongton)
                        {
                            MessageBox.Show("Số lượng quá lớn so với lượng hàng còn");

                        }
                        else
                        {
                            ctphieuxuat.id_hanghoa = idhh;
                            ctphieuxuat.soluongxuat = sl;
                            sp.soluongton -= sl;
                            db.CT_PHIEUXUATs.InsertOnSubmit(ctphieuxuat);
                            db.SubmitChanges();
                            MessageBox.Show("Thêm thành công");
                        }
                    }
                }
            }
            //this.Close();
            //frmHome f = new frmHome();
            //f.Show();

        }

        public void LoadSanPham()
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                grvKQTimKiem.DataSource = from sp in db.HANGHOAs
                                          select new
                                          {
                                              ID = sp.id_hanghoa,
                                              TenSanPham = sp.tenhanghoa,
                                              SoLuongTon = sp.soluongton
                                          };
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {

                grvKQTimKiem.DataSource = from sp in db.HANGHOAs
                                          where sp.tenhanghoa.Contains(txtTimKiemSP.Text)
                                          select new
                                          {
                                              ID = sp.id_hanghoa,
                                              TenSanPham = sp.tenhanghoa,
                                              SoLuongTon = sp.soluongton
                                          };
            }
        }

        private void grvKQTimKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                txtMaHang.Text = grvKQTimKiem.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString();
                txtTenHang.Text = grvKQTimKiem.SelectedCells[0].OwningRow.Cells["TenSanPham"].Value.ToString();
            }
        }

        private void btnHuyThemHang_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
