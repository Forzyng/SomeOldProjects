--CREATE FUNCTION  Hello_Name (@Name NVARCHAR(50))
--RETURNS NVARCHAR(50)
--BEGIN
--   RETURN
--      (SELECT
--         CONCAT(N'Hello, ', @Name, '!!!'))
      
--END

--SELECT [dbo].Hello_Name ('Zod') AS [Name]



--CREATE FUNCTION  Get_Minutes ()
--RETURNS NVARCHAR(50)
--BEGIN
--   RETURN
--      (SELECT
--            CONCAT(N'There is ', DATEPART ( minute , getdate() ), ' minutes'))
      
--END

--SELECT [dbo].Get_Minutes() AS [Current Minutes]
      

--CREATE FUNCTION  Get_Year ()
--RETURNS NVARCHAR(50)
--BEGIN
--   RETURN
--      (SELECT
--            CONCAT(N'There is ', DATEPART ( YEAR , getdate() ), ' Year'))
      
--END


--SELECT [dbo].Get_Year() AS [Current Year]

--CREATE FUNCTION  Get_Year ()
--RETURNS NVARCHAR(50)
--BEGIN
--   RETURN
--      (SELECT
--            CONCAT(N'There is ', DATEPART ( YEAR , getdate() ), ' Year'))
      
--END


--SELECT [dbo].Get_Year() AS [Current Year]


--ALTER FUNCTION  Get_Years_Chetnoe_Ne (@year DATE)
--RETURNS NVARCHAR(50)
--BEGIN
--   RETURN
--      (SELECT
--          case DATEPART ( YEAR , @year ) % 2 when 0 then N'Четное' else N'Нечетное' end
--           )
      
--END

--SELECT [dbo].Get_Years_Chetnoe_Ne('2020') AS [Четное или нет]


--CREATE FUNCTION  ManagersMIN (@familya NVARCHAR(50), @imya NVARCHAR(50), @SecName  NVARCHAR(50))
--RETURNS FLOAT
--BEGIN
--   RETURN
--      (SELECT
--         MIN(S.Cnt * P.Price)
--      FROM
--         Sales S
--         JOIN Products P ON S.ID_product = P.Id
--         JOIN Managers M ON S.ID_manager = M.Id
         
--      WHERE 
--        M.Surname = @familya
--        AND
--        M.Name = @imya
--        AND
--        M.Secname = @SecName
--        )
--END

--SELECT [dbo].ManagersMIN( N'Никитин', N'Станислав', N'Брониславович') AS [Минимальный чек];


--CREATE FUNCTION  SummOnDate (@Date DATE)
--RETURNS FLOAT
--BEGIN
--   RETURN
--      (SELECT
--         SUM(S.Cnt * P.Price)
--      FROM
--         Sales S
--         JOIN Products P ON S.ID_product = P.Id
--         JOIN Managers M ON S.ID_manager = M.Id
         
--      WHERE 
--        CAST(S.Moment AS DATE) = @Date
--        )
--END

--SELECT [dbo].SummOnDate ('2020-06-30') AS [Выручка за дату]



--CREATE FUNCTION  MaxSumEver ()
--RETURNS DATE
--BEGIN
--   RETURN
--      ( SELECT TOP 1 
--         CAST(S.Moment AS DATE) AS [Date]
--      FROM
--         Sales S
--         JOIN Products P ON S.ID_product = P.Id
--      GROUP BY 
--         CAST(S.Moment AS DATE)
--      ORDER BY
--         SUM(P.Price * S.Cnt) DESC
--        )
--END


--SELECT [dbo].MaxSumEver () AS [Дата максимально чека]

     
      
