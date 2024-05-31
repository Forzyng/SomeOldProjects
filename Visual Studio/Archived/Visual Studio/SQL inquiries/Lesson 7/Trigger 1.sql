-- Триггеры
-- В СУБД триггеры - разновидность хранимых процедур, вызываемых автоматически
-- при некоторых событиях (DDL, DML, ...) -- изменениях в "хранилище данных"

-- Зачем?
-- 1. Уведомление (администратора)
-- 2. Проверка, если недостаточно (или не реализовано) CHECK / CONSTRAINT
-- Статистика (аккумуляторы)

-- Для данных, которые постоянно  добавляются, часто нужно знать "итого"
-- при этом, расчитывая суммы, мы постоянно складываем все предыдущие
-- значения. Хотя можно было бы только добавлять новые данные к уже
-- накопленному значению

-- Этап 1ю Создание таблиц и заполнение текущей статистикой



--CREATE TABLE Acc_Sales
--(
--    Id INT PRIMARY KEY,
--    Total_Cnt INT,
--    Total_Sum FLOAT
--)

TRUNCATE TABLE Acc_Sales;

--DROP TABLE Acc_Sales;
INSERT INTO Acc_Sales VALUES(1,
( SELECT SUM(Cnt) FROM Sales),
(SELECT SUM(Sales.Cnt * Products.Price) FROM Sales JOIN Products ON Sales.ID_product = Products.Id))

-- Этап 2 (См. trigger 2)