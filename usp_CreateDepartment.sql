USE [Company]
GO
/****** Object:  StoredProcedure [dbo].[usp_CreateDepartment]    Script Date: 07-03-2022 14:18:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[usp_CreateDepartment]
(
	@DName VARCHAR(50),
	@MgrSSN BIGINT
)
AS
BEGIN
	IF @DName IS NOT NULL AND @MgrSSN IS NOT NULL
		BEGIN
			INSERT INTO Department (DName, MgrSSN) VALUES (@DName, @MgrSSN)
			
			SELECT SCOPE_IDENTITY();
		END
END
