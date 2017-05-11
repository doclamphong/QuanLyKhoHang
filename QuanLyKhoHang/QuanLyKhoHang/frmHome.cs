using System;
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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            CheckTab();
        }
        public void CheckTab()
        {
            if (tabControl.SelectedIndex == 0)
            {
                LoadXuatHang();
            }
            else if (tabControl.SelectedIndex == 1)
            {

            }
            else if (tabControl.SelectedIndex == 2)
            {
                LoadSanPham();

            }
            else if (tabControl.SelectedIndex == 3)
            {
                LoadNhaCungCap();
            }
            else if (tabControl.SelectedIndex == 4)
            {
                LoadNhanVien();
            }
        }

        private void tabControl_Click(object sender, EventArgs e)
        {
            CheckTab();
        }
        //Sản phẩm
        private void btnThem_Click(object sender, EventArgs e)
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                HANGHOA sp = new HANGHOA();
                sp.tenhanghoa = txtTenSP.Text;
                int id_ncc = (int)cbnNhaCC.SelectedValue;
                sp.id_nhacungcap = id_ncc;
                sp.mota = txtMota.Text;
                sp.giaban = txtGiaBan.Text;
                sp.donvitinh = txtDonVT.Text;
                sp.soluongton = Convert.ToInt32(txtSoLuong.Text);
                db.HANGHOAs.InsertOnSubmit(sp);
                db.SubmitChanges();
                MessageBox.Show("Thành công");
            }
            LoadSanPham();
        }
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void LoadSanPham()
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                cbnNhaCC.DataSource = db.NHACUNGCAPs;
                cbnNhaCC.DisplayMember = "tennhacungcap";
                cbnNhaCC.ValueMember = "id_nhacungcap";
                grvSanPham.DataSource = from sp in db.HANGHOAs
                                        from ncc in db.NHACUNGCAPs
                                        where sp.id_nhacungcap == ncc.id_nhacungcap
                                        select new
                                        {
                                            id_sp = sp.id_hanghoa,
                                            tensp = sp.tenhanghoa,
                                            tenncc = ncc.tennhacungcap,
                                            mota = sp.mota,
                                            sluong = sp.soluongton,
                                            dongia = sp.giaban,
                                            donvt = sp.donvitinh
                                        };
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                grvSanPham.DataSource = from sp in db.HANGHOAs
                                        from ncc in db.NHACUNGCAPs
                                        where sp.id_nhacungcap == ncc.id_nhacungcap && sp.tenhanghoa.Contains(txtTiemKiem.Text)
                                        select new
                                        {
                                            id_sp = sp.id_hanghoa,
                                            tensp = sp.tenhanghoa,
                                            tenncc = ncc.tennhacungcap,
                                            mota = sp.mota,
                                            sluong = sp.soluongton,
                                            dongia = sp.giaban,
                                            donvt = sp.donvitinh
                                        };
            }
        }


        //Nhà cung cấp
        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                NHACUNGCAP nhacc = new NHACUNGCAP();
                nhacc.tennhacungcap = txtTenNCC.Text;
                nhacc.diachi = txtDiaChiNCC.Text;
                db.NHACUNGCAPs.InsertOnSubmit(nhacc);
                db.SubmitChanges();
                MessageBox.Show("Thành Công");
            }
            LoadNhaCungCap();
        }

        private void btnSuaNCC_Click(object sender, EventArgs e)
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                int id = (int)grvNhaCC.SelectedCells[0].OwningRow.Cells["id_nhacungcap"].Value;
                NHACUNGCAP nhacc = db.NHACUNGCAPs.Where(n => n.id_nhacungcap == id).SingleOrDefault();
                nhacc.tennhacungcap = txtTenNCC.Text;
                nhacc.diachi = txtDiaChiNCC.Text;
                db.SubmitChanges();
                MessageBox.Show("Thành Công");
            }
            LoadNhaCungCap();
        }
        public void LoadNhaCungCap()
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                grvNhaCC.DataSource = from ncc in db.NHACUNGCAPs select ncc;
            }
        }
        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                int id = (int)grvNhaCC.SelectedCells[0].OwningRow.Cells["id_nhacungcap"].Value;
                NHACUNGCAP nhacc = db.NHACUNGCAPs.Where(n => n.id_nhacungcap == id).SingleOrDefault();
                db.NHACUNGCAPs.DeleteOnSubmit(nhacc);
                db.SubmitChanges();
            }
            LoadNhaCungCap();
        }

        //Nhân viên
        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                int id = (int)grvNhanVien.SelectedCells[0].OwningRow.Cells["id_nhanvien"].Value;
                NHANVIEN nv = db.NHANVIENs.Where(n => n.id_nhanvien == id).SingleOrDefault();
                nv.tennhanvien = txtTenNhanVien.Text;
                nv.diachi = txtDiaChiNV.Text;
                nv.taikhoan = txtTaiKhoan.Text;
                nv.matkhau = txtMatKhau.Text;
                db.SubmitChanges();
                MessageBox.Show("Thành công");
            }
            LoadNhanVien();
        }
        public void LoadNhanVien()
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                grvNhanVien.DataSource = from nv in db.NHANVIENs
                                         where nv.id_loainv == 2
                                         select new
                                         {
                                             id_nhanvien = nv.id_nhanvien,
                                             tennhanvien = nv.tennhanvien,
                                             diachi = nv.diachi,
                                             taikhoan = nv.taikhoan,
                                             matkhau = nv.matkhau
                                         };
            }
        }
        private void btnTimKiemNV_Click(object sender, EventArgs e)
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                grvNhanVien.DataSource = from nv in db.NHANVIENs
                                         where nv.tennhanvien.Contains(txtTimKiemNV.Text)
                                         select new
                                         {
                                             id_nhanvien = nv.id_nhanvien,
                                             tennhanvien = nv.tennhanvien,
                                             diachi = nv.diachi,
                                             taikhoan = nv.taikhoan,
                                             matkhau = nv.matkhau
                                         };
            }
        }
		private void btnXoaNV_Click(object sender, EventArgs e)
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                int id = (int)grvNhanVien.SelectedCells[0].OwningRow.Cells["id_nhanvien"].Value;
                NHANVIEN nv = db.NHANVIENs.Where(n => n.id_nhanvien == id).SingleOrDefault();
                db.NHANVIENs.DeleteOnSubmit(nv);
                db.SubmitChanges();
                MessageBox.Show("Xóa Thành Công");
            }
            LoadNhanVien();
        }
        //Xuất hàng
        private void grvXuatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                txtIDHoaDon.Text = grvXuatHang.SelectedCells[0].OwningRow.Cells["IDDONHANG"].Value.ToString();
                txtTenKH.Text = grvXuatHang.SelectedCells[0].OwningRow.Cells["TENKH"].Value.ToString();
                txtSoDT.Text = grvXuatHang.SelectedCells[0].OwningRow.Cells["SODT"].Value.ToString();
                txtDiaChi.Text = grvXuatHang.SelectedCells[0].OwningRow.Cells["DIACHIKH"].Value.ToString();
                DateTime dt = (DateTime)grvXuatHang.SelectedCells[0].OwningRow.Cells["NGAYXUATHANG"].Value;
                dtpNgayXuat.Value = dt;
                int id = (int)grvXuatHang.SelectedCells[0].OwningRow.Cells["IDDONHANG"].Value;
                grvCTXuatHang.DataSource = from xh in db.PHIEUXUATs
                                           from sp in db.HANGHOAs
                                           from ctpx in db.CT_PHIEUXUATs
                                           where xh.id_phieuxuat == ctpx.id_phieuxuat && ctpx.id_hanghoa == sp.id_hanghoa && xh.id_phieuxuat == id
                                           select new
                                           {
                                               IDSANPHAM = sp.id_hanghoa,
                                               TENSANPHAM = sp.tenhanghoa,
                                               SOLUONG = ctpx.soluongxuat,
                                               DGIA = sp.giaban,
                                               DVTINH = sp.donvitinh,
                                               THANHTIEN = Convert.ToInt32(sp.giaban) * ctpx.soluongxuat
                                           };
            }
        }
        private void btnThemHang_Click(object sender, EventArgs e)
        {
            int idDH;
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                idDH = (int)grvXuatHang.SelectedCells[0].OwningRow.Cells["IDDONHANG"].Value;
            }
            frmXuatHang xuathang = new frmXuatHang(idDH);
            xuathang.ShowDialog();

        }
        private void btnSuaHang_Click(object sender, EventArgs e)
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                int idPX = (int)grvXuatHang.SelectedCells[0].OwningRow.Cells["IDDONHANG"].Value;
                int idSP = (int)grvCTXuatHang.SelectedCells[0].OwningRow.Cells["IDSANPHAM"].Value;
                CT_PHIEUXUAT ct = (from ctpx in db.CT_PHIEUXUATs where ctpx.id_hanghoa == idSP && ctpx.id_phieuxuat == idPX select ctpx).SingleOrDefault();
                if (txtSoLuongMua.Text == "")
                {
                    ct.soluongxuat = 1;
                }
                else
                {
                    ct.soluongxuat = Convert.ToInt32(txtSoLuongMua.Text);
                }
                db.SubmitChanges();
                MessageBox.Show("Sửa Thành Công .");
            }
            LoadXuatHang();
        }
        private void grvCTXuatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMSP.Text = grvCTXuatHang.SelectedCells[0].OwningRow.Cells["IDSANPHAM"].Value.ToString();
            txtTSP.Text = grvCTXuatHang.SelectedCells[0].OwningRow.Cells["TENSANPHAM"].Value.ToString();
            txtSoLuongMua.Text = grvCTXuatHang.SelectedCells[0].OwningRow.Cells["SOLUONG"].Value.ToString();
        }
        private void btnXoaHang_Click(object sender, EventArgs e)
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                int idPX = (int)grvXuatHang.SelectedCells[0].OwningRow.Cells["IDDONHANG"].Value;
                int idSP = (int)grvCTXuatHang.SelectedCells[0].OwningRow.Cells["IDSANPHAM"].Value;
                CT_PHIEUXUAT ct = (from ctpx in db.CT_PHIEUXUATs where ctpx.id_hanghoa == idSP && ctpx.id_phieuxuat == idPX select ctpx).SingleOrDefault();
                db.CT_PHIEUXUATs.DeleteOnSubmit(ct);
                db.SubmitChanges();
                MessageBox.Show("Xóa Thành Công");
                //grvCTXuatHang.DataSource = null;
            }
            LoadXuatHang();
        }
        public void LoadXuatHang()
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                grvXuatHang.DataSource = from xh in db.PHIEUXUATs
                                         from nv in db.NHANVIENs
                                         where xh.id_nhanvien == nv.id_nhanvien
                                         select new
                                         {
                                             IDDONHANG = xh.id_phieuxuat,
                                             TENKH = xh.TenKH,
                                             SODT = xh.SoDT,
                                             DIACHIKH = xh.DiaChiKH,
                                             TENNV = nv.tennhanvien,
                                             NGAYXUATHANG = xh.ngayxuat
                                         };
            }

        }

    }

}
