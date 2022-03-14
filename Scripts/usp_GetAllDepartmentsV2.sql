CREATE PROCEDURE [dbo].[usp_GetAllDepartmentsV2]
AS
BEGIN
	BEGIN
		SELECT Department.DNumber, Department.DName, EmpCount
			FROM Department
		END
END