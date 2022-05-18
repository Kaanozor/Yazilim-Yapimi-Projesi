ALTER PROC UserAdd
@UserName     NVARCHAR (50),
@Name         NVARCHAR (50),
@Surname      NVARCHAR (50),
@Mail         NVARCHAR (50),
@Password     NVARCHAR (50),
@UserTypeName NVARCHAR (50)
AS
	INSERT INTO tbl_users(UserName,Name,Surname,Mail,Password,UserTypeName)
	VALUES(@UserName,@Name,@Surname,@Mail,@Password,@UserTypeName)