-- Ограничения в группирующих вопросах

--SELECT
--   MAX(P.Name) AS [Product],
--   SUM (S.Cnt) AS [Col-vo],
--   SUM(P.Price) AS [Price]
--FROM
--   Sales S
 
--   JOIN Products P ON S.ID_product = P.Id
--WHERE -- Условия на исходные данные
--   S.Moment > '2020-06-23 00:00:00'
--   AND
--   S.Moment < DATEADD(DAY, 1, '2020-06-23 00:00:00')
  
--GROUP BY
--   P.Id
--HAVING -- Условия на агрегированые или груповые
--   SUM (S.Cnt) > 60
--ORDER BY
--   2



--SELECT
--   MAX(M.Surname) + ' ' +  MAX(M.Name) + ' ' +  MAX(M.Secname)  AS [Manager],
--   MAX(P.Name) AS [Product],
--   SUM (S.Cnt) AS [Col-vo],
--   SUM(S.Cnt * P.Price) AS [Price]
--FROM
--   Sales S
--   JOIN Products P ON S.ID_product = P.Id
--   JOIN Managers M ON S.ID_manager = M.Id
--   JOIN Departments ON M.Id_main_dep = D.Id
--WHERE -- Условия на исходные данные
--   S.Moment > '2020-06-23 00:00:00'
--   AND
--   S.Moment < DATEADD(DAY, 1, '2020-06-23 00:00:00')
  
--GROUP BY
--   P.Id
--HAVING -- Условия на агрегированые или груповые
--   SUM(S.Cnt * P.Price) < 1000
--ORDER BY
--   4





-- Вывести отделы, которые за 23.06 наторговали меньше, чем на 50000 грн
SELECT
   D.Name,
   Stat.Money
FROM
   ( SELECT
      M.Id_main_dep,
      SUM(S.Cnt) AS [Sales, pcs],
      SUM(S.Cnt * P.Price) AS [Money]
   FROM
      Sales S
      JOIN Products P ON S.ID_product = P.Id
      JOIN Managers M ON S.ID_manager = M.Id
   WHERE -- условия на исходные данные
      S.Moment >= '2020-06-23'
      AND
      S.Moment < '2020-06-24'
   GROUP BY
      M.Id_main_dep
   HAVING -- условия на агрегированные данные
      SUM(S.Cnt * P.Price) < 50000
   ) AS Stat
   JOIN Departments D ON D.Id = Stat.Id_main_dep
ORDER BY
   1