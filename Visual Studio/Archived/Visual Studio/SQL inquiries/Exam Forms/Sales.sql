--CREATE TABLE Sales
--(
--	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
--	[Price] MONEY NOT NULL DEFAULT 0,
--	[Quantity] INT NOT NULL ,
--	[SaleDate] DATETIME  DEFAULT (getdate()) NULL,
--	[RecordsId] UNIQUEIDENTIFIER NOT NULL REFERENCES Records([Id]),
--)

--DROP TABLE Sales

--DECLARE @I INT
--SET     @I = 0
--SET     NOCOUNT ON
--WHILE   @I < 100000
--BEGIN
--	SET @I = @I + 1 
--	INSERT INTO Sales 
--		( Id, Quantity, Price, SaleDate, RecordsId)
--	VALUES
--	(
--	NEWID(),
--			( ABS( CHECKSUM( NEWID() ) ) % 50 + 1 ),	
--			(SELECT TOP 1 R.PriceForSale  FROM Records R ORDER BY NEWID()) ,
--		('2020-08-18'													
--			+ DATEADD( day,    ( ABS( CHECKSUM( NEWID() ) ) % 365 ), 0) 
--			+ DATEADD( hour,   ( ABS( CHECKSUM( NEWID() ) ) % 24  ), 0) 
--			+ DATEADD( minute, ( ABS( CHECKSUM( NEWID() ) ) % 60  ), 0) 
--		),
--			( SELECT TOP 1 Id FROM Records ORDER BY NEWID() )				
--	)
--END

SELECT * FROM Sales