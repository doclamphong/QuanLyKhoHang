USE [QuanLyKhoHang]
GO
/****** Object:  Table [dbo].[CT_PHIEUNHAP]    Script Date: 2017-05-08 21:46:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PHIEUNHAP](
	[id_phieunhap] [int] NOT NULL,
	[id_hanghoa] [int] NOT NULL,
	[soluongnhap] [int] NULL,
	[gianhap] [int] NULL,
 CONSTRAINT [PK_CT_PHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[id_phieunhap] ASC,
	[id_hanghoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CT_PHIEUXUAT]    Script Date: 2017-05-08 21:46:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PHIEUXUAT](
	[id_phieuxuat] [int] NOT NULL,
	[id_hanghoa] [int] NOT NULL,
	[soluongxuat] [int] NULL,
 CONSTRAINT [PK_CT_PHIEUXUAT] PRIMARY KEY CLUSTERED 
(
	[id_phieuxuat] ASC,
	[id_hanghoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HANGHOA]    Script Date: 2017-05-08 21:46:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HANGHOA](
	[id_hanghoa] [int] IDENTITY(1,1) NOT NULL,
	[tenhanghoa] [nvarchar](50) NULL,
	[donvitinh] [nvarchar](30) NULL,
	[id_nhacungcap] [int] NULL,
	[giaban] [varchar](50) NULL,
	[soluongton] [int] NULL,
	[mota] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_hanghoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAINHANVIEN]    Script Date: 2017-05-08 21:46:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAINHANVIEN](
	[id_loainv] [int] IDENTITY(1,1) NOT NULL,
	[tenloainv] [nvarchar](50) NULL,
 CONSTRAINT [PK_LOAINHANVIEN] PRIMARY KEY CLUSTERED 
(
	[id_loainv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 2017-05-08 21:46:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[id_nhacungcap] [int] IDENTITY(1,1) NOT NULL,
	[tennhacungcap] [nvarchar](100) NULL,
	[diachi] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_nhacungcap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 2017-05-08 21:46:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[id_nhanvien] [int] IDENTITY(1,1) NOT NULL,
	[tennhanvien] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[taikhoan] [varchar](50) NULL,
	[matkhau] [varchar](50) NULL,
	[id_loainv] [int] NULL,
 CONSTRAINT [PK__NHANVIEN__FE2A92876432AE2C] PRIMARY KEY CLUSTERED 
(
	[id_nhanvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 2017-05-08 21:46:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[id_phieunhap] [int] IDENTITY(1,1) NOT NULL,
	[ngaynhap] [datetime] NULL,
	[id_nhacungcap] [int] NULL,
	[id_nhanvien] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_phieunhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUXUAT]    Script Date: 2017-05-08 21:46:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUXUAT](
	[id_phieuxuat] [int] IDENTITY(1,1) NOT NULL,
	[ngayxuat] [datetime] NULL,
	[id_nhanvien] [int] NULL,
	[TenKH] [nvarchar](50) NULL,
	[DiaChiKH] [nvarchar](200) NULL,
	[SoDT] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_phieuxuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CT_PHIEUNHAP] ([id_phieunhap], [id_hanghoa], [soluongnhap], [gianhap]) VALUES (1, 1, 10, 5000000)
INSERT [dbo].[CT_PHIEUNHAP] ([id_phieunhap], [id_hanghoa], [soluongnhap], [gianhap]) VALUES (1, 2, 10, 5000000)
INSERT [dbo].[CT_PHIEUNHAP] ([id_phieunhap], [id_hanghoa], [soluongnhap], [gianhap]) VALUES (2, 4, 10, 5000000)
INSERT [dbo].[CT_PHIEUNHAP] ([id_phieunhap], [id_hanghoa], [soluongnhap], [gianhap]) VALUES (2, 5, 10, 5000000)
INSERT [dbo].[CT_PHIEUNHAP] ([id_phieunhap], [id_hanghoa], [soluongnhap], [gianhap]) VALUES (3, 1, 10, 5000000)
INSERT [dbo].[CT_PHIEUNHAP] ([id_phieunhap], [id_hanghoa], [soluongnhap], [gianhap]) VALUES (3, 6, 10, 5000000)
INSERT [dbo].[CT_PHIEUNHAP] ([id_phieunhap], [id_hanghoa], [soluongnhap], [gianhap]) VALUES (4, 2, 10, 5000000)
INSERT [dbo].[CT_PHIEUNHAP] ([id_phieunhap], [id_hanghoa], [soluongnhap], [gianhap]) VALUES (4, 3, 10, 5000000)
INSERT [dbo].[CT_PHIEUXUAT] ([id_phieuxuat], [id_hanghoa], [soluongxuat]) VALUES (1, 1, 6)
INSERT [dbo].[CT_PHIEUXUAT] ([id_phieuxuat], [id_hanghoa], [soluongxuat]) VALUES (1, 2, 7)
INSERT [dbo].[CT_PHIEUXUAT] ([id_phieuxuat], [id_hanghoa], [soluongxuat]) VALUES (1, 3, 7)
INSERT [dbo].[CT_PHIEUXUAT] ([id_phieuxuat], [id_hanghoa], [soluongxuat]) VALUES (1, 4, 5)
INSERT [dbo].[CT_PHIEUXUAT] ([id_phieuxuat], [id_hanghoa], [soluongxuat]) VALUES (1, 8, 2)
INSERT [dbo].[CT_PHIEUXUAT] ([id_phieuxuat], [id_hanghoa], [soluongxuat]) VALUES (1, 12, 0)
INSERT [dbo].[CT_PHIEUXUAT] ([id_phieuxuat], [id_hanghoa], [soluongxuat]) VALUES (2, 3, 3)
INSERT [dbo].[CT_PHIEUXUAT] ([id_phieuxuat], [id_hanghoa], [soluongxuat]) VALUES (2, 4, 2)
INSERT [dbo].[CT_PHIEUXUAT] ([id_phieuxuat], [id_hanghoa], [soluongxuat]) VALUES (2, 5, 4)
INSERT [dbo].[CT_PHIEUXUAT] ([id_phieuxuat], [id_hanghoa], [soluongxuat]) VALUES (2, 12, 2)
INSERT [dbo].[CT_PHIEUXUAT] ([id_phieuxuat], [id_hanghoa], [soluongxuat]) VALUES (3, 1, 1)
INSERT [dbo].[CT_PHIEUXUAT] ([id_phieuxuat], [id_hanghoa], [soluongxuat]) VALUES (3, 2, 5)
INSERT [dbo].[CT_PHIEUXUAT] ([id_phieuxuat], [id_hanghoa], [soluongxuat]) VALUES (3, 3, 3)
INSERT [dbo].[CT_PHIEUXUAT] ([id_phieuxuat], [id_hanghoa], [soluongxuat]) VALUES (4, 2, 7)
INSERT [dbo].[CT_PHIEUXUAT] ([id_phieuxuat], [id_hanghoa], [soluongxuat]) VALUES (4, 3, 7)
INSERT [dbo].[CT_PHIEUXUAT] ([id_phieuxuat], [id_hanghoa], [soluongxuat]) VALUES (4, 6, 5)
SET IDENTITY_INSERT [dbo].[HANGHOA] ON 

INSERT [dbo].[HANGHOA] ([id_hanghoa], [tenhanghoa], [donvitinh], [id_nhacungcap], [giaban], [soluongton], [mota]) VALUES (1, N'EliteBook 8460', N'Chiếc', 1, NULL, NULL, N'abc')
INSERT [dbo].[HANGHOA] ([id_hanghoa], [tenhanghoa], [donvitinh], [id_nhacungcap], [giaban], [soluongton], [mota]) VALUES (2, N'Iphone 4', N'Chiếc', 3, N'15000000', 10, N'Sản phẩm hót tháng 4')
INSERT [dbo].[HANGHOA] ([id_hanghoa], [tenhanghoa], [donvitinh], [id_nhacungcap], [giaban], [soluongton], [mota]) VALUES (3, N'Iphone 4S', N'Chiếc', 2, N'100000', 100, N'uzl')
INSERT [dbo].[HANGHOA] ([id_hanghoa], [tenhanghoa], [donvitinh], [id_nhacungcap], [giaban], [soluongton], [mota]) VALUES (4, N'Iphone 5', N'Chiếc', 3, N'120000', NULL, N'Sản phẩm của  APPLE')
INSERT [dbo].[HANGHOA] ([id_hanghoa], [tenhanghoa], [donvitinh], [id_nhacungcap], [giaban], [soluongton], [mota]) VALUES (5, N'Iphone 5S', N'Chiếc', 4, NULL, NULL, NULL)
INSERT [dbo].[HANGHOA] ([id_hanghoa], [tenhanghoa], [donvitinh], [id_nhacungcap], [giaban], [soluongton], [mota]) VALUES (6, N'Iphone 5C', N'Chiếc', 5, NULL, NULL, NULL)
INSERT [dbo].[HANGHOA] ([id_hanghoa], [tenhanghoa], [donvitinh], [id_nhacungcap], [giaban], [soluongton], [mota]) VALUES (7, N'Iphone 5SE', N'Chiếc', 6, NULL, NULL, NULL)
INSERT [dbo].[HANGHOA] ([id_hanghoa], [tenhanghoa], [donvitinh], [id_nhacungcap], [giaban], [soluongton], [mota]) VALUES (8, N'Iphone 6', N'Chiếc', 3, N'20000000', 20, N'')
INSERT [dbo].[HANGHOA] ([id_hanghoa], [tenhanghoa], [donvitinh], [id_nhacungcap], [giaban], [soluongton], [mota]) VALUES (9, N'Iphone 6Plus', N'Chiếc', 6, NULL, NULL, NULL)
INSERT [dbo].[HANGHOA] ([id_hanghoa], [tenhanghoa], [donvitinh], [id_nhacungcap], [giaban], [soluongton], [mota]) VALUES (10, N'Iphone 7', N'Chiếc', 8, NULL, NULL, NULL)
INSERT [dbo].[HANGHOA] ([id_hanghoa], [tenhanghoa], [donvitinh], [id_nhacungcap], [giaban], [soluongton], [mota]) VALUES (12, N'Iphone8 Red', N'Chiếc', 1, N'22000000', 20, N'Hàng hít')
SET IDENTITY_INSERT [dbo].[HANGHOA] OFF
SET IDENTITY_INSERT [dbo].[LOAINHANVIEN] ON 

INSERT [dbo].[LOAINHANVIEN] ([id_loainv], [tenloainv]) VALUES (1, N'Quản trị')
INSERT [dbo].[LOAINHANVIEN] ([id_loainv], [tenloainv]) VALUES (2, N'Nhân viên')
SET IDENTITY_INSERT [dbo].[LOAINHANVIEN] OFF
SET IDENTITY_INSERT [dbo].[NHACUNGCAP] ON 

INSERT [dbo].[NHACUNGCAP] ([id_nhacungcap], [tennhacungcap], [diachi]) VALUES (1, N'NOKIA', N'Hà Nội')
INSERT [dbo].[NHACUNGCAP] ([id_nhacungcap], [tennhacungcap], [diachi]) VALUES (2, N'SAMSUNG', N'Hà Nội')
INSERT [dbo].[NHACUNGCAP] ([id_nhacungcap], [tennhacungcap], [diachi]) VALUES (3, N'IPHONE', N'Hà Nội')
INSERT [dbo].[NHACUNGCAP] ([id_nhacungcap], [tennhacungcap], [diachi]) VALUES (4, N'HP ELITEBOOK', N'Hà Nội')
INSERT [dbo].[NHACUNGCAP] ([id_nhacungcap], [tennhacungcap], [diachi]) VALUES (5, N'DELL', N'Hà Nội')
INSERT [dbo].[NHACUNGCAP] ([id_nhacungcap], [tennhacungcap], [diachi]) VALUES (6, N'ASUS', N'Hà Nội')
INSERT [dbo].[NHACUNGCAP] ([id_nhacungcap], [tennhacungcap], [diachi]) VALUES (7, N'OPPO', N'Hà Nội')
INSERT [dbo].[NHACUNGCAP] ([id_nhacungcap], [tennhacungcap], [diachi]) VALUES (8, N'CAMRY', N'hải Dương')
INSERT [dbo].[NHACUNGCAP] ([id_nhacungcap], [tennhacungcap], [diachi]) VALUES (9, N'LG SMART TV', N'Hà Nội')
INSERT [dbo].[NHACUNGCAP] ([id_nhacungcap], [tennhacungcap], [diachi]) VALUES (11, N'HP PROBOOK', N'Hà Nội')
INSERT [dbo].[NHACUNGCAP] ([id_nhacungcap], [tennhacungcap], [diachi]) VALUES (12, N'TOYOTA', N'Nhật Bản')
INSERT [dbo].[NHACUNGCAP] ([id_nhacungcap], [tennhacungcap], [diachi]) VALUES (13, N'SAMSUNG ELECTRONIC', N'Hàn Quốc')
SET IDENTITY_INSERT [dbo].[NHACUNGCAP] OFF
SET IDENTITY_INSERT [dbo].[NHANVIEN] ON 

INSERT [dbo].[NHANVIEN] ([id_nhanvien], [tennhanvien], [diachi], [taikhoan], [matkhau], [id_loainv]) VALUES (1, N'Nguyễn Hoàn', N'Bắc Ninh', N'hoanns', N'123456', 1)
INSERT [dbo].[NHANVIEN] ([id_nhanvien], [tennhanvien], [diachi], [taikhoan], [matkhau], [id_loainv]) VALUES (2, N'Nguyễn Thảo', N'Từ Sơn', N'hoanns', N'123456', 2)
INSERT [dbo].[NHANVIEN] ([id_nhanvien], [tennhanvien], [diachi], [taikhoan], [matkhau], [id_loainv]) VALUES (3, N'Nguyễn Hiền', N'Gia Bình', N'banana', N'123456', 2)
INSERT [dbo].[NHANVIEN] ([id_nhanvien], [tennhanvien], [diachi], [taikhoan], [matkhau], [id_loainv]) VALUES (4, N'Nguyễn Tùng', N'Quế Võ', N'ahihi', N'123456', 2)
INSERT [dbo].[NHANVIEN] ([id_nhanvien], [tennhanvien], [diachi], [taikhoan], [matkhau], [id_loainv]) VALUES (5, N'Nguyễn Cúc', N'Thuận Thành', N'keke', N'123456', 2)
INSERT [dbo].[NHANVIEN] ([id_nhanvien], [tennhanvien], [diachi], [taikhoan], [matkhau], [id_loainv]) VALUES (6, N'Nguyễn Trúc', N'Hải Dương', N'haha', N'123456', 2)
INSERT [dbo].[NHANVIEN] ([id_nhanvien], [tennhanvien], [diachi], [taikhoan], [matkhau], [id_loainv]) VALUES (7, N'Nguyễn Mai', N'Bắc Ninh', N'hihi', N'123456', 2)
INSERT [dbo].[NHANVIEN] ([id_nhanvien], [tennhanvien], [diachi], [taikhoan], [matkhau], [id_loainv]) VALUES (8, N'Tư Huỳnh', N'Kim Thành', N'hoanns', N'123456', 2)
INSERT [dbo].[NHANVIEN] ([id_nhanvien], [tennhanvien], [diachi], [taikhoan], [matkhau], [id_loainv]) VALUES (9, N'Thành Luân', N'Hải Phòng', N'hoanns', N'123456', 2)
INSERT [dbo].[NHANVIEN] ([id_nhanvien], [tennhanvien], [diachi], [taikhoan], [matkhau], [id_loainv]) VALUES (10, N'Như Hai', N'Cầu Giấy', N'hoanns', N'123456', 2)
INSERT [dbo].[NHANVIEN] ([id_nhanvien], [tennhanvien], [diachi], [taikhoan], [matkhau], [id_loainv]) VALUES (11, N'Sơn Tùng', N'Ba Đình', N'hoanns', N'123456', 2)
INSERT [dbo].[NHANVIEN] ([id_nhanvien], [tennhanvien], [diachi], [taikhoan], [matkhau], [id_loainv]) VALUES (12, N'Nhật Minh', N'Ninh Giang', N'hoanns', N'123456', NULL)
SET IDENTITY_INSERT [dbo].[NHANVIEN] OFF
SET IDENTITY_INSERT [dbo].[PHIEUNHAP] ON 

INSERT [dbo].[PHIEUNHAP] ([id_phieunhap], [ngaynhap], [id_nhacungcap], [id_nhanvien]) VALUES (1, CAST(0x0000A73C00000000 AS DateTime), 1, 1)
INSERT [dbo].[PHIEUNHAP] ([id_phieunhap], [ngaynhap], [id_nhacungcap], [id_nhanvien]) VALUES (2, CAST(0x0000A73C00000000 AS DateTime), 1, 1)
INSERT [dbo].[PHIEUNHAP] ([id_phieunhap], [ngaynhap], [id_nhacungcap], [id_nhanvien]) VALUES (3, CAST(0x0000A73C00000000 AS DateTime), 1, 2)
INSERT [dbo].[PHIEUNHAP] ([id_phieunhap], [ngaynhap], [id_nhacungcap], [id_nhanvien]) VALUES (4, CAST(0x0000A73C00000000 AS DateTime), 1, 3)
INSERT [dbo].[PHIEUNHAP] ([id_phieunhap], [ngaynhap], [id_nhacungcap], [id_nhanvien]) VALUES (5, CAST(0x0000A73C00000000 AS DateTime), 2, 1)
INSERT [dbo].[PHIEUNHAP] ([id_phieunhap], [ngaynhap], [id_nhacungcap], [id_nhanvien]) VALUES (6, CAST(0x0000A73C00000000 AS DateTime), 1, 3)
INSERT [dbo].[PHIEUNHAP] ([id_phieunhap], [ngaynhap], [id_nhacungcap], [id_nhanvien]) VALUES (7, CAST(0x0000A73C00000000 AS DateTime), 1, 4)
INSERT [dbo].[PHIEUNHAP] ([id_phieunhap], [ngaynhap], [id_nhacungcap], [id_nhanvien]) VALUES (8, CAST(0x0000A73C00000000 AS DateTime), 4, 1)
INSERT [dbo].[PHIEUNHAP] ([id_phieunhap], [ngaynhap], [id_nhacungcap], [id_nhanvien]) VALUES (9, CAST(0x0000A73C00000000 AS DateTime), 3, 1)
INSERT [dbo].[PHIEUNHAP] ([id_phieunhap], [ngaynhap], [id_nhacungcap], [id_nhanvien]) VALUES (10, CAST(0x0000A73C00000000 AS DateTime), 5, 1)
SET IDENTITY_INSERT [dbo].[PHIEUNHAP] OFF
SET IDENTITY_INSERT [dbo].[PHIEUXUAT] ON 

INSERT [dbo].[PHIEUXUAT] ([id_phieuxuat], [ngayxuat], [id_nhanvien], [TenKH], [DiaChiKH], [SoDT]) VALUES (1, CAST(0x0000A73F00000000 AS DateTime), 1, N'Hoàn', N'HN', N'0123')
INSERT [dbo].[PHIEUXUAT] ([id_phieuxuat], [ngayxuat], [id_nhanvien], [TenKH], [DiaChiKH], [SoDT]) VALUES (2, CAST(0x0000A76200000000 AS DateTime), 2, N'Thành', N'BN', N'0978')
INSERT [dbo].[PHIEUXUAT] ([id_phieuxuat], [ngayxuat], [id_nhanvien], [TenKH], [DiaChiKH], [SoDT]) VALUES (3, CAST(0x0000A74300000000 AS DateTime), 3, N'Thảo', N'HD', N'0123')
INSERT [dbo].[PHIEUXUAT] ([id_phieuxuat], [ngayxuat], [id_nhanvien], [TenKH], [DiaChiKH], [SoDT]) VALUES (4, CAST(0x0000A74300000000 AS DateTime), 4, NULL, NULL, NULL)
INSERT [dbo].[PHIEUXUAT] ([id_phieuxuat], [ngayxuat], [id_nhanvien], [TenKH], [DiaChiKH], [SoDT]) VALUES (5, CAST(0x0000A74300000000 AS DateTime), 5, NULL, NULL, NULL)
INSERT [dbo].[PHIEUXUAT] ([id_phieuxuat], [ngayxuat], [id_nhanvien], [TenKH], [DiaChiKH], [SoDT]) VALUES (6, CAST(0x0000A74300000000 AS DateTime), 3, NULL, NULL, NULL)
INSERT [dbo].[PHIEUXUAT] ([id_phieuxuat], [ngayxuat], [id_nhanvien], [TenKH], [DiaChiKH], [SoDT]) VALUES (7, CAST(0x0000A74300000000 AS DateTime), 3, NULL, NULL, NULL)
INSERT [dbo].[PHIEUXUAT] ([id_phieuxuat], [ngayxuat], [id_nhanvien], [TenKH], [DiaChiKH], [SoDT]) VALUES (8, CAST(0x0000A74300000000 AS DateTime), 4, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[PHIEUXUAT] OFF
ALTER TABLE [dbo].[HANGHOA]  WITH CHECK ADD FOREIGN KEY([id_nhacungcap])
REFERENCES [dbo].[NHACUNGCAP] ([id_nhacungcap])
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD FOREIGN KEY([id_loainv])
REFERENCES [dbo].[LOAINHANVIEN] ([id_loainv])
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD FOREIGN KEY([id_nhacungcap])
REFERENCES [dbo].[NHACUNGCAP] ([id_nhacungcap])
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK__PHIEUNHAP__id_nh__182C9B23] FOREIGN KEY([id_nhanvien])
REFERENCES [dbo].[NHANVIEN] ([id_nhanvien])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK__PHIEUNHAP__id_nh__182C9B23]
GO
ALTER TABLE [dbo].[PHIEUXUAT]  WITH CHECK ADD  CONSTRAINT [FK__PHIEUXUAT__id_nh__1CF15040] FOREIGN KEY([id_nhanvien])
REFERENCES [dbo].[NHANVIEN] ([id_nhanvien])
GO
ALTER TABLE [dbo].[PHIEUXUAT] CHECK CONSTRAINT [FK__PHIEUXUAT__id_nh__1CF15040]
GO
