USE [master]
GO
/****** Object:  Database [PhoneDirectory]    Script Date: 20/07/2023 13:53:49 ******/
CREATE DATABASE [PhoneDirectory]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PhoneDirectory', FILENAME = N'D:\SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\PhoneDirectory.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PhoneDirectory_log', FILENAME = N'D:\SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\PhoneDirectory_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [PhoneDirectory] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PhoneDirectory].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PhoneDirectory] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PhoneDirectory] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PhoneDirectory] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PhoneDirectory] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PhoneDirectory] SET ARITHABORT OFF 
GO
ALTER DATABASE [PhoneDirectory] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PhoneDirectory] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PhoneDirectory] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PhoneDirectory] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PhoneDirectory] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PhoneDirectory] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PhoneDirectory] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PhoneDirectory] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PhoneDirectory] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PhoneDirectory] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PhoneDirectory] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PhoneDirectory] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PhoneDirectory] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PhoneDirectory] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PhoneDirectory] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PhoneDirectory] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PhoneDirectory] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PhoneDirectory] SET RECOVERY FULL 
GO
ALTER DATABASE [PhoneDirectory] SET  MULTI_USER 
GO
ALTER DATABASE [PhoneDirectory] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PhoneDirectory] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PhoneDirectory] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PhoneDirectory] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PhoneDirectory] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PhoneDirectory] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'PhoneDirectory', N'ON'
GO
ALTER DATABASE [PhoneDirectory] SET QUERY_STORE = ON
GO
ALTER DATABASE [PhoneDirectory] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [PhoneDirectory]
GO
/****** Object:  Table [dbo].[Contacts]    Script Date: 20/07/2023 13:53:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contacts](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[firstName] [varchar](100) NOT NULL,
	[lastName] [varchar](100) NOT NULL,
	[gsmNumber] [varchar](20) NOT NULL,
	[email] [varchar](255) NOT NULL,
	[address] [text] NULL,
	[username] [varchar](100) NULL,
	[activeState] [binary](1) NOT NULL,
 CONSTRAINT [PK_Contacts_ID] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_contacts_gsm] UNIQUE NONCLUSTERED 
(
	[gsmNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_contacts_username] UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DeletedContacts]    Script Date: 20/07/2023 13:53:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeletedContacts](
	[id] [int] NOT NULL,
	[firstName] [varchar](100) NULL,
	[lastName] [varchar](100) NULL,
	[gsmNumber] [varchar](20) NULL,
	[email] [varchar](255) NULL,
	[address] [text] NULL,
	[username] [varchar](100) NULL,
	[deletedBy] [varchar](100) NULL,
	[deletedAt] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DeletedUsers]    Script Date: 20/07/2023 13:53:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeletedUsers](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[email] [varchar](255) NOT NULL,
	[password] [varchar](255) NOT NULL,
	[role] [varchar](50) NOT NULL,
	[firstName] [varchar](100) NULL,
	[lastName] [varchar](100) NULL,
	[username] [varchar](100) NULL,
	[address] [varchar](255) NULL,
	[gsmNumber] [varchar](20) NOT NULL,
	[deletedBy] [varchar](100) NULL,
	[deletedAt] [datetime] NULL,
 CONSTRAINT [PK_DeletedUsers_GSM] PRIMARY KEY CLUSTERED 
(
	[gsmNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserContacts]    Script Date: 20/07/2023 13:53:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserContacts](
	[userId] [int] NOT NULL,
	[contactId] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 20/07/2023 13:53:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[email] [varchar](255) NOT NULL,
	[password] [varchar](255) NOT NULL,
	[role] [varchar](50) NOT NULL,
	[firstName] [varchar](100) NOT NULL,
	[lastName] [varchar](100) NOT NULL,
	[username] [varchar](100) NULL,
	[address] [varchar](255) NULL,
	[gsmNumber] [varchar](20) NOT NULL,
	[activeState] [binary](1) NOT NULL,
 CONSTRAINT [PK_Users_ID] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_users_gsm] UNIQUE NONCLUSTERED 
(
	[gsmNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_users_username] UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Contacts] ADD  DEFAULT ((1)) FOR [activeState]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT ((1)) FOR [activeState]
GO
ALTER TABLE [dbo].[UserContacts]  WITH CHECK ADD  CONSTRAINT [FK_UserContacts_Contacts] FOREIGN KEY([contactId])
REFERENCES [dbo].[Contacts] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserContacts] CHECK CONSTRAINT [FK_UserContacts_Contacts]
GO
ALTER TABLE [dbo].[UserContacts]  WITH CHECK ADD  CONSTRAINT [FK_UserContacts_Users] FOREIGN KEY([userId])
REFERENCES [dbo].[Users] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserContacts] CHECK CONSTRAINT [FK_UserContacts_Users]
GO
/****** Object:  StoredProcedure [dbo].[AddExistingContact]    Script Date: 20/07/2023 13:53:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddExistingContact]
	@contactUsername VARCHAR(100),
	@username VARCHAR(100)
AS
BEGIN
	INSERT INTO UserContacts(userId, contactId)
	VALUES((SELECT id FROM users
	WHERE username = @username),
	(SELECT id FROM contacts
	WHERE username = @contactUsername))
END
GO
/****** Object:  StoredProcedure [dbo].[ChangePassword]    Script Date: 20/07/2023 13:53:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ChangePassword]
	@username VARCHAR(100),
	@password VARCHAR(255)
AS
BEGIN
	UPDATE Users
	SET Users.password = @password
	WHERE username = @username
END
GO
/****** Object:  StoredProcedure [dbo].[CreateContact]    Script Date: 20/07/2023 13:53:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CreateContact]
	@name VARCHAR(100),
	@surname VARCHAR(100),
	@gsmNum VARCHAR(100),
	@email VARCHAR(100),
	@address VARCHAR(100),
	@userUserName VARCHAR(100),
	@username VARCHAR(100)
AS
BEGIN
	IF EXISTS (SELECT 1 FROM contacts WHERE gsmNumber = @gsmNum)
	BEGIN
		EXEC AddExistingContact @username, @userUsername
	END

	ELSE
	BEGIN
		INSERT INTO contacts (firstName, lastName, gsmNumber, email, address)
		VALUES (@name, @surname, @gsmNum, @email, @address)

		INSERT INTO UserContacts(userId, contactId)
		values((
		SELECT id FROM users
		WHERE username = @userUserName),
		(SELECT id from contacts 
		WHERE username = @username))
	END
END
GO
/****** Object:  StoredProcedure [dbo].[CreateUser]    Script Date: 20/07/2023 13:53:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CreateUser]
	@username VARCHAR(100),
	@name VARCHAR(100),
	@surname VARCHAR(100),
	@gsmNum VARCHAR(100),
	@email VARCHAR(100),
	@role VARCHAR(100),
	@address VARCHAR(100),
	@password VARCHAR(100)
AS
BEGIN
	INSERT INTO users(firstName, lastName, username, email, role, address, gsmNumber, password)
	VALUES(@name, @surname, @username, @email, @role, @address, @gsmNum, @password)
END
GO
/****** Object:  StoredProcedure [dbo].[RemoveContact]    Script Date: 20/07/2023 13:53:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RemoveContact]
	@username VARCHAR(100)
AS
BEGIN
	DELETE FROM contacts
	WHERE username = @username

END
GO
/****** Object:  StoredProcedure [dbo].[RemoveUser]    Script Date: 20/07/2023 13:53:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RemoveUser]
	@username VARCHAR(100)
AS
BEGIN

	DELETE FROM users
	WHERE username = @username
END
GO
/****** Object:  StoredProcedure [dbo].[RetrieveData]    Script Date: 20/07/2023 13:53:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RetrieveData]
	@userUsername VARCHAR(100),
	@contactSearch VARCHAR(100),
	@activeState BINARY
AS
BEGIN
	SELECT c.*
	FROM contacts c
	JOIN UserContacts uc ON c.id = uc.contactId
	JOIN users u ON uc.userId = u.id
	WHERE u.username = @userUsername AND c.username LIKE '%' + @contactSearch + '%' AND c.activeState = @activeState
END
GO
/****** Object:  StoredProcedure [dbo].[RetrieveDeletedContact]    Script Date: 20/07/2023 13:53:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RetrieveDeletedContact]
	@username VARCHAR(100)
AS
BEGIN

	UPDATE Contacts
	SET activeState = 1
	WHERE username = @username

END
GO
/****** Object:  StoredProcedure [dbo].[RetrieveDeletedUser]    Script Date: 20/07/2023 13:53:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[RetrieveDeletedUser]
	@username VARCHAR(100)
AS
BEGIN
	UPDATE Users 
	Set activeState = 1
	WHERE username = @username
END
GO
/****** Object:  StoredProcedure [dbo].[RetrieveUserContacts]    Script Date: 20/07/2023 13:53:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RetrieveUserContacts]
	@username VARCHAR(255)
AS
BEGIN
	
	SELECT c.*
	FROM users u
	JOIN UserContacts uc ON u.id = uc.userId
	JOIN contacts c ON uc.contactId = c.id
	WHERE u.email = @username

END
GO
/****** Object:  StoredProcedure [dbo].[RetrieveUsers]    Script Date: 20/07/2023 13:53:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[RetrieveUsers]
	@userSearch VARCHAR(100),
	@activeState BINARY
AS
BEGIN
	SELECT * FROM users
	WHERE username LIKE '%' + @userSearch + '%' AND activeState = @activeState

END
GO
/****** Object:  StoredProcedure [dbo].[SevereUserContact]    Script Date: 20/07/2023 13:53:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SevereUserContact]
	@userUsername VARCHAR(100),
	@contactUsername VARCHAR(100)
AS
BEGIN
	DELETE FROM UserContacts 
	WHERE userId = (SELECT id FROM Users WHERE username = @userUsername)
	AND contactId = (SELECT id FROM Contacts WHERE username = @contactUsername)
END
GO
/****** Object:  StoredProcedure [dbo].[SoftDeleteFromContacts]    Script Date: 20/07/2023 13:53:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SoftDeleteFromContacts]

	@username VARCHAR(100)
AS
BEGIN

UPDATE Contacts
SET activeState = 0
WHERE username = @username;

END
GO
/****** Object:  StoredProcedure [dbo].[SoftDeleteFromUsers]    Script Date: 20/07/2023 13:53:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SoftDeleteFromUsers]
	
	@username VARCHAR(100)

AS
BEGIN

UPDATE Users
SET activeState = 0
WHERE username = @username

END
GO
/****** Object:  StoredProcedure [dbo].[UpdateContact]    Script Date: 20/07/2023 13:53:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateContact]
	@name VARCHAR(100),
	@surname VARCHAR(100),
	@gsmNum VARCHAR(100),
	@email VARCHAR(100),
	@address VARCHAR(100),
	@oldUsername VARCHAR (100)
AS
BEGIN
	UPDATE contacts
	SET firstName = @name,
		lastName = @surname,
		gsmNumber= @gsmNum,
		email = @email,
		address = @address
		WHERE username = @oldUsername
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateUser]    Script Date: 20/07/2023 13:53:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateUser]
	@username VARCHAR(100),
	@name VARCHAR(100),
	@surname VARCHAR(100),
	@gsmNum VARCHAR(100),
	@email VARCHAR(100),
	@address VARCHAR(100),
	@password VARCHAR(100),
	@role VARCHAR(100),
	@oldUsername VARCHAR(100)
AS
BEGIN
	UPDATE users
	SET firstName = @name,
		lastName = @surname,
		gsmNumber = @gsmNum,
		email = @email,
		username = @username, 
		address = @address,
		password = @password,
		role = @role
		WHERE username = @oldUsername
END
GO
/****** Object:  StoredProcedure [dbo].[VerifyUnamePwd]    Script Date: 20/07/2023 13:53:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VerifyUnamePwd]
	@email VARCHAR(255),
	@password VARCHAR(255)

AS
BEGIN
	SELECT * FROM users WHERE email = @email AND @password = password AND activeState != 0;
END;
GO
USE [master]
GO
ALTER DATABASE [PhoneDirectory] SET  READ_WRITE 
GO
