USE Northwind

--SELECT C.CompanyName FROM Customers C INNER JOIN Orders O
--ON C.CustomerID=O.CustomerID


--SELECT C.CompanyName FROM Customers C LEFT JOIN Orders O
--ON C.CustomerID=O.CustomerID
--WHERE O.OrderID IS NULL


--SELECT C.CompanyName FROM Orders O  RIGHT JOIN  Customers C
--ON C.CustomerID=O.CustomerID
--WHERE O.OrderID IS NULL


--Henuz h�c sat�s� yap�lmam�s urunler

--SELECT P.ProductName,OD.ProductID FROM  Products P LEFT JOIN  [Order Details] OD
--ON P.ProductID=OD.ProductID
--WHERE OD.ProductID IS NULL


--Henuz sat�s yapamam�s cal�sanlar� l�steley�n

SELECT E.LastName +' ' + E.FirstName as 'Ad Soyad' FROM Employees E LEFT JOIN Orders O
ON E.EmployeeID=O.EmployeeID
WHERE O.EmployeeID IS NULL