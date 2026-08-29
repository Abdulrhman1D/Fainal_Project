select * from employees;



select first_name + ' bin ' + last_name as 'Employee Name',
		salary as Salary
from
	employees
where
	salary between 4000 and 9000
order by
	salary desc;



select first_name as 'First Name',
		salary as Salary
from 
	employees
where 
	salary >= 4000 and salary <= 9000 
order by 
	salary desc;


select *
from employees
where manager_id is null;


select first_name , department_id
from employees
where department_id = 60 or department_id = 90