use mydb;
create table showconstraints(ID int primary key identity(11,1),firstname varchar(20) not null,lastname varchar(20) default('kumar'));
insert into showconstraints(firstname)values('Hritvik');
insert into showconstraints(firstname,lastname)values('Hritvik','Gayaki');
alter table showconstraints alter column firstname varchar(30);
alter table showconstraints alter column lastname varchar(20) not null;
alter table showconstraints add salary decimal(12,2); 

select * from showconstraints;
delete from showconstraints;