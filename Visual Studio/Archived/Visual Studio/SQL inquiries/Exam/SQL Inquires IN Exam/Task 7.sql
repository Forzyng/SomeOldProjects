SELECT
CONCAT(BOOK.Name, ' | ', THEME.Name, ' | ', AUTHOR.Surname + ' ' + AUTHOR.Name ) AS [All],
   BOOK.Price AS [Цена],
   S.Quantity AS [Количество]
   
FROM
   Sales S
   LEFT JOIN
              (
              SELECT
              *
              FROM
              Shops Sh
              WHERE
              Sh.Id NOT LIKE 'fea65ee4-a8a0-425b-8f11-3896c1e2197e' AND Sh.Id NOT LIKE '23d52416-d994-4564-a106-1fdf5fecef25'
              ) AS SHOP ON S.ShopsId = SHOP.Id
   JOIN
             (SELECT
             *
             FROM
             Books B 
             WHERE 
              B.Name NOT LIKE N'%А%' OR B.Name NOT LIKE N'%a%'
          ) AS BOOK ON S.BooksId = BOOK.Id

   LEFT JOIN 
   (
              SELECT
              *
              FROM
              Authors A 
              WHERE
              A.Name NOT LIKE 'Гвинет' AND A.Surname NOT LIKE 'Джонс'
              ) AS AUTHOR ON BOOK.AuthorsId = AUTHOR.Id
   JOIN 
   (
                  SELECT 
                  * 
                  FROM
                  Themes T
                  WHERE T.Id NOT LIKE '7b08197b-c55f-4389-891f-bf12a575dffb'
                  ) AS THEME ON BOOK.ThemesId = THEME.Id
WHERE 
    BOOK.Price < 20 AND  BOOK.Price > 10 
    AND S.Quantity > 8
