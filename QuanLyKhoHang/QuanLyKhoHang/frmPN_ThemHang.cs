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
    public partial class frmPN_ThemHang : Form
    {
        CT_PHIEUNHAP ctPhieuNhap = null;
        int idNCC;
        public frmPN_ThemHang(int idPhieuNhap,int idncc)
        {
            CenterToParent();
            ctPhieuNhap = new CT_PHIEUNHAP();
            ctPhieuNhap.id_phieunhap = idPhieuNhap;
            idNCC = idncc;
            InitializeComponent();
        }

        private void frmPN_ThemHang_Load(object sender, EventArgs e)
        {
            LoadSanPham();
        }
        public void LoadSanPham()
        {
            using(DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                grvPN_KQTimKiem.DataSource = from sp in db.HANGHOAs where sp.id_nhacungcap == idNCC
                                             select new {
                                                 ID = sp.id_hanghoa,
                                                 TenSanPham = sp.tenhanghoa,
                                                 SoLuongTon = sp.soluongton
                                             } ;
            }
        }

        private void btnPN_TimKiem_Click(object sender, EventArgs e)
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                grvPN_KQTimKiem.DataSource = from sp in db.HANGHOAs select new {
                    ID = sp.id_hanghoa,
                    TenSanPham = sp.tenhanghoa,
                    SoLuongTon = sp.soluongton
                };
            }
                
        }

        private void btnPN_ThemMoiHang_Click(object sender, EventArgs e)
        {
            int id = ctPhieuNhap.id_phieunhap;
            int masp = Convert.ToInt32(txtPN_MaHang.Text);
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {

                CT_PHIEUNHAP ctphieunhap = db.CT_PHIEUNHAPs.Where(n => n.id_phieunhap == id && n.id_hanghoa == masp).SingleOrDefault();
                if (ctphieunhap != null)
                {
                    MessageBox.Show("Sản phẩm đã tồn tại trong đơn . Vui lòng chỉnh lại số lượng .");
                }
                else
                {
                    ctPhieuNhap.id_hanghoa = masp;
                    int sl = txtPN_SoLuongNhap.Text == null ? 0 : Convert.ToInt32(txtPN_SoLuongNhap.Text);
                    ctPhieuNhap.soluongnhap = sl;
                    ctPhieuNhap.gianhap = txtPN_GiaNhap.Text == null ? 500000 : Convert.ToInt32(txtPN_GiaNhap.Text);
                    HANGHOA sp = db.HANGHOAs.Where(n => n.id_hanghoa == masp).SingleOrDefault();
                    sp.soluongton += sl;
                    db.CT_PHIEUNHAPs.InsertOnSubmit(ctPhieuNhap);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm thành công");
                }
                
            }
        }

        private void btnPN_HuyThemHang_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grvPN_KQTimKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (DBKhoHangDataContext db = new DBKhoHangDataContext())
            {
                txtPN_MaHang.Text = grvPN_KQTimKiem.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString();
                txtPN_TenHang.Text = grvPN_KQTimKiem.SelectedCells[0].OwningRow.Cells["TenSanPham"].Value.ToString();
            }
        }
    }
}
