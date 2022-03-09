CREATE PROCEDURE [dbo].[usp_DeleteDepartment]
(
	@DNumber BIGINT
)
AS
BEGIN
	IF @DNumber IS NOT NULL
		BEGIN
			DELETE Department
			WHERE DNumber = @DNumber
		END
END
