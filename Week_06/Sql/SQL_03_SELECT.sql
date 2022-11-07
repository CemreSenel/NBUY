--USE HastaneDb
--SELECT * FROM Bolumler

--USE HastaneDb
--SELECT * FROM Doktorlar

--USE HastaneDb
--SELECT adSoyad as 'AD SOYAD',adres as ADRES FROM Doktorlar

--FILTRELEME
--SELECT * FROM Doktorlar WHERE id=5
--SELECT * FROM Doktorlar WHERE adSoyad='Tuna Sefer'
--SELECT * FROM Doktorlar WHERE adSoyad!='Tuna Sefer'
--SELECT * FROM Doktorlar WHERE id=3 OR id=6
--SELECT * FROM Doktorlar WHERE NOT adSoyad='Tuna Sefer'
--SELECT * FROM Doktorlar WHERE bolumId=5 AND adres='Ýzmir'
--SELECT * FROM Doktorlar WHERE id>=6

--ÝSTANBUL VE ÝZMÝRDEKI DOKTORLAR
--SELECT * FROM Doktorlar WHERE adres IN ('Ankara','Ýstanbul')

--Adý a harfi ile baslayan doktorlar
 --SELECT * FROM Doktorlar WHERE adSoyad LIKE 't%'
 --SELECT * FROM Doktorlar WHERE adSoyad LIKE 'tut%'
 --SELECT * FROM Doktorlar WHERE adSoyad LIKE '%evgar'
 --SELECT * FROM Doktorlar WHERE adSoyad LIKE '%s%'
 --SELECT * FROM Doktorlar WHERE adSoyad LIKE '_e%'
 --SELECT * FROM Doktorlar WHERE adSoyad LIKE 'd_m%'


 --SIRALAMA
 --SELECT * FROM Doktorlar ORDER BY adSoyad 

 --SELECT * FROM Doktorlar ORDER BY adSoyad DESC

  --SELECT * FROM Doktorlar ORDER BY bolumId DESC

  --SELECT * FROM Doktorlar ORDER BY adres
  
  SELECT * FROM Doktorlar ORDER BY adres, adSoyad DESC

