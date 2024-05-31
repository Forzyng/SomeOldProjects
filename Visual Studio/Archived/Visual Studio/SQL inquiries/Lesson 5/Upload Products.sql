UPDATE Products 
SET Id_manager = (SELECT TOP 1 Id FROM Managers ORDER BY NEWID())