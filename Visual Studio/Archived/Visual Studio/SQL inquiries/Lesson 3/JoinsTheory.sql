/*

-- Объединения / JOIN
-- OUTER JOIN / INNER JOIN

-- OUTER JOIN - Все возможные комбинации, Декартово произведение
-- Наиболее популярный пример игральные карты (см. "Cards")

-- INNER JOIN - Объединяет таблицы по совпадению значений полей
-- JOIN - парный, действует на две таблицы. Результат - одна таблица

*/

-- Вывести ФИО сотрудников и названия отделов, в которых они работают

/*

SELECT
   CONCAT(M.Surname, ' ', M.Name, ' ', M.Secname) AS [Сотрудник],
   D.Name AS [Отдел]
   -- *
FROM
   Managers M
   JOIN Departments D ON M.Id_sec_dep = D.Id -- AND M.Id_sec_dep = D.Id JOIN (INNER) - игнорирует записи, в которых нет совпадения
   

*/

-- Вывести ФИО сотрудников и названия отделов, в которых они работают
-- Если не подрабатывают, поставить "-"
-- LEFT/RIGHT JOIN - объединение с приоритетом

-- LEFT - Всё из левой таблицы (левой от оператора JOIN) + если есть совпадения, то данные из правой таблицы, если нет - NULL
-- В приоритетных объединенияъ популярен оператор NULL-коалесценции
-- COALESCE (arg1, arg2, arg3, ...) - возвращает первый аргумент не равный NULL


/*

SELECT
   CONCAT(M.Surname, ' ', M.Name, ' ', M.Secname) AS [Сотрудник],
   COALESCE (D.Name, N'Есть личная жизнь') AS [Отдел]
   -- *
FROM
   Managers M
   LEFT JOIN Departments D ON M.Id_main_dep = D.Id 

   */

   
--   /*
--SELECT
--   CONCAT(M.Surname, ' ', M.Name, ' ', M.Secname) AS [Сотрудник],
--   COALESCE (MD.Name, N'Есть личная жизнь') AS [Отдел],
--   COALESCE (SD.Name, N'Есть личная жизнь') AS [Подработка]
--   -- *
--FROM
--   Managers M
--   JOIN Departments MD ON M.Id_main_dep = MD.Id 
--   LEFT JOIN Departments SD ON M.Id_sec_dep = SD.Id 
--ORDER BY
--   M.Surname

--   */

-- Вывести информацию о продажах: с названиями товаров и ФИО продавцов

--SELECT TOP 10
--CONCAT(M.Surname, ' ', M.Name, ' ', M.Secname) AS [Сотрудник],
--   P.Name AS [Название продукта],
--   P.Price AS [Цена],
--   S.Cnt AS [Количество],
--   S.Moment AS [Время покупки]
--FROM
--   Sales S
--   JOIN Products P ON S.ID_product = P.Id
--   JOIN Managers M ON S.ID_manager = M.Id
----ORDER BY
--  -- M.Surname

--SELECT TOP 10
--CONCAT(M.Surname, ' ', M.Name, ' ', M.Secname) AS [Сотрудник],
--   D.Name AS [Отдел],
--   P.Name AS [Название продукта],
--   P.Price AS [Цена],
--   S.Cnt AS [Количество],
--   S.Moment AS [Время покупки]
--FROM
--   Sales S
--   JOIN Products P ON S.ID_product = P.Id
--   JOIN Managers M ON S.ID_manager = M.Id
--   JOIN Departments D ON M.Id_main_dep = D.Id
----ORDER BY
--  -- M.Surname


--SELECT TOP 10

--   P.Name AS [Товар],
--   P.Price AS [Цена],
--   S.Cnt AS [Количество],
--   S.Moment AS [Время покупки]
--FROM
--   Sales S
--   JOIN Products P ON S.ID_product = P.Id
--WHERE 
--   CAST (S.Moment AS DATE) > '2020-06-16'
--   AND
--   CAST (S.Moment AS DATE) < DATEADD(MONTH, 1, '2020-06-16')
--ORDER BY
--(S.Cnt * P.Price) DESC,
--S.Moment DESC



SELECT
   CONCAT(M.Surname, ' ', M.Name, ' ', M.Secname) AS [Сотрудник],
    COALESCE (MK.Surname + ' ' + MK.Name + ' ' + MK.Secname, N'Является Боссом')  AS [Босс]
FROM
   Managers M
   LEFT JOIN Managers MK ON M.Id_chief = MK.Id
ORDER BY
   M.Surname
