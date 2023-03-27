create table Author(
Author_SSN int primary key,
Author_Name nvarchar (50),
Nationality nvarchar(50));

create table Publisher(
Pub_Name nvarchar(50) primary key,
city text,
country nvarchar(25));

create table Buyer(
Buyer_SSN int primary key,
Buyer_name nvarchar(50),
email text,
phone int);

create table Book(
ISBN int primary key,
title nvarchar(100),
price real,
Pub_name nvarchar(50),
Buyer_SSN int,
foreign key(Pub_name) REFERENCES Publisher,
foreign key(Buyer_SSN) REFERENCES Buyer,
copynum int);

create table Employee(
ID int primary key,
Emp_name nvarchar(50));

create table Writtenby(
ISBN int,
Author_SSN int,
foreign key (ISBN) references Book,
foreign key (Author_SSN) references Author);

create table servedby(
ID int,
Buyer_SSN int,
foreign key (ID) references Employee,
foreign key (Buyer_SSN) references Buyer);