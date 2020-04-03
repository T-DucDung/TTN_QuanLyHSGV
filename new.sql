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


-- 


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


GO
-- THAP TÁC VỚI KHÓA HỌC
CREATE PROC INSERTKHOAHOC(@MAKHOAHOC VARCHAR(10), @TENKHOAHOC NVARCHAR(50))AS
BEGIN

	INSERT INTO KHOAHOC(MaKH,TenKH)
	VALUES(@MAKHOAHOC,@TENKHOAHOC)

END

GO
INSERTKHOAHOC 'KH20142018',N'KHÓA HỌC 2014-2018'
GO
INSERTKHOAHOC 'KH20152019',N'KHÓA HỌC 2015-2019'
GO
INSERTKHOAHOC 'KH20162020',N'KHÓA HỌC 2016-2020'
GO
INSERTKHOAHOC 'KH20172021',N'KHÓA HỌC 2017-2021'
GO
INSERTKHOAHOC 'KH20182022',N'KHÓA HỌC 2018-2022'

GO
CREATE PROC UPDATEKHOAHOC(@MAKHOAHOC VARCHAR(10) ,  @TENKHOAHOC NVARCHAR(50))AS
BEGIN
	UPDATE KHOAHOC
	SET TenKH = @TENKHOAHOC
	WHERE MaKH = @MAKHOAHOC
END







/**
PHẦN KHOA NÀY TÔI NGHĨ RA KHÁ ÍT NÊN AE THÊM TAY
	TUNHIEN		TỰ NHIÊN
	
	XAHOI		XÃ HỘI
	
	NANGKHIEU	NĂNG KHIẾU

*/

-- THAO TÁC VỚI KHOA CỦA BỘ MÔN
/*
-- HÀM NÀY VẪN TẠO RA PHỤC VỤ VIẾT BÊN C#
GO 
CREATE PROC INSERTKHOA(@MAKHOA VARCHAR(10), @TENKHOA NVARCHAR(50), @MATRUONGKHOA VARCHAR(10))AS
BEGIN

	INSERT INTO KHOA(MaKhoa , TenKhoa , MaTruongKhoa)
	VALUES(@MAKHOA , @TENKHOA , @MATRUONGKHOA)

END
*/

GO
CREATE PROC UPDATEKHOA(@MAKHOA VARCHAR(10), @TENKHOA NVARCHAR(50), @MATRUONGKHOA VARCHAR(10))AS
BEGIN

	UPDATE KHOA
	SET TenKhoa = @TENKHOA ,MaTruongKhoa = @MATRUONGKHOA 
	WHERE MaKhoa = @MAKHOA
END



GO
CREATE PROC DELETEKHOA(@MAKHOA VARCHAR(10))AS
BEGIN

	DELETE KHOA 
	WHERE MaKhoa = @MAKHOA

END


-- THAO TÁC VS MÔN HỌC
GO
CREATE PROC INSERTMONHOC(@MAMONHOC VARCHAR(10),@TENMONHOC NVARCHAR(50),@MAKHOA VARCHAR(10))AS
BEGIN
	INSERT INTO MONHOC(MaMon,TenMon ,MaKhoa)
	VALUES(@MAMONHOC ,@TENMONHOC , @MAKHOA)
END


GO
INSERTMONHOC 'HOA',N'HÓA HỌC','TUNHIEN'
GO
INSERTMONHOC 'LI',N'VẬT LÍ','TUNHIEN'
GO
INSERTMONHOC 'TOAN',N'TOÁN HỌC','TUNHIEN'
GO
INSERTMONHOC 'THEDUC',N'THỂ DỤC','NANGKHIEU'
GO
INSERTMONHOC 'MYTHUAT',N'MỸ THUẬT','NANGKHIEU'
GO
INSERTMONHOC 'AMNHAC',N'ÂM NHẠC','NANGKHIEU'
GO
INSERTMONHOC 'SU',N'LỊCH SỬ','XAHOI'
GO
INSERTMONHOC 'DIA',N'ĐỊA LÍ','XAHOI'
GO
INSERTMONHOC 'VAN',N'NGỮ VĂN','XAHOI'
GO
INSERTMONHOC 'SINH',N'SINH HỌC','TUNHIEN'
GO
INSERTMONHOC 'CONGNGHE',N'CÔNG NGHỆ','TUNHIEN'
GO 
INSERTMONHOC 'TIN' , N'TIN HỌC' , 'TUNHIEN'
GO 
INSERTMONHOC 'NGOAINGU' , N'TIẾNG ANH' , 'XAHOI'
GO 
INSERTMONHOC 'GDCD' , 'GDCD' , 'XAHOI'


