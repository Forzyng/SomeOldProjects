SELECT TOP 1
   Sh.Name
FROM
   Sales S
   JOIN Shops Sh on S.ShopsId = Sh.Id
ORDER BY
   S.Quantity * S.Price