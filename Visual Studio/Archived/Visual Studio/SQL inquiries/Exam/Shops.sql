
--CREATE TABLE Shops
--(
--	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
--	[Name] NVARCHAR(MAX) NOT NULL CHECK ([Name] <> N''),
--	[CountriesID] UNIQUEIDENTIFIER NOT NULL REFERENCES Countries([Id])
--)


--DROP TABLE Shops

--INSERT INTO Shops
--(Id, Name, CountriesID)
--VALUES 
--(NEWID(), N'Book Magazine Number 1',  '6b94ad47-8ed4-444f-82bd-04e018e549e4') ,
--(NEWID(), N'Book And Book',  'f36a0657-7436-48db-a558-83ab7b0672e7') ,
--(NEWID(), N'Book Forever',  '0a34eb48-028f-4429-b3dc-321816b524be') ,
--(NEWID(), N'Book 24',  '83a0158e-273f-46da-a76b-82ca5ed513ca') ,
--(NEWID(), N'Book & Sword',  'fb3b27c4-5896-4cda-8914-bba1e120b9f6') ,
--(NEWID(), N'MyBook',  'c7722a5a-67c9-4b15-b0e4-fbd277508671') ,
--(NEWID(), N'Cafe-book',  '6f1d72e8-5220-4b3d-81d9-766f9f36f488') ,
--(NEWID(), N'Coffe-book',  'a7193bfb-9242-4d88-a726-1e7cffd03f43') ,
--(NEWID(), N'Work with book',  '2e94a37d-0a48-46df-acc4-200964e3f917') ,
--(NEWID(), N'1001 Book', 'a81f9920-4999-4e11-a119-3e02d23c8f0d') ,
--(NEWID(), N'LitRes', '1c067566-f226-4ff7-b26e-7fdbbfd90757') ,
--(NEWID(), N'Knigarnya', '1f0774b6-2795-4488-8f33-c891400a52c9') ,
--(NEWID(), N'Knigga', '421f4bf6-15c7-4146-87d8-f45c73c107c9') ,
--(NEWID(), N'One Book for all', 'f67cd7e2-2006-4358-b3cd-3bb96eeddb7d') ,
--(NEWID(), N'FBreaderBook', '884df2bb-08c4-40f1-8eb3-28a91e4a839b') 


SELECT * FROM Shops ORDER BY Name