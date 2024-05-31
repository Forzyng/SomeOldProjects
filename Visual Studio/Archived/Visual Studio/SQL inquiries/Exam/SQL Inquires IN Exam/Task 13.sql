SELECT
   MAX(T.Name) AS [Жанр],
   SUM(B.Pages) AS [Количество страниц]
FROM
   Books B
   JOIN Themes T ON B.ThemesId = T.Id
WHERE
   B.Pages > 400
   AND
   B.ThemesId = '4a550d3b-d1f2-40ef-ae4e-963612c6713a' OR B.ThemesId = '5f9e1269-4354-4d85-95df-a2ca08e77f0c' OR B.ThemesId = '5ad90d2b-9848-42bb-a476-b701a888f40c'
GROUP BY 
   T.Name