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
<<<<<<< HEAD
=======
<<<<<<< HEAD

=======
>>>>>>> refs/remotes/origin/master
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
<<<<<<< HEAD
=======

>>>>>>> refs/remotes/origin/master
        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
<<<<<<< HEAD
        private void grvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                cbnNhaCC.DataSource = db.NHACUNGCAPs;
                cbnNhaCC.DisplayMember = "tennhacungcap";
                cbnNhaCC.ValueMember = "id_nhacungcap";
                txtTenSP.Text = grvSanPham.SelectedCells[0].OwningRow.Cells["tensp"].Value.ToString();
                cbnNhaCC.Text = grvSanPham.SelectedCells[0].OwningRow.Cells["tenncc"].Value.ToString();
                txtMota.Text = grvSanPham.SelectedCells[0].OwningRow.Cells["Mota"].Value == null ? null : grvSanPham.SelectedCells[0].OwningRow.Cells["Mota"].Value.ToString();
                txtSoLuong.Text = grvSanPham.SelectedCells[0].OwningRow.Cells["sluong"].Value == null ? null : grvSanPham.SelectedCells[0].OwningRow.Cells["sluong"].Value.ToString();
                txtGiaBan.Text = grvSanPham.SelectedCells[0].OwningRow.Cells["Dongia"].Value == null ? null : grvSanPham.SelectedCells[0].OwningRow.Cells["Dongia"].Value.ToString();
                txtDonVT.Text = grvSanPham.SelectedCells[0].OwningRow.Cells["donvt"].Value == null ? null : grvSanPham.SelectedCells[0].OwningRow.Cells["donvt"].Value.ToString();


            }
        }
=======
>>>>>>> refs/remotes/origin/master
>>>>>>> refs/remotes/origin/master
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
        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                string id = grvSanPham.SelectedCells[0].OwningRow.Cells["id_sp"].Value.ToString();
                int idSP = Convert.ToInt32(id);
                HANGHOA sp = db.HANGHOAs.Where(n => n.id_hanghoa == idSP).SingleOrDefault();
                db.HANGHOAs.DeleteOnSubmit(sp);
                db.SubmitChanges();
            }
            LoadSanPham();
        }
        private void grvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                cbnNhaCC.DataSource = db.NHACUNGCAPs;
                cbnNhaCC.DisplayMember = "tennhacungcap";
                cbnNhaCC.ValueMember = "id_nhacungcap";
                txtTenSP.Text = grvSanPham.SelectedCells[0].OwningRow.Cells["tensp"].Value.ToString();
                cbnNhaCC.Text = grvSanPham.SelectedCells[0].OwningRow.Cells["tenncc"].Value.ToString();
                txtMota.Text = grvSanPham.SelectedCells[0].OwningRow.Cells["Mota"].Value == null ? null : grvSanPham.SelectedCells[0].OwningRow.Cells["Mota"].Value.ToString();
                txtSoLuong.Text = grvSanPham.SelectedCells[0].OwningRow.Cells["sluong"].Value == null ? null : grvSanPham.SelectedCells[0].OwningRow.Cells["sluong"].Value.ToString();
                txtGiaBan.Text = grvSanPham.SelectedCells[0].OwningRow.Cells["Dongia"].Value == null ? null : grvSanPham.SelectedCells[0].OwningRow.Cells["Dongia"].Value.ToString();
                txtDonVT.Text = grvSanPham.SelectedCells[0].OwningRow.Cells["donvt"].Value == null ? null : grvSanPham.SelectedCells[0].OwningRow.Cells["donvt"].Value.ToString();


            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                int id = (int)grvSanPham.SelectedCells[0].OwningRow.Cells["id_sp"].Value;
                HANGHOA sp = db.HANGHOAs.Where(n => n.id_hanghoa == id).SingleOrDefault();
                sp.tenhanghoa = txtTenSP.Text;
                int id_ncc = (int)cbnNhaCC.SelectedValue;
                sp.id_nhacungcap = id_ncc;
                sp.mota = txtMota.Text;
                sp.giaban = txtGiaBan.Text;
                sp.donvitinh = txtDonVT.Text;
                sp.soluongton = Convert.ToInt32(txtSoLuong.Text);
                db.SubmitChanges();

            }
            LoadSanPham();
        }
        //Nhà cung cấp
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
        private void grvNhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDNCC.Text = grvNhaCC.SelectedCells[0].OwningRow.Cells["id_nhacungcap"].Value.ToString();
            txtTenNCC.Text = grvNhaCC.SelectedCells[0].OwningRow.Cells["tennhacungcap"].Value.ToString();
            txtDiaChiNCC.Text = grvNhaCC.SelectedCells[0].OwningRow.Cells["diachi"].Value.ToString();
        }
>>>>>>> refs/remotes/origin/master
        private void btnTimKiemNCC_Click(object sender, EventArgs e)
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                grvNhaCC.DataSource = from ncc in db.NHACUNGCAPs where ncc.tennhacungcap.Contains(txtTimKiemNCC.Text) select ncc;
            }
        }
>>>>>>> refs/remotes/origin/master
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
<<<<<<< HEAD

=======
<<<<<<< HEAD
        private void btnThoatNCC_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void grvNhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDNCC.Text = grvNhaCC.SelectedCells[0].OwningRow.Cells["id_nhacungcap"].Value.ToString();
            txtTenNCC.Text = grvNhaCC.SelectedCells[0].OwningRow.Cells["tennhacungcap"].Value.ToString();
            txtDiaChiNCC.Text = grvNhaCC.SelectedCells[0].OwningRow.Cells["diachi"].Value.ToString();
        }
=======

>>>>>>> refs/remotes/origin/master
>>>>>>> refs/remotes/origin/master
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
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> refs/remotes/origin/master

=======
        private void btnThoatNCC_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
>>>>>>> refs/remotes/origin/master
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
<<<<<<< HEAD
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                NHANVIEN nv = new NHANVIEN();
                nv.tennhanvien = txtTenNhanVien.Text;
                nv.diachi = txtDiaChiNV.Text;
                nv.taikhoan = txtTaiKhoan.Text;
                nv.matkhau = txtMatKhau.Text;
                nv.id_loainv = 2;
                db.NHANVIENs.InsertOnSubmit(nv);
                db.SubmitChanges();
                MessageBox.Show("Thành Công");
            }
            LoadNhanVien();
        }
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
       
=======
        private void btnThoatNV_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
>>>>>>> refs/remotes/origin/master
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
<<<<<<< HEAD

        
=======
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                NHANVIEN nv = new NHANVIEN();
                nv.tennhanvien = txtTenNhanVien.Text;
                nv.diachi = txtDiaChiNV.Text;
                nv.taikhoan = txtTaiKhoan.Text;
                nv.matkhau = txtMatKhau.Text;
                nv.id_loainv = 2;
                db.NHANVIENs.InsertOnSubmit(nv);
                db.SubmitChanges();
                MessageBox.Show("Thành Công");
            }
            LoadNhanVien();
        }
>>>>>>> refs/remotes/origin/master
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
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
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
        private void btnThemHD_Click(object sender, EventArgs e)
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {

            }
        }

        private void btnTimHD_Click(object sender, EventArgs e)
        {

        }
>>>>>>> refs/remotes/origin/master
>>>>>>> refs/remotes/origin/master
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
