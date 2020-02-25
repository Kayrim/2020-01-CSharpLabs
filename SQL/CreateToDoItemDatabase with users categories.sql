use master
go

drop database if exists ToDoDatabase
go

create database ToDoDatabase
go

use ToDoDatabase
go



create table Users(
UserID int primary key identity not null,
UserName varchar(50) null)

go

create table Categories(
CategoryID int primary key identity not null,
CategoryName varchar(50)null)

go

create table ToDoItems(
ToDoItemID int primary key identity not null,
ToDoItem varchar (50) null,
StartDate date null,
Done bit null default 0,
UserID int null foreign key references Users(UserID) ,
CategoryID int null foreign key references Categories(CategoryID)
)

insert into Categories values('home'),( 'work'),('personal')

insert into Users values('Tom'),('John'), ('Joe')

insert into ToDoItems (ToDoItem,StartDate,UserID,CategoryID) 
values ('Clean Room', '2020-2-10',1,1),
('Finish Homework','2020-1-1',2,3),
('Train Legs','2020-2-1',2,3),
('Train Legs','2020-2-1',3,3)

--alter table Users add UserAge varchar(50) null

alter table Users add UserAge int null
go
 
update Users set UserAge = 21 where UserID = 1;
update Users set UserAge = 23 where UserID = 2;

select UserName, ToDoItem, CategoryName, ToDoItemID, StartDate, UserAge, case when done = 1 then 'Yes' Else 'No' End as Done from ToDoItems 
 join Users on ToDoItems.UserID = Users.UserID
 join Categories on ToDoItems.CategoryID = Categories.CategoryID