SELECT CustomerID, CompanyName, customers.Address FROM Customers
WHERE City = 'London' or City = 'Paris'

SELECT * FROM Products
WHERE QuantityPerUnit LIKE '%BOTTLE%'

SELECT *, SUP.CompanyName, Sup.Country FROM Products PRO
JOIN Suppliers SUP ON  SUP.SupplierID = PRO.SupplierID
WHERE QuantityPerUnit LIKE '%BOTTLE%'

SELECT DISTINCT PRO.CategoryID,CAT.CategoryName,PRO.UnitsInStock FROM Products PRO
JOIN Categories CAT ON CAT.CategoryID = PRO.CategoryID
ORDER BY UnitsInStock DESC


SELECT TitleOfCourtesy + ' ' + FirstName+ ' ' +LastName AS [Full Name], City FROM Employees
WHERE Country = 'UK'

SELECT REG.RegionID, ROUND (SUM(OD.UNITPRICE*OD.QUANTITY),2) AS SALESTOTAL FROM [Order Details] OD
JOIN Orders ORD ON ORD.OrderID = OD.OrderID
JOIN EmployeeTerritories EMP ON EMP.EmployeeID = ORD.EmployeeID
JOIN Territories TER ON TER.TerritoryID =  EMP.TerritoryID
JOIN Region REG ON REG.RegionID = TER.RegionID
GROUP BY REG.RegionID
HAVING SUM(OD.UNITPRICE * OD.QUANTITY)>1000000

SELECT COUNT (ORD.OrderID) FROM Orders ORD
WHERE (ORD.ShipCountry = 'UK' OR ORD.ShipCountry = 'USA') AND ORD.Freight > 100
GROUP BY ORD.Freight


SELECT * FROM Orders


