using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhoHang.Entity;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyKhoHang.DataAccessLayer
{
    class NhanVienDAL
    {
        public List<NhanVien> GetAll()
        {
            List<NhanVien> listNhanVien = new List<NhanVien>();
            using (SqlDataReader dr = SqlHelper.ExecuteReader("SELECT id_nhanvien,tennhanvien,diachi,taikhoan,matkhau FROM NHANVIEN"))
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        //NhanVien nv = new NhanVien();
                        //nv.set_idNhanVien(Convert.ToInt32(dr["id_nhanvien"]));
                        listNhanVien.Add(new NhanVien()
                        {
                            _idNhanVien = Convert.ToInt32(dr["id_nhanvien"].ToString()),
                            _tenNhanVien = dr["tennhanvien"].ToString(),
                            _diaChi = dr["diachi"].ToString(),
                            _taiKhoan = dr["taikhoan"].ToString(),
                            _matKhau = dr["matkhau"].ToString()
                        });
                    }
                }
            }
            return listNhanVien;
        }
        public NhanVien GetNhanVien(int id_nhanvien)
        {
            using (SqlDataReader dr = SqlHelper.ExecuteReader("Select id_nhanvien,tennhanvien,diachi,taikhoan,matkhau from NHANVIEN where id_nhanvien =@id_nhanvien",new SqlParameter("@id_nhanvien", id_nhanvien)))
            {
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        return new NhanVien() {
                            _idNhanVien = Convert.ToInt32(dr["id_nhanvien"].ToString()),
                            _tenNhanVien = dr["tennhanvien"].ToString(),
                            _taiKhoan = dr["taikhoan"].ToString(),
                            _matKhau = dr["matkhau"].ToString()

                        };

                    }
                }
            }
                return null;
        }
        public int Insert(NhanVien nhanvien)
        {
            string query = "INSERT INTO NHANVIEN(tennhanvien,diachi,taikhoan,matkhau) VALUES (@tennhanvien,@diachi,@taikhoan,@matkhau)";
            SqlParameter[] listParameter = { new SqlParameter("@tennhanvien",nhanvien._tenNhanVien),
                                                new SqlParameter("@diachi",nhanvien._diaChi),
                                                new SqlParameter("@taikhoan",nhanvien._taiKhoan),
                                                new SqlParameter("@matkhau",nhanvien._matKhau)}; 
            return SqlHelper.ExecuteCommand(query,listParameter);
        }
        public int Update(NhanVien nhanvien)
        {
            return 0;
        }
        public int Insert(int id_nhanvien)
        {
            return 0;
        }
    }
}
