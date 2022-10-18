CREATE PROCEDURE [dbo].[YSP_addUser]
	@FirstName NVARCHAR(60),
	@LastName NVARCHAR(60),
	@Email NVARCHAR(384),
	@Passwd NVARCHAR(24),
	@Phone NVARCHAR(50)
    AS
      BEGIN
	      INSERT INTO [Users] (FirstName, LastName, Email, Passwd, Phone) 
	      OUTPUT [inserted].[Id]
	      VALUES (@LastName, @FirstName, @Email, HASHBYTES('SHA2_512', dbo.YSF_Salt() + @Passwd), @Phone);
      END
