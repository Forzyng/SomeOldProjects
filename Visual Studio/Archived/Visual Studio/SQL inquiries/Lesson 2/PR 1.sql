SELECT 
   CONCAT( M.Surname, ' ', M.Name, ' ', M.Secname) AS Manager
FROM
   Managers M
WHERE
   M.Id_main_dep = '131EF84B-F06E-494B-848F-BB4BC0604266'
   OR 
   M.Id_sec_dep = '131EF84B-F06E-494B-848F-BB4BC0604266'
   ORDER BY 
   M.Surname