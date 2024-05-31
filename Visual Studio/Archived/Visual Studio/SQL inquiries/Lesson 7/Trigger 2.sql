-- Этап 2. Триггеры

--CREATE TRIGGER
--   On_Sales_Insert   -- Имя триггера
--ON
--   Sales  -- Таблица-источник события
--AFTER     -- BEFORE (для задачи, типа 2)
--   INSERT -- Тип(ы) события
--AS
--BEGIN
--	SET NOCOUNT ON
--	-- Тело
--	-- В теле триггеров есть специальные таблицы iserted, deleted
--	-- их структура = таблице-источнику, а содержимое - обычно одна строка
--	-- С вносимыми / удаляемыми данными (для события UPDATE заполнены обе таблицы)

--	DECLARE @C INT -- объявляем переменную
--	SET @C = (SELECT SUM(Cnt) FROM inserted) -- сумма внесенных шт.

--	DECLARE @M FLOAT
--	SET @M = (SELECT SUM(Cnt * Price) FROM inserted JOIN Products P ON inserted.ID_product = P.Id)

--	UPDATE Acc_Sales SET Total_Cnt += @C, Total_Sum += @M WHERE Id = 1

--END

--DECLARE @I INT
--SET     @I = 0
--SET     NOCOUNT ON
--WHILE   @I < 90000
--BEGIN
--	SET @I = @I + 1 
--	INSERT INTO Sales 
--		( Id_manager, Id_product, Moment, Cnt)
--	VALUES
--	(
--		( SELECT TOP 1 Id FROM Managers ORDER BY NEWID() ),				-- random ID from Manager
--		( SELECT TOP 1 Id FROM Products ORDER BY NEWID() ),				-- random ID from Products
--		('2021-01-01'													-- base date - first day in year
--			+ DATEADD( day,    ( ABS( CHECKSUM( NEWID() ) ) % 365 ), 0) -- random day - one from 365
--			+ DATEADD( hour,   ( ABS( CHECKSUM( NEWID() ) ) % 24  ), 0) -- random hour - one from 24
--			+ DATEADD( minute, ( ABS( CHECKSUM( NEWID() ) ) % 60  ), 0) -- random minute - one from 60
--		),
--		( ABS( CHECKSUM( NEWID() ) ) % 10 + 1 )							-- random Cnt: 1 to 10
--	)
--END



--CREATE TRIGGER
--   On_Sales_delete   -- Имя триггера
--ON
--   Sales  -- Таблица-источник события
--AFTER     -- BEFORE (для задачи, типа 2)
--   DELETE -- Тип(ы) события
--AS
--BEGIN
--	SET NOCOUNT ON

--	DECLARE @C INT 
--	SET @C = (SELECT SUM(Cnt) FROM deleted) 

--	DECLARE @M FLOAT
--	SET @M = (SELECT SUM(Cnt * Price) FROM deleted JOIN Products P ON deleted.ID_product = P.Id)

--	UPDATE Acc_Sales SET Total_Cnt -= @C, Total_Sum -= @M WHERE Id = 1

--END

--DELETE FROM Sales WHERE Id = (SELECT TOP 1 Id FROM Sales ORDER BY Moment DESC)

--SELECT * FROM Sales WHERE Id = 'b752e3b3-348a-4000-a275-015917d4ffad'
--UPDATE Sales SET Cnt += 10 WHERE Id = 'b752e3b3-348a-4000-a275-015917d4ffad'
-- UPDATE не задействует триггеры
