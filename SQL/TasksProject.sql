 create database HR_Management_Project
 ------------create-------done----------------
 create table departments (
 DepartmentID int primary key,
 DepartmentName varchar(50) not null unique 
 );
------------create-------done----------------
 create table employees (
 EmployeeID int identity primary key ,
 FirstName varchar(20) not null,
 LastName varchar(30) not null,
 DepartmentID int ,
 ManagerID int ,
 Salary decimal (10,2) constraint employees_Salary_CK check (Salary > 0 ),
 constraint employees_DepartmentID_FK foreign key(DepartmentID) REFERENCES departments(DepartmentID),
 constraint employees_ManagerID_FK foreign key(ManagerID) REFERENCES employees(EmployeeID)
 );
------------create-------done----------------
 create table LeaveRequests (
 LeaveID int identity primary key ,
 EmployeeID int ,
 StartDate date not null,
 EndDate date not null,
 Reason varchar(100),
 Status varchar(20) constraint LeaveRequests_Status_CK check (Status in ('Pending','Approved','Rejected'))
 constraint LeaveRequests_EmployeeID_FK foreign key(EmployeeID) references employees(EmployeeID)
 );
 ------------create-------done----------------
 create table Instructors (
 InstructorID int identity primary key,
 FirstName varchar(25) not null,
 LastName varchar(25) not null
 );
 ------------create-------done----------------
 create table TrainingCourses (
 CourseID int identity primary key,
 CourseName varchar(100) not null,
 StartDate date not null,
 EndDate date not null,
 InstructorID int ,
 constraint CK_TrainingCourses_EndDate check (EndDate > StartDate),
 constraint TrainingCourses_InstructorID_FK foreign key(InstructorID) references Instructors(InstructorID) 
 );
 -----------create------done-----------------
 select * from departments
 insert into departments 
 values (1,'HR'),
 (2,'Finance'),
 (3,'IT'),
 (4,'Marketing'),
 (5,'Operations'),
 (6,'Sales'),
 (7,'Customer Service'),
 (8,'Research and Development'),
 (9,'Finance_');
 -------------insert----done------------------
 select * from employees
 insert into employees 
 (FirstName,LastName,DepartmentID,ManagerID,Salary)
 values
--('John','Doe',1,null,50000),
--('Jane','Smith',2,1,60000),
--('Ahmad','Ali',3,1,55000),
('Sara','Khan',2,3,52000),
('Mohammed','Hassan',1,5,48000),
('Hasan','Ali',1,6,54000),
('Fatima','Khaled',2,7,62000),
('Amr','Mohammed',3,8,56000),
('Sara','Ahmed',4,1,51000),
('Ahmed','Youssef',1,1,50000);
 -------------insert----done------------------
select * from TrainingCourses
insert into TrainingCourses (CourseID,CourseName,StartDate,EndDate,InstructorID)
values 
(201,'Leadership Skills','2023-11-02','2023-11-07',1),
(202,'Excel Advanced','2023-11-12','2023-11-14',2),
(203,'Time Management','2023-11-20','2023-11-21',3),
(204,'Communication Tips ','2023-12-02','2023-12-04',4),
(205,'Conflict Resolution','2023-12-10','2023-12-11',5),
(206,'Negotiation Skills','2023-12-20','2023-12-22',6),
(207,'Financial Planning','2024-01-05','2024-01-07',7),
(208,'Leadership Workshop','2024-01-10','2024-01-12',8),
(209,'Effective Communication','2024-01-15','2024-01-17',9),
(210,'Time Management','2024-01-20','2024-01-22',10);
 -------------insert----done------------------
select * from Instructors
insert into Instructors (FirstName,LastName)
values ('Sarah','Johnson'),
('James','Smith'),
('Mary','Davis'),
('Ahmad','Hassan'),
('Fatima','Ali'),
('Yasmine','Ali'),
('Mohammed','Hassen'),
('Ahmad','Youssef'),
('Amr','Mohammed'),
('Sara','Ahmad'); 
 -------------insert----done------------------
select * from LeaveRequests
insert into LeaveRequests (LeaveID,EmployeeID,StartDate,EndDate,Reason,Status)
values 
(106,6,'2023-12-10','2023-12-24','Annual Leave','done'),
(102,3,'2023-11-05','2023-11-07','Conference','Pending'),
(103,2,'2023-10-20','2023-10-21','Sick Leave','Approved'),
(104,4,'2023-12-01','2023-12-03','Family Emergency','Pending'),
(105,5,'2023-10-25','2023-10-26','Personal','Approved');
 -------------insert----done------------------
