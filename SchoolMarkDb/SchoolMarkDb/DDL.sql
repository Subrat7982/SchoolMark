create Database School;
use School ;
create table StudentDetails
( 
	Sid int identity Primary key ,
	Fname Varchar(15) not null ,
	Lname Varchar(15) not null ,
	Parentsname Varchar(15) not null ,
	Address Varchar(15) not null ,
	City Varchar(15) not null ,
	Dob Date not null ,
	PhoneNo int not null ,
	class int not null ,
)



create table Marksheet
(
id int identity Primary key,
Sid int references StudentDetails(Sid) ,
Subject1 int not null ,
Subject2 int not null ,
Subject3 int not null ,
Subject4 int not null ,
Subject5 int not null 
)

