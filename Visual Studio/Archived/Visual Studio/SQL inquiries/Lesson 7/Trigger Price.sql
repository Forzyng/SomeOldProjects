

--CREATE TABLE Price_Fix_Moment
--(
--    Id INT PRIMARY KEY,
--    Moment DATETIME,
--)
--INSERT INTO Price_Fix_Moment VALUES
--(1, CURRENT_TIMESTAMP)

--DROP TRIGGER On_Price_Change
--CREATE TRIGGER
--    On_Price_Change 
--ON
--    Products            
--AFTER                
--    INSERT, DELETE, UPDATE            
--AS
--BEGIN
--    SET NOCOUNT ON

--    UPDATE Price_Fix_Moment SET Moment = CURRENT_TIMESTAMP WHERE Id = 1
--END

--UPDATE Products SET Price = 10 WHERE Id = 'DA1E17BB-A90D-4C79-B801-5462FB070F57'

--INSERT INTO Products VALUES (
--	NEWID(), N'Шуруп 50мм', 11.50	
--)

--INSERT INTO Products
--	( Id, Name,	Price	)
--VALUES
--    ( NEWID(), N'Шуруп 50мм',			11.50	)

--DELETE FROM Products WHERE Id = 'e50567cd-32d0-42d0-bf46-a810c4607b08'
