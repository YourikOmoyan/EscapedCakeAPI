CREATE PROCEDURE [dbo].[YSP_deleteProduct]
	@id int
AS
	DELETE FROM [Product]
	WHERE[Id] = @id
GO
