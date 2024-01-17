select*from employee
select emp_id,fname,lname from employee
select emp_id,hire_date from employee
select emp_id,fname+' '+lname as fullname from employee
select*from employee where job_id=10
select*from employee where job_id=10 and pub_id=1389
select*from employee where job_id=10 or pub_id=1389
select*from employee where job_id in(14,10,8)
select*from employee where fname in('Aria','Anabela','manuel')
select*from employee where hire_date between '1.1.1990' and '12.31.1992'
select*from employee where hire_date between '1.1.1990' and '12.31.1990'
select*from employee where job_id not in(14,10,8)
select*from authors where city='Oakland'

--pattern matching

select*from employee where fname like 'p%' --name starts with p
select*from employee where fname like '%e' --name ends with e
select*from employee where fname like 'p%e'--name starts with p and ends with e
select*from employee where fname like '%j%' --name contains j
select*from employee where fname like '_a%' --name contains 2nd char a
select*from employee where fname like '[kp]%'--name starts with k and p
select*from employee where fname not like '[kp]%'--name not starts with k and p
select*from employee where fname like '[^kp]%'--name not starts with k and p