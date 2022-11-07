USE master
GO

DROP DATABASE IF EXISTS HastaneDb
GO

CREATE DATABASE HastaneDb
GO

--�st taraf varsa hastaneDb y� s�l�p yen�den olusturur.

USE HastaneDb
GO
--HASTALAR TABLOSU
CREATE TABLE Hastalar(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	adSoyad NVARCHAR(50) NOT NULL,
	cinsiyet CHAR(1) NOT NULL,
	adres NVARCHAR(50),
	telefon CHAR(11)
)
GO

INSERT INTO Hastalar(adSoyad,cinsiyet,adres) VALUES
	('Erencan Germirli','E','�stanbul'),
	('Selin Fergen�','K','Ankara'),
	('Sadi Kuloglu ','E','�zmir'),
	('Ne�e Kalabal�k ','K','�stanbul'),
	('Sevda A�alar ','K','�zmir'),
	('Nora Ta�kesen ','K','Ankara'),
	('Emama �eto�lu ','K','�stanbul'),
	('Krem S�zc� ','E','Ankara'),
	('Suat Tartar ','E','�stanbul')
GO
--BOLUMLER TABLOSU
CREATE TABLE Bolumler(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(30) NOT NULL
)

INSERT INTO Bolumler VALUES
	('Dahiliye'),('Ortopedi'),('N�roloji'),('Di�'),('Genel Cerrahi'),('Periodontoloji')
GO

--DOKTORLAR
CREATE TABLE Doktorlar(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	adSoyad NVARCHAR(50) NOT NULL,
	adres NVARCHAR(50),
	bolumId INT,
	FOREIGN KEY (bolumId) REFERENCES Bolumler(id)
)
GO

INSERT INTO Doktorlar VALUES
	('Ali Can','�stanbul','1'),
	('Demet Evgar','Bursa','2'),
	('Sedat Kanar ','�stanbul','3'),
	('Ferhunde Han�m ','�zmir','1'),
	('Zafer Kimki ','Ankara','2'),
	('Hale Elveren ','�stanbul','3'),
	('Tuna Sefer  ','Ankara','4'),
	(' Kevser Tutku ','�stanbul','4'),
	(' Tutkum Kap��mak ','�zmir','5'),
	(' �sa Canova  ','�zmir','5'),
	(' Tu�ce Bolumsuz  ','�stanbul',null)

GO

--Yukar�dak� INSERT INTO nun son sat�r�n�n alternatifi buras�:
--INSERT INTO Doktorlar(adSoyad,adres)VALUES
--	(' Tu�ce Bolumsuz  ','�stanbul')
--GO

