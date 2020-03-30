create database TTN_QLHSGV
go

use TTN_QLHSGV
go

--học sinh
--giao viên
--lớp
--giảng dạy
--khoa
--khóa học
--môn học

create table HOCSINH(
	MaHS varchar(10)  not null primary key,
	TenHS nvarchar(50) not null,
	DiaChi nvarchar(100) ,
	GioiTinh nvarchar(4) not null,
	SDT varchar (11),
	AnhDaiDien VARBINARY(MAX),
	MaLop varchar(10) not null
)
go

create table GIAOVIEN(
	MaGV varchar(10)  not null primary key,
	TenGV nvarchar(50) not null,
	DiaChi nvarchar(100) ,
	GioiTinh nvarchar(4) not null,
	SDT varchar (11),
	ChucVu nvarchar(50) not null,
	AnhDaiDien VARBINARY(MAX),
	MaMon varchar(10) not null
)
go

create table LOP(
	MaLop varchar(10)  not null primary key,
	TenLop nvarchar(50) not null,
	MaGVCN varchar(10) references GIAOVIEN(MaGV),
	MaKH varchar(10) not null
)
go

create table KHOA(
	MaKhoa varchar(10)  not null primary key,
	TenKhoa nvarchar(50) not null,
	MaTruongKhoa varchar(10) references GIAOVIEN(MaGV)
)
go

create table MONHOC(
	MaMon varchar(10)  not null primary key,
	TenMon nvarchar(50) not null,
	MaKhoa varchar(10) not null
)
go

create table KHOAHOC(
	MaKH varchar(10)  not null primary key,
	TenKH nvarchar(50) not null
)
go

alter table HOCSINH
add foreign key (MaLop) references LOP(MaLop)
go

alter table GIAOVIEN
add foreign key (MaMon) references MONHOC(MaMon)
go

alter table MONHOC
add foreign key (MaKhoa) references KHOA(MaKhoa)

alter table LOP
add foreign key (MaKH) references KHOAHOC(MaKH)
go

create table GIANGDAY(
	MaGV varchar(10) not null references GIAOVIEN(MaGV),
	MaLop varchar(10) not null references LOP(MaLop),
	SoTiet int,
	DiaDiem nvarchar(50),
	Thu varchar(20),
	Tiet varchar(20),
	primary key (MaGV, Malop)
)
go

