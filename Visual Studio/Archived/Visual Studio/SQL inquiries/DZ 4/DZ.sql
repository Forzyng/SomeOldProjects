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

--DROP FUNCTION ManagersMIN


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

--DROP FUNCTION SummOnDate


--CREATE FUNCTION  SoldProduct (@Nazvamiye NVARCHAR(50))
--RETURNS FLOAT
--BEGIN
--   RETURN
--      (SELECT
--          SUM(S.Cnt * P.Price)
--      FROM
--         Sales S
--         JOIN Products P ON S.ID_product = P.Id
--         JOIN Managers M ON S.ID_manager = M.Id
         
--      WHERE 
--        P.Name = @Nazvamiye
--        )
--END

SELECT [dbo].SoldProduct (N'Сварочный аппарат') AS [Выручка за товар (за всё время)]

--DROP FUNCTION SoldProduct
