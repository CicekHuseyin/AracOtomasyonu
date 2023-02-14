ALTER procedure [dbo].[AracEkle]
@AracPlaka nvarchar(10),
@AracMarkaa tinyint,
@AracSerii tinyint,
@AracModel int,
@AracRenk varchar(20),
@AracKm int,
@AracYakit varchar(10),
@AracFiyati int
as
begin
insert into TblArac(AracPlaka,AracMarkaa,AracSerii,AracModel,AracRenk,AracKm,AracYakit,AracFiyati)
values
(@AracPlaka,@AracMarkaa,@AracSerii,@AracModel,@AracRenk,@AracKm,@AracYakit,@AracFiyati);
end