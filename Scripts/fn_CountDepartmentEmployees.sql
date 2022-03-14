CREATE FUNCTION [dbo].[fn_CountDepartmentEmployees]
(
	@DNumber INT
)
RETURNS BIGINT
AS
     BEGIN
         DECLARE @EmpCount BIGINT;
		 SELECT @EmpCount = COUNT(Employee.Dno)
		 FROM Employee
		 WHERE Employee.Dno = @DNumber
         RETURN @EmpCount;
     END;