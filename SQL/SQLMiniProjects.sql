--1.1 Write a query that lists all Customers in either Paris or London. Include Customer ID, Company Name and all address fields
SELECT CustomerID, CompanyName, customers.Address FROM Customers
WHERE City = 'London' or City = 'Paris'

--1.2 List all products stored in bottle. 
SELECT * FROM Products
WHERE QuantityPerUnit LIKE '%BOTTLE%'

--1.3 Repeat question above, but add in the Supplier Name and Country. 
SELECT SUP.CompanyName, Sup.Country, * FROM Products PRO
JOIN Suppliers SUP ON  SUP.SupplierID = PRO.SupplierID
WHERE QuantityPerUnit LIKE '%BOTTLE%'

--1.4 Write an SQL Statement that shows how many products there are in each category. 
--Include Category Name in result set and list the highest number first. 
SELECT CAT.CategoryName, count(pro.ProductID) AS TotalProducts
FROM Products PRO
JOIN Categories CAT ON CAT.CategoryID = PRO.CategoryID
GROUP BY CAT.CategoryName
ORDER BY TotalProducts DESC

select * from Products
order by CategoryID

--List all UK employees using concatenation to join their title of courtesy, 
-- first name and last name together. Also include their city of residence. 
SELECT TitleOfCourtesy + ' ' + FirstName+ ' ' +LastName AS [Full Name], City FROM Employees
WHERE Country = 'UK'

--List Sales Totals for all Sales Regions (via the Territories table using 4 joins) with a Sales Total greater than 1,000,000.
-- Use rounding or FORMAT to present the numbers. 
SELECT REG.RegionID, ROUND (SUM(OD.UNITPRICE*OD.QUANTITY),2) AS SALESTOTAL FROM [Order Details] OD
JOIN Orders ORD ON ORD.OrderID = OD.OrderID
JOIN EmployeeTerritories EMP ON EMP.EmployeeID = ORD.EmployeeID
JOIN Territories TER ON TER.TerritoryID =  EMP.TerritoryID
JOIN Region REG ON REG.RegionID = TER.RegionID
GROUP BY REG.RegionID
HAVING SUM(OD.UNITPRICE * OD.QUANTITY)>1000000
 
SELECT COUNT (*) as FreightTotalOver100 FROM Orders ORD 
WHERE ORD.Freight > 100 and ShipCountry in ('UK', 'USA')









