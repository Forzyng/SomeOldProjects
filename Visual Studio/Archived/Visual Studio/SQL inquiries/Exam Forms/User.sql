--CREATE TABLE [User]
--(
--[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
--[Name] NVARCHAR(MAX) NOT NULL CHECK ([Name] <> N''),
--[Surname] NVARCHAR(MAX) NOT NULL CHECK ([Surname] <> N''),
--[Login] NVARCHAR(MAX) NOT NULL CHECK ([Login] <> N''),
--[Password] NVARCHAR(MAX) NOT NULL CHECK ([Password] <> N''),
--[Discount] INT NOT NULL,
--[Balance] FLOAT not null check ([Balance] >= 0.0) default 0.0,
--[Admin] INT NOT NULL  check ([Admin] >= 0 AND [Admin] <= 1) default 0
--)

--DROP TABLE [User]

--INSERT INTO [User]
--VALUES
--(NEWID(), N'Zod', N'Zoda', N'Zod', N'123456789', 50, 10000, 1)

SELECT * FROM [User]