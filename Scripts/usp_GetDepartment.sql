CREATE PROCEDURE [dbo].[usp_GetDepartment]
(
	@DNumber BIGINT
)
AS
DECLARE @EmpCount BIGINT
BEGIN
	IF @DNumber IS NOT NULL
		BEGIN
			SET NOCOUNT ON;
			SELECT @EmpCount = COUNT(*) FROM Employee
			WHERE Employee.Dno = @DNumber
			SELECT *, @EmpCount AS EmpCount FROM Department
			WHERE DNumber = @DNumber
		END
END