--      INSERT INTO Managers 
--	( Id, Surname, Name, Secname, Id_main_dep, Id_sec_dep, Id_chief )
--VALUES 
--	( NEWID(),  N'Носков',	N'Артём',		N'Евгенович',		'D2469412-0E4B-46F7-80EC-8C522364D099',		null,										'FEA65EE4-A8A0-425B-8F11-3896C1E2197E'	),
--    ( NEWID(),  N'Носков',	N'Максим',		N'Юрьевич',		'D2469412-0E4B-46F7-80EC-8C522364D099',		null,										'7A88B1B9-0216-4259-8BA6-C123ABB3C6A8'			)

--   INSERT INTO Managers 
--	( Id, Surname, Name, Secname, Id_main_dep, Id_sec_dep, Id_chief )
--VALUES 
--	( NEWID(),  N'Соболев',	N'Андрей',		N'Тортович',		'D3C376E4-BCE3-4D85-ABA4-E3CF49612C94',		null,										'521C07BE-6FBD-411F-BCCB-93E2672BD50E'	)








--CREATE FUNCTION Get_Surname(@Surname NVARCHAR(50))
--RETURNS @Info_With_Same_Surnames TABLE
--(
--    Id			UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
--	Surname		NVARCHAR(50) NOT NULL,
--	Name		NVARCHAR(50) NOT NULL,
--	Secname		NVARCHAR(50) NOT NULL,
--	Id_main_dep UNIQUEIDENTIFIER NOT NULL ,
--	Id_sec_dep	UNIQUEIDENTIFIER,
--	Id_chief	UNIQUEIDENTIFIER
--)
--AS
--BEGIN
--    INSERT INTO @Info_With_Same_Surnames 
--	( Id, Surname, Name, Secname, Id_main_dep, Id_sec_dep, Id_chief )
-- SELECT
-- *
-- FROM
-- Managers M
-- WHERE
-- M.Surname = @Surname
-- ORDER BY M.Name
-- RETURN
-- END

--SELECT [dbo].Get_Surname(N'Носков') 
--DROP FUNCTION Get_Surname




--SELECT
--    M.Id AS [ID],
--    M.Surname + ' ' + M.Name + ' ' + M.Secname AS [Manager],
--     D.Name AS [Main Work],
--    COALESCE(D2.Name, 'No second work') AS [Second Work],
--    COALESCE( M2.Surname + ' ' + M2.Name + ' ' + M2.Secname, 'Is Boss') AS [Boss]
   
-- FROM
--    Managers M
--    LEFT JOIN Departments D ON M.Id_main_dep = D.Id 
--    LEFT JOIN Departments D2 ON M.Id_sec_dep = D2.Id 
--    LEFT JOIN Managers M2 ON M.Id_chief = M2.Id
-- WHERE
--    M.Surname IN
--    (
--       SELECT
--          M.Surname
--       FROM
--          Managers M
--       GROUP BY
--          M.Surname
--       HAVING 
--          COUNT(M.Surname) > 1)


--CREATE FUNCTION Get_Surname ()
--RETURNS TABLE
--AS RETURN(
--SELECT
--    M.Id AS [ID],
--    M.Surname + ' ' + M.Name + ' ' + M.Secname AS [Manager],
--     D.Name AS [Main Work],
--    COALESCE(D2.Name, 'No second work') AS [Second Work],
--    COALESCE( M2.Surname + ' ' + M2.Name + ' ' + M2.Secname, 'Is Boss') AS [Boss]
   
-- FROM
--    Managers M
--    LEFT JOIN Departments D ON M.Id_main_dep = D.Id 
--    LEFT JOIN Departments D2 ON M.Id_sec_dep = D2.Id 
--    LEFT JOIN Managers M2 ON M.Id_chief = M2.Id
-- WHERE
--    M.Surname IN
--    (
--       SELECT
--          M.Surname
--       FROM
--          Managers M
--       GROUP BY
--          M.Surname
--       HAVING 
--          COUNT(M.Surname) > 1)
--     )


 
 
 SELECT * FROM [dbo].Get_Surname() 



--DROP FUNCTION Get_Surname
