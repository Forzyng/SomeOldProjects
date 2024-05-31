-- Хранимые процедуры (Stored procedures)
-- "скомпилированные" именованные запросы, хранящиеся на стороне СУБД
-- "+" выполняется быстрее
--     скрывает детали(имена полей и т.п.) - более безопасный
-- "-" занимает место в БД
--     требует пересоздания при изменении имен и т.п.
/*
CREATE PROCEDURE  -- можно сокращенно PROC
	Get_Products_Names
AS
	SELECT [Name] FROM Products
*/

-- EXECUTE Get_Products_Names
-- EXEC Get_Products_Names
-- Get_Products_Names  -- вне стандарта

-- Параметры / аргументы - Аналог Get_Dailly_Stat (Date D) {...}
--CREATE PROC
--	Get_Daily_Stat
--	@D DATE
--	AS
--BEGIN
--   SELECT
--      @D AS  [DATE],
--      SUM(S.Cnt) AS Pcs,
--	  SUM(S.Cnt * P.Price) AS Hrn
--   FROM
--      Sales S
--	  JOIN Products P ON S.ID_product = P.Id
--	WHERE
--	   CAST (S.Moment AS DATE) = @D
--END

--DROP PROC Get_Daily_Stat

--EXEC Get_Daily_Stat '2020-06-23'

--DROP PROC Get_Dep_Min

--CREATE PROC
--	Get_Dep_Min
--	@D DATE,
--    @M INT
--	AS
--BEGIN
-- SET NOCOUNT ON
--SELECT
--   D.Name,
--   Stat.Money,
--   @D AS [Date]
--FROM
--   ( SELECT
--      M.Id_main_dep,
--      SUM(S.Cnt) AS [Sales, pcs],
--      SUM(S.Cnt * P.Price) AS [Money]
--   FROM
--      Sales S
--      JOIN Products P ON S.ID_product = P.Id
--      JOIN Managers M ON S.ID_manager = M.Id
--   WHERE -- условия на исходные данные
      
--CAST(S.Moment AS DATE) = @D


--   GROUP BY
--      M.Id_main_dep
--   HAVING -- условия на агрегированные данные
--      SUM(S.Cnt * P.Price) < @M
--   ) AS Stat
--   JOIN Departments D ON D.Id = Stat.Id_main_dep
--ORDER BY
--   1
--   END


--EXEC Get_Dep_Min '2020-06-23', 100000


-- Задание: процедура Daily_Worst - принимает дату,
-- выводит 3 наихудших товара по итогам продаж (грн) за "дату"

--DROP PROC Get_Top3_Worst_Prod

--CREATE PROC
--	Get_Top3_Worst_Prod
--	@D DATE
--	AS
--BEGIN
-- SET NOCOUNT ON
--SELECT TOP 3
--   @D AS [Date],
--      MAX(P.Name) AS [Name] ,
--      SUM(S.Cnt) AS [Col-Vo],
--      SUM(S.Cnt * P.Price) AS [Money]
--   FROM
--      Sales S
--      JOIN Products P ON S.ID_product = P.Id
--   WHERE -- условия на исходные данные
      
--CAST(S.Moment AS DATE) = @D

--   GROUP BY
--      P.Id
      
--ORDER BY
--   [Money]
--   END

--EXEC Get_Top3_Worst_Prod '2020-06-23'



-- Задание: процедура Daily_Worst_N - принимает дату и кол-во,
-- выводит "кол-во" наихудших товара по итогам продаж (грн) за "дату"

--DROP PROC Get_Top3_Worst_Prod_With_Colvo

--CREATE PROC
--	Get_Top3_Worst_Prod_With_Colvo
--	@D DATE,
--    @COLVO INT
--	AS
--BEGIN
-- SET NOCOUNT ON
--SELECT TOP 3
--   @D AS [Date],
--      MAX(P.Name) AS [Name] ,
--      SUM(S.Cnt) AS [Col-Vo],
--      SUM(S.Cnt * P.Price) AS [Money]
--   FROM
--      Sales S
--      JOIN Products P ON S.ID_product = P.Id
--   WHERE -- условия на исходные данные
      
--CAST(S.Moment AS DATE) = @D

--   GROUP BY
--      P.Id
--HAVING
-- SUM(S.Cnt) < @COLVO
--ORDER BY
--   [Col-Vo]
--   END

EXEC Get_Top3_Worst_Prod_With_Colvo'2020-06-23', 50