GO
CREATE PROC UPDATEMONHOC(@MAMONHOC VARCHAR(10),@TENMONHOC NVARCHAR(50),@MAKHOA VARCHAR(10))as
BEGIN
	UPDATE MONHOC
	SET TenMon = @TENMONHOC , MaKhoa = @MAKHOA
	WHERE MaMon = @MAMONHOC
END


GO
CREATE PROC DELETEMONHOC(@MAMONHOC VARCHAR(10))AS
BEGIN
	DELETE MONHOC
	WHERE MaMon = @MAMONHOC
END



/*
THÊM HỌC SINH VÀ GIÁO VIÊN BẮT BUỘC PHẢI THÊM TAY TRƯỚC DO VƯỚNG ẢNH ĐẠI DIỆN DÙ ĐỂ NULL NHƯNG NÓ VẪN KO NHẬN
K
*/

-- THAO TAC VS BANG GIAO VIEN
/*
GV001		NGUYỄN HOÀNG NAM		43 Trần Duy Hưng, Trung Hoà, Cầu Giấy, Hà Nội			NAM			0987346782		GIẢNG VIÊN			(ẢNH ĐẠI DIỆN ĐỂ KO)	TOAN

GV002		HOÀNG HẢI YẾN			133 TRẦN HƯNG ĐẠO , HOÀNG MAI, Hà Nội					NỮ			0354674345		GIẢNG VIÊN			(ẢNH ĐẠI DIỆN ĐỂ KO)	VAN

GV003		BÙI HOÀNG VIỆT			43 Trần Duy Hưng, Trung Hoà, Cầu Giấy, Hà Nội			NAM			0936643737		PHÓ HIỆU TRƯỞNG		(ẢNH ĐẠI DIỆN ĐỂ KO)	TOAN

'GV004' 'NGÔ XUÂN KHIÊM' '62 Trung Hoà, Cầu Giấy, Hà Nội' 'NAM'	'0387620987' 'GIẢNG VIÊN' '' LI

'GV005'  'BÙI XUÂN HUẤN'   'Phan Văn Trường, Dịch Vọng Hậu, Cầu Giấy, Hà Nội' 	'NAM'	'0387620987' 'GIẢNG VIÊN' 'NULL' 'MYTHUAT'

'GV006' 'NGÔ THI THANH'	'15, Phạm Hùng, Phường Mỹ Đình 2, Quận Nam Từ Liêm, Hà Nội'	'NAM' '0387620987' 'GIẢNG VIÊN' 'NGOAINGU'

GV007 HOÀNG THÙY LINH Số 6 Ngõ 370 Nguyễn Văn Cừ, Ngọc Lâm, Long Biên, Hà Nội  NAM	0387620987 GIẢNG VIÊN (ẢNH ĐẠI DIỆN ĐỂ KO) TIN

GV008 VÕ TRUNG TÚ 12 Hàng Chĩnh, Hàng Buồm, Hoàn Kiếm, Hà Nội	NAM	0387620987 GIẢNG VIÊN (ẢNH ĐẠI DIỆN ĐỂ KO) SINH

GV009 BÙI VĂN BẢO	234, Văn Cao, Liễu Giai, Ba Đình, Hà Nội  NAM	0387620987 GIẢNG VIÊN	 DIA

GV010 TRƯƠNG TUẤN NGHĨA 716 Nguyễn Văn Cừ, Ngọc Lâm, Long Biên, Hà Nội  NAM	0387620987 GIẢNG VIÊN	 GDCD

GV011 HOÀNG ANH QUÝ 44 Trần Quốc Hoàn, Dịch Vọng Hậu, Cầu Giấy, Hà Nội  NAM	0387620987 GIẢNG VIÊN	 THEDUC

GV012 ĐỖ THỊ HẠNH 54 Liễu Giai, Cống Vị, Ba Đình, Hà Nội  NAM	0387620987 GIẢNG VIÊN	 VAN

GV013 ĐÀO DIỆU LINH  12 Chùa Bộc, Quang Trung, Đống Đa, Hà Nội  NAM	0387620987 GIẢNG VIÊN  TOAN
*/



