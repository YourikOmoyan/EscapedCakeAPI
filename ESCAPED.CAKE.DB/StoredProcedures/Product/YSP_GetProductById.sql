CREATE PROCEDURE [dbo].[YSP_GetProductById]
@id INT
AS
 BEGIN

	SELECT [Id],[Name],[Description],[Price],[Photo],[Video],[CategoryId]
	FROM [Product]
	
	WHERE Product.Id = @id

	END
