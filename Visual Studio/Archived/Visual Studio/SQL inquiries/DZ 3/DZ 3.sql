-- Задание: процедура Daily_Best_Man - принимает дату, 
--  выводит 3 наилучших сотрудника по итогам продаж (грн) за "дату"

-- Задание: процедура Daily_Best_Man_N - принимает дату и кол-во, 
--  выводит "кол-во" наилучших сотрудников по итогам продаж (грн) за "дату"

--DROP PROC Get_Manager_Worst

--CREATE PROC
--	Daily_Best_Man
--	@D DATE
--	AS
--BEGIN
--   SET NOCOUNT ON
--SELECT TOP 3
--      MAX(M.Surname) + ' ' +  MAX(M.Name) + ' ' +  MAX(M.Secname)  AS [Manager],
--      SUM(S.Cnt) AS [Sales],
--      SUM(S.Cnt * P.Price) AS [Money]
--   FROM
--      Sales S
--      JOIN Products P ON S.ID_product = P.Id
--      JOIN Managers M ON S.ID_manager = M.Id
--   WHERE -- условия на исходные данные
--      CAST(S.Moment AS DATE) = @D
--   GROUP BY
--      M.Id
--   ORDER BY
--      3 DESC
--END

--EXEC Daily_Best_Man '2020-06-23'

--DROP PROC Daily_Best_Man_N

--CREATE PROC
--	Daily_Best_Man_N
--	@D DATE,
--    @COLVO INT
--	AS
--BEGIN
--   SET NOCOUNT ON
--SELECT TOP (@COLVO)
--      MAX(M.Surname) + ' ' +  MAX(M.Name) + ' ' +  MAX(M.Secname)  AS [Manager],
--      SUM(S.Cnt) AS [Sales],
--      SUM(S.Cnt * P.Price) AS [Money]
--   FROM
--      Sales S
--      JOIN Products P ON S.ID_product = P.Id
--      JOIN Managers M ON S.ID_manager = M.Id
--   WHERE -- условия на исходные данные
--      CAST(S.Moment AS DATE) = @D
--   GROUP BY
--      M.Id
--   ORDER BY
--      3 DESC
--END

--EXEC Daily_Best_Man_N '2020-06-23', 5