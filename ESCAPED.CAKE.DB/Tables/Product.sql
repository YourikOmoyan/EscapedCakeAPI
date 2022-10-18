CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL UNIQUE, 
    [Description] NVARCHAR(384) NOT NULL, 
    [Price] FLOAT NULL, 
    [Photo] NVARCHAR(384) NOT NULL, 
    [Video] NVARCHAR(384) NOT NULL, 
    [CategoryId] INT NOT NULL,
    CONSTRAINT [PK_Cakes] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_Product_Category] FOREIGN KEY ([CategoryId]) REFERENCES [Category]([Id]), 
         
)