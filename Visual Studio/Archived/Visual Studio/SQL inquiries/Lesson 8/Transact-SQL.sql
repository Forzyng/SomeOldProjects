--CREATE FUNCTION  ManagersCnt (@ident UNIQUEIDENTIFIER)
--RETURNS INT
--BEGIN
--   RETURN
--      (SELECT
--         COUNT(M.Id) AS [COL-VO Id ]
--      FROM
--         Managers M
--         JOIN Departments D ON M.Id_main_dep = D.Id
--      WHERE 
--      D.Id = @ident)
--END

SELECT [dbo].ManagersCnt ('D3C376E4-BCE3-4D85-ABA4-E3CF49612C94') AS [Col-vo];