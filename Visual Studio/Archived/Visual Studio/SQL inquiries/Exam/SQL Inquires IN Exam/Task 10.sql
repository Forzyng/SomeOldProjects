SELECT
   CONCAT(A.Name,' ', A.Surname) AS [Имя],
   SUM(B.Pages) AS [Количество страниц],
   COUNT(B.Id) AS [Кол-во книг]
FROM
   Books B 
   LEFT JOIN Authors A ON B.AuthorsId = A.Id
GROUP BY 
   CONCAT(A.Name,' ', A.Surname)
ORDER BY
   COUNT(B.Id)

   