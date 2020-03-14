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
	MaGVCN int references GIAOVIEN(MaGV),
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
	Thu int,
	Tiet varchar(5),
	primary key (MaGV, Malop)
)
go


