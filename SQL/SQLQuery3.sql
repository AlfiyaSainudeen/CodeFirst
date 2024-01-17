create database Assignment3
use Assignment3
CREATE TABLE Worker (
Worker_Id INT PRIMARY KEY ,
First_Name VARCHAR(25),
Last_Name VARCHAR(25),
Salary INT,
Joining_Date DATETIME,
Department CHAR(25)
);
CREATE TABLE Bonus (
Worker_Ref_Id INT,
Bonus_Amount INT,
Bonus_Date DATETIME,
FOREIGN KEY (Worker_Ref_Id)
REFERENCES Worker(Worker_Id)
ON DELETE CASCADE
);

CREATE TABLE Title (
Worker_Ref_Id INT ,
Worker_Title CHAR(25),
Affected_From DATETIME,
FOREIGN KEY (Worker_Ref_Id)
REFERENCES Worker(Worker_Id)
ON DELETE CASCADE
);
insert into Worker values(001,'Monika','Arora',10000,'2014-02-20 9:00:00','HR'),
(002,'Niharika', 'Verma', 80000, '2014-06-11 09:00:00','Admin'),
(003,'Vishal', 'Singhal', 300000 ,'2014-02-20 09:00:00','HR'),
(004,'Amitabh', 'Singh', 500000,'2014-02-20 09:00:00','Admin'),
(005,'Vivek', 'Bhati' ,500000 ,'2014-06-11 09:00:00','Admin'),
(006,'Vipul',' Diwan',200000,'2014-06-11 09:00:00','Account'),
(007,'Satish',' Kumar' ,75000, '2014-01-20 09:00:00','Account'),
(008,'Geetika','Chauhan',90000,'2014-04-11 09:00:00','Admin')

insert into Bonus values(1,5000,'2016-02-20 00:00:00'),
(2,3000,'2016-06-11 00:00:00'),
(3,4000,'2016-02-20 00:00:00'),
(1,4500,'2016-02-20 00:00:00'),
(2,3500,'2016-06-11 00:00:00')
insert into Title values (1,'Manager', '2016-02-20 00:00:00'),
(2,'Executive', '2016-06-11 00:00:00'),
(8,'Executive', '2016-06-11 00:00:00'),
(5,'Manager','2016-06-11 00:00:00'),
(4 ,'Asst. Manager' ,'2016-06-11 00:00:00'),
(7,'Executive', '2016-06-11 00:00:00'),
(6,'Lead', '2016-06-11 00:00:00'),
(3 ,'Lead' ,'2016-06-11 00:00:00')
--question1
select First_Name from Worker where First_Name='Monika'
--qus2
select upper(First_Name) from Worker
--qus3
select distinct(Department) from Worker
--qus4
select SUBSTRING(First_Name,1,3) as[First Name] from Worker
--qus5
SELECT Position ('A' IN First_Name) FROM worker WHERE First_Name = 'Amitabh';
--qus6
SELECT RTRIM(First_Name) FROM Worker
--qus7
SELECT LTRIM(Department) FROM Worker;
--qus8
SELECT DISTINCT Department, LEN(Department) AS [Department Length] FROM Worker;
--qus9
SELECT REPLACE(First_Name, 'a', 'A') FROM Worker;
--qus10
SELECT CONCAT(First_Name, ' ', Last_Name) AS [Complete_Name] FROM Worker;
--qus11
SELECT * FROM Worker ORDER BY First_Name ASC;
--qus12
SELECT * FROM Worker ORDER BY First_Name ASC, Department DESC;
--qus13
SELECT * FROM Worker WHERE First_Name IN ('Vipul', 'Satish');
--qus14
SELECT * FROM Worker WHERE First_Name NOT IN ('Vipul', 'Satish');
--qus15
SELECT * FROM Worker WHERE Department = 'Admin';
--qus16
SELECT * FROM Worker WHERE First_Name LIKE '%a%';
--qus17
SELECT * FROM Worker WHERE First_Name LIKE '%a';
--qus18
SELECT * FROM Worker WHERE First_Name LIKE '______h';
--qus19
SELECT * FROM Worker WHERE Salary BETWEEN 100000 AND 500000;
--qus20
SELECT * FROM Worker WHERE year(Joining_Date) = 2014 AND
month(Joining_Date) = 2;
--qus21
SELECT COUNT(*) FROM Worker WHERE department = 'Admin';
--qus22
SELECT Department, count(Worker_Id) as [No.of Workers] FROM Worker
GROUP BY Department  ORDER BY [No.of Workers] DESC;
--qus23
SELECT * FROM Worker WHERE Worker_Id IN(SELECT Worker_Ref_Id FROM
Title WHERE Worker_Title='Manager')
--qus24
SELECT GETDATE()AS [current date time];