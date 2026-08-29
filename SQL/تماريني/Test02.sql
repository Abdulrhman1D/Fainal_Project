use hr;
select * from employees
select * from departments
select * from locations
select * from jobs


select first_name,job_id,department_id,salary
from employees 
where job_id in (
	select job_id
	from employees 
	where department_id = 80
) 
order by job_id,
salary desc
------------------------
select first_name+' '+last_name 'Employee name', job_id, salary 
from employees 
where department_id in ( select location_id 
		from locations
		where location_id = 1700 
		) and department_id <> 100
order by department_id , 
salary desc

select first_name+' '+last_name 'Employee name', job_id, salary 
from employees 
where department_id in ( select department_id 
		from departments
		where location_id in (
		select location_id
		from locations
		where city = 'seattle' )
		) and department_id <> 100
order by department_id , 
salary desc


select * from employees
select * from departments
select * from locations
select * from countries
select * from regions

select e.first_name,e.job_id , e.salary
from employees e
where e.department_id in (
	select d.department_id
	from departments d
	where d.location_id in (
	
		select l.location_id
		from locations l 
		where l.country_id in (
			select c.country_id
			from countries c
			where c.region_id  = 1
			)
		)
	)
		and e.salary >= 7000
order by department_id ,
e.salary desc


select * from employees
select * from departments
select * from locations
select * from countries
select * from regions

select e.first_name,e.job_id,e.salary,e.department_id
from employees e
where e.department_id in (
	select d.department_id
	from departments d
	where d.location_id in (
		select l.location_id
		from locations l
		where l.country_id in (
			select c.country_id 
			from countries c
			where c.region_id = 2
		)
	)
) and e.salary > (
		select avg(salary)
		from employees
		where department_id = 60
	) and e.department_id <> 90
order by e.department_id , e.salary desc

--
select * from employees
select * from jobs 

select e.first_name , j.job_title , e.salary 
from employees e join jobs j
on e.job_id = j.job_id
where e.department_id in (
	select d.department_id 
	from departments d 
	where d.department_id = 80
	) and e.department_id not in (
	select d.department_id 
	from departments d
	where d.department_id = 80
	)
--

select * from employees
select * from jobs 
select * from departments

select e.employee_id, e.first_name , j.job_title , e.salary 
from employees e join jobs j
on e.job_id = j.job_id
where e.job_id in 
	(
	select job_id 
	from employees
	where department_id = 80
	)
	and e.employee_id <> 80
	and salary > 
	(
	select min(e.salary)
	from employees e
	where e.department_id = 50
	) and salary < 
	(
	select max(e.salary)
	from employees e
	where e.department_id = 90
	)
order by j.job_title , e.salary desc

select * from employees 
select * from jobs 
select * from departments
select * from countries
select * from locations

select e.first_name+' '+e.last_name 'Employee name',d.department_name 'Department name',
	j.job_title'Job title',e.salary'Salary'
from employees e join departments d on e.department_id = d.department_id join
jobs j on e.job_id = j.job_id
--
where e.department_id in (select d.department_id
	from departments d where d.location_id in
	(
		select l.country_id from locations l where l.country_id in (
		select c.country_name from countries c where c.country_name ='canada')
	)
) and e.salary > (select avg(e.salary) from employees e where department_id = 60)
and e.department_id <> 80 
order by d.department_name, e.salary desc
----

select e.first_name+' '+e.last_name 'Employee name',d.department_name 'Department name',
	j.job_title'Job title',e.salary'Salary'
from employees e join departments d on e.department_id = d.department_id join
jobs j on e.job_id = j.job_id
--
where e.department_id in (select d2.department_id
	from departments d2 where d2.location_id in
	(
		select l.location_id from locations l where l.country_id in (
		select c.country_id from countries c where c.country_name ='canada')
	)
) and e.job_id not in 
( select job_id from employees where department_id = 80 )
order by d.department_name, e.salary desc

-----
select * from employees 
select * from jobs 
select * from departments
select * from countries
select * from locations
select * from regions
-----
select e.first_name+' '+e.last_name 'Employee name',j.job_title'Job title',
	d.department_name 'Department name',e.salary'Salary'
from employees e join departments d on e.department_id = d.department_id join
jobs j on e.job_id = j.job_id
where e.department_id in 
(
	select d2.department_id 
	from departments d2
	where d2.location_id in
		(
		select l.location_id
		from locations l
		where l.country_id in 
			(
			select c.country_id
			from countries c
			where region_id = 1
			)
		)
) and e.salary > 
	(
	select avg(salary)
	from employees 
	where department_id > 
		(
		select department_id , count(*)'Employee count' from employees
		where department_id is not null 
		group by department_id
		)
	) 

	-----------------------------------------------

SELECT
    e.first_name + ' ' + e.last_name AS [Employee name],
    j.job_title AS [Job title],
    d.department_name AS [Department name],
    e.salary AS [Salary]
FROM employees e
JOIN jobs j
    ON e.job_id = j.job_id
JOIN departments d
    ON e.department_id = d.department_id
JOIN locations l
    ON d.location_id = l.location_id
JOIN countries c
    ON l.country_id = c.country_id
JOIN regions r
    ON c.region_id = r.region_id
WHERE r.region_name = 'Europe'

-- راتبه أعلى من متوسط رواتب القسم صاحب أكبر عدد موظفين
AND e.salary > (
    SELECT AVG(e2.salary)
    FROM employees e2
    WHERE e2.department_id IN (
        SELECT e3.department_id
        FROM employees e3
        WHERE e3.department_id IS NOT NULL
        GROUP BY e3.department_id
        HAVING COUNT(*) = (
            SELECT MAX(x.employee_count)
            FROM (
                SELECT COUNT(*) AS employee_count
                FROM employees
                WHERE department_id IS NOT NULL
                GROUP BY department_id
            ) x
        )
    )
)

-- وظيفته ليست ضمن وظائف القسم صاحب أقل متوسط رواتب
AND e.job_id NOT IN (
    SELECT e4.job_id
    FROM employees e4
    WHERE e4.department_id IN (
        SELECT e5.department_id
        FROM employees e5
        WHERE e5.department_id IS NOT NULL
        GROUP BY e5.department_id
        HAVING AVG(e5.salary) = (
            SELECT MIN(x.average_salary)
            FROM (
                SELECT AVG(salary) AS average_salary
                FROM employees
                WHERE department_id IS NOT NULL
                GROUP BY department_id
            ) x
        )
    )
)

-- لا تعرض الموظفين الذين ليس لديهم مدير
AND e.manager_id IS NOT NULL

ORDER BY
    d.department_name,
    j.job_title,
    e.salary DESC;



	------------------------
