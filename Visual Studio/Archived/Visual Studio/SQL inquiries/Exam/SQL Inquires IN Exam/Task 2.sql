SELECT
   B.Name AS [Название],
   B.Price AS [Цена],
   B.Pages AS [Кол-во страниц]
FROM
   Books B
WHERE
   B.Name LIKE N'А%' OR B.Name LIKE N'З%'
ORDER BY 
   B.Name