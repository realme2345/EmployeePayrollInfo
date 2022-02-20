CREATE PROCEDURE spInsertDepartmentInfo
@DepartId int,
@EmpId bigint,
@DepertName varchar(200)
AS
INSERT INTO Departmentinfo(DepartId,EmpId,DepertName)
VALUES(@DepartId,@EmpId,@DepertName);