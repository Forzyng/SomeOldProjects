SELECT
CONCAT(B.Name, ' | ', T.Name, ' | ', A.Surname + ' ' + A.Name ) AS [ALL],
   B.Price AS [Цена],
   S.Quantity AS [Количество]
   
FROM
   Sales S
   LEFT JOIN Books B ON S.BooksId = B.Id
   LEFT JOIN Authors A ON B.AuthorsId = A.Id
   JOIN Themes T ON B.ThemesId = T.Id
WHERE 
   B.Price / B.Pages < 65
   