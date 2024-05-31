--CREATE TABLE [Type_Product]
--(
--[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
--[Name] NVARCHAR(MAX) NOT NULL CHECK ([Name] <> N'')
--)


--INSERT INTO [Type_Product]
--VALUES
--(NEWID(), N'Вода'),
--(NEWID(), N'Мясо и продукция из него'),
--(NEWID(), N'Плодоовощные товары'),
--(NEWID(), N'Вкусовые товары'),
--(NEWID(), N'Пищевые жиры'),
--(NEWID(), N'Молочные продукты'),
--(NEWID(), N'Крахмал, сахар, мед и кондитерские товары'),
--(NEWID(), N'Зерно-мучные товары'),
--(NEWID(), N'Рыба и рыбные продукты'),
--(NEWID(), N'Яйца и продукция из них')

SELECT * FROM Type_Product