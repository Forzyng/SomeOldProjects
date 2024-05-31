--CREATE TABLE Authors 
--(
--	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
--	[Name] NVARCHAR(MAX) NOT NULL CHECK ([Name] <> N''),
--	[Surname] NVARCHAR(MAX) NOT NULL CHECK ([Surname] <> N''),
--	[CountriesID] UNIQUEIDENTIFIER NOT NULL REFERENCES Countries([Id])
--)

--DROP TABLE Authors

--INSERT INTO Authors 
--(Id, Name, Surname, CountriesID)
--VALUES 
--(NEWID() , N'Лев' ,N'Толстой' ,			'2e94a37d-0a48-46df-acc4-200964e3f917') ,
--(NEWID() , N'Николай' ,N'Гоголь' ,		'2e94a37d-0a48-46df-acc4-200964e3f917') ,
--(NEWID() , N'Александр' ,N'Пушкин' ,	'2e94a37d-0a48-46df-acc4-200964e3f917') ,

--(NEWID() , N'Стефан' ,N'Цвейг' ,		'0a34eb48-028f-4429-b3dc-321816b524be') ,
--(NEWID() , N'Карл' ,N'Краус' ,			'0a34eb48-028f-4429-b3dc-321816b524be') ,
--(NEWID() , N'Гуго' ,N'фон Гофмансталь' ,'0a34eb48-028f-4429-b3dc-321816b524be') ,

--(NEWID() , N'Жюль' ,N'Верн' ,			'2331EDC9-400D-42EF-8344-08F31E6C340E') ,
--(NEWID() , N'Фредерик' ,N'Бегбер' ,		'2331EDC9-400D-42EF-8344-08F31E6C340E') ,
--(NEWID() , N'Альбер' ,N'Камю' ,			'2331EDC9-400D-42EF-8344-08F31E6C340E') ,

--(NEWID() , N'Джозеф' ,N'Дилейни' ,		'A81F9920-4999-4E11-A119-3E02D23C8F0D') ,
--(NEWID() , N'Кевин' ,N'Брукс' ,			'A81F9920-4999-4E11-A119-3E02D23C8F0D') ,
--(NEWID() , N'Редьярд' ,N'Киплинг' ,		'A81F9920-4999-4E11-A119-3E02D23C8F0D') ,
--(NEWID() , N'Джулиан' ,N'Барнс' ,		'A81F9920-4999-4E11-A119-3E02D23C8F0D') ,
--(NEWID() , N'Джон' ,N'Рональд' ,		'A81F9920-4999-4E11-A119-3E02D23C8F0D') ,

--(NEWID() , N'Лопе' ,N'де Вега' ,		'F67CD7E2-2006-4358-B3CD-3BB96EEDDB7D') ,
--(NEWID() , N'Артуро' ,N'Перес-Реверте' ,'F67CD7E2-2006-4358-B3CD-3BB96EEDDB7D') ,
--(NEWID() , N'Эдуардо' ,N'Мендоса' ,		'F67CD7E2-2006-4358-B3CD-3BB96EEDDB7D') ,

--(NEWID() , N'Данте' ,N'Алигьери' ,		'875306F7-2BCB-482B-BA3B-27AAFAB28047') ,
--(NEWID() , N'Рафаэлло' ,N'Джованьоли' , '875306F7-2BCB-482B-BA3B-27AAFAB28047') ,
--(NEWID() , N'Джованни' ,N'Боккаччо' ,	'875306F7-2BCB-482B-BA3B-27AAFAB28047') ,

--(NEWID() , N'Георгий' ,N'Баженов' ,		'2e94a37d-0a48-46df-acc4-200964e3f917') ,
--(NEWID() , N'Борис' ,N'Акунин' ,		'2e94a37d-0a48-46df-acc4-200964e3f917') ,
--(NEWID() , N'Михаил' ,N'Булгаков' ,		'2e94a37d-0a48-46df-acc4-200964e3f917') ,

--(NEWID() , N'Николае' ,N'Филимон' ,		'c03c0339-2f39-4ac9-a51b-b77c16ca63db') ,
--(NEWID() , N'Мирча' ,N'Элиаде' ,		'c03c0339-2f39-4ac9-a51b-b77c16ca63db') ,
--(NEWID() , N'Чезар' ,N'Петреску' ,		'c03c0339-2f39-4ac9-a51b-b77c16ca63db') ,

--(NEWID() , N'Адам' ,N'Мицкевич' ,		'421F4BF6-15C7-4146-87D8-F45C73C107C9') ,
--(NEWID() , N'Генрик' ,N'Сенкевич' ,     '421F4BF6-15C7-4146-87D8-F45C73C107C9') ,
--(NEWID() , N'Чеслав' ,N'Милош' ,	    '421F4BF6-15C7-4146-87D8-F45C73C107C9') ,

--(NEWID() , N'Теодор' ,N'Драйзер' ,	    '838584B1-D9DD-4902-B140-CD9C081FE325') ,
--(NEWID() , N'Лаймен' ,N'Баум' ,			'838584B1-D9DD-4902-B140-CD9C081FE325') ,
--(NEWID() , N'Джек' ,N'Лондон' ,			'838584B1-D9DD-4902-B140-CD9C081FE325') ,

--(NEWID() , N'Стефан' ,N'Цвейг' ,		'FB3B27C4-5896-4CDA-8914-BBA1E120B9F6') ,
--(NEWID() , N'Карл' ,N'Краус' ,		    'FB3B27C4-5896-4CDA-8914-BBA1E120B9F6') ,
--(NEWID() , N'Гуго' ,N'фон Гофмансталь' ,'FB3B27C4-5896-4CDA-8914-BBA1E120B9F6') ,

--(NEWID() , N'Сергей' ,N'Жадан' ,		'F36A0657-7436-48DB-A558-83AB7B0672E7') ,
--(NEWID() , N'Юрий' ,N'Андрухович' ,		'F36A0657-7436-48DB-A558-83AB7B0672E7') ,
--(NEWID() , N'Юрий' ,N'Винничук' ,		'F36A0657-7436-48DB-A558-83AB7B0672E7') ,

--(NEWID() , N'Алексис' ,N'Киви' ,		'40929D6B-959A-4569-98B5-C6201F5FF2A1') ,
--(NEWID() , N'Ханну' ,N'Мякеля' ,		'40929D6B-959A-4569-98B5-C6201F5FF2A1') ,
--(NEWID() , N'Арто' ,N'Паасилинна' ,		'40929D6B-959A-4569-98B5-C6201F5FF2A1') ,
 
--(NEWID() , N'Фридрих' ,N'Дюрренматт' ,  '17C53358-256B-4BE9-9D28-CA397A0BB156') ,
--(NEWID() , N'Герман' ,N'Гессе' ,		'17C53358-256B-4BE9-9D28-CA397A0BB156') ,
--(NEWID() , N'Макс' ,N'Фриш' ,			'17C53358-256B-4BE9-9D28-CA397A0BB156') 

SELECT * FROM Authors ORDER BY Name