-- THAO TÁC VỚI LỚP HỌC 
GO
CREATE PROC INSERTLOPHOC(@MALOP VARCHAR(10), @TENLOP NVARCHAR(50), @MAGVCN VARCHAR(10), @MAKH VARCHAR(10))AS
BEGIN

	INSERT INTO LOP(MaLop , TenLop , MaGVCN, MaKH)
	VALUES(@MALOP , @TENLOP, @MAGVCN , @MAKH)

END

GO
INSERTLOPHOC 'L6A', N'6A', 'NULL', 'KH20182022'

GO
CREATE PROC UPDATELOPHOC(@MALOP VARCHAR(10), @TENLOP NVARCHAR(50), @MAGVCN VARCHAR(10), @MAKH VARCHAR(10))AS
BEGIN
	
	UPDATE LOP
	SET  TenLop=@TENLOP , MaGVCN =@MAGVCN , MaKH = @MAKH 
	WHERE MaLop=@MALOP

END



GO
UPDATELOPHOC 'L6A',N'6A','GV001','KH20182022'
GO
UPDATELOPHOC 'L6B',N'6B','GV002','KH20182022'
GO
UPDATELOPHOC 'L6C',N'6C','GV003','KH20182022'

GO
INSERTLOPHOC 'L7A',N'7A','GV005','KH20172021'
GO
INSERTLOPHOC 'L7B',N'7B','GV006','KH20172021'
GO
INSERTLOPHOC 'L7C',N'7C','GV007','KH20172021'


GO
CREATE PROC DELETELOPHOC(@MALOP VARCHAR(10))AS
BEGIN
	DELETE LOP
	WHERE MaLop = @MALOP
END


-- THAO TAC VS BANG HOC SINH 

GO
CREATE PROC INSERTHOCSINH(@MAHS VARCHAR(10), @TENHS NVARCHAR(50) ,@DIACHI NVARCHAR(100), @GIOITINH NVARCHAR(4),@SDT VARCHAR(11), @ANHDAIDIEN VARBINARY(MAX),@MALOP VARCHAR(10))AS
BEGIN

	INSERT INTO HOCSINH(MaHS , TenHS, DiaChi, GioiTinh,SDT,AnhDaiDien, MaLop)
	VALUES (@MAHS , @TENHS, @DIACHI, @GIOITINH, @SDT, @ANHDAIDIEN, @MALOP)

END
/*
	'HS001',	N'HÀ NGỌC ÁNH' ,		N'154 Ngõ 173 Hoàng Hoa Thám, Ngọc Hồ, Ba Đình, Hà Nội',	'NỮ',		'','',			'L6A'
	'HS002',	N'NGUYỄN TRUNG BÌNH' ,	N'173  Phố Hàng Khay, Hoàn Kiếm, Hà Nội',					'NAM',		'','',			'L6A'
	'HS003',	N'BÙI NHƯ LẠC',			N'54 Hoàng Như Tiếp , Long Biên , Hà Nội',					'NỮ',		'','',			'L6A'

*/





-- thao tác với giảng dạy
/**
*/

