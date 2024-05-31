--CREATE TABLE ChangesInManager
--(
--   [Id] int not null identity(1, 1)  PRIMARY KEY,
--   Date_Exchange DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
--)

--INSERT INTO ChangesInManager
--VALUES
--( CURRENT_TIMESTAMP)

--DROP TABLE ChangesInManager

--CREATE TRIGGER
--    On_Managers_Change 
--ON
--    Managers            
--AFTER                
--    INSERT, DELETE, UPDATE            
--AS
--BEGIN
--    SET NOCOUNT ON

--    UPDATE ChangesInManager SET Date_Exchange = CURRENT_TIMESTAMP WHERE Id = 1
--END


UPDATE Managers SET Surname = 'Орестенко' WHERE Id = '743C93F2-4717-4E81-A093-69903476E176'

SELECT * FROM ChangesInManager