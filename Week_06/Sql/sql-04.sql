--sayfa sayýsý 300'den buyuk esýt olan kýtaplar
--USE KutuphaneDb
--SELECT * FROM Kitaplar WHERE sayfaSayisi>=300


--stok adedi 90-113 arasýndakýler
--USE KutuphaneDb
--SELECT * FROM Kitaplar WHERE 90<=stok AND stok>=113
--SELECT * FROM Kitaplar WHERE stok BETWEEN 90 AND 113


--sayfa sayýsý en cok olandan en az olana
--USE KutuphaneDb
--SELECT * FROM Kitaplar ORDER  BY sayfaSayisi DESC

--türe gore kucukten buyuge
--USE KutuphaneDb
--SELECT * FROM Kitaplar ORDER BY turId,sayfaSayisi DESC

--HESAPLAMA
--USE KutuphaneDb
--SELECT * FROM Kitaplar

--SELECT MIN(sayfaSayisi)as 'En Az Sayfa Sayýsý' FROM Kitaplar
--SELECT MAX(sayfaSayisi)as 'En Yüksek Sayfa Sayýsý' FROM Kitaplar

--SELECT COUNT(*) FROM Kitaplar

--USE HastaneDb
--SELECT COUNT(*) FROM Doktorlar
--SELECT COUNT(bolumId) FROM Doktorlar

--USE KutuphaneDb
--SELECT AVG(sayfaSayisi) FROM Kitaplar
--SELECT SUM(stok) FROM Kitaplar
--SELECT SUM(stok * sayfaSayisi) FROM Kitaplar


--STRING 
USE HastaneDb
--SELECT LEN('Cemre Þenel')
--SELECT adSoyad,LEN(adSoyad) as 'Uzunluk' FROM Doktorlar
--SELECT 
--   adSoyad,
--   LEFT(adSoyad,3)as'Ýlk 3 Karakter',
--   LEN(adSoyad) as 'Uzunluk'
--   FROM Doktorlar

--SELECT
--	adsoyad,
--	UPPER(adSoyad) as 'Büyük',
--	LOWER(adSoyad) as 'Küçük'
--FROM Doktorlar

--SELECT
--	REPLACE('Cemre Þenel','n','MERHABA')

--SELECT
--	LOWER(REPLACE('Cemre Þenel',' ','')) + '@benimfirmam.com'


--SELECT 
--	adSoyad,
--	REPLACE(LOWER(adSoyad),' ','')+@'firma.com' as 'Mail Adresi'
--FROM Doktorlar

--Sercan Furkan adýnda Amasyada yasayan bolumu 3 olan doktoru kayedecek sorguyu yazýnýz

--USE HastaneDb
--INSERT INTO Doktorlar VALUES
--	('Sercan Furkan','Amasya',3)


--GUNCELLEME
--USE HastaneDb
--UPDATE Doktorlar SET adSoyad='Secan Ahmet Furkan'
--WHERE id=12

--USE HastaneDb
--UPDATE Doktorlar SET adSoyad='Al sana yený ýsým'

--USE KutuphaneDb
--UPDATE Kitaplar SET sayfaSayisi = sayfaSayisi * 1.2


--SÝLME
--USE HastaneDb
--DELETE FROM Doktorlar WHERE id=6

USE HastaneDb
DELETE FROM Doktorlar WHERE bolumId IS NULL