GO
CREATE PROC INSERTGIANGDAY(@MAGV VARCHAR(10),@MALOP VARCHAR(10) ,@SOTIET INT , @DIADIEM NVARCHAR(50) ,@THU VARCHAR(20),@TIET VARCHAR(20) )AS
BEGIN

	INSERT INTO GIANGDAY(MaGV,MaLop,SoTiet,DiaDiem,Thu,Tiet)
	VALUES(@MAGV , @MALOP , @SOTIET , @DIADIEM , @THU , @TIET )

END
GO
INSERTGIANGDAY 'GV001','L6A','60',N'TÒA B,P.102','2,5','1-3,4-5'
GO
INSERTGIANGDAY 'GV001','L6C','60',N'TOÀ B,P104','3,6','3-5,6-8'
GO
INSERTGIANGDAY 'GV002','L6A','60',N'TÒA B,P102','4,6','1-3,1-3'
GO
INSERTGIANGDAY 'GV004','L6A','30',N'TÒA B,P102','5','3-5'
GO
INSERTGIANGDAY 'GV004','L6B','30',N'TÒA B,P103','4','1-3'
go
INSERTGIANGDAY 'GV002','L6B','45',N'TÒA B,P103','2,4','1-3'
delete GIANGDAY
where MaGV='GV002' and MaLop='L6B'


/*8 ĐOẠN NÀY NGHĨ 1 HỒI THÌ SẼ ĐỂ LÀ THEO MÃ LỚP . AE CÓ CAO KIẾN KHÁC THÌ BÁO .
VÌ NGHĨ THEO KIỂU CHUYỂN GIÁO VIÊN KHÁC ĐẾN DẠY LỚP NÀY DẠY THAY HAY HƠN LÀ 
CHUYỂN GIÁO VIÊN SANG LỚP KHÁC DẠY . VÀ NÓ SẼ UPDATE LỊCH GIẢNG DẠY LIÊN TỤC KHI CÓ THAY ĐỔI NÊN SẼ KHÔNG CHỚI XÓA
*/
GO
alter PROC UPDATEGIANGDAY(@MAGV VARCHAR(10),@MAGV1 VARCHAR(10), @MALOP VARCHAR(10) ,@MALOP1 VARCHAR(10),@SOTIET INT , @DIADIEM NVARCHAR(50) ,@THU VARCHAR(20),@TIET VARCHAR(20))AS
BEGIN
	
		UPDATE GIANGDAY
		SET MaLop = @MALOP1 ,MaGV = @MAGV1, SoTiet = @SOTIET , DiaDiem = @DIADIEM , Thu = @THU , Tiet = @TIET 
		WHERE MaGV = @MAGV and MaLop = @MALOP

END
UPDATEGIANGDAY 'GV004','GV002','L6B','L6C','35',N'TÒA B,P103','2,4','1-3' 

create proc XEMLICHGIANGDAY AS
BEGIN
	select * from GIANGDAY
END

select * from GIANGDAY


create view XEMMALOP AS
SELECT MaLop
FROM LOP

SELECT * FROM XEMMALOP 

select count(*) tongso
from GIANGDAY


