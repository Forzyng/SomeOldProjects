SELECT

   T.Name,
   AVG(B.Pages) AS [Среднее количество книг]
FROM
   Books B
   JOIN Themes T ON B.ThemesId = T.Id
WHERE
   B.Pages IN
   (
   SELECT
      B.Pages
   FROM
      Books B
    GROUP BY
       B.Pages 
    HAVING AVG(B.Pages) <= 400
   )
 GROUP BY
    T.Name