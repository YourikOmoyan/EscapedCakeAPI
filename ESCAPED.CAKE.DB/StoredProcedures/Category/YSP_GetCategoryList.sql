CREATE PROCEDURE [dbo].[YSP_GetCategoryList]
	
AS
 BEGIN
	SELECT [Id],[Name]
	FROM Category
END