create proc FilterInfo(@MAGV VARCHAR(10), @MALOP VARCHAR(10),@THU VARCHAR(20),@TIET VARCHAR(20))as
begin
	 IF(@MALOP = 'Tất cả' and @MAGV='Tất cả' and ((@THU = '' or @THU = 'None') and (@TIET = '' or @TIET = 'None')))
		begin
			select * from GIANGDAY
		end

	if(@MALOP = 'Tất cả' and @MAGV='Tất cả'and @TIET = 'Sáng' and ( @THU='' or @THU='None'))
		begin
			select * from GIANGDAY
			where Tiet LIKE '%1%' or Tiet Like '%2%' or Tiet LIKE '%3%' or Tiet LIKE '%4%' or Tiet LIKE '%5%' or Tiet LIKE '%6%'
		end

	if(@MALOP = 'Tất cả' and @MAGV='Tất cả'and @TIET = 'Chiều' and ( @THU='' or @THU='None'))
		begin
			select * from GIANGDAY
			where Tiet LIKE '%7%' or Tiet Like '%8%' or Tiet LIKE '%9%' or Tiet LIKE '%10%' or Tiet LIKE '%11%' or Tiet LIKE '%12%'
		end

	if(@MALOP = 'Tất cả' and @MAGV='Tất cả'and @TIET = 'Sáng')
		begin
			select * from GIANGDAY
			where (Tiet LIKE '%1%' or Tiet Like '%2%' or Tiet LIKE '%3%' or Tiet LIKE '%4%' or Tiet LIKE '%5%' or Tiet LIKE '%6%')
			and (Thu LIKE CAST(('%'+@THU+'%') AS varchar(20)))
		end

	if(@MALOP = 'Tất cả' and @MAGV='Tất cả'and @TIET = 'Chiều' )
		begin
			select * from GIANGDAY
			where (Tiet LIKE '%7%' or Tiet Like '%8%' or Tiet LIKE '%9%' or Tiet LIKE '%10%' or Tiet LIKE '%11%' or Tiet LIKE '%12%')
			and (Thu LIKE CAST(('%'+@THU+'%') AS varchar(20)))
		end

	 if(@MALOP = 'Tất cả' and @MAGV='Tất cả' and (@TIET= '' or @TIET= 'None') )
		begin
			select * from GIANGDAY
			where (Thu LIKE CAST(('%'+@THU+'%') AS varchar(20)))
		end

	 if(@MALOP = 'Tất cả' and @MAGV='Tất cả' and (@THU= '' or @THU= 'None') )
		begin
			select * from GIANGDAY
			where (Thu LIKE CAST(('%'+@THU+'%') AS varchar(20)))
		end

	if(@MALOP = 'Tất cả' and @TIET = 'Sáng' and (@THU!=''or @THU!='None'))
		begin
			select * from GIANGDAY
			where (Tiet LIKE '%1%' or Tiet Like '%2%' or Tiet LIKE '%3%' or Tiet LIKE '%4%' or Tiet LIKE '%5%' or Tiet LIKE '%6%')
			and (Thu LIKE CAST(('%'+@THU+'%') AS varchar(20))) and MaGV = @MAGV
		end

	 if(@MALOP = 'Tất cả' and @TIET = 'Chiều' and (@THU!=''or @THU!='None'))
		begin
			select * from GIANGDAY
			where (Tiet LIKE '%7%' or Tiet Like '%8%' or Tiet LIKE '%9%' or Tiet LIKE '%10%' or Tiet LIKE '%11%' or Tiet LIKE '%12%')
			and (Thu LIKE CAST(('%'+@THU+'%') AS varchar(20))) and MaGV = @MAGV
		end

	if(@MALOP = 'Tất cả' and @TIET = 'Sáng'  and (@THU=''or @THU='None'))
		begin
			select * from GIANGDAY
			where (Tiet LIKE '%1%' or Tiet Like '%2%' or Tiet LIKE '%3%' or Tiet LIKE '%4%' or Tiet LIKE '%5%' or Tiet LIKE '%6%')
			and MaGV = @MAGV
		end

	if(@MALOP = 'Tất cả' and @TIET = 'Chiều'  and (@THU=''or @THU='None'))
		begin
			select * from GIANGDAY
			where (Tiet LIKE '%7%' or Tiet Like '%8%' or Tiet LIKE '%9%' or Tiet LIKE '%10%' or Tiet LIKE '%11%' or Tiet LIKE '%12%')
			 and MaGV = @MAGV
		end

	if(@MAGV = 'Tất cả' and @TIET = 'Sáng'and (@THU!=''or @THU!='None'))
		begin
			select * from GIANGDAY
			where (Tiet LIKE '%1%' or Tiet Like '%2%' or Tiet LIKE '%3%' or Tiet LIKE '%4%' or Tiet LIKE '%5%' or Tiet LIKE '%6%')
			and (Thu LIKE CAST(('%'+@THU+'%') AS varchar(20))) and MaLop=@MALOP
		end

	if(@MAGV = 'Tất cả' and @TIET = 'Chiều' and (@THU!=''or @THU!='None'))
		begin
			select * from GIANGDAY
			where (Tiet LIKE '%7%' or Tiet Like '%8%' or Tiet LIKE '%9%' or Tiet LIKE '%10%' or Tiet LIKE '%11%' or Tiet LIKE '%12%')
			and (Thu LIKE CAST(('%'+@THU+'%') AS varchar(20))) and MaLop=@MALOP
		end

	 if(@MAGV = 'Tất cả' and @TIET = 'Sáng' and (@THU = 'None' or @THU=''))
		begin
			select * from GIANGDAY
			where (Tiet LIKE '%1%' or Tiet Like '%2%' or Tiet LIKE '%3%' or Tiet LIKE '%4%' or Tiet LIKE '%5%' or Tiet LIKE '%6%')
			and MaLop=@MALOP
		end

	if(@MAGV = 'Tất cả' and @TIET = 'Chiều' and (@THU='None'or @THU=''))
		begin
			select * from GIANGDAY
			where (Tiet LIKE '%7%' or Tiet Like '%8%' or Tiet LIKE '%9%' or Tiet LIKE '%10%' or Tiet LIKE '%11%' or Tiet LIKE '%12%')
			 and MaLop=@MALOP
		end

	 if(@MALOP = 'Tất cả' and ((@TIET = 'None' and @THU = 'None')or (@TIET = '' and @THU = '')) )
		begin
			select * from GIANGDAY
			where  MaGV = @MAGV
		end

	if(@MAGV = 'Tất cả'  and ((@TIET = 'None' and @THU = 'None')or (@TIET = '' and @THU = '')) )
		begin
			select * from GIANGDAY
			where  MaLop=@MALOP
		end

	if(@TIET = 'Sáng')
		begin
			select * from GIANGDAY
			where (Tiet LIKE '%1%' or Tiet Like '%2%' or Tiet LIKE '%3%' or Tiet LIKE '%4%' or Tiet LIKE '%5%' or Tiet LIKE '%6%')
			and (Thu LIKE CAST(('%'+@THU+'%') AS varchar(20))) and MaLop=@MALOP and MaGV = @MAGV
		end
	else 
		begin
			select * from GIANGDAY
			where (Tiet LIKE '%7%' or Tiet Like '%8%' or Tiet LIKE '%9%' or Tiet LIKE '%10%' or Tiet LIKE '%11%' or Tiet LIKE '%12%')
			and (Thu LIKE CAST(('%'+@THU+'%') AS varchar(20))) and MaLop=@MALOP and MaGV = @MAGV
		end
