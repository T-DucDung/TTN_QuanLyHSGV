--them
CREATE PROC ThemGV ( @TenGV nvarchar(50),@DiaChi nvarchar(100), @GioiTinh nvarchar(4),
@SDT varchar(11), @ChucVu nvarchar(50), @AnhDaiDien varbinary(max),@MaMon int)
As
BEGIN
	INSERT INTO GIAOVIEN(TenGV ,DiaChi, GioiTinh, SDT , ChucVu, AnhDaiDien, MaMon)
	VALUES (@TenGV, @DiaChi, @GioiTinh, @SDT, @ChucVu, @AnhDaiDien, @MaMon)
END
go

--Sua
CREATE PROC SuaGV (@Ma int, @TenGV nvarchar(50),@DiaChi nvarchar(100), @GioiTinh nvarchar(4),
@SDT varchar(11), @ChucVu nvarchar(50), @AnhDaiDien varbinary(max),@MaMon int)
AS
BEGIN
	UPDATE GIAOVIEN
	SET TenGV=@TenGV, DiaChi=@DiaChi, GioiTinh=@GioiTinh, SDT=@SDT, ChucVu=@ChucVu, AnhDaiDien=@AnhDaiDien, MaMon=@MaMon
	where MaGV = @Ma
END
go

--Xoa
CREATE PROC XoaGV(@Ma int)
AS
BEGIN
	DELETE FROM GIAOVIEN
	WHERE MaGV = @Ma
END
go

--XEM THONG TIN Gv
create PROC XemTatCaGV AS
BEGIN
	SELECT * FROM GIAOVIEN
END
go
-- xem 1 gv
CREATE PROC XemChiTietGV(@Ma int) 
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

create proc SearchGiaoVien (@GioiTinh nvarchar(4), @ChucVu nvarchar(50), @MaMon int)
as
begin
	if(@GioiTinh = 'none' and @ChucVu = 'none' and @MaMon = 0)
		select * from GIAOVIEN
	if(@GioiTinh != 'none' and @ChucVu = 'none' and @MaMon = 0)
		select * from GIAOVIEN where GioiTinh = @GioiTinh
	if(@GioiTinh = 'none' and @ChucVu != 'none' and @MaMon = 0)
		select * from GIAOVIEN where ChucVu = @ChucVu
	if(@GioiTinh = 'none' and @ChucVu = 'none' and @MaMon != 0)
		select * from GIAOVIEN where MaMon = @MaMon
	if(@GioiTinh != 'none' and @ChucVu != 'none' and @MaMon = 0)
		select * from GIAOVIEN where GioiTinh = @GioiTinh and ChucVu = @ChucVu
	if(@GioiTinh != 'none' and @ChucVu = 'none' and @MaMon != 0)
		select * from GIAOVIEN where GioiTinh = @GioiTinh and MaMon = @MaMon
	if(@GioiTinh = 'none' and @ChucVu != 'none' and @MaMon != 0)
		select * from GIAOVIEN where MaMon = @MaMon and ChucVu = @ChucVu
	if(@GioiTinh != 'none' and @ChucVu != 'none' and @MaMon != 0)
		select * from GIAOVIEN where GioiTinh=@GioiTinh and ChucVu=@ChucVu and MaMon=@MaMon
end

exec SearchGiaoVien N'none', N'none', 0 

-----------------------------------HS-----------------------------
--them
CREATE PROC ThemHS ( @TenHS nvarchar(50),@DiaChi nvarchar(100), @GioiTinh nvarchar(4),
@SDT varchar(11), @AnhDaiDien varbinary(max),@MaLop int)
As
BEGIN
	INSERT INTO HOCSINH(TenHS ,DiaChi, GioiTinh, SDT, AnhDaiDien, MaLop)
	VALUES (@TenHS, @DiaChi, @GioiTinh, @SDT, @AnhDaiDien, @MaLop)
END
go

--Sua
CREATE PROC SuaHS (@Ma int, @TenHS nvarchar(50),@DiaChi nvarchar(100), @GioiTinh nvarchar(4),
@SDT varchar(11), @AnhDaiDien varbinary(max), @MaLop int)
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
	SELECT * FROM HOCSINH
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

create proc SearchHocSinh (@GioiTinh nvarchar(4), @MaLop int, @MaKhoa int)
as
begin
	if(@GioiTinh = 'none' and @MaLop = 0 and @MaKhoa = 0)
		select HOCSINH.* 
		from HOCSINH join LOP on HOCSINH.MaLop = LOP.MaLop inner join KHOAHOC on LOP.MaKH = KHOAHOC.MaKH
	if(@GioiTinh != 'none' and @MaLop = 0 and @MaKhoa = 0)
		select HOCSINH.* 
		from HOCSINH join LOP on HOCSINH.MaLop = LOP.MaLop inner join KHOAHOC on LOP.MaKH = KHOAHOC.MaKH
		where GioiTinh = @GioiTinh
	if(@GioiTinh = 'none' and @MaLop != 0 and @MaKhoa = 0)
		select HOCSINH.* 
		from HOCSINH join LOP on HOCSINH.MaLop = LOP.MaLop inner join KHOAHOC on LOP.MaKH = KHOAHOC.MaKH
		where Lop.MaLop = @MaLop
	if(@GioiTinh = 'none' and @MaLop = 0 and @MaKhoa != 0)
		select HOCSINH.* 
		from HOCSINH join LOP on HOCSINH.MaLop = LOP.MaLop inner join KHOAHOC on LOP.MaKH = KHOAHOC.MaKH
		where KHOAHOC.MaKH = @MaKhoa
	if(@GioiTinh != 'none' and @MaLop != 0 and @MaKhoa = 0)
		select HOCSINH.* 
		from HOCSINH join LOP on HOCSINH.MaLop = LOP.MaLop inner join KHOAHOC on LOP.MaKH = KHOAHOC.MaKH
		where GioiTinh = @GioiTinh and LOP.MaLop = @MaLop
	if(@GioiTinh != 'none' and @MaLop = 0 and @MaKhoa != 0)
		select HOCSINH.* 
		from HOCSINH join LOP on HOCSINH.MaLop = LOP.MaLop inner join KHOAHOC on LOP.MaKH = KHOAHOC.MaKH
		where GioiTinh = @GioiTinh and KHOAHOC.MaKH = @MaKhoa
	if(@GioiTinh = 'none' and @MaLop != 0 and @MaKhoa != 0)
		select HOCSINH.* 
		from HOCSINH join LOP on HOCSINH.MaLop = LOP.MaLop inner join KHOAHOC on LOP.MaKH = KHOAHOC.MaKH
		where LOP.MaLop = @MaLop and KHOAHOC.MaKH = @MaKhoa
	if(@GioiTinh != 'none' and @MaLop != 0 and @MaKhoa != 0)
		select HOCSINH.* 
		from HOCSINH join LOP on HOCSINH.MaLop = LOP.MaLop inner join KHOAHOC on LOP.MaKH = KHOAHOC.MaKH
		where GioiTinh=@GioiTinh and LOP.MaLop = @MaLop and KHOAHOC.MaKH = @MaKhoa
end