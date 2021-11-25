use mydb; 
create table teacher (ID int,fname varchar(20),lname varchar(20),branch varchar(20),city varchar(20));
insert into teacher values(101,'Hritvik','Gayaki','CSE','Nagpur');
insert into teacher values(102,'Akash','Narwade','CSE','Nagpur');
insert into teacher values(103,'Kunal','Barmate','CSE','Nagpur');
insert into teacher values(104,'Nilesh','Dhanore','CSE','Nagpur');
select * from teacher;