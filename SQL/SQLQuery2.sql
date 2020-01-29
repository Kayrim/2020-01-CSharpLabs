use master
go

drop database if exists testdatabase
go

create database testdatabase
go

use testdatabase
go

--Null means entry can be empyt
--Not null means value is required
-- Identity means Auto Creare ID with next available ID Automatically
--Primary key means unique values required

create table testtable(
		TestTableID INT NOT NULL IDENTITY PRIMARY KEY,
		TestName VARCHAR(50) NULL,
		TestAge INT NULL
		)

insert into testtable values ('names01', 22)
insert into testtable values ('names02', 28)
insert into testtable values ('names03', 34)

select * from testtable