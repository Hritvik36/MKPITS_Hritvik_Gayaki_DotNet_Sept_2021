 --create database mkpit_database;
use mkpitsbd; --use databasename
--create table student(rollno int,fname varchar(20),lname varchar(20),std varchar(10),age int);

drop database mkpits_bd;
insert into student values(4,'Hritvik','Gayaki',16,35);
insert into student (rollno,fname,lname)values(21,'nilesh','dhanore'); --we are not writting the data std it will display "NULL"
select * from student;