--insert data
INSERT [dbo].[GIANGDAY] ([MaGV], [MaLop], [SoTiet], [DiaDiem], [Thu], [Tiet]) VALUES (N'GV001', N'L6A', 60, N'TÒA B,P.102', N'2,5', N'1-3,4-5')
INSERT [dbo].[GIANGDAY] ([MaGV], [MaLop], [SoTiet], [DiaDiem], [Thu], [Tiet]) VALUES (N'GV001', N'L6C', 60, N'TOÀ B,P104', N'3,6', N'3-5,6-8')
INSERT [dbo].[GIANGDAY] ([MaGV], [MaLop], [SoTiet], [DiaDiem], [Thu], [Tiet]) VALUES (N'GV002', N'L6A', 60, N'TÒA B,P102', N'4,6', N'1-3,1-3')
INSERT [dbo].[GIANGDAY] ([MaGV], [MaLop], [SoTiet], [DiaDiem], [Thu], [Tiet]) VALUES (N'GV004', N'L6A', 30, N'TÒA B,P102', N'5', N'3-5')
INSERT [dbo].[GIANGDAY] ([MaGV], [MaLop], [SoTiet], [DiaDiem], [Thu], [Tiet]) VALUES (N'GV004', N'L6B', 30, N'TÒA B,P103', N'4', N'1-3')
INSERT [dbo].[GIAOVIEN] ( [TenGV], [DiaChi], [GioiTinh], [SDT], [ChucVu], [AnhDaiDien], [MaMon]) VALUES ( N'NGUYỄN HOÀNG NAM', N'43 Trần Duy Hưng, Trung Hoà, Cầu Giấy, Hà Nội', N'NAM', '0987346782', N'GIẢNG VIÊN', NULL, 6)
INSERT [dbo].[GIAOVIEN] ( [TenGV], [DiaChi], [GioiTinh], [SDT], [ChucVu], [AnhDaiDien], [MaMon]) VALUES ( N'HOÀNG HẢI YẾN', N'133 TRẦN HƯNG ĐẠO, HOÀNG MAI, Hà Nội', N'NỮ', '0354674345', N'GIẢNG VIÊN', NULL, 7)
INSERT [dbo].[GIAOVIEN] ( [TenGV], [DiaChi], [GioiTinh], [SDT], [ChucVu], [AnhDaiDien], [MaMon]) VALUES ( N'BÙI HOÀNG VIỆT', N'43 Trần Duy Hưng, Trung Hoà, Cầu Giấy, Hà Nội', N'NAM', '0936643737', N'PHÓ HIỆU TRƯỞNG', NULL, 8)
INSERT [dbo].[GIAOVIEN] ( [TenGV], [DiaChi], [GioiTinh], [SDT], [ChucVu], [AnhDaiDien], [MaMon]) VALUES ( N'NGÔ XUÂN KHIÊM', N'43 Trần Duy Hưng, Trung Hoà, Cầu Giấy, Hà Nội', N'NAM', '0387620987', N'GIẢNG VIÊN', NULL, 10)
INSERT [dbo].[HOCSINH] ( [TenHS], [DiaChi], [GioiTinh], [SDT], [AnhDaiDien], [MaLop]) VALUES ( N'HÀ NGỌC ÁNH', N'154 Ngõ 173 Hoàng Hoa Thám, Ngọc Hồ, Ba Đình, Hà Nội', N'N?', N'', NULL, 1)
INSERT [dbo].[HOCSINH] ( [TenHS], [DiaChi], [GioiTinh], [SDT], [AnhDaiDien], [MaLop]) VALUES ( N'NGUYỄN TRUNG BÌNH', N'173  Phố Hàng Khay, Hoàn Kiếm, Hà Nội', N'NAM', N'', NULL, 1)
INSERT [dbo].[HOCSINH] ( [TenHS], [DiaChi], [GioiTinh], [SDT], [AnhDaiDien], [MaLop]) VALUES ( N'BÙI NHƯ LẠC', N'54 Hoàng Như Tiếp , Long Biên , Hà Nội', N'N?', N'', NULL, 2)
INSERT [dbo].[KHOA] ([MaKhoa], [TenKhoa], [MaTruongKhoa]) VALUES (N'NANGKHIEU', N'NĂNG KHIẾU', N'GV003')
INSERT [dbo].[KHOA] ([MaKhoa], [TenKhoa], [MaTruongKhoa]) VALUES (N'TUNHIEN', N'TỰ NHIÊN', N'GV001')
INSERT [dbo].[KHOA] ([MaKhoa], [TenKhoa], [MaTruongKhoa]) VALUES (N'XAHOI', N'XÃ HỘI', N'GV002')
INSERT [dbo].[KHOAHOC] ([MaKH], [TenKH]) VALUES (N'KH20142018', N'KHÓA HỌC 2014-2018')
INSERT [dbo].[KHOAHOC] ([MaKH], [TenKH]) VALUES (N'KH20152019', N'KHÓA HỌC 2015-2019')
INSERT [dbo].[KHOAHOC] ([MaKH], [TenKH]) VALUES (N'KH20162020', N'KHÓA HỌC 2016-2020')
INSERT [dbo].[KHOAHOC] ([MaKH], [TenKH]) VALUES (N'KH20172021', N'KHÓA HỌC 2017-2021')
INSERT [dbo].[KHOAHOC] ([MaKH], [TenKH]) VALUES (N'KH20182022', N'KHÓA HỌC 2018-2022')
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaGVCN], [MaKH]) VALUES (N'L6A', N'6A', N'GV001', N'KH20182022')
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaGVCN], [MaKH]) VALUES (N'L6B', N'6B', N'GV002', N'KH20182022')
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaGVCN], [MaKH]) VALUES (N'L6C', N'6C', N'GV003', N'KH20182022')
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaGVCN], [MaKH]) VALUES (N'L7A', N'7A', N'GV001', N'KH20172021')
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaGVCN], [MaKH]) VALUES (N'L7B', N'7B', N'GV002', N'KH20172021')
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaGVCN], [MaKH]) VALUES (N'L7C', N'7C', N'GV003', N'KH20172021')
INSERT [dbo].[MONHOC] ([MaMon], [TenMon], [MaKhoa]) VALUES (N'AMNHAC', N'ÂM NHẠC', N'NANGKHIEU')
INSERT [dbo].[MONHOC] ([MaMon], [TenMon], [MaKhoa]) VALUES (N'CONGNGHE', N'CÔNG NGHỆ', N'TUNHIEN')
INSERT [dbo].[MONHOC] ([MaMon], [TenMon], [MaKhoa]) VALUES (N'DIA', N'ĐỊA LÍ', N'XAHOI')
INSERT [dbo].[MONHOC] ([MaMon], [TenMon], [MaKhoa]) VALUES (N'GDCD', N'GDCD', N'XAHOI')
INSERT [dbo].[MONHOC] ([MaMon], [TenMon], [MaKhoa]) VALUES (N'HOA', N'HÓA HỌC', N'TUNHIEN')
INSERT [dbo].[MONHOC] ([MaMon], [TenMon], [MaKhoa]) VALUES (N'LI', N'VẬT LÍ', N'TUNHIEN')
INSERT [dbo].[MONHOC] ([MaMon], [TenMon], [MaKhoa]) VALUES (N'MYTHUAT', N'MỸ THUẬT', N'NANGKHIEU')
INSERT [dbo].[MONHOC] ([MaMon], [TenMon], [MaKhoa]) VALUES (N'NGOAINGU', N'TIẾNG ANH', N'XAHOI')
INSERT [dbo].[MONHOC] ([MaMon], [TenMon], [MaKhoa]) VALUES (N'SINH', N'SINH HỌC', N'TUNHIEN')
INSERT [dbo].[MONHOC] ([MaMon], [TenMon], [MaKhoa]) VALUES (N'SU', N'LỊCH SỬ', N'XAHOI')
INSERT [dbo].[MONHOC] ([MaMon], [TenMon], [MaKhoa]) VALUES (N'THEDUC', N'THỂ DỤC', N'NANGKHIEU')
INSERT [dbo].[MONHOC] ([MaMon], [TenMon], [MaKhoa]) VALUES (N'TIN', N'TIN HỌC', N'TUNHIEN')
INSERT [dbo].[MONHOC] ([MaMon], [TenMon], [MaKhoa]) VALUES (N'TOAN', N'TOÁN HỌC', N'TUNHIEN')
INSERT [dbo].[MONHOC] ([MaMon], [TenMon], [MaKhoa]) VALUES (N'VAN', N'NGỮ VĂN', N'XAHOI')
