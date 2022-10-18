CREATE PROCEDURE [dbo].[YSP_GetProductList]
	
AS
BEGIN

	SELECT [Name],[Description],[Price],[Photo],[Video],[CategoryId]
	FROM Product

	END

