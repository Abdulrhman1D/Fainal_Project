select * from employees 

insert into employees
values (90,'Abdulrhman','Nasser','abdu1@gmil.com',050-497-0139,'1997-03-11','IT_PROG',48000,0.52,null,60);


insert into employees (employee_id,first_name,last_name,email,phone_number,hire_date,job_id,salary,department_id)
values (207,'lmi','khdrio','ljsd@gmil.com','510.321.1111','2005-03-11','IT_PROG',6450,60);


select first_name,email 
from employees
where email like '%@%'

update employees
set phone_number = '515.123.8181' 
where employee_id = 

delete employees
where employee_id in (90,207)
-------------------------------------------------



create database class1
--drop database class1;

create table courses (
cours_id int ,
cours_title varchar(30) not null unique,
price decimal not null,
startdate date default dateadd(day,7,getdate()),
duration int,

constraint courses_cours_id_PK primary key(cours_id) ,
constraint courses_price_CK_800_AND_300 check(price between 800 and 3000),
constraint courses_duration_CK_between_12_AND_120 check(duration between 12 and 120)
);

drop table courses

select * from courses

-- * create a projects table 
--   project_id => pk
--   project_name => not null
--   client_name => 
--   hour_rate => positive greater than 1

create table projects (
project_id int constraint projects_project_id_PK primary key(project_id),
project_name varchar(100) not null,
client_name varchar(100),
hour_rate decimal(10,2) constraint projects_hour_rate_PK check(hour_rate > 1)
);

create table Tasks (
    Task_ID INT PRIMARY KEY,
    Description_ VARCHAR(255),
    StartDate DATE,
    End_Date DATE,
    Project_ID INT ,
	CONSTRAINT Tasks_Project_ID_FK  FOREIGN KEY(Project_ID) REFERENCES Projects(Project_ID),
    CONSTRAINT CK_Tasks_EndDate CHECK (End_Date > StartDate)
);







