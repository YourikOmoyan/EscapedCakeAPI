CREATE PROCEDURE [dbo].[YSP_updateProduct]
@id INT,
@name NVARCHAR (50),
@description NVARCHAR (384),
@price MONEY,
@photo NVARCHAR (384),
@video NVARCHAR (384),
@categoryid INT
AS
	BEGIN
	UPDATE[Product]

	SET [Name] = @name,
	    [Description] = @description,
		[Price] = @price,
		[Photo] = @photo,
		[Video] = @video,
		[CategoryId] = @categoryid
	WHERE [Id] = @id

	END