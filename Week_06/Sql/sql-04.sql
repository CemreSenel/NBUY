--sayfa say�s� 300'den buyuk es�t olan k�taplar
--USE KutuphaneDb
--SELECT * FROM Kitaplar WHERE sayfaSayisi>=300


--stok adedi 90-113 aras�ndak�ler
--USE KutuphaneDb
--SELECT * FROM Kitaplar WHERE 90<=stok AND stok>=113
--SELECT * FROM Kitaplar WHERE stok BETWEEN 90 AND 113


--sayfa say�s� en cok olandan en az olana
--USE KutuphaneDb
--SELECT * FROM Kitaplar ORDER  BY sayfaSayisi DESC

--t�re gore kucukten buyuge
--USE KutuphaneDb
--SELECT * FROM Kitaplar ORDER BY turId,sayfaSayisi DESC

--HESAPLAMA
--USE KutuphaneDb
--SELECT * FROM Kitaplar

--SELECT MIN(sayfaSayisi)as 'En Az Sayfa Say�s�' FROM Kitaplar
--SELECT MAX(sayfaSayisi)as 'En Y�ksek Sayfa Say�s�' FROM Kitaplar

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
--SELECT LEN('Cemre �enel')
--SELECT adSoyad,LEN(adSoyad) as 'Uzunluk' FROM Doktorlar
--SELECT 
--   adSoyad,
--   LEFT(adSoyad,3)as'�lk 3 Karakter',
--   LEN(adSoyad) as 'Uzunluk'
--   FROM Doktorlar

--SELECT
--	adsoyad,
--	UPPER(adSoyad) as 'B�y�k',
--	LOWER(adSoyad) as 'K���k'
--FROM Doktorlar

--SELECT
--	REPLACE('Cemre �enel','n','MERHABA')

--SELECT
--	LOWER(REPLACE('Cemre �enel',' ','')) + '@benimfirmam.com'


--SELECT 
--	adSoyad,
--	REPLACE(LOWER(adSoyad),' ','')+@'firma.com' as 'Mail Adresi'
--FROM Doktorlar

--Sercan Furkan ad�nda Amasyada yasayan bolumu 3 olan doktoru kayedecek sorguyu yaz�n�z

--USE HastaneDb
--INSERT INTO Doktorlar VALUES
--	('Sercan Furkan','Amasya',3)


--GUNCELLEME
--USE HastaneDb
--UPDATE Doktorlar SET adSoyad='Secan Ahmet Furkan'
--WHERE id=12

--USE HastaneDb
--UPDATE Doktorlar SET adSoyad='Al sana yen� �s�m'

--USE KutuphaneDb
--UPDATE Kitaplar SET sayfaSayisi = sayfaSayisi * 1.2


--S�LME
--USE HastaneDb
--DELETE FROM Doktorlar WHERE id=6

USE HastaneDb
DELETE FROM Doktorlar WHERE bolumId IS NULL
