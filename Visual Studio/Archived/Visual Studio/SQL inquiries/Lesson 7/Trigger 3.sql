-- UPDATE, Универсальный триггер

--CREATE TRIGGER
--   On_Sales_Update  
--ON
--   Sales  
--AFTER     
--   UPDATE 
--AS
--BEGIN
--	SET NOCOUNT ON
	
--	DECLARE @C INT 
--	SET @C = (SELECT SUM(Cnt) FROM inserted) - (SELECT SUM(Cnt) FROM deleted) 

--	DECLARE @M FLOAT
--	SET @M = (SELECT SUM(Cnt * Price) FROM inserted JOIN Products P ON inserted.ID_product = P.Id) -
--	(SELECT SUM(Cnt * Price) FROM deleted JOIN Products P ON deleted.ID_product = P.Id)

--	UPDATE Acc_Sales SET Total_Cnt += @C, Total_Sum += @M WHERE Id = 1

--END

--UPDATE Sales SET Cnt += 10 WHERE Id = 'b752e3b3-348a-4000-a275-015917d4ffad'