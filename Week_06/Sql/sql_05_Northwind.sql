--Product tablosunu UNIT Pr�ce kolom-nuna gore buyukten kucuge dogru s�ralay�n�z

--USE Northwind

--SELECT * FROM Products ORDER BY  UnitPrice DESC


--F�YATI 100 VE UZERINDE OLANLAR
--USE Northwind
	--SELECT * FROM Products
	--WHERE UnitPrice>=100

----Kategorisi 7ve 8 olan urunler� goster�n�z

--USE Northwind
--SELECT * FROM Products
--	WHERE CategoryID=7 OR CategoryID=8


--	--Kategorisi 7ve 8 olanLARDAN STOK MIKTARI (UNITSINSTOCKS) <=10 OLANLARI LISTELEYINIZ

--USE Northwind
--SELECT * FROM Products
--	WHERE (CategoryID=7 OR CategoryID=8 ) AND UnitsInStock<=10




	--Kategorisi 7ve 8 olanlardan STOK MIKTARI (UNITSINSTOCKS) <=10 OLAN urunler�n say�s�

USE Northwind
--SELECT COUNT(*) FROM Products
--	--WHERE (CategoryID=7 OR CategoryID=8 ) AND UnitsInStock<=10
--	WHERE (CategoryID=9 OR CategoryID=3 ) AND UnitsInStock<=50

--INNER JOIN
--SELECT Products.ProductName,Categories.CategoryName FROM Products INNER JOIN Categories
--	ON Products.CategoryID=Categories.CategoryID

--SELECT P.ProductName,C.CategoryName
--FROM Products P INNER JOIN Categories C
--ON P.CategoryID=C.CategoryID

--SELECT P.ProductName,C.CategoryName,P.UnitPrice
--FROM Products P INNER JOIN Categories C
--ON P.CategoryID=C.CategoryID
--WHERE CategoryName='Beverages' AND P.UnitPrice<=40
--ORDER BY P.UnitPrice DESC

--PRODUCTNAME VE SUPPLIERCOMPANY NAME I GOSTEREN BIR SORGU YAZINIZ

--SELECT P.ProductName,S.CompanyName
--FROM Products P INNER JOIN Suppliers S
--ON P.SupplierId=S.SupplierID

--Germany den tedar�k ed�len urunler�n l�stes�(ProductName gozukse yeter)

--SELECT P.ProductName
--FROM Products P INNER JOIN Suppliers S
--ON P.SupplierId=S.SupplierID
--WHERE S.Country='Germany'

--Germany den tedar�k ed�len urunler�n TOPLAM TUTARI

--SELECT SUM(P.UnitPrice * P.UnitsInStock) as 'Toplam Tutar'
--FROM Products P INNER JOIN Suppliers S
--ON P.SupplierId=S.SupplierID
--WHERE S.Country='Sweden'


--CHAI sat�slar�n�n toplam tutar�

--SELECT SUM(OD.UnitPrice * OD.Quantity) 
--FROM Products P INNER JOIN [Order Details] OD
--ON P.ProductID = OD.ProductID
--WHERE P.ProductName='Chai'


--SELECT SUM(OD.UnitPrice * OD.Quantity)
--FROM Orders O INNER JOIN [Order Details] OD
--ON O.OrderID=OD.OrderID INNER JOIN Products P
--ON OD.ProductID=P.ProductID
--WHERE P.ProductName='Chai' AND O.ShipCountry='Germany'



--Ernst Handel muster�s�ne yap�lan sat�s tutar�n�n toplam�
SELECT SUM(UnitPrice * Quantity)
FROM [Order Details] OD INNER JOIN Orders O
ON OD.OrderID=O.OrderID INNER JOIN Customers C
ON O.CustomerID=C.CustomerID
WHERE C.CompanyName='The Cracker Box'


