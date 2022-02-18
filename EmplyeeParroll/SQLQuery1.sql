CREATE PROCEDURE spUpdatePerson
@Id int,
@BasePay float
AS
UpDATE Employee_payrollinfo set Basepay=@Basepay where @Id=Id;