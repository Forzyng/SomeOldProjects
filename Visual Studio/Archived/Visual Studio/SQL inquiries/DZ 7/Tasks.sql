---- Task 1

--SELECT
--   *
--FROM
--   Teachers T
--   LEFT JOIN Groups G ON T.Name = G.Name


---- Task 2

--SELECT
--   D.Name
--FROM
--   Departments D
--   LEFT JOIN Faculties F ON D.FacultyId = F.Id
--WHERE
--   D.Financing > F.Financing


---- Task 3

--SELECT
--   C.Surname,
--   C.Name,
--   Gr.Name
--FROM 
--   GroupsCurators GC
--   LEFT JOIN Groups Gr ON Gc.GroupId = Gr.Id
--   LEFT JOIN Curators C ON Gc.CuratorId = C.Id


---- Task 4

--SELECT
--   C.Surname,
--   C.Name,
--   Gr.Name AS [Name Group]
--FROM 
--   GroupsCurators GC
--   LEFT JOIN Groups Gr ON Gc.GroupId = Gr.Id
--   LEFT JOIN Curators C ON Gc.CuratorId = C.Id
--WHERE
--   Gr.Name = 'P107'


---- Task 6

--SELECT
--   G.Name AS [Group name],
--   D.Name AS [Department name]
--FROM
--   Groups G
--   JOIN Departments D ON G.DepartmentId = D.Id

---- Task 7

--SELECT
--   T.Name,
--   T.Surname,
--   S.Name AS [Name of Subj]
--FROM
--   Lectures L
--   LEFT JOIN Teachers T ON L.TeacherId = T.Id
--   JOIN Subjects S ON L.SubjectId = S.Id
--WHERE
--   T.Name = 'Adams' AND T.Surname = 'Samantha'