end

create proc GetDanhSachHocSinhLop(@malop varchar(10))as
begin
	select * from HOCSINH
	where MaLop = @malop
end

xemchitietmotlop 'L6A'



select * from HOCSINH
where MaLop = 'L6A'

/*
select * from GIANGDAY
where Thu LIKE '%1%' or Thu Like '%2%' or Thu LIKE '%3%' or Thu LIKE '%4%' or Thu LIKE '%5%' or Thu LIKE '%6%'

create view chianho
as
select 

CREATE FUNCTION dbo.splitstring ( @stringToSplit VARCHAR(MAX) )
RETURNS
 @returnList TABLE ([Name] [nvarchar] (500))
AS
BEGIN

 DECLARE @name NVARCHAR(255)
 DECLARE @pos INT

 WHILE CHARINDEX(',', @stringToSplit) > 0
 BEGIN
  SELECT @pos  = CHARINDEX(',', @stringToSplit)  
  SELECT @name = SUBSTRING(@stringToSplit, 1, @pos-1)

  INSERT INTO @returnList 
  SELECT @name

  SELECT @stringToSplit = SUBSTRING(@stringToSplit, @pos+1, LEN(@stringToSplit)-@pos)
 END

 INSERT INTO @returnList
 SELECT @stringToSplit

 RETURN
END


SELECT * FROM dbo.splitstring(GIANGDAY.Thu)


*/
-- NÚT CUỐI PHẦN 2 ĐÂY
-->*/
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



