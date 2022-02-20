CREATE PROCEDURE spEmpData
@EmpId bigint,
@CompanyId varchar(200),
@EmpName varchar(200),
@EmpPhno varchar(200),
@StartDate date
AS
INSERT INTO EmployeeInfo(EmpId,CompanyId,EmpName,EmpPhno,StartDate)
values(@EmpId,@CompanyId,@EmpName,@EmpPhno,@StartDate);