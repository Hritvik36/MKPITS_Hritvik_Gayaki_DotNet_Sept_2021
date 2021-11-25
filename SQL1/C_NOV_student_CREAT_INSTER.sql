use mydb;
create table student(Roll_no int primary key identity(1,1),firstname varchar(20),lastname varchar(20),Eng int,Maths int,sci int);
drop table student;

insert into student(firstname,lastname,Eng,Maths,sci)values('kunal','Barmate',80,75,65);
insert into student(firstname,lastname,Eng,Maths,sci)values('akash','narwade',65,75,90);
insert into student(firstname,lastname,Eng,Maths,sci)values('nilesh','dhanore',86,89,47);
insert into student(firstname,lastname,Eng,Maths,sci)values('roshan','Thakre',72,96,91);
insert into student(firstname,lastname,Eng,Maths,sci)values('nikita','bhoyar',80,56,87);

select * from student;
select firstname +' '+lastname as 'Full name' from studentbill gates
select Roll_no,firstname +' '+lastname as 'full name' from student;
--lect id as 'Employee Id',firstname+' '+lastname as'Name' ,salary as '$salary' from employee_1; --
select Roll_no as 'Roll No',firstname +' '+lastname as 'Name', ENG AS 'English',maths,sci as 'science' from student;