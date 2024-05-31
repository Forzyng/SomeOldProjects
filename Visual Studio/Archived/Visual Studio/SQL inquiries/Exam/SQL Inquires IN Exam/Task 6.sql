SELECT
   B.Name AS [Название],
   B.Price AS [Цена],
   B.Pages AS [Кол-во страниц]
FROM
   Books B
WHERE
   --array_length(regexp_split_to_array(B.Name, '\s+'), 1) = 4
    B.Name NOT LIKE '% % % '
ORDER BY 
   B.Name

