CREATE PROCEDURE spUpdatePerson
@Id int,
@BasePay float,
@Department varchar(200)
AS
insert into Employee_payrollinfo(Id,Basepay,Department)
values(@Id,@BasePay,@Department);