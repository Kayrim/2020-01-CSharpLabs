--system database
use master 
go 

--create database
drop database if exists Users
go
create database Users
go
use Users
go
-- create users and categories
create table Categories(
CategoryID int not null primary key identity,
CategoryName varchar(50) null,
)

insert into Categories values ('admin'),('work'),('personal')

select * from Categories

create table Users(
UserID int not null primary key identity(1,1),
CategoryID int null foreign key references Categories(CategoryID),
UserName varchar(50) null,
DateOfBirth date null,
isValid bit null

)

insert into users values (1,'fred','2020-10-10', 'true')

select * from users

-- SQL Join similar to LINQ
select * from users
join Categories
on users.CategoryID = Categories.CategoryID

select userid, username, isvalid, categoryname from Users join Categories
on users.CategoryID = Categories.CategoryID