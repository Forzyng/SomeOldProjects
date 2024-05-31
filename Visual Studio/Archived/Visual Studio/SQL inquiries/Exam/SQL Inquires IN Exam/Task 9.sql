SELECT
   T.Name AS [Жанр],
   SUM(B.Pages) AS [Количество страниц]
FROM
   Books B 
   LEFT JOIN Themes T ON B.ThemesId = T.Id
GROUP BY 
   T.Name
   