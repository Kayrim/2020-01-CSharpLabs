select top 5 * from Customers
select * from Customers where City = 'London'
select distinct TitleOfCourtesy from Employees
select count(TitleOfCourtesy)as NumberOfDRs from Employees where TitleOfCourtesy = 'Dr.'
select count(Discontinued) as DiscontinuedProducts from Products where Discontinued = 1
select count(*) from Products where CategoryID = 1 and Discontinued = 1
select count(*) from Products where UnitsInStock > 0 and UnitPrice > 29.99
select * from Products where UnitsInStock > 0 and UnitPrice > 29.99 order by UnitPrice desc
select distinct Country from Customers
select distinct City from Customers
select * from Products where ProductName like '%ch%'
select count(*) from Products where ProductName like '%ch%'
select count(*) from Customers where Region like '%a%'
select count(*) from Customers where Region like 'a%'
select count(*) from Customers where Region like '%a'
select count(*) from Products where ProductName not like '%ch%'
select * from orders where customerid = 'ALFKI'
select * from orders

join [Order Details] on Orders.OrderID = [Order Details].OrderID
where CustomerID = 'alfki'

select customerid, orders.OrderID, productname, quantity, o.UnitPrice from  orders
join [Order Details] as o on Orders.OrderID = o.OrderID
join Products on o.ProductID = Products.ProductID
where CustomerID = 'alfki'

select customers.contactname, orders.customerid, od.OrderID, od.ProductID, Products.ProductName, od.UnitPrice, Quantity,Discount
from orders
join [Order Details] as od on Orders.OrderID = od.OrderID
join Customers on Customers.CustomerID = Orders.CustomerID
join Products on Products.ProductID = od.ProductID
where Orders.CustomerID = 'alfki'

select sum ((od.UnitPrice)-(od.UnitPrice*Discount)) as Total from orders
join [Order Details] as od on Orders.OrderID = od.OrderID
join Customers on Customers.CustomerID = Orders.CustomerID
join Products on Products.ProductID = od.ProductID
where Orders.CustomerID = 'alfki'