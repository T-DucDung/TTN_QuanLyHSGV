--them
create PROC ThemGV ( @TenGV nvarchar(50),@DiaChi nvarchar(100), @GioiTinh nvarchar(4),
@SDT varchar(11), @ChucVu nvarchar(50), @AnhDaiDien varbinary(max),@MaMon varchar(10) )
As
BEGIN
	declare @maGV varchar(10), @temp int, @i varchar(10)
	if((select COUNT(MaGV) from GIAOVIEN) = 0)
		set @temp=0
	else 
		set @temp=( select MAX(CAST(MaGV as int)) from GIAOVIEN )
	set @temp=@temp+1
	set @i=CAST(@temp as varchar(10))
	INSERT INTO GIAOVIEN(MaGV, TenGV,DiaChi, GioiTinh, SDT , ChucVu, AnhDaiDien, MaMon)
	VALUES (@i ,@TenGV, @DiaChi, @GioiTinh, @SDT, @ChucVu, @AnhDaiDien, @MaMon)
END
go


exec ThemGV N'h', N'h',N'h', '2', N'h', 0, 'Toan'


--Sua
CREATE PROC SuaGV (@Ma varchar(10), @TenGV nvarchar(50),@DiaChi nvarchar(100), @GioiTinh nvarchar(4),
@SDT varchar(11), @ChucVu nvarchar(50), @AnhDaiDien varbinary(max),@MaMon varchar(10))
AS
BEGIN
	UPDATE GIAOVIEN
	SET TenGV=@TenGV, DiaChi=@DiaChi, GioiTinh=@GioiTinh, SDT=@SDT, ChucVu=@ChucVu, AnhDaiDien=@AnhDaiDien, MaMon=@MaMon
	where MaGV = @Ma
END
go

--XEM THONG TIN Gv
create PROC XemTatCaGV AS
BEGIN
	SELECT * FROM GIAOVIEN
END
go
-- xem 1 gv
CREATE PROC XemChiTietGV(@Ma varchar(10)) 
AS
BEGIN
	SELECT * FROM GIAOVIEN
	WHERE MaGV = @Ma
END
--XEM tat ca mon
create PROC XemTatCaMonHoc AS
BEGIN
	SELECT * FROM MONHOC
END
go

create proc LayChucVu 
as
begin
	select ChucVu from GIAOVIEN
	group by ChucVu
end


-----------------------------------HS-----------------------------
--them

create PROC ThemHS ( @TenHS nvarchar(50),@DiaChi nvarchar(100), @GioiTinh nvarchar(4),
@SDT varchar(11), @AnhDaiDien varbinary(max),@MaLop varchar(10) )
As
BEGIN
	declare @maHS varchar(10), @temp int, @i varchar(10)
	select * from HOCSINH
	if((select COUNT(MaHS) from HOCSINH) = 0)
		set @temp=0
	else 
		set @temp=( select MAX(CAST(MaHS as int)) from HOCSINH )
	set @temp=@temp+1
	set @i=CAST(@temp as varchar(10))
	INSERT INTO HOCSINH(MaHS,TenHS ,DiaChi, GioiTinh, SDT, AnhDaiDien, MaLop)
	VALUES (@i ,@TenHS, @DiaChi, @GioiTinh, @SDT, @AnhDaiDien, @MaLop)
END
go
exec ThemHS N'h', N'h',N'h', '2', 0, 'Lop6'
go

--Sua
CREATE PROC SuaHS (@Ma varchar(10), @TenHS nvarchar(50),@DiaChi nvarchar(100), @GioiTinh nvarchar(4),
@SDT varchar(11), @AnhDaiDien varbinary(max), @MaLop varchar(10))
AS
BEGIN
	UPDATE HOCSINH
	SET TenHS=@TenHS, DiaChi=@DiaChi, GioiTinh=@GioiTinh, SDT=@SDT, AnhDaiDien=@AnhDaiDien, MaLop=@MaLop
	where MaHS = @Ma
