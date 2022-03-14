CREATE PROCEDURE [dbo].[usp_GetAllDepartments]
AS
BEGIN
	BEGIN
		SET NOCOUNT ON;
		SELECT Department.DNumber, Department.DName, COUNT(Employee.Dno) AS EmpCount 
			FROM Department
		LEFT JOIN Employee ON Department.DNumber = Employee.Dno
		GROUP BY Department.DNumber, Department.DName
		END
END