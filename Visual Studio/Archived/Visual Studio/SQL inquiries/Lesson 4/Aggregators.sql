-- Функции агрегирования или агрегаторы
-- Это функции, работающие с множествами, возвращающие одно значение

--SELECT COUNT(*)  AS [Количество товаров] FROM Products; -- Count - счёт
--SELECT COUNT(Surname)  AS [Количество сотрудников] FROM Managers;

--SELECT SUM(Price) AS [Сумма всех товаров] FROM Products; -- Сумма

--SELECT AVG(PRICE) AS [Средняя цена] FROM Products; -- Среднее арифметическое

--SELECT MAX(Price) AS [Максимальная стоимость], MIN(Price) [Минимальная стоимость] FROM Products; -- Экстремумы

--SELECT 
--   COUNT(S.ID)  AS [Продано чеков],
--   SUM(S.Cnt) AS [Продано товаров]
--FROM 
--   Sales S 
--WHERE
--    CAST (S.Moment AS DATE) = '2020-06-17'

SELECT 
   COUNT(S.ID)  AS [Продано чеков],
   SUM(S.Cnt) AS [Продано товаров],
   SUM(P.Price * S.Cnt) AS [Выторг],
   AVG(P.Price * S.Cnt) AS [Средний чек],
   MAX(P.Price * S.Cnt) AS [Максимальный чек],
   MIN(P.Price * S.Cnt) [Минимальный чек]
FROM 
   Sales S 
   LEFT JOIN Products P ON S.ID_product = P.Id
WHERE
   CAST (S.Moment AS DATE) > '2019-12-30'
   AND
   CAST (S.Moment AS DATE) < DATEADD(YEAR, 1, '2020-01-01')
   --CAST (S.Moment AS DATE) = '2020-06-17'
