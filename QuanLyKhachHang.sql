--Tạo database
USE master
GO
CREATE DATABASE QuanLyKhoHang;

--Sử dụng database
GO
USE QuanLyKhoHang;
--Tạo bảng: 
GO
CREATE TABLE NHANVIEN (id_nhanvien int NOT NULL PRIMARY KEY IDENTITY(1,1) ,
						tennhanvien nvarchar(50),
						diachi nvarchar(50),
						taikhoan varchar(50) NOT NULL ,
						matkhau varchar(50) NOT NULL);
GO
INSERT INTO NHANVIEN(tennhanvien,diachi,taikhoan,matkhau) VALUES(N'Nguyễn Hoàn',N'Bắc Ninh','hoanns','123456');
INSERT INTO NHANVIEN(tennhanvien,diachi,taikhoan,matkhau) VALUES(N'Nguyễn Thảo',N'Từ Sơn','hoanns','123456');
INSERT INTO NHANVIEN(tennhanvien,diachi,taikhoan,matkhau) VALUES(N'Nguyễn Hiền',N'Gia Bình','banana','123456');
INSERT INTO NHANVIEN(tennhanvien,diachi,taikhoan,matkhau) VALUES(N'Nguyễn Tùng',N'Quế Võ','ahihi','123456');
INSERT INTO NHANVIEN(tennhanvien,diachi,taikhoan,matkhau) VALUES(N'Nguyễn Cúc',N'Thuận Thành','keke','123456');
INSERT INTO NHANVIEN(tennhanvien,diachi,taikhoan,matkhau) VALUES(N'Nguyễn Trúc',N'Hải Dương','haha','123456');
INSERT INTO NHANVIEN(tennhanvien,diachi,taikhoan,matkhau) VALUES(N'Nguyễn Mai',N'Bắc Ninh','hihi','123456');
INSERT INTO NHANVIEN(tennhanvien,diachi,taikhoan,matkhau) VALUES(N'Tư Huỳnh',N'Kim Thành','hoanns','123456');
INSERT INTO NHANVIEN(tennhanvien,diachi,taikhoan,matkhau) VALUES(N'Thành Luân',N'Hải Phòng','hoanns','123456');
INSERT INTO NHANVIEN(tennhanvien,diachi,taikhoan,matkhau) VALUES(N'Như Hai',N'Cầu Giấy','hoanns','123456');
INSERT INTO NHANVIEN(tennhanvien,diachi,taikhoan,matkhau) VALUES(N'Sơn Tùng',N'Ba Đình','hoanns','123456');
INSERT INTO NHANVIEN(tennhanvien,diachi,taikhoan,matkhau) VALUES(N'Nhật Minh',N'Ninh Giang','hoanns','123456');
GO
CREATE TABLE NHACUNGCAP (id_nhacungcap int NOT NULL PRIMARY KEY IDENTITY(1,1),
							tennhacungcap nvarchar(100),
							diachi nvarchar(200));
GO
INSERT INTO NHACUNGCAP(tennhacungcap,diachi) VALUES (N'NOKIA',N'Hà Nội')
INSERT INTO NHACUNGCAP(tennhacungcap,diachi) VALUES (N'SAMSUNG',N'Hà Nội')
INSERT INTO NHACUNGCAP(tennhacungcap,diachi) VALUES (N'IPHONE',N'Hà Nội')
INSERT INTO NHACUNGCAP(tennhacungcap,diachi) VALUES (N'HP ELITEBOOK',N'Hà Nội')
INSERT INTO NHACUNGCAP(tennhacungcap,diachi) VALUES (N'DELL',N'Hà Nội')
INSERT INTO NHACUNGCAP(tennhacungcap,diachi) VALUES (N'ASUS',N'Hà Nội')
INSERT INTO NHACUNGCAP(tennhacungcap,diachi) VALUES (N'OPPO',N'Hà Nội')
INSERT INTO NHACUNGCAP(tennhacungcap,diachi) VALUES (N'CAMRY',N'Hà Nội')
INSERT INTO NHACUNGCAP(tennhacungcap,diachi) VALUES (N'LG SMART TV',N'Hà Nội')
INSERT INTO NHACUNGCAP(tennhacungcap,diachi) VALUES (N'SƠN HÀ',N'Hà Nội')
INSERT INTO NHACUNGCAP(tennhacungcap,diachi) VALUES (N'HP PROBOOK',N'Hà Nội')
INSERT INTO NHACUNGCAP(tennhacungcap,diachi) VALUES (N'TÔN ĐÔNG Á',N'Hà Nội')

