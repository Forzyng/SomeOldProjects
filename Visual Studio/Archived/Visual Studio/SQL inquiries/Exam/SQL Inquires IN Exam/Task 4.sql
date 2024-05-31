SELECT 
   B.Name AS [Название],
   B.Price AS [Цена],
   B.Pages AS [Кол-во страниц]
FROM
   Books B
WHERE
   B.Name LIKE N'%Microsoft%' AND B.Name NOT LIKE N'%Windows%'
ORDER BY 
   B.Name