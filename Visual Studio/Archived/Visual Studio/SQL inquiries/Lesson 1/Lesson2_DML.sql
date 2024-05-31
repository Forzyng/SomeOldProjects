-- INSERT INTO strings VALUES (5, N'Hi')
-- UPDATE [strings] SET txt = N'Кто прочитал, тот прочитал' WHERE id = 2
-- DELETE FROM strings WHERE txt = 'Hi'
-- DELETE FROM strings WHERE id=2 -- = <> (!=) < <= > >=

/*
 SELECT
      txt AS [Die woorde],
      id [Getalle]
   FROM
   [strings]
   WHERE
   id < 3
   AND id <> 1
   */

 SELECT
      *
   FROM
   [strings]
   WHERE
   id < 3