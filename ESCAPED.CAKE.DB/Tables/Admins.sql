CREATE TABLE [dbo].[Admins]
(
	[Id] INT NOT NULL IDENTITY, 
    [Email] NCHAR(20) NOT NULL, 
    [Passwd] BINARY(64) NOT NULL, 
    CONSTRAINT [PK_Admins] PRIMARY KEY ([Id]) 
)
