CREATE PROCEDURE [dbo].[YSP_newCategory]
     @name NVARCHAR (50)
 AS
BEGIN
 INSERT INTO [Category] ([Name])
 VALUES (@name)
END