END
go


--XEM THONG TIN Gv
create PROC XemTatCaHS AS
BEGIN
	SELECT HOCSINH.*,  KHOAHOC.MaKH
	FROM HOCSINH inner join LOP on HOCSINH.MaLop = LOP.MaLop
	inner join KHOAHOC on LOP.MaKH = KHOAHOC.MaKH
END
go
-- xem 1 gv
CREATE PROC XemChiTietHS(@Ma int) 
AS
BEGIN
	SELECT * FROM HOCSINH
	WHERE MaHS = @Ma
END
--XEM tat ca mon
create PROC XemTatCaLopHoc AS
BEGIN
	SELECT MaLop, TenLop FROM LOP
END
go

create proc XemTatCaKhoaHoc as
begin
	select * from KHOAHOC
end

go

create proc SearchHocSinh (@GioiTinh nvarchar(4), @MaLop varchar(10), @MaKhoa varchar(10))
as
begin
	if(@GioiTinh = 'None' and @MaLop = 'None' and @MaKhoa = 'None')
		select HOCSINH.* 
		from HOCSINH join LOP on HOCSINH.MaLop = LOP.MaLop inner join KHOAHOC on LOP.MaKH = KHOAHOC.MaKH
	if(@GioiTinh != 'None' and @MaLop = 'None' and @MaKhoa = 'None')
		select HOCSINH.* 
		from HOCSINH join LOP on HOCSINH.MaLop = LOP.MaLop inner join KHOAHOC on LOP.MaKH = KHOAHOC.MaKH
		where GioiTinh = @GioiTinh
	if(@GioiTinh = 'None' and @MaLop != 'None' and @MaKhoa = 'None')
		select HOCSINH.* 
		from HOCSINH join LOP on HOCSINH.MaLop = LOP.MaLop inner join KHOAHOC on LOP.MaKH = KHOAHOC.MaKH
		where Lop.MaLop = @MaLop
	if(@GioiTinh = 'None' and @MaLop = 'None' and @MaKhoa != 'None')
		select HOCSINH.* 
		from HOCSINH join LOP on HOCSINH.MaLop = LOP.MaLop inner join KHOAHOC on LOP.MaKH = KHOAHOC.MaKH
		where KHOAHOC.MaKH = @MaKhoa
	if(@GioiTinh != 'None' and @MaLop != 'None' and @MaKhoa = 'None')
		select HOCSINH.* 
		from HOCSINH join LOP on HOCSINH.MaLop = LOP.MaLop inner join KHOAHOC on LOP.MaKH = KHOAHOC.MaKH
		where GioiTinh = @GioiTinh and LOP.MaLop = @MaLop
	if(@GioiTinh != 'None' and @MaLop = 'None' and @MaKhoa != 'None')
		select HOCSINH.* 
		from HOCSINH join LOP on HOCSINH.MaLop = LOP.MaLop inner join KHOAHOC on LOP.MaKH = KHOAHOC.MaKH
		where GioiTinh = @GioiTinh and KHOAHOC.MaKH = @MaKhoa
	if(@GioiTinh = 'None' and @MaLop != 'None' and @MaKhoa != 'None')
		select HOCSINH.* 
		from HOCSINH join LOP on HOCSINH.MaLop = LOP.MaLop inner join KHOAHOC on LOP.MaKH = KHOAHOC.MaKH
		where LOP.MaLop = @MaLop and KHOAHOC.MaKH = @MaKhoa
	if(@GioiTinh != 'None' and @MaLop != 'None' and @MaKhoa != 'None')
		select HOCSINH.* 
		from HOCSINH join LOP on HOCSINH.MaLop = LOP.MaLop inner join KHOAHOC on LOP.MaKH = KHOAHOC.MaKH
		where GioiTinh=@GioiTinh and LOP.MaLop = @MaLop and KHOAHOC.MaKH = @MaKhoa
end