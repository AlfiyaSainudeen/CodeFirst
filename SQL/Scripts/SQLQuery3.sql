--composite primary key example
create table student(
[sid] int,
[name] varchar(30) not null,
class varchar(30) not null,
section char(1) not null,
mobile varchar(20),
constraint com_pk primary key(sid,mobile))
insert into student values(1,'Rohan','4','A',9090909090)
insert into student values(2,'Karan','2','A',9090909090)
insert into student values(3,'James','1','A',9090909089)
select*from student

--identity
create table person(pid int identity(1,1) primary key,[name] varchar(30) not null)
insert into person values('james')
insert into person values('manoj')
select*from person