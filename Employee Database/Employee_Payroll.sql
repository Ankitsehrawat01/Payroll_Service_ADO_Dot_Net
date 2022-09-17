--UC1 Create Database

create database Payroll_Service

--UC2 Create table

create table Employee_Payroll(Id int identity(1,1) primary key, Name varchar(200), Salary bigint, Start_Date date)

--UC3 Insert Data in Employee_Payroll table

insert into Employee_Payroll values ('Terissa', 30000, '2022-2-10'), ( 'Manish', 28000, '2022-2-18'), ( 'Ankit', 30000, '2022-4-2'), ( 'Sumit', 40000, '2022-4-4'), ( 'Mohit', 28000, '2022-4-8'), ( 'Manvi', 20000, '2022-9-13'), ( 'Anamika', 30000, '2022-9-12') 

--UC4 to view table

select * from Employee_Payroll

--UC5 To view details of a particular Employee by name or between dates

select * from Employee_Payroll where name = 'Mohit'
select * from Employee_Payroll where Start_Date between cast ('2022-2-18' as date ) and Getdate()

--UC6 Add gender column and update gender 

alter table Employee_Payroll add Gender varchar(10) 
update Employee_Payroll set Gender = 'M' where Name = 'Ankit' or Name = 'Sumit' or Name = 'Mohit' or Name = 'Manish'
update Employee_Payroll set Gender = 'F' where Name = 'Manvi' or Name = 'Anamika' or Name = 'Terissa'

--UC7 Using Aggregate Function

select Sum(Salary) as Total_Salary_Of_Male from Employee_Payroll where Gender = 'M' GROUP BY Gender
select Sum(Salary) as Total_Salary_Of_Female from Employee_Payroll where Gender = 'F' GROUP BY Gender
select Sum(Salary) as Total_Salary_Of_Employees from Employee_Payroll

select Avg(Salary) as Average_Salary_Of_Male from Employee_Payroll where Gender = 'M' GROUP BY Gender
select Avg(Salary) as Average_Salary_Of_Female from Employee_Payroll where Gender = 'F' GROUP BY Gender
select Avg(Salary) as Average_Salary_Of_Employees from Employee_Payroll

select Min(Salary) as Minimum_Salary_Of_Male from Employee_Payroll where Gender = 'M' GROUP BY Gender
select Min(Salary) as Minimum_Salary_Of_Female from Employee_Payroll where Gender = 'F' GROUP BY Gender
select Min(Salary) as Minimum_Salary_Of_Employee from Employee_Payroll

select Max(Salary) as Maximum_Salary_Of_Male from Employee_Payroll where Gender = 'M' GROUP BY Gender
select Max(Salary) as Maximum_Salary_Of_Female from Employee_Payroll where Gender = 'F' GROUP BY Gender
select Max(Salary) as Maximum_Salary_Of_Employee from Employee_Payroll

select Count(Id) as Number_Of_Male_Employees from Employee_Payroll where Gender = 'M' GROUP BY Gender
select Count(Id) as Number_Of_Female_Employees from Employee_Payroll where Gender = 'F' GROUP BY Gender
select Count(Id) as Total_Employees from Employee_Payroll

--UC8 Extend Employee_Payroll Data

alter table Employee_Payroll add Phone_Number bigint,  Address varchar(200), Department varchar(50) not null default 'Test'
update Employee_Payroll set Phone_Number = 111111111, Address = 'Charkhi Dadri', Department = 'IT' WHERE Name = 'Ankit'
update Employee_Payroll set Phone_Number = 222222222, Address = 'Gurugram', Department = 'Sales & Marketing' WHERE Name = 'Sumit'
update Employee_Payroll set Phone_Number = 333333333, Address = 'Jind', Department = 'IT' WHERE Name = 'Mohit'
update Employee_Payroll set Phone_Number = 444444444, Address = 'Panipat', Department = 'Sales & Marketing' WHERE Name = 'Manish'
update Employee_Payroll set Phone_Number = 555555555, Address = 'Allahabad', Department = 'HR' WHERE Name = 'Manvi'
update Employee_Payroll set Phone_Number = 666666666, Address = 'Panipat', Department = 'HR' WHERE Name = 'Anamika'
update Employee_Payroll set Phone_Number = 777777777, Address = 'USA', Department = 'Sales & Marketing' WHERE Name = 'Terissa'

--UC9 Extend Employee_Payroll to more columns

alter table Employee_Payroll add Basic_Pay bigint, Deductions bigint, Taxable_Pay bigint, Income_Tax bigint, Net_Pay bigint
update Employee_Payroll set Basic_Pay = 10000, Deductions = 2000, Taxable_Pay = 1000, Income_Tax = 1500, Net_Pay = 30000 where Name = 'Ankit'
update Employee_Payroll set Basic_Pay = 10000, Deductions = 2500, Taxable_Pay = 1500, Income_Tax = 2000, Net_Pay = 40000 where Name = 'Sumit'
update Employee_Payroll set Basic_Pay = 10000, Deductions = 2200, Taxable_Pay = 1200, Income_Tax = 1800, Net_Pay = 28000 where Name = 'Mohit'
update Employee_Payroll set Basic_Pay = 10000, Deductions = 2200, Taxable_Pay = 1200, Income_Tax = 1800, Net_Pay = 28000 where Name = 'Manish'
update Employee_Payroll set Basic_Pay = 10000, Deductions = 1000, Taxable_Pay = 1000, Income_Tax = 800, Net_Pay = 20000 where Name = 'Manvi'
update Employee_Payroll set Basic_Pay = 10000, Deductions = 2000, Taxable_Pay = 1000, Income_Tax = 1500, Net_Pay = 30000 where Name = 'Anamika'
update Employee_Payroll set Basic_Pay = 10000, Deductions = 2000, Taxable_Pay = 1000, Income_Tax = 1500, Net_Pay = 30000 where Name = 'Terissa'

--UC10 Make Terissa as part of sales &Marketing

update Employee_Payroll set Department = 'Sales & Marketing' WHERE Name = 'Terissa'




