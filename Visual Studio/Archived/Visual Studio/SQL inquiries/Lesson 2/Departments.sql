﻿-- Модуль 4. Многотабличные базы данных

CREATE TABLE Departments 
(
	Id			UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	Name		NVARCHAR(50) NOT NULL
) ;

INSERT INTO Departments 
	( Id, Name )
VALUES 
	( 'D3C376E4-BCE3-4D85-ABA4-E3CF49612C94',  N'IT одтел'		 	 ), 
	( '131EF84B-F06E-494B-848F-BB4BC0604266',  N'Бухгалтерия'		 ), 
	( '8DCC3969-1D93-47A9-8B79-A30C738DB9B4',  N'Служба безопасности'), 
	( 'D2469412-0E4B-46F7-80EC-8C522364D099',  N'Отдел кадров'		 ),
	( '1EF7268C-43A8-488C-B761-90982B31DF4E',  N'Канцелярия'		 ), 
	( '415B36D9-2D82-4A92-A313-48312F8E18C6',  N'Одтел продаж'		 ), 
	( '624B3BB5-0F2C-42B6-A416-099AAB799546',  N'Юридическая служба' )