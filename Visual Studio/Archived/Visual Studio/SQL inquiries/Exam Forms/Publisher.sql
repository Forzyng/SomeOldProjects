--CREATE TABLE Publisher
--(
--[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
--[Name] NVARCHAR(MAX) NOT NULL CHECK ([Name] <> N'')
--)

--INSERT INTO Publisher
--VALUES
--(NEWID(), N'World Best Records studio'),
--(NEWID(), N'Country & Road'),
--(NEWID(), N'Rec&Order'),
--(NEWID(), N'Light clAb')

SELECT * FROM Publisher