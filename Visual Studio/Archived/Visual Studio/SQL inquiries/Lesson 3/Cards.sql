-- Демонстрация полного объединения - игральные карты

--CREATE TABLE Suits (Name VARCHAR(10));
--CREATE TABLE Faces (Name VARCHAR(10));

--INSERT INTO Suits VALUES('Spades'), ('Clubs'), ('Hearts'), ('Diamonds');
--INSERT INTO Faces VALUES ('6'),('7'),('8'),('9'),('10'),('J'),('Q'),('K'),('A');

SELECT
   CONCAT(F.Name, ' - ', S.Name) AS Card
FROM
   Faces F,   -- FULL OUTER JOIN - просто указываем таблицы через ","
   Suits S
ORDER BY
   NEWID()