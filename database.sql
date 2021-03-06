USE [master]
GO
/****** Object:  Database [TTN_QLHSGV]    Script Date: 04/15/20 2:10:07 PM ******/
CREATE DATABASE [TTN_QLHSGV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TTN_QLHSGV', FILENAME = N'D:\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\TTN_QLHSGV.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TTN_QLHSGV_log', FILENAME = N'D:\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\TTN_QLHSGV_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [TTN_QLHSGV] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TTN_QLHSGV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TTN_QLHSGV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TTN_QLHSGV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TTN_QLHSGV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TTN_QLHSGV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TTN_QLHSGV] SET ARITHABORT OFF 
GO
ALTER DATABASE [TTN_QLHSGV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TTN_QLHSGV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TTN_QLHSGV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TTN_QLHSGV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TTN_QLHSGV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TTN_QLHSGV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TTN_QLHSGV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TTN_QLHSGV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TTN_QLHSGV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TTN_QLHSGV] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TTN_QLHSGV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TTN_QLHSGV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TTN_QLHSGV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TTN_QLHSGV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TTN_QLHSGV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TTN_QLHSGV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TTN_QLHSGV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TTN_QLHSGV] SET RECOVERY FULL 
GO
ALTER DATABASE [TTN_QLHSGV] SET  MULTI_USER 
GO
ALTER DATABASE [TTN_QLHSGV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TTN_QLHSGV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TTN_QLHSGV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TTN_QLHSGV] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TTN_QLHSGV] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'TTN_QLHSGV', N'ON'
GO
ALTER DATABASE [TTN_QLHSGV] SET QUERY_STORE = OFF
GO
USE [TTN_QLHSGV]
GO
/****** Object:  UserDefinedFunction [dbo].[splitstring]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[splitstring] ( @stringToSplit VARCHAR(MAX) )
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
GO
/****** Object:  Table [dbo].[LOP]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOP](
	[MaLop] [varchar](10) NOT NULL,
	[TenLop] [nvarchar](50) NOT NULL,
	[MaGVCN] [varchar](10) NULL,
	[MaKH] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[XEMMALOP]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[XEMMALOP] AS
SELECT MaLop
FROM LOP
GO
/****** Object:  Table [dbo].[GIANGDAY]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIANGDAY](
	[MaGV] [varchar](10) NOT NULL,
	[MaLop] [varchar](10) NOT NULL,
	[SoTiet] [int] NULL,
	[DiaDiem] [nvarchar](50) NULL,
	[Thu] [varchar](20) NULL,
	[Tiet] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC,
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GIAOVIEN]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIAOVIEN](
	[MaGV] [varchar](10) NOT NULL,
	[TenGV] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](100) NULL,
	[GioiTinh] [nvarchar](4) NOT NULL,
	[SDT] [varchar](11) NULL,
	[ChucVu] [nvarchar](50) NOT NULL,
	[AnhDaiDien] [varbinary](max) NULL,
	[MaMon] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOCSINH]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOCSINH](
	[MaHS] [varchar](10) NOT NULL,
	[TenHS] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](200) NULL,
	[GioiTinh] [nvarchar](4) NOT NULL,
	[SDT] [varchar](11) NULL,
	[AnhDaiDien] [varbinary](max) NULL,
	[MaLop] [varchar](10) NULL,
 CONSTRAINT [PK__HOCSINH__2725A6EF189A09D7] PRIMARY KEY CLUSTERED 
(
	[MaHS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHOA]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHOA](
	[MaKhoa] [varchar](10) NOT NULL,
	[TenKhoa] [nvarchar](50) NOT NULL,
	[MaTruongKhoa] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHOAHOC]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHOAHOC](
	[MaKH] [varchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MONHOC]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MONHOC](
	[MaMon] [varchar](10) NOT NULL,
	[TenMon] [nvarchar](50) NOT NULL,
	[MaKhoa] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[GIANGDAY]  WITH CHECK ADD FOREIGN KEY([MaGV])
REFERENCES [dbo].[GIAOVIEN] ([MaGV])
GO
ALTER TABLE [dbo].[GIANGDAY]  WITH CHECK ADD FOREIGN KEY([MaGV])
REFERENCES [dbo].[GIAOVIEN] ([MaGV])
GO
ALTER TABLE [dbo].[GIANGDAY]  WITH CHECK ADD FOREIGN KEY([MaLop])
REFERENCES [dbo].[LOP] ([MaLop])
GO
ALTER TABLE [dbo].[GIANGDAY]  WITH CHECK ADD FOREIGN KEY([MaLop])
REFERENCES [dbo].[LOP] ([MaLop])
GO
ALTER TABLE [dbo].[GIAOVIEN]  WITH CHECK ADD FOREIGN KEY([MaMon])
REFERENCES [dbo].[MONHOC] ([MaMon])
GO
ALTER TABLE [dbo].[GIAOVIEN]  WITH CHECK ADD FOREIGN KEY([MaMon])
REFERENCES [dbo].[MONHOC] ([MaMon])
GO
ALTER TABLE [dbo].[HOCSINH]  WITH CHECK ADD FOREIGN KEY([MaLop])
REFERENCES [dbo].[LOP] ([MaLop])
GO
ALTER TABLE [dbo].[HOCSINH]  WITH CHECK ADD  CONSTRAINT [FK__HOCSINH__MaLop__4316F928] FOREIGN KEY([MaLop])
REFERENCES [dbo].[LOP] ([MaLop])
GO
ALTER TABLE [dbo].[HOCSINH] CHECK CONSTRAINT [FK__HOCSINH__MaLop__4316F928]
GO
ALTER TABLE [dbo].[KHOA]  WITH CHECK ADD FOREIGN KEY([MaTruongKhoa])
REFERENCES [dbo].[GIAOVIEN] ([MaGV])
GO
ALTER TABLE [dbo].[KHOA]  WITH CHECK ADD FOREIGN KEY([MaTruongKhoa])
REFERENCES [dbo].[GIAOVIEN] ([MaGV])
GO
ALTER TABLE [dbo].[LOP]  WITH CHECK ADD FOREIGN KEY([MaGVCN])
REFERENCES [dbo].[GIAOVIEN] ([MaGV])
GO
ALTER TABLE [dbo].[LOP]  WITH CHECK ADD FOREIGN KEY([MaGVCN])
REFERENCES [dbo].[GIAOVIEN] ([MaGV])
GO
ALTER TABLE [dbo].[LOP]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHOAHOC] ([MaKH])
GO
ALTER TABLE [dbo].[LOP]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHOAHOC] ([MaKH])
GO
ALTER TABLE [dbo].[MONHOC]  WITH CHECK ADD FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[KHOA] ([MaKhoa])
GO
ALTER TABLE [dbo].[MONHOC]  WITH CHECK ADD FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[KHOA] ([MaKhoa])
GO
/****** Object:  StoredProcedure [dbo].[AddLop]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AddLop] @tenlop nvarchar(50), @magv varchar(10), @tenkh nvarchar(50)
as
begin
	declare @makh varchar(10)
	set @makh = (select MaKH from KHOAHOC where TenKH = @tenkh)
	insert into LOP
	values('L'+@tenlop,@tenlop,@magv,@makh)
	select 'L'+@tenlop
end
GO
/****** Object:  StoredProcedure [dbo].[DELETEKHOA]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DELETEKHOA](@MAKHOA VARCHAR(10))AS
BEGIN

	DELETE KHOA 
	WHERE MaKhoa = @MAKHOA

END
GO
/****** Object:  StoredProcedure [dbo].[DELETELOPHOC]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DELETELOPHOC](@MALOP VARCHAR(10))AS
BEGIN
	DELETE LOP
	WHERE MaLop = @MALOP
END
GO
/****** Object:  StoredProcedure [dbo].[DELETEMONHOC]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DELETEMONHOC](@MAMONHOC VARCHAR(10))AS
BEGIN
	DELETE MONHOC
	WHERE MaMon = @MAMONHOC
END
GO
/****** Object:  StoredProcedure [dbo].[FilterInfo]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[FilterInfo](@MAGV VARCHAR(10), @MALOP VARCHAR(10),@THU VARCHAR(20),@TIET VARCHAR(20))as
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
GO
/****** Object:  StoredProcedure [dbo].[GetDanhSachHocSinhGt]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetDanhSachHocSinhGt] @gt nvarchar(4)
as
begin
	select * from HOCSINH where GioiTinh = @gt
end
GO
/****** Object:  StoredProcedure [dbo].[GetDanhSachHocSinhLop]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetDanhSachHocSinhLop] @malop varchar(10)
as
begin
	select * from HOCSINH where MaLop = @malop or MaLop in (select MaLop from lop where TenLop = @malop)
end
GO
/****** Object:  StoredProcedure [dbo].[GetDanhSachHocSinhLopGt]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetDanhSachHocSinhLopGt] @malop nvarchar(50), @gt nvarchar(4)
as
begin
	select * from HOCSINH where GioiTinh = @gt and MaLop In (select MaLop from LOP where TenLop = @malop)
end
GO
/****** Object:  StoredProcedure [dbo].[GetDanhSachKhoaHoc]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetDanhSachKhoaHoc] as
begin
	select * from KHOAHOC
end
GO
/****** Object:  StoredProcedure [dbo].[GetDanhSachLop]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[GetDanhSachLop] as
begin
	select * from LOP
end
GO
/****** Object:  StoredProcedure [dbo].[GetDanhSachLopTheoKhoa]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create Proc [dbo].[GetDanhSachLopTheoKhoa] @KhoaHoc nvarchar(50) as
begin
	select MaLop,TenLop,MaGVCN,LOP.MaKH from LOP,KHOAHOC where KHOAHOC.MaKH = LOP.MaKH and TenKH = @KhoaHoc
end
GO
/****** Object:  StoredProcedure [dbo].[GetDanhSachTenGV]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetDanhSachTenGV]
as
begin
	select MaGV +':'+ TenGV from GIAOVIEN
end
GO
/****** Object:  StoredProcedure [dbo].[GetGVCN]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetGVCN] @MaLop varchar(10) as
begin
	select TenGV from LOP,GIAOVIEN where Lop.MaGVCN = GIAOVIEN.MaGV and LOP.MaLop = @MaLop
end
GO
/****** Object:  StoredProcedure [dbo].[GetTenLop]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetTenLop] @malop varchar(10)
as
begin
	select TenLop from LOP where MaLop = @malop
end
GO
/****** Object:  StoredProcedure [dbo].[gettenmonhoc]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- them 1 cai proc moi 
-- author : Vu
-- lay ten mon theo giaovien

create proc [dbo].[gettenmonhoc](@magiaovien varchar(10))as
begin
	select TenMon from MONHOC , GIAOVIEN 
	where MaGV=@magiaovien and GIAOVIEN.MaMon = MONHOC.MaMon
	
end
GO
/****** Object:  StoredProcedure [dbo].[INSERTGIANGDAY]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[INSERTGIANGDAY](@MAGV VARCHAR(10),@MALOP VARCHAR(10) ,@SOTIET INT , @DIADIEM NVARCHAR(50) ,@THU VARCHAR(20),@TIET VARCHAR(20) )AS
BEGIN

	INSERT INTO GIANGDAY(MaGV,MaLop,SoTiet,DiaDiem,Thu,Tiet)
	VALUES(@MAGV , @MALOP , @SOTIET , @DIADIEM , @THU , @TIET )

END
GO
/****** Object:  StoredProcedure [dbo].[INSERTGIAOVIEN]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[INSERTGIAOVIEN](@MAGV VARCHAR(10), @TENGV NVARCHAR(50), @DiaChi NVARCHAR(100), @GioiTinh NVARCHAR(4), @SDT NVARCHAR(11), @ChucVu NVARCHAR(50), @MaMon VARCHAR(10))AS
BEGIN

	INSERT INTO [dbo].[GIAOVIEN]
           ([MaGV]
           ,[TenGV]
           ,[DiaChi]
           ,[GioiTinh]
           ,[SDT]
           ,[ChucVu]
           ,[MaMon])
     VALUES
           (@MAGV, @TENGv, @DiaChi, @GioiTinh, @SDT , @ChucVu, @MaMon )

END
GO
/****** Object:  StoredProcedure [dbo].[INSERTHOCSINH]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[INSERTHOCSINH](@MAHS VARCHAR(10), @TENHS NVARCHAR(50) ,@DIACHI NVARCHAR(100), @GIOITINH NVARCHAR(4),@SDT VARCHAR(11), @ANHDAIDIEN VARBINARY(MAX),@MALOP VARCHAR(10))AS
BEGIN

	INSERT INTO HOCSINH(MaHS , TenHS, DiaChi, GioiTinh,SDT,AnhDaiDien, MaLop)
	VALUES (@MAHS , @TENHS, @DIACHI, @GIOITINH, @SDT, @ANHDAIDIEN, @MALOP)

END
GO
/****** Object:  StoredProcedure [dbo].[INSERTKHOA]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[INSERTKHOA](@MAKHOA VARCHAR(10), @TENKHOA NVARCHAR(50), @MATRUONGKHOA VARCHAR(10))AS
BEGIN

	INSERT INTO KHOA(MaKhoa , TenKhoa , MaTruongKhoa)
	VALUES(@MAKHOA , @TENKHOA , @MATRUONGKHOA)

END


GO
/****** Object:  StoredProcedure [dbo].[INSERTKHOAHOC]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- THAP TÁC VỚI KHÓA HỌC
CREATE PROC [dbo].[INSERTKHOAHOC](@MAKHOAHOC VARCHAR(10), @TENKHOAHOC NVARCHAR(50))AS
BEGIN

	INSERT INTO KHOAHOC(MaKH,TenKH)
	VALUES(@MAKHOAHOC,@TENKHOAHOC)

END

GO
/****** Object:  StoredProcedure [dbo].[INSERTLOPHOC]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[INSERTLOPHOC](@MALOP VARCHAR(10), @TENLOP NVARCHAR(50), @MAGVCN VARCHAR(10), @MAKH VARCHAR(10))AS
BEGIN

	INSERT INTO LOP(MaLop , TenLop , MaGVCN, MaKH)
	VALUES(@MALOP , @TENLOP, @MAGVCN , @MAKH)

END

GO
/****** Object:  StoredProcedure [dbo].[INSERTMONHOC]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[INSERTMONHOC](@MAMONHOC VARCHAR(10),@TENMONHOC NVARCHAR(50),@MAKHOA VARCHAR(10))AS
BEGIN
	INSERT INTO MONHOC(MaMon,TenMon ,MaKhoa)
	VALUES(@MAMONHOC ,@TENMONHOC , @MAKHOA)
END
GO
/****** Object:  StoredProcedure [dbo].[LayChucVu]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LayChucVu] 
as
begin
	select ChucVu from GIAOVIEN
	group by ChucVu
end
GO
/****** Object:  StoredProcedure [dbo].[SearchGiaoVien]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SearchGiaoVien] (@GioiTinh nvarchar(4), @ChucVu nvarchar(50), @MaMon varchar(10))
as
begin
	if(@GioiTinh = 'None' and @ChucVu = 'None' and @MaMon = 'None')
		select * from GIAOVIEN
	if(@GioiTinh != 'None' and @ChucVu = 'None' and @MaMon = 'None')
		select * from GIAOVIEN where GioiTinh = @GioiTinh
	if(@GioiTinh = 'None' and @ChucVu != 'None' and @MaMon = 'None')
		select * from GIAOVIEN where ChucVu = @ChucVu
	if(@GioiTinh = 'None' and @ChucVu = 'None' and @MaMon != 'None')
		select * from GIAOVIEN where MaMon = @MaMon
	if(@GioiTinh != 'None' and @ChucVu != 'None' and @MaMon = 'None')
		select * from GIAOVIEN where GioiTinh = @GioiTinh and ChucVu = @ChucVu
	if(@GioiTinh != 'None' and @ChucVu = 'None' and @MaMon != 'None')
		select * from GIAOVIEN where GioiTinh = @GioiTinh and MaMon = @MaMon
	if(@GioiTinh = 'None' and @ChucVu != 'None' and @MaMon != 'None')
		select * from GIAOVIEN where MaMon = @MaMon and ChucVu = @ChucVu
	if(@GioiTinh != 'None' and @ChucVu != 'None' and @MaMon != 'None')
		select * from GIAOVIEN where GioiTinh=@GioiTinh and ChucVu=@ChucVu and MaMon=@MaMon
end
GO
/****** Object:  StoredProcedure [dbo].[SearchHocSinh]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SearchHocSinh] (@GioiTinh nvarchar(4), @MaLop varchar(10), @MaKhoa varchar(10))
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
GO
/****** Object:  StoredProcedure [dbo].[SuaGV]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaGV] (@Ma varchar(10), @TenGV nvarchar(50),@DiaChi nvarchar(100), @GioiTinh nvarchar(4),
@SDT varchar(11), @ChucVu nvarchar(50), @AnhDaiDien varbinary(max),@MaMon varchar(10))
AS
BEGIN
	UPDATE GIAOVIEN
	SET TenGV=@TenGV, DiaChi=@DiaChi, GioiTinh=@GioiTinh, SDT=@SDT, ChucVu=@ChucVu, AnhDaiDien=@AnhDaiDien, MaMon=@MaMon
	where MaGV = @Ma
END
GO
/****** Object:  StoredProcedure [dbo].[SuaHS]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaHS] (@Ma varchar(10), @TenHS nvarchar(50),@DiaChi nvarchar(100), @GioiTinh nvarchar(4),
@SDT varchar(11), @AnhDaiDien varbinary(max), @MaLop varchar(10))
AS
BEGIN
	UPDATE HOCSINH
	SET TenHS=@TenHS, DiaChi=@DiaChi, GioiTinh=@GioiTinh, SDT=@SDT, AnhDaiDien=@AnhDaiDien, MaLop=@MaLop
	where MaHS = @Ma
END
GO
/****** Object:  StoredProcedure [dbo].[ThemGV]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemGV] ( @TenGV nvarchar(50),@DiaChi nvarchar(100), @GioiTinh nvarchar(4),
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
GO
/****** Object:  StoredProcedure [dbo].[ThemHS]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemHS] ( @TenHS nvarchar(50),@DiaChi nvarchar(100), @GioiTinh nvarchar(4),
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
GO
/****** Object:  StoredProcedure [dbo].[UPDATEGIANGDAY]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UPDATEGIANGDAY](@MAGV VARCHAR(10),@MALOP VARCHAR(10) ,@SOTIET INT , @DIADIEM NVARCHAR(50) ,@THU VARCHAR(20),@TIET VARCHAR(20))AS
BEGIN
	
	UPDATE GIANGDAY
	SET MaLop = @MALOP , SoTiet = @SOTIET , DiaDiem = @DIADIEM , Thu = @THU , Tiet = @TIET
	WHERE MaGV = @MAGV

END
GO
/****** Object:  StoredProcedure [dbo].[UPDATEKHOA]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UPDATEKHOA](@MAKHOA VARCHAR(10), @TENKHOA NVARCHAR(50), @MATRUONGKHOA VARCHAR(10))AS
BEGIN

	UPDATE KHOA
	SET TenKhoa = @TENKHOA ,MaTruongKhoa = @MATRUONGKHOA 
	WHERE MaKhoa = @MAKHOA
END
GO
/****** Object:  StoredProcedure [dbo].[UPDATEKHOAHOC]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UPDATEKHOAHOC](@MAKHOAHOC VARCHAR(10) ,  @TENKHOAHOC NVARCHAR(50))AS
BEGIN
	UPDATE KHOAHOC
	SET TenKH = @TENKHOAHOC
	WHERE MaKH = @MAKHOAHOC
END





GO
/****** Object:  StoredProcedure [dbo].[UpdateLop]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateLop] @malop varchar(10), @tenlop nvarchar(50), @magvcn varchar(10), @tenkh nvarchar(50)
as
begin
	
	UPDATE LOP
	SET  TenLop=@tenkh , MaGVCN =@magvcn , MaKH = (select MAKH FROM KHOAHOC where TenKH = @tenkh) 
	WHERE MaLop=@malop
end
GO
/****** Object:  StoredProcedure [dbo].[UPDATELOPHOC]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UPDATELOPHOC](@MALOP VARCHAR(10), @TENLOP NVARCHAR(50), @MAGVCN VARCHAR(10), @MAKH VARCHAR(10))AS
BEGIN
	
	UPDATE LOP
	SET  TenLop=@TENLOP , MaGVCN =@MAGVCN , MaKH = @MAKH 
	WHERE MaLop=@MALOP

END



GO
/****** Object:  StoredProcedure [dbo].[UPDATEMONHOC]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UPDATEMONHOC](@MAMONHOC VARCHAR(10),@TENMONHOC NVARCHAR(50),@MAKHOA VARCHAR(10))as
BEGIN
	UPDATE MONHOC
	SET TenMon = @TENMONHOC , MaKhoa = @MAKHOA
	WHERE MaMon = @MAMONHOC
END
GO
/****** Object:  StoredProcedure [dbo].[XemAnhGV]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[XemAnhGV] @magv varchar(10) as
begin
    select AnhDaiDien from GIAOVIEN where MaGV = @magv
end
GO
/****** Object:  StoredProcedure [dbo].[XemAnhHS]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[XemAnhHS] @mahs varchar(10) as
begin
    select AnhDaiDien from HOCSINH where MaHS = @mahs
end
GO
/****** Object:  StoredProcedure [dbo].[XemChiTietGV]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XemChiTietGV](@Ma varchar(10)) 
AS
BEGIN
	SELECT * FROM GIAOVIEN
	WHERE MaGV = @Ma
END
GO
/****** Object:  StoredProcedure [dbo].[XemChiTietHS]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XemChiTietHS](@Ma varchar(10)) 
AS
BEGIN
	SELECT * FROM HOCSINH
	WHERE MaHS = @Ma
END
GO
/****** Object:  StoredProcedure [dbo].[XEMLICHGIANGDAY]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[XEMLICHGIANGDAY] AS
BEGIN
	select * from GIANGDAY
END

select * from GIANGDAY
GO
/****** Object:  StoredProcedure [dbo].[XemTatCaGV]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XemTatCaGV] AS
BEGIN
	SELECT * FROM GIAOVIEN
END
GO
/****** Object:  StoredProcedure [dbo].[XemTatCaHS]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XemTatCaHS] AS
BEGIN
	SELECT HOCSINH.*,  KHOAHOC.MaKH, KHOAHOC.TenKH
	FROM HOCSINH inner join LOP on HOCSINH.MaLop = LOP.MaLop
	inner join KHOAHOC on LOP.MaKH = KHOAHOC.MaKH
END
GO
/****** Object:  StoredProcedure [dbo].[XemTatCaKhoaHoc]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[XemTatCaKhoaHoc] as
begin
	select * from KHOAHOC
end
GO
/****** Object:  StoredProcedure [dbo].[XemTatCaLopHoc]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XemTatCaLopHoc] AS
BEGIN
	SELECT MaLop, TenLop FROM LOP
END
GO
/****** Object:  StoredProcedure [dbo].[XemTatCaMonHoc]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XemTatCaMonHoc] AS
BEGIN
	SELECT * FROM MONHOC
END
GO
/****** Object:  StoredProcedure [dbo].[XoaGV]    Script Date: 04/15/20 2:10:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Xoa
CREATE PROC [dbo].[XoaGV](@Ma int)
AS
BEGIN
	DELETE FROM GIAOVIEN
	WHERE MaGV = @Ma
END
GO
USE [master]
GO
ALTER DATABASE [TTN_QLHSGV] SET  READ_WRITE 
GO
