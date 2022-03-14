CREATE PROCEDURE [dbo].[usp_UpdateDepartmentManager]
(
	@DNumber BIGINT,
	@MgrSSN BIGINT
)
AS
BEGIN
	IF @DNumber IS NOT NULL AND @MgrSSN IS NOT NULL
		BEGIN
			UPDATE Department
			SET MgrSSN = @MgrSSN, MgrStartDate = GETDATE()
			WHERE DNumber = @DNumber

			UPDATE Employee
			Set SuperSSN = @MgrSSN
			WHERE Dno = @DNumber AND Employee.SSN != @MgrSSN
		END
END
