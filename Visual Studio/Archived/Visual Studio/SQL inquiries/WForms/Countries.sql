--CREATE TABLE Countries 
--(
--	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
--	[Name_Country] NVARCHAR(MAX) NOT NULL CHECK ([Name_Country] <> N''),
--	[Name_Capital] NVARCHAR(MAX) NOT NULL CHECK ([Name_Capital] <> N''),
--	[Quantity_People] FLOAT NOT NULL,
--	[Country_Area] INT NOT NULL,
--	[Name_Part_World] NVARCHAR(MAX) NOT NULL CHECK ([Name_Part_World] <> N''),
--)

--DROP TABLE Countries

--INSERT INTO Countries
--VALUES
--(NEWID(), N'Украина', N'Киев', 44.39, 603628, N'Европа'),
--(NEWID(), N'Франция', N'Париж', 67.06, 643801, N'Европа'),
--(NEWID(), N'Россия', N'Москва', 144.4, 17130000, N'Азия'),
--(NEWID(), N'Казахстан', N'Нур-Султан', 18.51, 2725000, N'Азия'),
--(NEWID(), N'США', N'Вашингтон', 328.2, 9834000, N'Северная Америка'),
--(NEWID(), N'Мексика', N'Мехико', 127.6, 1973000, N'Северная Америка'),
--(NEWID(), N'Бразилия', N'Бразилиа', 211, 8516000, N'Южная Америка'),
--(NEWID(), N'Чили', N'Сантьяго', 18.95, 756102, N'Южная Америка')

SELECT * FROM Countries
