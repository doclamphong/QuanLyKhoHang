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
                LoadNhapHang();
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

        #region Sản phẩm Of Văn Đại
        //Sản phẩm
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
        private void btnSanPham_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Nhà cung cấp Of Nguyễn Trang
        //Nhà cung cấp
        public void LoadNhaCungCap()
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                grvNhaCC.DataSource = from ncc in db.NHACUNGCAPs select ncc;
            }
        }
        private void grvNhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDNCC.Text = grvNhaCC.SelectedCells[0].OwningRow.Cells["id_nhacungcap"].Value.ToString();
            txtTenNCC.Text = grvNhaCC.SelectedCells[0].OwningRow.Cells["tennhacungcap"].Value.ToString();
            txtDiaChiNCC.Text = grvNhaCC.SelectedCells[0].OwningRow.Cells["diachi"].Value.ToString();
        }
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
        private void btnTimKiemNCC_Click(object sender, EventArgs e)
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                grvNhaCC.DataSource = from ncc in db.NHACUNGCAPs where ncc.tennhacungcap.Contains(txtTimKiemNCC.Text) select ncc;
            }
        }

        private void btnThoatNCC_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        #endregion

        #region Nhân Viên Of Lê Kim Huệ

        //Nhân viên
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
        private void grvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                txtTenNhanVien.Text = grvNhanVien.SelectedCells[0].OwningRow.Cells["tennhanvien"].Value.ToString();
                txtDiaChiNV.Text = grvNhanVien.SelectedCells[0].OwningRow.Cells["diachinhanvien"].Value.ToString();
                txtTaiKhoan.Text = grvNhanVien.SelectedCells[0].OwningRow.Cells["taikhoan"].Value.ToString();
                txtMatKhau.Text = grvNhanVien.SelectedCells[0].OwningRow.Cells["matkhau"].Value.ToString();
            }
        }
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
        private void btnThoatNV_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Xuất Hàng
        //Xuất hàng
        public void LoadXuatHang()
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                cbbPX_NHANVIEN.DataSource = db.NHANVIENs;
                cbbPX_NHANVIEN.DisplayMember = "tennhanvien";
                cbbPX_NHANVIEN.ValueMember = "id_nhanvien";
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

        private void grvXuatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                cbbPX_NHANVIEN.DataSource = db.NHANVIENs;
                cbbPX_NHANVIEN.DisplayMember = "tennhanvien";
                cbbPX_NHANVIEN.ValueMember = "id_nhanvien";
                txtIDHoaDon.Text = grvXuatHang.SelectedCells[0].OwningRow.Cells["IDDONHANG"].Value.ToString();
                txtTenKH.Text = grvXuatHang.SelectedCells[0].OwningRow.Cells["TENKH"].Value.ToString();
                txtSoDT.Text = grvXuatHang.SelectedCells[0].OwningRow.Cells["SODT"].Value.ToString();
                txtDiaChi.Text = grvXuatHang.SelectedCells[0].OwningRow.Cells["DIACHIKH"].Value.ToString();
                DateTime dt = (DateTime)grvXuatHang.SelectedCells[0].OwningRow.Cells["NGAYXUATHANG"].Value;
                cbbPX_NHANVIEN.Text = grvXuatHang.SelectedCells[0].OwningRow.Cells["TENNV"].Value.ToString();
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
        private void grvCTXuatHang_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtMSP.Text = grvCTXuatHang.SelectedCells[0].OwningRow.Cells["IDSANPHAM"].Value.ToString();
            txtTSP.Text = grvCTXuatHang.SelectedCells[0].OwningRow.Cells["TENSANPHAM"].Value.ToString();
            txtSoLuongMua.Text = grvCTXuatHang.SelectedCells[0].OwningRow.Cells["SOLUONG"].Value.ToString();
        }
        //Chi Tiết Phiếu Xuất Hàng
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
                HANGHOA sp = db.HANGHOAs.Single(n => n.id_hanghoa == idSP);
                if (txtSoLuongMua.Text == "")
                {
                    ct.soluongxuat = 1;
                }
                else
                {
                    string a = txtSoLuongMua.Text;
                    int sl = Convert.ToInt32(a);
                    if (sl > sp.soluongton)
                    {
                        MessageBox.Show("Số lượng quá lớn so với lượng hàng còn");

                    }
                    else
                    {
                        ct.soluongxuat = sl;
                        sp.soluongton -= sl;
                        db.SubmitChanges();
                        MessageBox.Show("Sửa Thành Công .");
                    }
                }
            }
            LoadXuatHang();
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
            }
            LoadXuatHang();
        }
        //Phiếu Xuất Hàng
        private void btnThemHD_Click(object sender, EventArgs e)
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                PHIEUXUAT px = new PHIEUXUAT();
                px.ngayxuat = dtpNgayXuat.Value;
                px.TenKH = txtTenKH.Text;
                px.DiaChiKH = txtDiaChi.Text;
                px.SoDT = txtSoDT.Text;
                px.id_nhanvien = (int)cbbPX_NHANVIEN.SelectedValue;
                db.PHIEUXUATs.InsertOnSubmit(px);
                db.SubmitChanges();
                MessageBox.Show("Thêm Thành Công ");
            }
            LoadXuatHang();
        }
        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                int idPX = (int)grvXuatHang.SelectedCells[0].OwningRow.Cells["IDDONHANG"].Value;
                PHIEUXUAT px = db.PHIEUXUATs.Where(n => n.id_phieuxuat == idPX).SingleOrDefault();
                px.TenKH = txtTenKH.Text;
                px.SoDT = txtSoDT.Text;
                px.DiaChiKH = txtDiaChi.Text;
                px.ngayxuat = dtpNgayXuat.Value;
                px.id_nhanvien = (int)cbbPX_NHANVIEN.SelectedValue;
                db.SubmitChanges();
            }
            LoadXuatHang();
        }
        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                int idPX = (int)grvXuatHang.SelectedCells[0].OwningRow.Cells["IDDONHANG"].Value;
                PHIEUXUAT px = db.PHIEUXUATs.Where(n => n.id_phieuxuat == idPX).SingleOrDefault();
                var delete = db.CT_PHIEUXUATs.Where(n => n.id_phieuxuat == idPX);
                db.CT_PHIEUXUATs.DeleteAllOnSubmit(delete);
                db.SubmitChanges();
                db.PHIEUXUATs.DeleteOnSubmit(px);
                db.SubmitChanges();
            }
            LoadXuatHang();
        }
        private void btnTimHD_Click(object sender, EventArgs e)
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {

                int seach = txtPX_TimKiem.Text == "" ? 0 : Convert.ToInt32(txtPX_TimKiem.Text);

                if (seach == 0)
                {
                    cbbPX_NHANVIEN.DataSource = db.NHANVIENs;
                    cbbPX_NHANVIEN.DisplayMember = "tennhanvien";
                    cbbPX_NHANVIEN.ValueMember = "id_nhanvien";
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
                else
                {
                    cbbPX_NHANVIEN.DataSource = db.NHANVIENs;
                    cbbPX_NHANVIEN.DisplayMember = "tennhanvien";
                    cbbPX_NHANVIEN.ValueMember = "id_nhanvien";
                    grvXuatHang.DataSource = from xh in db.PHIEUXUATs
                                             from nv in db.NHANVIENs
                                             where xh.id_nhanvien == nv.id_nhanvien && xh.id_phieuxuat==seach
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
        #endregion

        #region Phieu nhap hang 
        public void LoadNhapHang()
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                grvNhapHang.DataSource = from pn in db.PHIEUNHAPs
                                         from nv in db.NHANVIENs
                                         from ncc in db.NHACUNGCAPs
                                         where pn.id_nhacungcap == ncc.id_nhacungcap && pn.id_nhanvien == nv.id_nhanvien
                                         select new
                                         {
                                             idPhieuNhap = pn.id_phieunhap,
                                             PN_NCC = ncc.tennhacungcap,
                                             PN_NhanVien = nv.tennhanvien,
                                             PN_NgayNhap = pn.ngaynhap
                                         };
            }
        }
        private void grvNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {

                cbbNhapHangNCC.DataSource = db.NHACUNGCAPs;
                cbbNhapHangNCC.DisplayMember = "tennhacungcap";
                cbbNhapHangNCC.ValueMember = "id_nhacungcap";
                cbbNhapHangNV.DataSource = db.NHANVIENs;
                cbbNhapHangNV.DisplayMember = "tennhanvien";
                cbbNhapHangNV.ValueMember = "id_nhanvien";
                txtIDHDNHAP.Text = grvNhapHang.SelectedCells[0].OwningRow.Cells["idPhieuNhap"].Value.ToString();
                cbbNhapHangNCC.Text = grvNhapHang.SelectedCells[0].OwningRow.Cells["PN_NCC"].Value.ToString();
                DateTime dt = (DateTime)grvNhapHang.SelectedCells[0].OwningRow.Cells["PN_NgayNhap"].Value;
                dtpNhapHangNgayNhap.Value = dt;
                cbbNhapHangNV.Text = grvNhapHang.SelectedCells[0].OwningRow.Cells["PN_NhanVien"].Value.ToString();
                int id = (int)grvNhapHang.SelectedCells[0].OwningRow.Cells["idPhieuNhap"].Value;
                grvCHITIETNHAPHANG.DataSource = from ctnh in db.CT_PHIEUNHAPs
                                                from sp in db.HANGHOAs
                                                where ctnh.id_phieunhap == id && ctnh.id_hanghoa == sp.id_hanghoa
                                                select new
                                                {
                                                    id_SanPham = sp.id_hanghoa,
                                                    CTPN_TenSP = sp.tenhanghoa,
                                                    CTPN_SoLuong = ctnh.soluongnhap,
                                                    CTPN_GiaNhap = ctnh.gianhap
                                                };
            }
        }
        private void grvCHITIETNHAPHANG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCTPN_IDSANPHAM.Text = grvCHITIETNHAPHANG.SelectedCells[0].OwningRow.Cells["id_SanPham"].Value.ToString();
            txtCTNH_TenSP.Text = grvCHITIETNHAPHANG.SelectedCells[0].OwningRow.Cells["CTPN_TenSP"].Value.ToString();
            txtCTNH_SoLuong.Text = grvCHITIETNHAPHANG.SelectedCells[0].OwningRow.Cells["CTPN_SoLuong"].Value.ToString();
            txtCTNH_GiaNhap.Text = grvCHITIETNHAPHANG.SelectedCells[0].OwningRow.Cells["CTPN_GiaNhap"].Value == null ? "1000" : grvCHITIETNHAPHANG.SelectedCells[0].OwningRow.Cells["CTPN_GiaNhap"].Value.ToString();
        }
        //Phiếuu nhập :
        private void btnPN_ThemHD_Click(object sender, EventArgs e)
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                PHIEUNHAP phieuNhap = new PHIEUNHAP();
                phieuNhap.ngaynhap = dtpNhapHangNgayNhap.Value;
                phieuNhap.id_nhacungcap = (int)cbbNhapHangNCC.SelectedValue;
                phieuNhap.id_nhanvien = (int)cbbNhapHangNV.SelectedValue;
                db.PHIEUNHAPs.InsertOnSubmit(phieuNhap);
                db.SubmitChanges();
                MessageBox.Show("Thành Công");
            }
            LoadNhapHang();
        }

        private void btnPN_SuaHD_Click(object sender, EventArgs e)
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                int id = (int)grvNhapHang.SelectedCells[0].OwningRow.Cells["idPhieuNhap"].Value;
                PHIEUNHAP _pn = db.PHIEUNHAPs.Where(n => n.id_phieunhap == id).SingleOrDefault();
                _pn.id_nhacungcap = (int)cbbNhapHangNCC.SelectedValue;
                _pn.id_nhanvien = (int)cbbNhapHangNV.SelectedValue;
                _pn.ngaynhap = dtpNhapHangNgayNhap.Value;
                db.SubmitChanges();
                MessageBox.Show("Thành Công");
            }
            LoadNhapHang();
        }

        private void btnPN_XoaHD_Click(object sender, EventArgs e)
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                int id = (int)grvNhapHang.SelectedCells[0].OwningRow.Cells["idPhieuNhap"].Value;
                PHIEUNHAP _pn = db.PHIEUNHAPs.Where(n => n.id_phieunhap == id).SingleOrDefault();
                var delete = from ctpn in db.CT_PHIEUNHAPs where ctpn.id_phieunhap == id select ctpn;
                db.CT_PHIEUNHAPs.DeleteAllOnSubmit(delete);
                db.SubmitChanges();
                db.PHIEUNHAPs.DeleteOnSubmit(_pn);
                db.SubmitChanges();
                MessageBox.Show("Thành Công");
            }
            LoadNhapHang();
        }
        private void btnTimKiemPN_Click(object sender, EventArgs e)
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {

                int seach = txtPN_TimKiem.Text == "" ? 0 : Convert.ToInt32(txtPN_TimKiem.Text);

                if (seach == 0)
                {
                    grvNhapHang.DataSource = from pn in db.PHIEUNHAPs
                                             from nv in db.NHANVIENs
                                             from ncc in db.NHACUNGCAPs
                                             where pn.id_nhacungcap == ncc.id_nhacungcap && pn.id_nhanvien == nv.id_nhanvien
                                             select new
                                             {
                                                 idPhieuNhap = pn.id_phieunhap,
                                                 PN_NCC = ncc.tennhacungcap,
                                                 PN_NhanVien = nv.tennhanvien,
                                                 PN_NgayNhap = pn.ngaynhap
                                             };
                }
                else
                {
                    grvNhapHang.DataSource = from pn in db.PHIEUNHAPs
                                             from nv in db.NHANVIENs
                                             from ncc in db.NHACUNGCAPs
                                             where pn.id_nhacungcap == ncc.id_nhacungcap && pn.id_nhanvien == nv.id_nhanvien && pn.id_phieunhap == seach
                                             select new
                                             {
                                                 idPhieuNhap = pn.id_phieunhap,
                                                 PN_NCC = ncc.tennhacungcap,
                                                 PN_NhanVien = nv.tennhanvien,
                                                 PN_NgayNhap = pn.ngaynhap
                                             };
                }

            }
        }
        //CT_Phiếu nhập : 

        private void btnCTPN_ThemHang_Click(object sender, EventArgs e)
        {
            int idDH, idNCC;
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                idDH = (int)grvNhapHang.SelectedCells[0].OwningRow.Cells["idPhieuNhap"].Value;
                idNCC = (int)cbbNhapHangNCC.SelectedValue;
            }
            frmPN_ThemHang themhang = new frmPN_ThemHang(idDH, idNCC);
            themhang.ShowDialog();
        }

        private void btnCTPN_SuaHang_Click(object sender, EventArgs e)
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                int idPN = (int)grvNhapHang.SelectedCells[0].OwningRow.Cells["idPhieuNhap"].Value;
                int idSP = (int)grvCHITIETNHAPHANG.SelectedCells[0].OwningRow.Cells["id_SanPham"].Value;
                CT_PHIEUNHAP ctpn = db.CT_PHIEUNHAPs.Where(n => n.id_phieunhap == idPN && n.id_hanghoa == idSP).SingleOrDefault();
                ctpn.soluongnhap = Convert.ToInt32(txtCTNH_SoLuong.Text);
                int sl = Convert.ToInt32(txtCTNH_GiaNhap.Text);
                ctpn.gianhap = sl;
                HANGHOA sp = db.HANGHOAs.Where(n => n.id_hanghoa == idSP).SingleOrDefault();
                sp.soluongton += sl;
                db.SubmitChanges();
                MessageBox.Show("Sửa Thành Công ");
            }
        }

        private void btnCTPN_XoaHang_Click(object sender, EventArgs e)
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                int idPN = (int)grvNhapHang.SelectedCells[0].OwningRow.Cells["idPhieuNhap"].Value;
                int idSP = (int)grvCHITIETNHAPHANG.SelectedCells[0].OwningRow.Cells["id_SanPham"].Value;
                CT_PHIEUNHAP ctpn = db.CT_PHIEUNHAPs.Where(n => n.id_phieunhap == idPN && n.id_hanghoa == idSP).SingleOrDefault();
                int sl = Convert.ToInt32(txtCTNH_SoLuong.Text);
                HANGHOA sp = db.HANGHOAs.Single(n => n.id_hanghoa == idSP);
                sp.soluongton -= sl;
                db.CT_PHIEUNHAPs.DeleteOnSubmit(ctpn);
                db.SubmitChanges();
                MessageBox.Show("Xóa Thành Công ");
            }
        }

        private void btnPN_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion


    }

}
