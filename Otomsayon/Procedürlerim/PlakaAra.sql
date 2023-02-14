create procedure PlakaAra
@Ara nvarchar(50)
as
begin
select * from TblArac where(@Ara='' or AracPlaka like '%'+@Ara+'%')
end