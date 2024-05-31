SELECT
   B.Name AS [Название],
   B.Pages AS [Кол-во страниц]
FROM
   Books B
WHERE
   B.Pages BETWEEN 500 AND 650
ORDER BY 
   B.Pages