USE [AracOtomasyon]
GO
/****** Object:  StoredProcedure [dbo].[AracGuncelle]    Script Date: 28.01.2022 15:59:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[AracGuncelle]
@Aracid int,
@AracPlaka varchar(10),
@AracMarka int,
@AracSeri int,
@AracModel int,
@AracRenk varchar(20),
@AracKm int,
@AracYakit varchar(15),
@AracFiyati int
as
begin
if(@Aracid=0)
begin
insert into TblArac(AracPlaka,AracMarkaa,AracSerii,AracModel,AracRenk,AracKm,AracYakit,AracFiyati)values(@AracPlaka,@AracMarka,@AracSeri,@AracModel,@AracRenk,@AracKm,@AracYakit,@AracFiyati)
end
else
update TblArac set
AracPlaka=@AracPlaka,
AracMarkaa=@AracMarka,
AracSerii=@AracSeri,
AracModel=@AracModel,
AracRenk=@AracRenk,
AracKm=@AracKm,
AracYakit=@AracYakit,
AracFiyati=@AracFiyati
where Aracİd=@Aracid
end