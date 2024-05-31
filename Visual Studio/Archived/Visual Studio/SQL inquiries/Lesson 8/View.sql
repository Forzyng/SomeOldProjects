--CREATE VIEW ViewManagers
--AS
--   SELECT
--      M.Surname + ' ' + M.Name + ' ' + M.Secname AS [Manager],
--      D.Name AS Depatment
--   FROM
--      Managers M
--      JOIN Departments D ON M.Id_main_dep = D.Id

--SELECT * FROM ViewManagers

--CREATE VIEW ViewProducts
--AS
--   SELECT
--      P.Id AS [Id],
--      P.Name AS [Name],
--      P.Price AS [Price]
--   FROM
--      Products P

--SELECT * FROM ViewProducts