--------task1--update--salary-------
select * from employees 
update employees
set salary = 52000
where EmployeeID = 5
----------------done---------------------
--------task2--rename--department----
select * from departments
update departments 
set DepartmentName = 'Human Resources'
where DepartmentName = 'HR'
-----------------done-------------------
-------task3--update---ManagerID----
select * from employees 
update employees
set ManagerID = 10
where ManagerID = 3
----------------done--------------------
--------task4--update--date---------
select * from TrainingCourses
update TrainingCourses
set StartDate = '2023-11-13'
where CourseID = 202
----------------done--------------------
--------task5---delete--emp---------
select * from employees
delete employees
where EmployeeID = 8
----------------done----------------
--------task6-----delete----dep------
select * from departments
delete departments
where DepartmentID = 9
----------------done----------------
--------task7---delete---TC---------
select * from TrainingCourses
delete TrainingCourses
where CourseID = 205
----------------done----------------
---------------Q1-------------------
select * from employees
select firstName+' '+LastName[Employee Name]
from employees 
---------------done----------------
--------------Q2-----------------'
select avg(salary)[Average Salary]  
from employees
----------------done----------------
--------------Q3-------------------
select firstName+' '+LastName[Employee Name],salary
from employees 
----------------done----------------
---------------Q4-------------------
select * from departments
select departmentName 
from departments
----------------done----------------
---------------Q5-------------------
select * from TrainingCourses
select CourseName,StartDate
from TrainingCourses
----------------done----------------
---------------task1----------------
select * from employees
select d.departmentname, count(e.employeeid)[Total Employees],avg(e.salary)[Average Salary]
from employees e join departments d
on e.departmentID = d.departmentID
group by  d.DepartmentName
----------------done----------------
---------------task2----------------
select * from Instructors 
select * from TrainingCourses
select i.FirstName+' '+i.LastName[Instructor Name],t.coursename
from Instructors i join TrainingCourses t
on i.InstructorID = t.InstructorID
----------------done----------------
---------------task3----------------
select e.FirstName+' '+e.LastName[Employee Name],d.departmentName,
( select avg(salary) from employees where DepartmentID = e.DepartmentID) [Total salary]
from employees e join departments d
on e.DepartmentID = d.DepartmentID
----------------done----------------
---------------task4----------------
select * from LeaveRequests 
select EmployeeID ,count(status) as [Total Leave Requests]
from LeaveRequests
where Status in ('Approved','Rejected')
group by EmployeeID ;
----------------done----------------
---------------task5----------------
select * from employees
select e.DepartmentID, d.DepartmentName, count(EmployeeID)[Total employees]
from employees e join departments d 
on e.DepartmentID = d.DepartmentID
group by e.DepartmentID, d.DepartmentName
----------------done----------------
---------------task6----------------
select * from Instructors
select * from TrainingCourses
select i.FirstName+' '+i.LastName [Instructor Name], count(t.CourseID)[Total Course]
from Instructors i join TrainingCourses t
on i.InstructorID = t.InstructorID
group by i.FirstName+' '+i.LastName 
----------------done----------------
---------------task7----------------
select e.FirstName+' '+e.LastName [Employee Name], d.departmentname
from employees e join departments d
on e.departmentid = d.departmentid
----------------done----------------
---------------task8----------------
select FirstName+' '+LastName [Employee Name]
from employees
where DepartmentID in 
(
	select DepartmentID
	from employees
	group by DepartmentID
	having count(EmployeeID) > 3
)
----------------done----------------
---------------task9----------------
select * from employees
select * from departments
select e.FirstName+' '+e.LastName [Employee Name], d.DepartmentName
from employees e join departments d
on e.DepartmentID = d.DepartmentID
where e.DepartmentID in 
(
	select DepartmentID
	from employees
	group by DepartmentID
	having count(EmployeeID)>1
)
order by d.DepartmentName

----------------done----------------
---------------task10----------------
select * from TrainingCourses
select * from Instructors
select count(t.CourseID)[Total cours] , i.firstname
from trainingcourses t join Instructors i
on t.InstructorID = i.InstructorID
where i.FirstName = 'Sarah'
group by i.firstname

select i.FirstName+' '+i.LastName[Instructir Name],t.CourseName
from trainingcourses t join Instructors i
on t.InstructorID = i.InstructorID 
where i.InstructorID = 1
----------------done----------------
---------------task11----------------
select * from employees        
select FirstName+' '+LastName [Employee Name],DepartmentID,ManagerID,Salary
from employees
where ManagerID is null --- اختيار خانة المدير الفاضية

----------------done----------------
---------------task12----------------
select * from departments
select d.departmentname,sum(e.salary)[Total Salary]
from departments d join  employees e
on d.DepartmentID = e.DepartmentID
group by d.DepartmentName
----------------done----------------
---------------task13----------------
select * from departments
select * from employees
select d.DepartmentName,e.FirstName , e.Salary
from departments d join  employees e
on d.DepartmentID = e.DepartmentID
where e.salary = (
select max(e2.salary)
from employees e2
where e2.DepartmentID = e.DepartmentID)
----------------done----------------
---------------task14----------------
select * from TrainingCourses 
select count(CourseName)[Total Courses After 2023-12-01]
from TrainingCourses
where StartDate > '2023-12-01';
----------------done----------------
---------------task15----------------
select * from employees
select e.FirstName , e.Salary, d.DepartmentID
from departments d join  employees e
on d.DepartmentID = e.DepartmentID
where e.salary = (
select max(e2.salary)
from employees e2
where e2.DepartmentID = e.DepartmentID)