SELECT TOP 1
   B.Name AS [Наибольше страниц в категории]
FROM
   Books B
   JOIN Themes T ON B.ThemesId = T.Id
WHERE
   T.Id = 'f2585221-1aca-4efe-a5e8-c2f4534d1f92'
ORDER BY
   B.Pages DESC