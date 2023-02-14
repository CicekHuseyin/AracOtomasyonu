Alter procedure AracListele2 
as
begin
select Arac›d,AracPlaka ,m1.AracMarka,s1.AracSeri,AracModel,AracRenk,AracKm,AracYakit,AracFiyati
from TblArac arac
inner join TblAracMarka m1 on m1.AracMarka›d=arac.AracMarkaa
inner join TblAracSeri s1 on s1.AracSeri›d=arac.AracSerii
end

