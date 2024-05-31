--CREATE TABLE Genre
--(
--[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
--[Name] NVARCHAR(MAX) NOT NULL CHECK ([Name] <> N'')
--)

--INSERT INTO Genre
--VALUES
--(NEwID(), N'Blues'),
--(NEwID(), N'Brass & Military'),
--(NEwID(), N'Childrens'),
--(NEwID(), N'Classical'),
--(NEwID(), N'Electronic'),
--(NEwID(), N'Folk, World, & Country'),
--(NEwID(), N'Funk / Soul'),
--(NEwID(), N'Hip Hop'),
--(NEwID(), N'Jazz'),
--(NEwID(), N'Latin'),
--(NEwID(), N'Non-Music'),
--(NEwID(), N'Pop'),
--(NEwID(), N'Reggae'),
--(NEwID(), N'Rock'),
--(NEwID(), N'Stage & Screen')

SELECT * FROM Genre