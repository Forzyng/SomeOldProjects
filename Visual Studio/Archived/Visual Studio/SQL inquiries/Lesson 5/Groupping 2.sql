-- Задание: показать статистику продаж: фио - продано, шт за период
-- 22.06 8:00 - 10:00, по отделу продаж

--SELECT
--  M.Surname + ' ' +  M.Name + ' ' +  M.Secname  AS [Manager],
--  COALESCE (TotalCnt, '0') AS TotalCnt, 
--  COALESCE (MaxInCheck, '0') AS MaxInCheck,
--  COALESCE (MinInCheck, '0')  AS MinInCheck
--  FROM
--  Managers M
--   LEFT JOIN

--        (SELECT 
--        ID_manager,
--        SUM(Cnt) AS TotalCnt,
--        MAX(Cnt)  AS MaxInCheck,
--        MIN(Cnt)  AS MinInCheck
--        FROM
--        Sales S
--        WHERE
--           S.Moment > '2020-06-17 08:00:00'
--           AND
--           S.Moment < DATEADD(HOUR, 2, '2020-06-17 08:00:00')
           
           
--           GROUP BY
--           ID_manager
           
--           ) AS Tmp 
--        ON M.Id = Tmp.ID_manager
--        WHERE
--        M.Id_main_dep = '415B36D9-2D82-4A92-A313-48312F8E18C6'
--        OR
--        M.Id_sec_dep = '415B36D9-2D82-4A92-A313-48312F8E18C6'
--        ORDER BY
--           [Manager]




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
--           S.Moment < DATEADD(HOUR, 2, '2020-06-17 08:00:00')
--           ) AS Tmp ON M.Id = Tmp.ID_manager
--WHERE
--   M.Id_main_dep = '415B36D9-2D82-4A92-A313-48312F8E18C6'
--   OR
--   M.Id_sec_dep = '415B36D9-2D82-4A92-A313-48312F8E18C6'
--GROUP BY
--   M.Id
--ORDER BY
--   [Manager]





--SELECT
--SaleDep.Manager AS [Manager],
--COALESCE (TotalCnt, '0') AS TotalCnt, 
--COALESCE (MaxInCheck, '0') AS MaxInCheck,
--COALESCE (MinInCheck, '0')  AS MinInCheck
--FROM
--        (SELECT 
--        ID_manager,
--        SUM(Cnt) AS TotalCnt,
--        MAX(Cnt)  AS MaxInCheck,
--        MIN(Cnt)  AS MinInCheck
--        FROM
--        Sales S
--        WHERE
--           S.Moment > '2020-06-17 08:00:00'
--           AND
--           S.Moment < DATEADD(HOUR, 2, '2020-06-17 08:00:00')
           
           
--           GROUP BY
--           ID_manager
           
--           ) AS Stat
--           RIGHT JOIN
--           (SELECT 
--           M.Id,
--           M.Surname + ' ' +  M.Name + ' ' +  M.Secname  AS [Manager]
--        FROM
--        Managers M
--        WHERE
--        M.Id_main_dep = '415B36D9-2D82-4A92-A313-48312F8E18C6'   
--        OR   
--        M.Id_sec_dep = '415B36D9-2D82-4A92-A313-48312F8E18C6'   
      
--           ) AS SaleDep 
--           ON Stat.ID_manager = SaleDep.ID
--           ORDER BY
--           [Manager]



SELECT
  M.Surname + ' ' +  M.Name + ' ' +  M.Secname  AS [Manager],
  COALESCE (TotalCnt, '0') AS TotalCnt, 
  COALESCE (MaxInCheck, '0') AS MaxInCheck,
  COALESCE (MinInCheck, '0')  AS MinInCheck
  FROM
  Managers M
   LEFT JOIN

        (SELECT 
        ID_manager,
        SUM(Cnt) AS TotalCnt,
        MAX(Cnt)  AS MaxInCheck,
        MIN(Cnt)  AS MinInCheck
        FROM
        Sales S
        WHERE
           S.Moment > '2020-06-22 08:00:00'
           AND
           S.Moment < DATEADD(HOUR, 2, '2020-06-22 08:00:00')
           
           
           GROUP BY
           ID_manager
           
           ) AS Tmp 
        ON M.Id = Tmp.ID_manager
        WHERE
        M.Id_main_dep = 'D2469412-0E4B-46F7-80EC-8C522364D099'
        OR
        M.Id_sec_dep = 'D2469412-0E4B-46F7-80EC-8C522364D099'
        ORDER BY
           [Manager]




SELECT
   MAX(M.Surname) + ' ' +  MAX(M.Name) + ' ' +  MAX(M.Secname)  AS [Manager],
   COALESCE (SUM(Tmp.Cnt), '0') AS TotalCnt, 
   COALESCE (MAX(Tmp.Cnt), '0') AS MaxInCheck,
   COALESCE (MIN(Tmp.Cnt), '0') AS MinInCheck  
FROM
   Managers M
   LEFT JOIN

        (SELECT 
        *  
        FROM
        Sales S
        WHERE
           S.Moment > '2020-06-22 08:00:00'
           AND
           S.Moment < DATEADD(HOUR, 2, '2020-06-22 08:00:00')
           ) AS Tmp ON M.Id = Tmp.ID_manager
WHERE
   M.Id_main_dep = 'D2469412-0E4B-46F7-80EC-8C522364D099'
   OR
   M.Id_sec_dep = 'D2469412-0E4B-46F7-80EC-8C522364D099'
GROUP BY
   M.Id
ORDER BY
   [Manager]









SELECT
SaleDep.Manager AS [Manager],
COALESCE (TotalCnt, '0') AS TotalCnt, 
COALESCE (MaxInCheck, '0') AS MaxInCheck,
COALESCE (MinInCheck, '0')  AS MinInCheck
FROM
        (SELECT 
        ID_manager,
        SUM(Cnt) AS TotalCnt,
        MAX(Cnt)  AS MaxInCheck,
        MIN(Cnt)  AS MinInCheck
        FROM
        Sales S
        WHERE
           S.Moment > '2020-06-22 08:00:00'
           AND
           S.Moment < DATEADD(HOUR, 2, '2020-06-22 08:00:00')
           
           
           GROUP BY
           ID_manager
           
           ) AS Stat
           RIGHT JOIN
           (SELECT 
           M.Id,
           M.Surname + ' ' +  M.Name + ' ' +  M.Secname  AS [Manager]
        FROM
        Managers M
        WHERE
        M.Id_main_dep = 'D2469412-0E4B-46F7-80EC-8C522364D099'   
        OR   
        M.Id_sec_dep = 'D2469412-0E4B-46F7-80EC-8C522364D099'   
      
           ) AS SaleDep 
           ON Stat.ID_manager = SaleDep.ID
           ORDER BY
           [Manager]
