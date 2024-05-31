-- SELECT NEWID(), NEWID() -- Генератор UUID
/*
CREATE TABLE Users
(
    Id         UNIQUEIDENTIFIER PRIMARY KEY,
    [Name]     NVARCHAR(MAX),
    [Login]    VARCHAR(MAX),
    [Password] CHAR(32), -- Нельзя хранить в открытом виде в БД 
    -- SELECT CONVERT(VARCHAR(32), HashBytes('MD5', 'email@dot.com'), 2)
    [Email]    VARCHAR(MAX)
)
*/

/*
INSERT INTO Users VALUES
(NEWID(), N'Здесь Ваша Реклама', 'Reklama', CONVERT(VARCHAR(32), HashBytes('MD5', '123'), 2), 'ZdesMoglaBitVashaReklama@i.ua'),
(NEWID(), N'Ricardo', 'Tanzor', CONVERT(VARCHAR(32), HashBytes('MD5', '321'), 2), 'RicardoTanzor@i.ua')
*/





--ALTER TABLE 
--    Users
--ADD 
--    BirthDate  DATE
   

    --ALTER TABLE 
    --Users
    --DROP COLUMN
    --BirthDate 


   --UPDATE Users SET BirthDate = '2021-06-10' WHERE Login = 'Reklama'
   --UPDATE Users SET BirthDate = '1998-03-11' WHERE Login = 'Tanzor'
   --UPDATE Users SET BirthDate = '2024-08-10' WHERE Login = 'Krytoi'


--   INSERT INTO Users VALUES
--(NEWID(), N'Noviy Chelovek', 'Krytoi', CONVERT(VARCHAR(32), HashBytes('MD5', '789'), 2), 'SamiyNoviyIKrutoy@i.ua', '2024-08-10')


SELECT * FROM Users
--SELECT * FROM Users WHERE BirthDate IS NOT NULL
