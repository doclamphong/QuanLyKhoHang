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
        //Nhà cung cấp

        public void LoadNhaCungCap()
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                grvNhaCC.DataSource = from ncc in db.NHACUNGCAPs select ncc;
            }
        }

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
        //Xuất hàng
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
