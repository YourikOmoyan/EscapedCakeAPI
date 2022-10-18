CREATE PROCEDURE [dbo].[YSP_GetProductByCategory]
	@categoryName NVARCHAR(50)
AS
 BEGIN

	SELECT [Product].[Id],[Product].[Name],[Description],[Price],[Photo],[Video]
	FROM [Product]
	JOIN Category
	ON Category.[Id] = Product.[CategoryId]
	WHERE Category.[Name] = @categoryName

	END
