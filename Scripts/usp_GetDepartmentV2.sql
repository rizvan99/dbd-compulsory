CREATE PROCEDURE [dbo].[usp_GetDepartmentV2]
(
	@DNumber BIGINT
)
AS
BEGIN
	IF @DNumber IS NOT NULL
		BEGIN
			SELECT * FROM Department
			WHERE DNumber = @DNumber
		END
END