
use Mydb;
create table Employee(ID int,firstname varchar(20),lastname varchar(20),branch varchar(20),city varchar(20));


insert into Employee values(101,'Akash','Narwade','Electrical','Nagpur')
insert into Employee values(102,'Hritvik','Gayaki','computer science','Nagpur')
insert into Employee values(103,'Nilesh','Dhanore','extc','Mumbai')
insert into Employee values(104,'Roshan','Thakre','mechanical','Nashik')
insert into Employee values(104,'yashwant','Bodake','mining','pune')
select * from Employee;