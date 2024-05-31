--SELECT TOP 3
--CONCAT(P.Name, ' - ', P.Price, ' hrn') AS Product
--FROM 
--   Products AS P
--   ORDER BY 
--   P.Price DESC

SELECT TOP 3
CONCAT(P.Name, ' - ', P.Price, ' hrn') AS Product
FROM 
   Products AS P
   WHERE
   P.Price >= 300
   ORDER BY 
   P.Price 