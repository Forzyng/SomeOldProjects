-- универсальный триггер
--DROP TRIGGER On_Sales_Insert ;
--DROP TRIGGER On_Sales_Delete ;
--DROP TRIGGER On_Sales_Update ;
--DROP TRIGGER On_Sales_Change

--CREATE TRIGGER
--    On_Sales_Change 
--ON
--    Sales            
--AFTER                
--    INSERT, DELETE, UPDATE            
--AS
--BEGIN
--    SET NOCOUNT ON
--    DECLARE @C INT
--    SET @C = COALESCE( ( SELECT SUM(Cnt) FROM inserted ), 0 )
--           - COALESCE( ( SELECT SUM(Cnt) FROM deleted  ), 0 ) 
 
--    DECLARE @S FLOAT
--    SET @S = COALESCE( ( SELECT SUM(Cnt * Price) 
--                FROM inserted I JOIN Products P ON I.ID_product = P.Id ), 0 )
--           - COALESCE( ( SELECT SUM(Cnt * Price) 
--                FROM deleted  D JOIN Products P ON D.ID_product = P.Id ), 0 )
 
--    -- Обновляем данные в аккумуляторе
--    UPDATE Acc_Sales SET Total_Cnt += @C, Total_Sum += @S WHERE Id = 1
--END


--INSERT INTO Sales VALUES (
--	NEWID(),
--	'0017aaae-3e22-462d-9031-4276a9788d51',
--	'64a4df8a-0733-4be9-aaba-c01b4ec3612a', -- price 9.98
--	10,
--	CURRENT_TIMESTAMP
--)

--UPDATE Sales SET Cnt += 10 WHERE Id = 'b752e3b3-348a-4000-a275-015917d4ffad'

--DELETE FROM Sales WHERE Id = (SELECT TOP 1 Id FROM Sales ORDER BY Moment DESC)
