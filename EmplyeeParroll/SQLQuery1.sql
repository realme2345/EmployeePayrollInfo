CREATE PROCEDURE spAdDEmployee
@Name varchar(200),
@Address varchar(200),
@BasePay float,
@Department varchar(200),
@Gender char(1),
@StartDate date
AS
insert into Employee_payrollinfo(Name,Address,Basepay,Department,Gender,StartDate)
values(@Name,@Address,@BasePay,@Department,@Gender,@StartDate);