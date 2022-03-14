CREATE PROCEDURE [dbo].[usp_GetAllDepartments]
AS
BEGIN
	BEGIN
		SET NOCOUNT ON;
		SELECT Department.DNumber, Department.DName, COUNT(Employee.Dno) AS EmpCount FROM Employee
		INNER JOIN Department ON Department.DNumber = Employee.Dno
		GROUP BY Department.DNumber, Department.DName
		END
END