GO
CREATE TABLE HANGHOA (id_hanghoa int NOT NULL PRIMARY KEY IDENTITY(1,1), 
					tenhanghoa nvarchar(50),
					donvitinh nvarchar(30),
					id_nhacungcap int references NHACUNGCAP(id_nhacungcap));

GO
INSERT INTO HANGHOA(tenhanghoa,donvitinh,id_nhacungcap) VALUES (N'EliteBook 8460',N'Chiếc',1)
INSERT INTO HANGHOA(tenhanghoa,donvitinh,id_nhacungcap) VALUES (N'Iphone 4',N'Chiếc',2)
INSERT INTO HANGHOA(tenhanghoa,donvitinh,id_nhacungcap) VALUES (N'Iphone 4S',N'Chiếc',2)
INSERT INTO HANGHOA(tenhanghoa,donvitinh,id_nhacungcap) VALUES (N'Iphone 5',N'Chiếc',3)
INSERT INTO HANGHOA(tenhanghoa,donvitinh,id_nhacungcap) VALUES (N'Iphone 5S',N'Chiếc',4)
INSERT INTO HANGHOA(tenhanghoa,donvitinh,id_nhacungcap) VALUES (N'Iphone 5C',N'Chiếc',5)
INSERT INTO HANGHOA(tenhanghoa,donvitinh,id_nhacungcap) VALUES (N'Iphone 5SE',N'Chiếc',6)
INSERT INTO HANGHOA(tenhanghoa,donvitinh,id_nhacungcap) VALUES (N'Iphone 6',N'Chiếc',5)
INSERT INTO HANGHOA(tenhanghoa,donvitinh,id_nhacungcap) VALUES (N'Iphone 6Plus',N'Chiếc',6)
INSERT INTO HANGHOA(tenhanghoa,donvitinh,id_nhacungcap) VALUES (N'Iphone 7',N'Chiếc',8)
INSERT INTO HANGHOA(tenhanghoa,donvitinh,id_nhacungcap) VALUES (N'Iphone 7Plus',N'Chiếc',1)
GO
CREATE TABLE PHIEUNHAP (id_phieunhap int NOT NULL PRIMARY KEY IDENTITY(1,1) ,
						ngaynhap datetime ,
						id_nhacungcap int references NHACUNGCAP(id_nhacungcap),
						id_nhanvien int references NHANVIEN(id_nhanvien));
GO
INSERT INTO PHIEUNHAP (ngaynhap,id_nhacungcap,id_nhanvien) VALUES ('2017/03/20',1,1)
INSERT INTO PHIEUNHAP (ngaynhap,id_nhacungcap,id_nhanvien) VALUES ('2017/03/20',1,1)
INSERT INTO PHIEUNHAP (ngaynhap,id_nhacungcap,id_nhanvien) VALUES ('2017/03/20',1,2)
INSERT INTO PHIEUNHAP (ngaynhap,id_nhacungcap,id_nhanvien) VALUES ('2017/03/20',1,3)
INSERT INTO PHIEUNHAP (ngaynhap,id_nhacungcap,id_nhanvien) VALUES ('2017/03/20',2,1)
INSERT INTO PHIEUNHAP (ngaynhap,id_nhacungcap,id_nhanvien) VALUES ('2017/03/20',1,3)
INSERT INTO PHIEUNHAP (ngaynhap,id_nhacungcap,id_nhanvien) VALUES ('2017/03/20',1,4)
INSERT INTO PHIEUNHAP (ngaynhap,id_nhacungcap,id_nhanvien) VALUES ('2017/03/20',4,1)
INSERT INTO PHIEUNHAP (ngaynhap,id_nhacungcap,id_nhanvien) VALUES ('2017/03/20',3,1)
INSERT INTO PHIEUNHAP (ngaynhap,id_nhacungcap,id_nhanvien) VALUES ('2017/03/20',5,1)

GO
CREATE TABLE CT_PHIEUNHAP (id_phieunhap int NOT NULL ,
							id_hanghoa int NOT NULL, 
							soluongnhap int ,
							gianhap int
							constraint PK_CT_PHIEUNHAP PRIMARY KEY(id_phieunhap,id_hanghoa));
