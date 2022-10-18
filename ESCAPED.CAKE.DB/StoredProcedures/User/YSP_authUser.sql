CREATE PROCEDURE [dbo].[YSP_authUser]
	@email NVARCHAR(384),
	@password NVARCHAR(64)
AS
	SELECT	
			[Email],
			'********' AS [Passwd]
	FROM [Users]
	WHERE [Email] LIKE @email
		AND [Passwd] = HASHBYTES('SHA2_512',  dbo.YSF_Salt() + @password)