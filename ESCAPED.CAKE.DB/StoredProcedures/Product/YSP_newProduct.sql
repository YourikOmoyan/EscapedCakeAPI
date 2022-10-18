CREATE PROCEDURE [dbo].[YSP_newProduct]
     @name NVARCHAR (50),
     @description NVARCHAR (384),
     @price MONEY,
     @photo NVARCHAR (384),
     @video NVARCHAR (384),
     @categoryid INT
 AS
BEGIN
 INSERT INTO [Product] ([Name], [Description], [Price], [Photo],[Video], [CategoryId])
 OUTPUT [inserted].[Id]
 VALUES (@name, @description, @price, @photo, @video, @categoryid)
END
