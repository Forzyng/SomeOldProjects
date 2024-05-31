SELECT
   B.Name AS [Что],
   Se.SaleDate [Когда],
   Sh.Name AS [Кем],
   Se.Quantity
FROM
   Shops Sh
   JOIN Sales Se ON Sh.Id = Se.ShopsId
   JOIN Books B ON Se.BooksId = B.Id
