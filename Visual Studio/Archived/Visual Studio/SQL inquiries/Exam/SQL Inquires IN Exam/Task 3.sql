SELECT
   B.Name AS [Название],
   B.Price AS [Цена],
   S.Quantity AS [Количество],
   T.Name AS [Жанр]
FROM
   Sales S
   LEFT JOIN Books B ON S.BooksId = B.Id
   LEFT JOIN Themes T ON B.ThemesId = T.Id
WHERE 
   B.ThemesId = '7b08197b-c55f-4389-891f-bf12a575dffb'
   AND
   S.Quantity > 30
   