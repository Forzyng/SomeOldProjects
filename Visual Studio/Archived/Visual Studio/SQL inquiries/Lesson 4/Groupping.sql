-- Групирующие запросы
-- Построение выборок комбинированного типа - смесь значений и множеств

/*
Sales:          Имя             Id

1-1 Болт  2     Болт   2 1-1    1-1 Болт  2
1-2 Гайка 3            1 1-1        Болт  1
1-1 Болт  1     Гайка  1 1-2    1-2 Гайка 3
1-2 Гайка 2            2 1-2        Гайка 2
1-2 Гайка 1            1 1-2        Гайка 1

*/

-- БД не может представить данные в виде "объединенных ячеек"
-- поэтому в группирующих запросах смешиваются поля и агрегаторы

--SELECT 
--   P.Name,   -- Единственное, что идет без агрегатора - это поле группы
--   SUM(S.Cnt) AS TotalCnt, -- Остальные - с агрегаторами
--   MAX(S.Cnt) As MaxInCheck,
--   MIN(S.Cnt) As MinInCheck
--FROM 
--   Sales S 
--   LEFT JOIN Products P ON S.ID_product = P.Id
--WHERE
--   --CAST (S.Moment AS DATE) > '2019-12-30'
--   --AND
--   --CAST (S.Moment AS DATE) < DATEADD(YEAR, 1, '2020-01-01')
--   CAST (S.Moment AS DATE) = '2020-06-17'
--GROUP BY
--   P.Name
--ORDER BY
--   P.Name


-- Поскольку группирование связано с сравнениями и поиском
-- Лучше группировать по индексированным полям (в т.ч. первичный ключ)

--SELECT 
--   MAX(P.Name) AS [Product],   -- Единственное, что идет без агрегатора - это поле группы
--   SUM(S.Cnt) AS TotalCnt, -- Остальные - с агрегаторами
--   MAX(S.Cnt) As MaxInCheck,
--   MIN(S.Cnt) As MinInCheck
--FROM 
--   Sales S 
--   LEFT JOIN Products P ON S.ID_product = P.Id
--WHERE
--   --CAST (S.Moment AS DATE) > '2019-12-30'
--   --AND
--   --CAST (S.Moment AS DATE) < DATEADD(YEAR, 1, '2020-01-01')
--   CAST (S.Moment AS DATE) = '2020-06-17'
--GROUP BY
--   P.Id
--ORDER BY
--   1


--SELECT 
--  COALESCE (MAX(M.Surname) + ' ' +  MAX(M.Name) + ' ' +  MAX(M.Secname), N'Бесполезным был в тот момент')  AS [Manager],
--  SUM(S.Cnt) AS TotalCnt, 
--  MAX(S.Cnt) As MaxInCheck,
--  MIN(S.Cnt) As MinInCheck
--FROM 
--   Sales S 
--   RIGHT JOIN Managers M ON S.ID_manager = M.Id
--WHERE
--   --CAST (S.Moment AS DATE) > '2019-12-30'
--   --AND
--   --CAST (S.Moment AS DATE) < DATEADD(YEAR, 1, '2020-01-01')
--   --CAST (S.Moment AS DATE) = '2020-06-17'

--   S.Moment > '2020-06-17 08:00:00'
--   AND
--   S.Moment < DATEADD(HOUR, 4, '2020-06-17 08:00:00')
--   OR 
--   S.Moment IS NULL
--GROUP BY
--   M.Id
--ORDER BY
--   [Manager]

/*
--SELECT
--   MAX(M.Surname) + ' ' +  MAX(M.Name) + ' ' +  MAX(M.Secname)  AS [Manager],
--   COALESCE (SUM(Tmp.Cnt), '0') AS TotalCnt, 
--   COALESCE (MAX(Tmp.Cnt), '0') AS MaxInCheck,
--   COALESCE (MIN(Tmp.Cnt), '0') AS MinInCheck  
--FROM
--   Managers M
--   LEFT JOIN

--        (SELECT 
--        *  
--        FROM
--        Sales S
--        WHERE
--           S.Moment > '2020-06-17 08:00:00'
--           AND
--           S.Moment < DATEADD(HOUR, 4, '2020-06-17 08:00:00')
--           ) AS Tmp ON M.Id = Tmp.ID_manager
--GROUP BY
--   M.Id
--ORDER BY
--   [Manager]
*/


-- Тот же вариант, но группирование внутри подзапроса
-- "+" группируется таблица из 4х колонок (Sales)
-- в предыдущем из 4+7 (Sales + Managers)
-- объединенная таблица содержит максимум 60 строк (Как у менеджеров),
-- в предыдущем больше (включая дубликаты)

SELECT
  M.Surname + ' ' +  M.Name + ' ' +  M.Secname  AS [Manager],
  Tmp.sumcnt
FROM
   Managers M
   LEFT JOIN

        (SELECT 
        ID_manager,
        SUM(Cnt) AS sumcnt
        FROM
        Sales S
        WHERE
           S.Moment > '2020-06-17 08:00:00'
           AND
           S.Moment < DATEADD(HOUR, 4, '2020-06-17 08:00:00')
           GROUP BY
           ID_manager
           
           ) AS Tmp 
        ON M.Id = Tmp.ID_manager
        ORDER BY
           [Manager]
