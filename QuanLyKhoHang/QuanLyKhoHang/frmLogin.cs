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
    public partial class frmLogin : Form
    {
        DBKhoHangDataContext db = null;
        public frmLogin()
        {
            this.CenterToScreen();
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            using (db = new DBKhoHangDataContext())
            {
                string us = txtUser.Text.Trim();
                string ps = txtPass.Text.Trim();
                //var rs = db.NHANVIENs.Where(n => n.taikhoan == us && n.matkhau == ps).SingleOrDefault();
                var rs = (from nv in db.NHANVIENs where nv.taikhoan == us && nv.matkhau == ps select nv).Skip(0).Take(1);

                if (rs != null)
                {
                    frmHome home = new frmHome();
                    home.Show();
                    this.Visible = true;
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng. Vui lòng nhập lại !");
                }

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
