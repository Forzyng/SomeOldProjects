--ALTER TABLE Products
--DROP CONSTRAINT FK_ProdMan ;



--ALTER TABLE Products
--DROP COLUMN Id_manager ;




--ALTER TABLE Products
--ADD
--Id_manager UNIQUEIDENTIFIER
--CONSTRAINT FK_ProdMan
--FOREIGN KEY( Id_manager ) REFERENCES Managers(Id)