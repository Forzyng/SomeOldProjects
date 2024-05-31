--CREATE TABLE #Info
--(
--[Названия] NVARCHAR (50) NOT NULL,
--[Данные] FLOAT NOT NULL
--)

--DROP TABLE #Info


--INSERT INTO #Info
--VALUES
--(N'Количество Авторов', (SELECT COUNT(Authors.Name) FROM Authors)),
--(N'Количество Книг', (SELECT COUNT(Books.Name) FROM Books)),
--(N'Средняя выручка', (SELECT AVG(Sales.Quantity * Sales.Price) FROM Sales)),
--(N'Среднее кол-во страниц', (SELECT AVG(Books.Pages) FROM Books))

SELECT * FROM #Info

