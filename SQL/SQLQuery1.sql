select top 5 * from customers
select top 5 * from customers order by customerid desc

 


select count(*) as Cities from customers where city = 'London'

 

select distinct count(TitleOfCourtesy) as TitlesofCourtesy from Employees  

 

select count(TitleOfCourtesy) as JobTitle from employees where TitleOfCourtesy = 'Dr.'

 

select count(Discontinued) as DiscontinuedProduct from Products where Discontinued = 1 

 


--offset = skip
--first 5 customers
select top 5 * from customers
--next 5
select *from customers order by customerid
offset 5 rows
fetch next 5 rows only
--next 5
select *from customers order by customerid
offset 10 rows
fetch next 5 rows only

 

--how many products with category 1 and discontinued?
select count(*) as CategoryIdAndDiscontinued from products where CategoryId = 1 and Discontinued = 1

 

--how many products with items in stock and unitprice > 29.99
select count(*) from Products where UnitsInStock >= 1 and UnitPrice > 29.99

 

--order the above list to show products ordered by unit price descending
select * from Products where UnitsInStock >= 1 and UnitPrice > 29.99
order by unitprice desc

 

--how many distinct countries exist in the customers table
select distinct count(Country) from customers 

 

--how many distinct cities exist in the customers table
select distinct count(City) from customers 

 


--LIKE
-- % is a wildcard for anything %a% contains a
--                                a%  starts with a
--                                %a ends with a
-- _ is a wildcard for one character
-- how many products contain 'ch'
select * from products where productname LIKE '%ch%'
select count(*) from products where productname LIKE '%ch%'

 

--how many regions contain the letter 'a' in customers
select count(*) from customers where region LIKE '%a%'

 

-- how many regions start with a
select count(*) from customers where region LIKE '%a'

 

--how many regions end with a
select count(*) from customers where region LIKE 'a%'

 

--NOT LIKE reverses query

 

--how many products do not contain ch
select count(*) from products where productname NOT LIKE '%ch%'

 

--using underscore to represent single character wildcard

 

--how many regions have 'a' as second letter (first letter wildcard)
select region, * from customers where region LIKE '_a%'

 

--OR but for long lists can use IN for a shorter version
select region, * from customers where region IN ('wa','ca')

 

--between for numeric ranges

 

--how many products which are not discontinued have price between 10.00 and 40.00
select count(*) from products where Discontinued = 0 and UnitPrice BETWEEN 10.00 and 40.00

 

--how many products start with b, s, t
select count(*) from products where productname like ('b%') or productname like ('s%') or productname like ('t%')

 

--how many product catgeoryname start with c or s
select count(*) from products 
join categories
on products.categoryid = categories.CategoryId
where categoryname like 'c%' or categoryname like 's%'

 

--concatenation
--select customers but join 'city and country' into one column ie 'lives in'
select *, concat (city,',',country) as LivesIn from Customers

 

--customer => order => details of order (order_details)
--select orders for ALFKI customer
select * from orders where customerid = 'ALFKI'

 

--have a look at order details as well
select * from orders 
join [Order Details] on orders.OrderID = [Order Details].OrderID
where customerid = 'ALFKI'

 

--create a query to have orderid, productname and quantity
select orderid, productname, quantity,* from products
join [Order Details] on [Order Details].ProductID = products.ProductID

 

--filter orders by customer ALFKI     (DOUBLE JOIN)
select customerid, orders.orderid, productname, quantity, [Order Details].unitprice from orders 
join [Order Details] on orders.OrderID = [Order Details].OrderID
join products on [Order Details].ProductID = products.ProductID
where customerid = 'ALFKI'

 

--goal is to list, for any given customer, the order details
--remember to get to the orrder details we have to go first through orders table
--customer => order => order details
--productid bought, quantity, price and discount
--customerid is already in orders table

 

--get customer name and all orders for customerid = alfki
select customers.customerId, contactname, OrderID from customers
join orders on customers.customerid = orders.customerid
where customers.customerid = 'alfki'

 

--develop this to show productid as well (include order details table)
select customers.customerId, contactname, [Order Details].OrderID, ProductID, UnitPrice from customers
join orders on customers.customerid = orders.customerid
join [Order Details] on orders.OrderID = [Order Details].OrderID
where customers.customerid = 'alfki'

 

--add product name
select customers.customerId, contactname, [Order Details].OrderID, ProductID,ProductName UnitPrice from customers
join orders on customers.customerid = orders.customerid
join [Order Details] on orders.OrderID = [Order Details].OrderID
join products on [Order Details].productid = products.productid
where customers.customerid = 'alfki'

 

--add quantity, price and discount
select customers.customerId, contactname, [Order Details].OrderID, ProductID, ProductName, UnitPrice, [Order Details].Quantity,
[Order Details].UnitPrice, [Order Details].Discount
from customers
join orders on customers.customerid = orders.customerid
join [Order Details] on orders.OrderID = [Order Details].OrderID
join products on [Order Details].productid = products.productid
where customers.customerid = 'alfki'

 

-- now can add some calculated columns eg order before discount
select cust.customerId, contactname, OD.UnitPrice, OD.Quantity,OD.UnitPrice, 
OD.Discount*100 as 'DiscountAmount', 
od.UnitPrice*od.Quantity as 'TotalBeforeDiscount',
(od.UnitPrice*od.Quantity)*(1-od.Discount) as 'OrderAfterDiscount'
from customers cust
join orders on cust.customerid = orders.customerid
join [Order Details] OD on orders.OrderID = OD.OrderID
join products on OD.productid = products.productid
where cust.customerid = 'alfki'

select cust.customerID,
sum (OD.Quantity) as 'Quantity Total',
sum (OD.UnitPrice*od.Quantity) as 'TotalBeforeDiscount',
round (sum ((od.UnitPrice*od.Quantity)*(1-od.Discount)),2) as 'OrderAfterDiscount'
from customers cust
join orders on cust.customerid = orders.customerid
join [Order Details] OD on orders.OrderID = OD.OrderID
join products on OD.productid = products.productid
where od.Discount >0
group by cust.CustomerID
having sum ((od.UnitPrice*od.Quantity)*(1-od.Discount)) > 10000
order by OrderAfterDiscount desc

select OrderID,datediff(d, Orders.OrderDate, orders.ShippedDate) as DaysTaken from orders
order by DaysTaken desc

select * From Orders

select * from customers c
left join orders o on c.CustomerID = o.CustomerID
order by o.OrderID

select * from customers c
left join orders o on c.CustomerID = o.CustomerID
where o.OrderID is null
