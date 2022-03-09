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
			SET MgrSSN = @MgrSSN
			WHERE DNumber = @DNumber
		END
END
