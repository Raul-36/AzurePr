create database AzurePr
use AzurePr;

create table Users(
     Id int primary key identity,
	 Name nvarchar(max)
)

insert into Users (Name)
values('a'),('b')