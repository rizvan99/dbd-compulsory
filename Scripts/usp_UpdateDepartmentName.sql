CREATE PROCEDURE [dbo].[usp_UpdateDepartmentName]
(
	@DNumber BIGINT,
	@DName VARCHAR(50)
)
AS
BEGIN
	IF @DName IS NOT NULL AND @DNumber IS NOT NULL
		BEGIN
			UPDATE Department
			SET DName = @DName
			WHERE DNumber = @DNumber
		END
END
