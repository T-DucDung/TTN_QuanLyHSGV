--them
alter PROC ThemGV ( @TenGV nvarchar(50),@DiaChi nvarchar(100), @GioiTinh nvarchar(4),
@SDT varchar(11), @ChucVu nvarchar(50), @AnhDaiDien varbinary(max),@MaMon varchar(10) )
As
BEGIN
	declare @maGV varchar(10), @temp int, @i varchar(10)
	if((select COUNT(MaGV) from GIAOVIEN) = 0)
		begin
			set @temp=0
			set @temp=@temp+1
			set @i= CONCAT('GV00', @temp)
		end
	else 
		begin 
			declare @x int
			set @x = (select CAST((select MAX(So.so) from (select REPLACE(MaGV, 'GV', '') as so from GiaoVien) as So) as int))
			if( @x < 9 )
				begin 
					set @x = @x+1
					set @i = CONCAT('GV00', @x)
				end
			else if( @x < 99 and @x >= 9 )
				begin 
					set @x = @x+1
					set @i = CONCAT('GV0', @x)
				end
			else if( @x < 999 and @x >= 99 )
				begin 
					set @x = @x+1
					set @i = CONCAT('GV', @x)
				end
			else if( @x >= 999 )
				begin 
					set @x = @x+1
					set @i = CONCAT('GV', @x)
				end
		end

	INSERT INTO GIAOVIEN(MaGV, TenGV,DiaChi, GioiTinh, SDT , ChucVu, AnhDaiDien, MaMon)
	VALUES (@i ,@TenGV, @DiaChi, @GioiTinh, @SDT, @ChucVu, @AnhDaiDien, @MaMon)
END
go

exec ThemGV N'1h', N'h',N'h', '2', N'h', 0, 'Toan'
select * from GIAOVIEN

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

alter PROC ThemHS ( @TenHS nvarchar(50),@DiaChi nvarchar(100), @GioiTinh nvarchar(4),
@SDT varchar(11), @AnhDaiDien varbinary(max),@MaLop varchar(10) )
As
BEGIN
	declare @maGV varchar(10), @temp int, @i varchar(10)
	if((select COUNT(MaHS) from HOCSINH) = 0)
		begin
			set @temp=0
			set @temp=@temp+1
			set @i= CONCAT('HS00', @temp)
		end
	else 
		begin 
			declare @x int
			set @x = (select CAST((select MAX(So.so) from (select REPLACE(MaHS, 'HS', '') as so from HOCSINH) as So) as int))
			if( @x < 9 )
				begin 
					set @x = @x+1
					set @i = CONCAT('HS00', @x)
				end
			else if( @x < 99 and @x >= 9 )
				begin 
					set @x = @x+1
					set @i = CONCAT('HS0', @x)
				end
			else if( @x < 999 and @x >= 99 )
				begin 
					set @x = @x+1
					set @i = CONCAT('HS', @x)
				end
			else if( @x >= 999 )
				begin 
					set @x = @x+1
					set @i = CONCAT('HS', @x)
				end
		end

	INSERT INTO HOCSINH(MaHS,TenHS ,DiaChi, GioiTinh, SDT, AnhDaiDien, MaLop)
	VALUES (@i ,@TenHS, @DiaChi, @GioiTinh, @SDT, @AnhDaiDien, @MaLop)
END
go
exec ThemHS N'h', N'h',N'h', '2', 0, 'Lop6'
select  * from HOCSINH
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
	SELECT HOCSINH.*,  KHOAHOC.MaKH, KHOAHOC.TenKH
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
