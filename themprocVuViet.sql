
-- them 1 cai proc moi 
-- author : Vu
-- lay ten mon theo giaovien

create proc gettenmonhoc(@magiaovien varchar(10))as
begin
	select TenMon from MONHOC , GIAOVIEN 
	where MaGV=@magiaovien and GIAOVIEN.MaMon = MONHOC.MaMon
	
end
