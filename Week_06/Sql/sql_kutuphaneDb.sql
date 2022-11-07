/*
KütüphaneDb adýnda býr verý tabaný olusturunuz
Verý tabanýnda asagýdaký tablolar olsun
	Turler
	Yazarlar
	Yayýnevlerý
	UYELER
	KÝTAPLAR
	ODUNC ISLEMLERI

*/

USE master
GO

DROP DATABASE IF EXISTS KutuphaneDb
GO

CREATE DATABASE KutuphaneDb
GO

USE KutuphaneDb

CREATE TABLE Turler(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(25) NOT NULL
)
GO

INSERT INTO Turler VALUES
	('Bilimsel'),
	('Tarih'),
	('Roman'),
	('Hikaye'),
	('Siyaset'),
	('Yeraltý Edebiyatý'),
	('Yemek'),
	('Þiir')
GO

CREATE TABLE Yazarlar(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	adSoyad NVARCHAR(25) NOT NULL,
	yas INT NOT NULL
	
)
GO

INSERT INTO Yazarlar VALUES
	('Ernest Hemingway',50),
	('Dostoyevski ',40),
	(' Gogol',70),
	(' Tolstoy',80),
	('Victor Hugo ',45),
	('Jack London ',42),
	('Muazzez Ýlmiye Çýð ',90)
GO


CREATE TABLE Yayýnevleri (
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(50) NOT NULL
)	

INSERT INTO Yayýnevleri VALUES
	('Ýndex'),
	('Haber'),
	('Ýþ Bankasý'),
	('Tarih'),
	('Can'),
	('Test'),
	('Bilge')
GO

CREATE TABLE Uyeler(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	adSoyad NVARCHAR(50) NOT NULL,
	yas INT NOT NULL
)
GO

INSERT INTO Uyeler Values
	('Cemre Þenel',27),
	('Kemal Sunal',55),
	('Deniz Demir',40),
	('Ezgi Sultan',35),
	('Recep Biler',27),
	('Arda Okan',22),
	('Suat Demir',18)
GO

CREATE TABLE Kitaplar(
	id	INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(50) NOT NULL,
	yazarId INT NOT NULL,
	yayineviId INT NOT NULL,
	turId INT NOT NULL,
	FOREIGN KEY (yazarId) REFERENCES Yazarlar(id),
	FOREIGN KEY (yayineviId) REFERENCES Yayýnevleri(id) ON DELETE CASCADE,
	FOREIGN KEY  (turId)   REFERENCES Turler(id) ON DELETE SET DEFAULT
)
GO

INSERT INTO Kitaplar VALUES
	('Beyaz Diþ',1,7,3),
	('Kumarbaz ',1,1,2),
	('AÞk ve Gurur ',2,2,3),
	('Karamazov Kardeþler ',3,1,4),
	('Suç ve Ceza',4,5,2),
	('Afrikanýn Yeþil Tepeleri',5,6,2),
	('Yaþlý Adam ve Deniz',6,3,4),
	('Labirent',7,3,5),
	('Ýki Þehrin Hikayesi',1,7,4),
	('Martin Eden',2,4,5)
GO

CREATE TABLE OduncIslemlerý(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	kitapId INT NOT NULL,
	uyeId INT NOT NULL,
	tarih DATE NOT NULL,
	FOREIGN KEY(kitapId) REFERENCES Kitaplar(id),
	FOREIGN KEY(uyeId) REFERENCES Uyeler(id),
)
GO

INSERT INTO OduncIslemlerý VALUES
	(1,1,'2022-10-05'),
	(2,2,'2022-09-05'),
	(3,3,'2022-05-03'),
	(4,4,'2022-04-22'),	
	(5,7,'2022-03-14'),	
	(6,1,'2022-01-01'),
	(7,6,'2022-07-07'),
	(7,3,'2022-08-25'),
	(8,4,'2022-03-19'),
	(9,5,'2022-01-19'),
	(10,1,'2022-12-12')	
GO