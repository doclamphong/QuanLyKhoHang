using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang.Entity
{
    public class NhanVien
    {
        public int _idNhanVien { get; set; }
        public int get_idNhanVien()
        {
            return _idNhanVien;
        }
        public int set_idNhanVien(int value)
        {
            _idNhanVien = value;
            return _idNhanVien;
        }

        public string _tenNhanVien { get; set; }
        public string _diaChi { get; set; }
        public string _taiKhoan { get; set; }
        public string _matKhau { get; set; }
    }
}