GO
INSERT INTO CT_PHIEUNHAP(id_phieunhap,id_hanghoa, soluongnhap,gianhap) VALUES (1,1,10,5000000)
INSERT INTO CT_PHIEUNHAP(id_phieunhap,id_hanghoa, soluongnhap,gianhap) VALUES (1,2,10,5000000)
INSERT INTO CT_PHIEUNHAP(id_phieunhap,id_hanghoa, soluongnhap,gianhap) VALUES (2,4,10,5000000)
INSERT INTO CT_PHIEUNHAP(id_phieunhap,id_hanghoa, soluongnhap,gianhap) VALUES (2,5,10,5000000)
INSERT INTO CT_PHIEUNHAP(id_phieunhap,id_hanghoa, soluongnhap,gianhap) VALUES (3,1,10,5000000)
INSERT INTO CT_PHIEUNHAP(id_phieunhap,id_hanghoa, soluongnhap,gianhap) VALUES (3,6,10,5000000)
INSERT INTO CT_PHIEUNHAP(id_phieunhap,id_hanghoa, soluongnhap,gianhap) VALUES (4,2,10,5000000)
INSERT INTO CT_PHIEUNHAP(id_phieunhap,id_hanghoa, soluongnhap,gianhap) VALUES (4,3,10,5000000)
GO

CREATE TABLE PHIEUXUAT(id_phieuxuat int NOT NULL PRIMARY KEY IDENTITY(1,1),
						ngayxuat datetime,
						id_nhanvien int references NHANVIEN(id_nhanvien));
GO
INSERT INTO PHIEUXUAT(ngayxuat,id_nhanvien) VALUES('2017-03-27',1)
INSERT INTO PHIEUXUAT(ngayxuat,id_nhanvien) VALUES('2017-03-27',2)
INSERT INTO PHIEUXUAT(ngayxuat,id_nhanvien) VALUES('2017-03-27',3)
INSERT INTO PHIEUXUAT(ngayxuat,id_nhanvien) VALUES('2017-03-27',4)
INSERT INTO PHIEUXUAT(ngayxuat,id_nhanvien) VALUES('2017-03-27',5)
INSERT INTO PHIEUXUAT(ngayxuat,id_nhanvien) VALUES('2017-03-27',3)
INSERT INTO PHIEUXUAT(ngayxuat,id_nhanvien) VALUES('2017-03-27',3)
INSERT INTO PHIEUXUAT(ngayxuat,id_nhanvien) VALUES('2017-03-27',4)
GO
CREATE TABLE CT_PHIEUXUAT(id_phieuxuat int NOT NULL,
							id_hanghoa int NOT NULL,
							soluongxuat int,
							giaxuat int,
							constraint PK_CT_PHIEUXUAT PRIMARY KEY(id_phieuxuat,id_hanghoa));
GO
INSERT INTO CT_PHIEUXUAT(id_phieuxuat,id_hanghoa,soluongxuat,giaxuat) VALUES (1,2,7,7000000)
INSERT INTO CT_PHIEUXUAT(id_phieuxuat,id_hanghoa,soluongxuat,giaxuat) VALUES (1,3,7,7000000)
INSERT INTO CT_PHIEUXUAT(id_phieuxuat,id_hanghoa,soluongxuat,giaxuat) VALUES (1,1,6,7000000)
INSERT INTO CT_PHIEUXUAT(id_phieuxuat,id_hanghoa,soluongxuat,giaxuat) VALUES (1,4,5,7000000)
INSERT INTO CT_PHIEUXUAT(id_phieuxuat,id_hanghoa,soluongxuat,giaxuat) VALUES (2,5,4,7000000)
INSERT INTO CT_PHIEUXUAT(id_phieuxuat,id_hanghoa,soluongxuat,giaxuat) VALUES (2,4,2,7000000)
INSERT INTO CT_PHIEUXUAT(id_phieuxuat,id_hanghoa,soluongxuat,giaxuat) VALUES (2,3,3,7000000)
INSERT INTO CT_PHIEUXUAT(id_phieuxuat,id_hanghoa,soluongxuat,giaxuat) VALUES (3,1,1,7000000)
INSERT INTO CT_PHIEUXUAT(id_phieuxuat,id_hanghoa,soluongxuat,giaxuat) VALUES (3,3,3,7000000)
INSERT INTO CT_PHIEUXUAT(id_phieuxuat,id_hanghoa,soluongxuat,giaxuat) VALUES (3,2,5,7000000)
INSERT INTO CT_PHIEUXUAT(id_phieuxuat,id_hanghoa,soluongxuat,giaxuat) VALUES (4,6,5,7000000)
INSERT INTO CT_PHIEUXUAT(id_phieuxuat,id_hanghoa,soluongxuat,giaxuat) VALUES (4,3,7,7000000)
INSERT INTO CT_PHIEUXUAT(id_phieuxuat,id_hanghoa,soluongxuat,giaxuat) VALUES (4,2,7,7000000)
