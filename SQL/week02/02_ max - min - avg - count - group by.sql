select * from employees
select * from departments
select * from countries
select * from locations
select * from jobs


select 
		d.department_name , l.street_address , l.city , l.state_province, c.country_name
	from
		departments d join locations l
		on d.location_id = l.location_id
		join countries c
		on l.country_id = c.country_id;


select 
	e.last_name 'last name', j.job_title 'job title',
	d.department_id 'department number', d.department_name 'department name'
	from
		employees e join jobs j
		on e.job_id = j.job_id
		join departments d
		on e.department_id = d.department_id
		join locations l
		on d.location_id = l.location_id
	where 
		l.city = 'toronto'


select 
	e.last_name 'last name', j.job_title 'job title',
	d.department_id 'department number', d.department_name 'department name'
	from
		employees e, jobs j, departments d, locations l
	where e.job_id = j.job_id and
	e.department_id = d.department_id and
	d.location_id = l.location_id and 
	l.city = 'toronto' ;


select * from employees
select * from departments
select * from countries
select * from locations
select * from jobs

select 
	j.job_title, max(salary) 'Maximum salary', min(salary)'Minimum salary',
	sum(salary)'Tptal salary', avg(salary)'Averge salary',
	count(e.employee_id)'Number of employees'
from
	employees e, jobs j
where
	e.job_id = j.job_id
group by 
	j.job_title
order by 
	j.job_title;


select 
	e.job_id, j.job_title, max(salary) 'Maximum salary', min(salary)'Minimum salary',
	sum(salary)'Tptal salary', avg(salary)'Averge salary',
	count(e.employee_id)'Number of employees'
from
	employees e, jobs j
where
	e.job_id = j.job_id
group by 
	e.job_id,j.job_title
order by 
	e.job_id

select * from employees
select * from departments
select * from countries
select * from locations
select * from jobs



select 
		d.department_id, d.department_name, max(salary)'Maximum salary',
		min(salary)'Minimum salary',count(salary)'Count salary',
		avg(salary)'Averge salary',count(d.department_id)'Number of employees'
		from employees e join departments d
		on e.department_id = d.department_id
		where d.department_id > 30
	group by 
		d.department_id, d.department_name
		having
		count(d.department_id) >= 5