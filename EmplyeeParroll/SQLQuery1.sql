CREATE PROCEDURE spDeletePerson
@Id varchar(200),
@Name varchar(200)
AS
DELETE from Employee_payrollinfo where Id=@Id and Name=@Name;