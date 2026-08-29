select * from employees


select 
	first_name +' '+ last_name as 'Employee name', job_id Job , department_id Department
from
	employees
where
	department_id in (30,50,70);

select 
	first_name +' '+ last_name as 'Full name',department_id , salary
from 
	employees
where
	commission_pct is null


select 
	last_name 'last name', job_id job, salary
from
	employees
where 
	salary not in (2500,3500,7000);


select
	last_name 'Last name',salary 
from
	employees
where 
	(last_name like 'j%' or
	last_name like 'a%' or
	last_name like 'm%' ) 
	and 
	salary > 6000
order by
	last_name desc


select * from employees

select * from departments

select * from jobs 


select e.first_name 'Employee Name', j.job_title 'Job Name'
from employees e join jobs j
on e.job_id = j.job_id


select * from departments
select * from locations
select * from countries

select 
	d.department_name , 
	l.street_address , l.city , l.state_province , l.country_id 
from 
	departments d join locations l
on
	d.location_id = l.location_id

select * from departments
select * from locations
select * from countries

select 
	d.department_name , 
	l.street_address , l.city , l.state_province , c.country_name
from 
	departments d join locations l 
on
	d.location_id = l.location_id 
join countries c
on
	l.country_id = c.country_id
	
select * from employees
select * from departments
select * from locations
select * from countries
select * from jobs

select 
	e.first_name+' '+last_name 'employee name',
	j.job_title 'job title',
	d.department_name 'department name',
	l.city,
	c.country_name 'countyr name',
	e.salary
from
	employees e join jobs j
on 
	e.job_id = j.job_id
join departments d
on
	e.department_id = d.department_id
join locations l
on
	l.location_id = d.location_id
join countries c
on
	c.country_id = l.country_id
where
	e.salary > 8000
order by 
	c.country_name,
	d.department_name,
	e.salary desc



select * from employees
select * from departments
select * from locations
select * from countries
select * from jobs


select 
	e.first_name+' '+last_name 'employee name',
	d.department_name 'department name',
	j.job_title 'job title',
	l.city,
	c.country_name 'countyr name'
from 
	employees e join departments d
on e.department_id = d.department_id
join jobs j
on j.job_id = e.job_id
join locations l
on d.location_id = l.location_id
join countries c
on l.country_id = c.country_id

where 
	c.country_name in ('canada','germany') and
	e.salary > 8000
order by 
	c.country_name,
	e.salary desc

select * from employees
select * from jobs
select * from departments
select * from locations
select * from countries


select 
	e.first_name+' '+last_name 'employee name',
	j.job_title 'job title',
	d.department_name 'department name',
	l.city,
	c.country_name 'countyr name'
from
	employees e join jobs j
	on 
		e.job_id = j.job_id
join departments d
	on
		e.department_id = d.department_id
join locations l
	on
		l.location_id = d.location_id
join countries c
	on 
		c.country_id = l.country_id
where
	e.department_id = 80 and
--	d.department_id = 80 and
	e.salary > 9000
order by 
	e.salary desc 
