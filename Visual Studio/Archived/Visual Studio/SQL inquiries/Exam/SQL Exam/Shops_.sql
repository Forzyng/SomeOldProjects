﻿
--CREATE TABLE Shops
--(
--	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
--	[Name] NVARCHAR(MAX) NOT NULL CHECK ([Name] <> N''),
--	[CountriesID] UNIQUEIDENTIFIER NOT NULL REFERENCES Countries([Id])
--)


--INSERT INTO Shops
--VALUES 
--('663c3142-1c9d-4957-800d-f6c6824b9c88' , N'Book' , '1D903ECA-9C24-49BB-B8F5-0B8B2E8B68E4') ,
--('e1ac29ad-122e-474d-926a-f93ac636f605' , N'Book & Shop' , '1A930DE7-647B-4A32-AD3B-0CAF4528B356') ,
--('ee860ee3-6cca-4ea3-a2f1-fb79f4fc823a' , N'Book Café' , '5FE63A0F-C1AE-44BE-9397-0F7DB0B95C1F') ,
--('5319fd22-9bde-48e5-819d-fe884b70afd8' , N'Primus Versus' , 'CDE086E1-D25C-4251-A234-10727818EE28') ,
--('d17a4442-0a71-4673-b450-36929048adef' , N'T & ko' , '676D8ED4-8307-4196-9776-107C40C1DF84') ,
--('69b125d7-99cc-42d6-a6fa-46687f333749' , N'SKLADNIG' , 'DD860E7E-C2F0-47A6-BA29-165BE015E5A2') ,
--('f7f1e576-af8d-4749-869e-4a794fe69d42' , N'Verbum' , '15F36ECC-EF25-495F-ADFF-169DB3339B88') ,
--('da1e17bb-a90d-4c79-b801-5462fb070f57' , N'Livebook' , '23D52416-D994-4564-A106-1FDF5FECEF25') ,
--('7264d33a-16b9-4e22-b3f1-63d6dae60078' , N'NarBook' , '2FA70965-5BCE-44F0-B6DD-2AF6072EB8B0') ,
--('870da1a9-44f4-4018-b7fc-727a2058faf0' , N'PhotoBookPoster' , 'D3FCC76B-09A2-4578-A72C-34468DA36C45') ,
--('efc6578a-00b7-4766-a7e3-79cdba8c294b' , N'Rufanbooks' , '0889C51E-7728-4ABD-9987-3588D48B54A9') ,
--('8ff90e21-dcdb-4d55-a557-7c6d57dbb029' , N'Book24' , '0B2BE83A-7FB4-403B-8CE8-37BE257B038C') ,
--('b6d20749-b495-4b1a-ba1c-80b88e78b7cd' , N'Books.ua' , 'FEA65EE4-A8A0-425B-8F11-3896C1E2197E') ,
--('bb29f63d-1261-41f2-89e8-88f44d5ec409' , N'Bizarrebook' , 'EFEF5433-7E26-43A3-A737-3BB032D7D88A') ,
--('94bc671a-a6b6-417a-bc9f-8ae4871a58ec' , N'Bookashki.net' , '0017AAAE-3E22-462D-9031-4276A9788D51') 


SELECT * FROM Shops