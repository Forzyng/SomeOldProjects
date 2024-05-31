﻿--CREATE TABLE Sales
--(
--	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
--	[Price] MONEY NOT NULL DEFAULT 0,
--	[Quantity] INT NOT NULL ,
--	[SaleDate] DATETIME  DEFAULT (getdate()) NULL,
--	[BooksId] UNIQUEIDENTIFIER NOT NULL REFERENCES Books([Id]),
--	[ShopsId] UNIQUEIDENTIFIER NOT NULL REFERENCES Shops([Id])
--)


--DECLARE @I INT
--SET     @I = 0
--SET     NOCOUNT ON
--WHILE   @I < 100
--BEGIN
--	SET @I = @I + 1 
--	INSERT INTO Sales 
--		( Id, Quantity, Price, SaleDate, BooksId, ShopsId)
--	VALUES
--	(
--	NEWID(),
--			( ABS( CHECKSUM( NEWID() ) ) % 10 + 1 ),	
--			(SELECT TOP 1 B.Price  FROM Books B ORDER BY NEWID()) ,
--		('2020-01-01'													
--			+ DATEADD( day,    ( ABS( CHECKSUM( NEWID() ) ) % 365 ), 0) 
--			+ DATEADD( hour,   ( ABS( CHECKSUM( NEWID() ) ) % 24  ), 0) 
--			+ DATEADD( minute, ( ABS( CHECKSUM( NEWID() ) ) % 60  ), 0) 
--		),
--			( SELECT TOP 1 Id FROM Books ORDER BY NEWID() ),				
--		( SELECT TOP 1 Id FROM Shops ORDER BY NEWID() )					
--	)
--END

--SELECT * FROM Sales