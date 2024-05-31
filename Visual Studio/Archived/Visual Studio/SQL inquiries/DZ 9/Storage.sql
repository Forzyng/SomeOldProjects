--CREATE TABLE [Storage]
--(
--[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
--[Id_of_product] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID() REFERENCES [Product]([Id]),
--[Supplier_Id] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID() REFERENCES [Supplier]([Id]),
--[Quantity] INT NOT NULL ,
--[Price] FLOAT NOT NULL,
--[Date_incoming] DATETIME  DEFAULT (getdate()) NULL,
--)


--DROP TABLE Storage
--DROP TABLE Supplier
--DROP TABLE Product


--DECLARE @I INT
--SET     @I = 0
--SET     NOCOUNT ON
--WHILE   @I < 9000
--BEGIN
--	SET @I = @I + 1 
--	INSERT INTO Storage 
--		( Id, Id_of_product, Supplier_Id, Quantity, Price, Date_incoming)
--	VALUES
--	(
--	NEWID(),
				
--				(SELECT TOP 1 P.Id  FROM Product P ORDER BY NEWID()) ,	
--			(SELECT TOP 1 S.Id  FROM Supplier S ORDER BY NEWID()) ,
--			( ABS( CHECKSUM( NEWID() ) ) % 50 + 1 ),
--			( ABS( CHECKSUM( NEWID() ) ) % 300 + 1 ),
--		('2020-01-01'													
--			+ DATEADD( day,    ( ABS( CHECKSUM( NEWID() ) ) % 365 ), 0) 
--			+ DATEADD( hour,   ( ABS( CHECKSUM( NEWID() ) ) % 24  ), 0) 
--			+ DATEADD( minute, ( ABS( CHECKSUM( NEWID() ) ) % 60  ), 0) 
--		)				
--	)
--END

--SELECT * FROM Storage

--SELECT T.Name AS [Type], AVG(St.Quantity) AS [Average Quantity] FROM Product P JOIN Storage St ON P.Id = St.Id_of_product JOIN Type_Product T ON P.Type_Id = T.Id WHERE T.Name IN ( SELECT Name FROM Type_Product GROUP BY Name ) GROUP BY T.Name ORDER BY [Average Quantity] DESC



--SELECT *

--FROM Type_Product T 

--WHERE T.Id NOT LIKE 'D2368E4A-DF5B-4287-A66B-821DEFF72D20'



--SELECT P.Name FROM 
--Type_Product T JOIN 
--Product P  ON  T.Id = P.Type_Id WHERE T.Name LIKE 'Вода'

SELECT P.Name FROM Product P JOIN Storage St ON P.Id = St.Id_of_product JOIN Supplier S ON St.Supplier_Id = S.Id WHERE S.Name = 'Razorfish' GROUP BY P.Name