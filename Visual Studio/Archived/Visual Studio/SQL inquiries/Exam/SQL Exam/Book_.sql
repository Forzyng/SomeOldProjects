﻿
--CREATE TABLE Books
--(
--	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
--	[Name] NVARCHAR(50) NOT NULL CHECK ([Name] <> N''),
--	[Pages] INT NOT NULL CHECK ([Pages] <> 0) ,
--	[Price] MONEY NOT NULL DEFAULT 0,
--	[PublishDate] DATE  DEFAULT (getdate()) NULL,
--	[AuthorsId] UNIQUEIDENTIFIER NOT NULL REFERENCES Authors([Id]),
--	[ThemesId] UNIQUEIDENTIFIER NOT NULL REFERENCES Themes([Id])
--)


--INSERT INTO Books
--VALUES 

--('61842E39-4C47-4B99-B02C-6A270E9DF2C7' , N'Женщины Цезаря' , 1460 , '90' , '1996-03-21', '39d57dfb-8da7-49c9-ae8d-464509618f02' , '07629571-a507-4bf2-9b81-c4edd0d295d6'),
--('AA9B8EA5-9FD0-4DB5-A5EB-7683FDAA2350' , N'Первый человек в Риме' , 1450 , '55.50' , '1990-01-01', '39d57dfb-8da7-49c9-ae8d-464509618f02' , '5f9e1269-4354-4d85-95df-a2ca08e77f0c'),

--('DAFA76DC-C6B3-4075-9C0E-9135F26C25CB' , N'Шантарам' , 691 , '31' , '2002-01-01', '66034616-24e5-4e90-815f-476eb0cbb6b1' , '4a550d3b-d1f2-40ef-ae4e-963612c6713a'),
--('4183A8B0-32F4-42B7-ADFF-BCAB0E184D10' , N'Тень горы' , 780 , '99.99' , '2015-10-13', '66034616-24e5-4e90-815f-476eb0cbb6b1' , '07629571-a507-4bf2-9b81-c4edd0d295d6'),
--('4C92677F-F261-429A-A28E-BEC391BB6096' , N'shantaram msr' , 864 , '55.50' , '2003-05-06', '66034616-24e5-4e90-815f-476eb0cbb6b1' , '07629571-a507-4bf2-9b81-c4edd0d295d6'),

--('3B797CDC-0785-4853-B457-00ACC5112BFB' , N'Книжный вор' , 703 , '60' , '2005-01-01', '381c2888-1cb0-41fa-9650-48b953f31ef6' , '2dca5e44-b06d-4613-bb6a-d3bc91430bfe'),
--('42A30F7C-854C-4341-A6AC-0162CEEC08DA' , N'Я — посланник' , 478 , '110' , '2002-01-10', '381c2888-1cb0-41fa-9650-48b953f31ef6' , '07629571-a507-4bf2-9b81-c4edd0d295d6'),
--('58F52604-9403-4009-8367-01DECCB53389' , N'the underdog' , 140 , '28.04' , '1999-01-01', '381c2888-1cb0-41fa-9650-48b953f31ef6' , '17db11d1-f50e-4cf4-9c54-cf1bd45802ea'),

--('0A859C0F-258B-487C-9B14-02A63001D951' , N'Шахматная новелла' , 288 , '150' , '1943-12-07', '79679ed4-0ccd-480a-8d5b-4a68287de6c4' , '2dca5e44-b06d-4613-bb6a-d3bc91430bfe'),
--('F9774696-BA65-44E4-92D6-02B089A471F5' , N'Нетерпение сердца' , 133 , '98' , '1939-01-10', '79679ed4-0ccd-480a-8d5b-4a68287de6c4' , '4a550d3b-d1f2-40ef-ae4e-963612c6713a'),
--('EDADFC61-E288-4756-A2E0-04580B1263AB' , N'Письмо незнакомки' , 310 , '189.50' , '1922-01-01', '79679ed4-0ccd-480a-8d5b-4a68287de6c4' , 'f2585221-1aca-4efe-a5e8-c2f4534d1f92'),


--('9AC3C163-D081-4AA1-BC81-B7C195C039E2' , N'Последние дни человечества' , 200 , '88' , '1918-05-10', '8587f6ea-3c5c-424c-87e0-4c76603364e2' , '5f9e1269-4354-4d85-95df-a2ca08e77f0c'),
--('34ACB2D5-265D-4F12-8190-A3186AF5B3DB' , N'Anderthalb Wahrheiten' , 133 , '78' , '1969-01-10', '8587f6ea-3c5c-424c-87e0-4c76603364e2' , '5f9e1269-4354-4d85-95df-a2ca08e77f0c'),
--('AA0F6A7D-6212-44F8-B1A6-A389FC457520' , N'Dicta and Contradicta' , 140 , '39' , '1909-01-01', '8587f6ea-3c5c-424c-87e0-4c76603364e2' , '5f9e1269-4354-4d85-95df-a2ca08e77f0c'),


--('CC144FAC-4E5C-4F87-8673-0503F73EF4BB' , N'The Lord Chandos Letter' , 100 , '15' , '1903-10-18', '7585d790-6e5a-4f73-a85c-4f9bd883d811' , '07629571-a507-4bf2-9b81-c4edd0d295d6'),
--('0F9B5383-D513-4617-8889-05A447224338' , N'The woman without a shadow' , 133 , '25' , '1919-01-10', '7585d790-6e5a-4f73-a85c-4f9bd883d811' , '07629571-a507-4bf2-9b81-c4edd0d295d6'),
--('3E0BC6A4-1841-485A-AF5A-0790E3F11207' , N'Andreas, or The united' , 134 , '42' , '1932-01-01', '7585d790-6e5a-4f73-a85c-4f9bd883d811' , '07629571-a507-4bf2-9b81-c4edd0d295d6'),

--('FECF5440-B519-49C3-A13D-09C128488185' , N'Intruder' , 288 , '33' , '1891-05-20', 'fe7e578e-5fc8-4d80-ad6b-500ddf2506c4' , 'dbb32859-03bd-4f81-bf10-c7cee30e42b1'),
--('290EDC03-DFFE-4432-B4CB-0A0270CE688E' , N'Пелей и Мелисанда' , 460 , '44' , '1892-05-10', 'fe7e578e-5fc8-4d80-ad6b-500ddf2506c4' , '07629571-a507-4bf2-9b81-c4edd0d295d6'),
--('7CF3A160-FC18-46E1-909B-0AE40CC6F4CF' , N'Синяя птица' , 119 , '15' , '1908-10-13', 'fe7e578e-5fc8-4d80-ad6b-500ddf2506c4' , '17db11d1-f50e-4cf4-9c54-cf1bd45802ea'),

--('ED313DE0-787D-4DE1-AACD-0C02DE49546B' , N'Мёртвый Брюгге' , 71 , '22' , '1892-02-14', '3e229eb8-e99a-455f-8af3-5871337a092c' , '4a550d3b-d1f2-40ef-ae4e-963612c6713a'),
--('AD5DD269-7FC9-4036-9E33-0D73EA342604' , N'Le règne du silence' , 133 , '22' , '1891-01-10', '3e229eb8-e99a-455f-8af3-5871337a092c' , '07629571-a507-4bf2-9b81-c4edd0d295d6'),
--('D935A3B6-D276-428C-A950-114A29F78897' , N'Мистические лилии' , 93 , '67' , '1898-08-24', '3e229eb8-e99a-455f-8af3-5871337a092c' , '5f9e1269-4354-4d85-95df-a2ca08e77f0c'),

--('00374FD3-D8C0-40BB-BFD6-116B3CE1112A' , N'Легенда об Уленшпигеле' , 982 , '100' , '1867-09-27', '1e45e5ff-4199-4f6e-b2a5-6045432ef81c' , '5ad90d2b-9848-42bb-a476-b701a888f40c'),
--('28D45B4E-1EE2-4EBE-A4CD-125FB014D545' , N'Flemish Legends' , 103 , '56' , '1858-01-10', '1e45e5ff-4199-4f6e-b2a5-6045432ef81c' , 'dbb32859-03bd-4f81-bf10-c7cee30e42b1'),
--('EBE32C72-6B19-418D-A6FE-1283554064BC' , N'Легенда об Уленшпигеле и Ламме Гудзаке' , 820 , '88' , '1867-07-30', '1e45e5ff-4199-4f6e-b2a5-6045432ef81c' , '7b08197b-c55f-4389-891f-bf12a575dffb'),

--('97C1365B-CA22-42AA-A50C-129803326972' , N'Bold as Love' , 256 , '23' , '2001-05-20', '8939ed0c-bbdb-435e-923e-68158d2153c6' , '07629571-a507-4bf2-9b81-c4edd0d295d6'),
--('6A0277BE-20BB-44C3-AD52-13AF0CB8B7DA' , N'White Queen' , 324 , '105' , '1991-02-27', '8939ed0c-bbdb-435e-923e-68158d2153c6' , '07629571-a507-4bf2-9b81-c4edd0d295d6'),
--('64D43FA3-10DC-498E-AB5E-13E4F4F728C1' , N'Divine Endurance' , 133 , '67' , '1984-10-13', '8939ed0c-bbdb-435e-923e-68158d2153c6' , '5f9e1269-4354-4d85-95df-a2ca08e77f0c'),

--('89E6EBEC-4598-4534-A34F-13E95D72DE0A' , N'Ученик Ведьмака' , 505 , '240' , '2004-07-01', '743c93f2-4717-4e81-a093-69903476e176' , '07629571-a507-4bf2-9b81-c4edd0d295d6'),
--('D5FF055A-2A10-464B-950B-14ACA750ED52' , N'The Last Apprentice: I Am Alice' , 500 , '194' , '2013-06-06', '743c93f2-4717-4e81-a093-69903476e176' , '07629571-a507-4bf2-9b81-c4edd0d295d6'),
--('6EA4A942-9E24-439F-8B30-1536C5FA7216' , N'Проклятие Ведьмака' , 264 , '244' , '2005-06-30', '743c93f2-4717-4e81-a093-69903476e176' , '07629571-a507-4bf2-9b81-c4edd0d295d6'),

--('5AB42814-4855-4CC5-A344-1598288AC49C' , N'The Bunker Diary' , 100 , '5.95' , '2013-03-07', '868f6394-3ca3-4700-90bb-6b73ec6719a7' , '2dca5e44-b06d-4613-bb6a-d3bc91430bfe'),
--('8F7F727F-7FCE-46F8-B910-166D02D460CD' , N'Road of the Dead' , 103 , '10.87' , '2006-02-13', '868f6394-3ca3-4700-90bb-6b73ec6719a7' , '5f9e1269-4354-4d85-95df-a2ca08e77f0c'),
--('B7686B72-05ED-4A7A-B655-16896E595DB7' , N'iBoy' , 144 , '20' , '2010-07-30', '868f6394-3ca3-4700-90bb-6b73ec6719a7' , '07629571-a507-4bf2-9b81-c4edd0d295d6'),

----('EB60EB7B-39D4-4B5E-910D-A4C4AEE54BE1' , N'Lucky Per' , 98 , '69' , '1898-08-13', 'dc268b00-1727-4381-9878-6da1bfef2701' , '2dca5e44-b06d-4613-bb6a-d3bc91430bfe'),
----('D8B23547-4485-438E-AF27-A70915CA21B3' , N'The Realm of the Dead' , 68 , '54' , '1912-02-27', 'dc268b00-1727-4381-9878-6da1bfef2701' , 'f2585221-1aca-4efe-a5e8-c2f4534d1f92'),
----('DEC69C3A-7D13-4BFD-9793-A7CE706C1130' , N'The Old Adam' , 103 , '67' , '1894-10-13', 'dc268b00-1727-4381-9878-6da1bfef2701' , '07629571-a507-4bf2-9b81-c4edd0d295d6'),

----('CCC75084-4B99-462A-81A3-A837B161329D' , N'Koala' , 58 , '15' , '2020-08-28', '29219db8-16a0-4046-a7e1-6e455b0559cd' , '17db11d1-f50e-4cf4-9c54-cf1bd45802ea'),
----('3D0B5594-3BD4-4094-BB3F-AB594D8E9229' , N'Small Woodland Creatures' , 85 , '20' , '2001-06-06', '29219db8-16a0-4046-a7e1-6e455b0559cd' , '17db11d1-f50e-4cf4-9c54-cf1bd45802ea'),
----('0CF32F63-7B15-4F47-B099-AFF744852C67' , N'Rotten' , 101 , '15.99' , '2020-05-08', '29219db8-16a0-4046-a7e1-6e455b0559cd' , '17db11d1-f50e-4cf4-9c54-cf1bd45802ea')

----('2F524C93-A258-4960-8B15-B0B2B8BDE986' , N'Nanna a Story of Danish Love' , 240 , '45' , '1901-06-30', '1adc048c-e346-47c3-8c35-7ad4fdaa6eb7' , '4a550d3b-d1f2-40ef-ae4e-963612c6713a'),
----('B6158225-DE84-4482-B3AB-B6A8DE7303A3' , N'The Cruise of the Wild Duck And Other Tales' , 213 , '66' , '1893-09-09', '1adc048c-e346-47c3-8c35-7ad4fdaa6eb7' , '5ad90d2b-9848-42bb-a476-b701a888f40c'),
----('317B3700-F3D5-4D45-9523-B70C27E8E9AC' , N'Derovre Fra Graensen Strejftog' , 277 , '87' , '1877-07-30', '1adc048c-e346-47c3-8c35-7ad4fdaa6eb7' , '2dca5e44-b06d-4613-bb6a-d3bc91430bfe'),

--('1C01983C-1CD5-4012-966E-21F7DE8F64E0' , N'Овечий источник' , 166 , '13' , '1619-01-01', '7b8219fc-9fd2-431e-985c-7caa6e9bd013' , '4a550d3b-d1f2-40ef-ae4e-963612c6713a'),
--('27549752-5A5D-471E-8E60-2394233C5D84' , N'Punishment Without Revenge' , 134 , '11' , '1631-01-01', '7b8219fc-9fd2-431e-985c-7caa6e9bd013' , '64a4df8a-0733-4be9-aaba-c01b4ec3612a'),
--('94F054C4-FA38-4E30-BC39-23F1FEAA4A62' , N'The Lady Boba: A Woman of Little Sense' , 187 , '20.21' , '1613-01-01', '7b8219fc-9fd2-431e-985c-7caa6e9bd013' , '7b08197b-c55f-4389-891f-bf12a575dffb'),

--('91884C4B-F233-4586-9352-241EABCF923F' , N'Клуб Дюма, или Тень Ришельё' , 508 , '45' , '1993-08-28', 'a93a1b20-155a-43bd-acee-87a6088c969e' , '4a550d3b-d1f2-40ef-ae4e-963612c6713a'),
--('78DAC490-17FC-4AFF-BA2E-251155FA2393' , N'Королева Юга' , 539 , '56' , '2002-04-29', 'a93a1b20-155a-43bd-acee-87a6088c969e' , '4a550d3b-d1f2-40ef-ae4e-963612c6713a'),
--('3DFA3B59-1621-416F-9913-25886C47323D' , N'Фламандская доска' , 443 , '50' , '1990-09-14', 'a93a1b20-155a-43bd-acee-87a6088c969e' , '4a550d3b-d1f2-40ef-ae4e-963612c6713a'),

--('A69450B7-C472-411B-B046-27AFC6ED0BC9' , N'No Word from Gurb' , 98 , '45' , '1990-06-30', '13ded219-a580-4ff8-8211-90a408b0afa6' , '4a550d3b-d1f2-40ef-ae4e-963612c6713a'),
--('F57B9EE0-73EF-4F54-97B6-2898E08E388A' , N'El enredo de la bolsa y la vida' , 145 , '25' , '2012-10-29', '13ded219-a580-4ff8-8211-90a408b0afa6' , '07629571-a507-4bf2-9b81-c4edd0d295d6'),
--('3D371FBE-EC2C-4137-B826-291CB0B6F080' , N'El último trayecto de Horacio Dos' , 78 , '87' , '2002-01-13', '13ded219-a580-4ff8-8211-90a408b0afa6' , '7b08197b-c55f-4389-891f-bf12a575dffb'),


----('6F42AFAC-2CE7-4E2A-840B-0501DBAE7E44' , N'Божественная комедия' , 785 , '100' , '2009-12-12', '521c07be-6fbd-411f-bccb-93e2672bd50e' , '2dca5e44-b06d-4613-bb6a-d3bc91430bfe'),
----('62C40E29-185B-4595-9A86-060001F70C01' , N'Новая жизнь' , 126 , '132' , '1294-01-01', '521c07be-6fbd-411f-bccb-93e2672bd50e' , '64a4df8a-0733-4be9-aaba-c01b4ec3612a'),
----('85A8016B-AAF0-4614-A7D8-060520D8777C' , N'О народном красноречии' , 187 , '99' , '1305-01-01', '521c07be-6fbd-411f-bccb-93e2672bd50e' , 'f2585221-1aca-4efe-a5e8-c2f4534d1f92')

----('1FB046E8-090C-42AA-9BC1-084DF6010DF9' , N'Спартак' , 623 , '267' , '1874-08-28', 'bedffe25-20fa-4e8f-8cac-9609ed3443dc' , '07629571-a507-4bf2-9b81-c4edd0d295d6'),
----('C6A689AA-B3F4-418F-9F8F-0A47AE05FE07' , N'Опимия' , 319 , '178' , '1882-03-12', 'bedffe25-20fa-4e8f-8cac-9609ed3443dc' , '4a550d3b-d1f2-40ef-ae4e-963612c6713a'),
----('13C94FFF-71D3-48C4-81E7-0AD5A65068C1' , N'Spartacus' , 553 , '147' , '1995-01-01', 'bedffe25-20fa-4e8f-8cac-9609ed3443dc' , '07629571-a507-4bf2-9b81-c4edd0d295d6')

----('75ADEA9C-4FBF-4FE6-80C8-006E5E50A004' , N'Декамерон' , 521 , '89' , '1351-01-01', '267f7528-2d4b-4063-a2c8-98e8f19fb6ee' , '07629571-a507-4bf2-9b81-c4edd0d295d6'),
----('583FD49C-18BE-4AFD-A313-010300D9DE6E' , N'De mulieribus claris' , 113 , '68' , '1374-01-01', '267f7528-2d4b-4063-a2c8-98e8f19fb6ee' , '17db11d1-f50e-4cf4-9c54-cf1bd45802ea'),
----('6A727B03-C23F-47C4-A8D6-044DF07EB36A' , N'Фьямметта' , 100 , '87' , '1350-01-01', '267f7528-2d4b-4063-a2c8-98e8f19fb6ee' , '5f9e1269-4354-4d85-95df-a2ca08e77f0c'),

--('87022C99-4C08-4D58-957C-0C299F0BD4B1' , N'Бабушка и внучка' , 286 , '55' , '2021-05-12', '05e31241-7274-43b5-8b59-9a62d725e54f' , '07629571-a507-4bf2-9b81-c4edd0d295d6'),
--('8FED8145-380E-4AB7-AC61-0D11562D698F' , N'Ловушка для Адама и Евы' , 950 , '178' , '2021-05-01', '05e31241-7274-43b5-8b59-9a62d725e54f' , '07629571-a507-4bf2-9b81-c4edd0d295d6'),
--('CA79AD97-164B-4245-A9E9-0D8744357C73' , N'Другу смотри в глаза' , 400 , '99' , '2021-05-01', '05e31241-7274-43b5-8b59-9a62d725e54f' , '07629571-a507-4bf2-9b81-c4edd0d295d6'),

--('08B0909D-A9AD-4CBC-9956-0F68A17473A0' , N'Азазель' , 322 , '118' , '1998-01-01', '3618d1d1-32de-40b5-b823-9f82924a3caf' , '5f9e1269-4354-4d85-95df-a2ca08e77f0c'),
--('EF8346F8-25BE-4E15-AE02-107810798E1C' , N'Левиафан' , 335 , '168' , '1998-03-26', '3618d1d1-32de-40b5-b823-9f82924a3caf' , '2dca5e44-b06d-4613-bb6a-d3bc91430bfe'),
--('AA476E5A-378B-4ECE-AC1A-130E1819D68D' , N'Турецкий гамбит' , 282 , '117' , '1998-02-02', '3618d1d1-32de-40b5-b823-9f82924a3caf' , '2dca5e44-b06d-4613-bb6a-d3bc91430bfe'),

--('E79EB456-A2D7-4778-8E51-13B5094F3719' , N'Дни Турбиных' , 101 , '89' , '1927-01-01', '207cdcf2-89ad-49a5-a669-a082fa9cccba' , 'f2585221-1aca-4efe-a5e8-c2f4534d1f92'),
--('2BEF5D21-DE6D-4A74-8B93-143CCF7C7732' , N'Кабала святош' , 72 , '79' , '1962-01-01', '207cdcf2-89ad-49a5-a669-a082fa9cccba' , 'f2585221-1aca-4efe-a5e8-c2f4534d1f92'),
--('1A906A50-855D-420E-86E2-14EB75851B21' , N'Адам и Ева' , 109 , '87' , '1926-01-01', '207cdcf2-89ad-49a5-a669-a082fa9cccba' , '4a550d3b-d1f2-40ef-ae4e-963612c6713a'),


----('7AABB2DD-4178-46D3-BC2A-182638BBB484' , N'Пастушья дудочка и другие сказки' , 105 , '5.50' , '1978-09-02', '2b3170c4-3063-43e6-985d-a38d9e45af09' , '17db11d1-f50e-4cf4-9c54-cf1bd45802ea'),
----('BB4C384D-BBB3-463C-BD4B-1A88C3A2EA42' , N'Старые и новые мироеды' , 97 , '10' , '1954-04-21', '2b3170c4-3063-43e6-985d-a38d9e45af09' , 'f2585221-1aca-4efe-a5e8-c2f4534d1f92'),
----('4E7D42EF-44E7-4BE3-B9FE-1AB42BA6226B' , N'Роман-чудодей' , 143 , '11.05' , '1940-11-12', '2b3170c4-3063-43e6-985d-a38d9e45af09' , '5f9e1269-4354-4d85-95df-a2ca08e77f0c'),

----('E9249978-01CA-4B8A-823B-1BBE3E255624' , N'Миф о вечном возвращении' , 568 , '27' , '1949-01-01', '45489fe7-86c8-4fa1-9d79-a82197566bf3' , '64a4df8a-0733-4be9-aaba-c01b4ec3612a'),
----('47130FC3-04BB-4E1F-A450-1C8DBC82727A' , N'The History of Religious Ideas' , 268 , '38' , '1976-01-31', '45489fe7-86c8-4fa1-9d79-a82197566bf3' , 'dbb32859-03bd-4f81-bf10-c7cee30e42b1'),
----('F546E049-BF7D-4ED7-B566-1D5FBF20D17E' , N'Майтрейи' , 282 , '117' , '1933-06-04', '45489fe7-86c8-4fa1-9d79-a82197566bf3' , '4a550d3b-d1f2-40ef-ae4e-963612c6713a'),

----('4EC96973-EB14-40C2-91C2-1E0260833316' , N'Фрам - белый медведь' , 160 , '89' , '1975-07-19', 'e56f5de6-a1d3-4c3e-a09a-a9b9fa96c9b3' , 'dbb32859-03bd-4f81-bf10-c7cee30e42b1'),
----('459DA659-9FD3-4097-AE44-1F04590C3426' , N'Крушение' , 169 , '79' , '1963-10-23', 'e56f5de6-a1d3-4c3e-a09a-a9b9fa96c9b3' , '5ad90d2b-9848-42bb-a476-b701a888f40c'),
----('60D2FB79-CAEF-470C-B526-253B4E3598E6' , N'Улица Победы' , 175 , '43' , '1972-04-29', 'e56f5de6-a1d3-4c3e-a09a-a9b9fa96c9b3' , '5f9e1269-4354-4d85-95df-a2ca08e77f0c'),

--('4D1DACD7-A874-4590-9F89-255F78CD07D7' , N'Хазарский словарь' , 333 , '55' , '1984-10-03', '2b3170c4-3063-43e6-985d-a38d9e45af09' , '5f9e1269-4354-4d85-95df-a2ca08e77f0c'),
--('66F26089-565E-4C4B-BE31-25872CC4D8F3' , N'Пейзаж, нарисованный чаем' , 145 , '69' , '1988-02-21', '2b3170c4-3063-43e6-985d-a38d9e45af09' , 'f2585221-1aca-4efe-a5e8-c2f4534d1f92'),
--('58B9425E-6C10-4933-9D96-26331D4FC2E3' , N'Внутренняя сторона ветра. Роман о Геро и Леандре' , 194 , '77.24' , '1991-11-12', '2b3170c4-3063-43e6-985d-a38d9e45af09' , '07629571-a507-4bf2-9b81-c4edd0d295d6'),

--('F63158FE-ED3A-4B13-8E8D-28E99758D16F' , N'Rabies' , 134 , '89' , '1983-01-01', '45489fe7-86c8-4fa1-9d79-a82197566bf3' , '5f9e1269-4354-4d85-95df-a2ca08e77f0c'),
--('ACEE432E-65A6-451E-B7F8-2D11C6E4AA1B' , N'The Golden Fleece' , 268 , '77' , '1978-01-31', '45489fe7-86c8-4fa1-9d79-a82197566bf3' , '07629571-a507-4bf2-9b81-c4edd0d295d6'),
--('18B37049-89E2-4BF8-BD85-2F80C0F267BA' , N'Godine koje su pojeli skakavci' , 125 , '98' , '1986-06-04', '45489fe7-86c8-4fa1-9d79-a82197566bf3' , 'dbb32859-03bd-4f81-bf10-c7cee30e42b1'),

--('8AEE8345-3310-4ECF-A54D-33B167072AFA' , N'Götz and Meyer' , 78 , '45' , '2003-03-20', 'e56f5de6-a1d3-4c3e-a09a-a9b9fa96c9b3' , 'dbb32859-03bd-4f81-bf10-c7cee30e42b1'),
--('C9F6016C-86A9-4F9E-AC0C-33D2850A7F9A' , N'Kontrolni punkt' , 109 , '79' , '2011-10-23', 'e56f5de6-a1d3-4c3e-a09a-a9b9fa96c9b3' , '64a4df8a-0733-4be9-aaba-c01b4ec3612a'),
--('BB5A688D-487A-4A5A-8971-34A26FAC4614' , N'Bait' , 88 , '34' , '1996-01-29', 'e56f5de6-a1d3-4c3e-a09a-a9b9fa96c9b3' , '07629571-a507-4bf2-9b81-c4edd0d295d6'),


--('79BFF8F3-A073-4798-968A-376564851BF6' , N'Сестра Керри' , 585 , '580' , '1900-01-01', '1166ecdd-63c8-42fc-a68a-c292176a7b04' , '4a550d3b-d1f2-40ef-ae4e-963612c6713a'),
--('EBAA7548-1387-486A-AB67-38621EB20C74' , N'Американская трагедия' , 953 , '176' , '1925-12-17', '1166ecdd-63c8-42fc-a68a-c292176a7b04' , '4a550d3b-d1f2-40ef-ae4e-963612c6713a'),
--('18AB10D0-5F6B-4D45-96BC-38BE3E739009' , N'Финансист' , 682 , '677' , '1912-11-12', '1166ecdd-63c8-42fc-a68a-c292176a7b04' , '4a550d3b-d1f2-40ef-ae4e-963612c6713a'),

--('CAA32EF7-5B82-4D85-AEF1-3A7CEEB41133' , N'Чудесная страна Оз' , 150 , '89' , '1904-07-05', 'c5ee780a-4d53-40fb-a592-c35cfc9455f2' , '17db11d1-f50e-4cf4-9c54-cf1bd45802ea'),
--('5E80B6D0-2141-451D-AA1F-3A8DED4F6E4B' , N'Озма из страны Оз' , 123 , '79' , '1907-07-30', 'c5ee780a-4d53-40fb-a592-c35cfc9455f2' , '17db11d1-f50e-4cf4-9c54-cf1bd45802ea'),
--('3B826E28-A960-4010-A113-3D29D979AFAB' , N'Изумрудный город страны Оз' , 125 , '98' , '1910-07-20', 'c5ee780a-4d53-40fb-a592-c35cfc9455f2' , '17db11d1-f50e-4cf4-9c54-cf1bd45802ea'),

--('1724CA3F-C6C7-4487-9917-3F16770889D2' , N'Зов предков' , 75 , '55' , '1903-01-01', '0989e3a2-3d6d-4bc3-a538-c4055f9a09dd' , '17db11d1-f50e-4cf4-9c54-cf1bd45802ea'),
--('4A502F4A-F9C7-4FD3-9461-3F3FF719ADFC' , N'Белый Клык' , 149 , '50' , '1906-12-14', '0989e3a2-3d6d-4bc3-a538-c4055f9a09dd' , '5ad90d2b-9848-42bb-a476-b701a888f40c'),
--('D4A7A807-9419-4206-A532-405AA28D71DD' , N'Мартин Иден' , 289 , '59' , '1909-01-01', '0989e3a2-3d6d-4bc3-a538-c4055f9a09dd' , '5f9e1269-4354-4d85-95df-a2ca08e77f0c'),

--('573DFDBB-F1B9-4C37-91F0-40DAF9FF1B10' , N'Двадцать тысяч лье под водой' , 311 , '135' , '1869-03-20', '63531753-4d76-4a93-ad15-c727ffeca6ab' , '5ad90d2b-9848-42bb-a476-b701a888f40c'),
--('56F1C9F8-AF2C-4554-B805-4387C7F8B238' , N'Путешествие к центру Земли' , 239 , '128' , '1864-11-25', '63531753-4d76-4a93-ad15-c727ffeca6ab' , '07629571-a507-4bf2-9b81-c4edd0d295d6'),
--('89444EF6-3106-41CE-B8C7-4D78EB616358' , N'Вокруг света за 80 дней' , 347 , '100.98' , '1872-05-22', '63531753-4d76-4a93-ad15-c727ffeca6ab' , '5f9e1269-4354-4d85-95df-a2ca08e77f0c'),


----('7979B635-6EE4-4470-B9DF-4DDA04F47134' , N'В поисках утраченного времени' , 4215 , '167' , '1913-01-01', 'd13f3cca-b9f8-4bc1-96f4-c80583928e55' , '4a550d3b-d1f2-40ef-ae4e-963612c6713a'),
----('A0252846-64AA-442D-9432-519C5E13DA50' , N'По направлению к Свану' , 522 , '133' , '1913-11-14', 'd13f3cca-b9f8-4bc1-96f4-c80583928e55' , 'dbb32859-03bd-4f81-bf10-c7cee30e42b1'),
----('972B7DB8-9271-444D-AC94-53ADC9C1762B' , N'Под сенью девушек в цвету' , 606 , '102' , '1918-11-30', 'd13f3cca-b9f8-4bc1-96f4-c80583928e55' , '5f9e1269-4354-4d85-95df-a2ca08e77f0c'),

----('A9A0CCA2-DEE1-4D90-9D14-5768237D0BE3' , N'Полая игла' , 813 , '45' , '1909-01-02', '101be2b1-c0af-493e-bbf2-c8d8e4eb826c' , '5f9e1269-4354-4d85-95df-a2ca08e77f0c'),
----('F8D6ECDC-317F-4659-8F4F-5C21BA778233' , N'The Crystal Stopper' , 762 , '78' , '1912-02-03', '101be2b1-c0af-493e-bbf2-c8d8e4eb826c' , '2dca5e44-b06d-4613-bb6a-d3bc91430bfe'),
----('EBCF9746-1DB0-4771-9E51-5D5D9651E1D8' , N'Остров тридцати гробов' , 434 , '98' , '1919-03-04', '101be2b1-c0af-493e-bbf2-c8d8e4eb826c' , '07629571-a507-4bf2-9b81-c4edd0d295d6'),



--('D794C9E7-C99E-49CC-BB98-5D76432BBADE' , N'Ворошиловград' , 442 , '88' , '2010-06-26', 'ff559ae5-64b6-459e-9771-cb36130b3b75' , '64a4df8a-0733-4be9-aaba-c01b4ec3612a'),
--('3DAD2E2B-E965-4E9E-B9A5-5EB842750FE0' , N'Интернат' , 352 , '57' , '2017-09-13', 'ff559ae5-64b6-459e-9771-cb36130b3b75' , '07629571-a507-4bf2-9b81-c4edd0d295d6'),
--('BD8457B8-837B-41A5-9907-5FED42455355' , N'Месопотамия' , 315 , '33' , '2014-08-30', 'ff559ae5-64b6-459e-9771-cb36130b3b75' , '5f9e1269-4354-4d85-95df-a2ca08e77f0c'),

--('64A3FF22-681F-48D9-8AF0-6397A3326B59' , N'Московиада' , 379 , '31' , '1993-01-01', '789a53ab-a54d-4af7-94a5-dd288428a37c' , '07629571-a507-4bf2-9b81-c4edd0d295d6'),
--('8B073918-66CE-4D72-8DB6-6E5926489A3A' , N'Перверзия' , 444 , '54' , '1997-04-22', '789a53ab-a54d-4af7-94a5-dd288428a37c' , '5ad90d2b-9848-42bb-a476-b701a888f40c'),
--('621DB60E-F39A-49A2-BF70-6FFF6A78D206' , N'Рекреации' , 267 , '43' , '1992-03-31', '789a53ab-a54d-4af7-94a5-dd288428a37c' , '07629571-a507-4bf2-9b81-c4edd0d295d6'),

--('287AF7B4-E57D-43CB-A38B-731366081847' , N'Место для дракона' , 96 , '89' , '1990-01-08', '435eee28-e5ea-4ec9-9f01-de884dfd6292' , '17db11d1-f50e-4cf4-9c54-cf1bd45802ea'),
--('1F08847E-3B61-448D-BD7C-74CFB9412A29' , N'Танго смерти' , 169 , '76' , '2012-12-01', '435eee28-e5ea-4ec9-9f01-de884dfd6292' , '4a550d3b-d1f2-40ef-ae4e-963612c6713a'),
--('641B219D-1A87-43BD-ACA9-750580631C20' , N'Весенние игры в осенних садах' , 156 , '82' , '2005-09-21', '435eee28-e5ea-4ec9-9f01-de884dfd6292' , 'dbb32859-03bd-4f81-bf10-c7cee30e42b1'),


--('BD758538-F49D-49E4-A44E-76E872FD9DA9' , N'Семеро братьев' , 267 , '13' , '1970-04-05', '6fb5bca3-2cae-4450-aab5-e0184fd45be9' , '5ad90d2b-9848-42bb-a476-b701a888f40c'),
--('DA012BC0-91F1-48B0-A074-773E2940B30C' , N'Heath cobblers' , 230 , '32' , '1865-01-01', '6fb5bca3-2cae-4450-aab5-e0184fd45be9' , '2dca5e44-b06d-4613-bb6a-d3bc91430bfe'),
--('40953950-0011-4CD2-8F8F-8103CFB9976A' , N'Kullervo' , 342 , '26' , '1864-01-01', '6fb5bca3-2cae-4450-aab5-e0184fd45be9' , '2dca5e44-b06d-4613-bb6a-d3bc91430bfe'),

--('85B26026-E494-4198-BA45-819E29A01F8D' , N'Mr. Boo' , 100 , '23' , '1973-03-03', '46d73a48-3906-44f4-a4b4-e29f1cc40b4f' , '5f9e1269-4354-4d85-95df-a2ca08e77f0c'),
--('7B52C635-99C6-433D-BAF9-8535C5D6C11B' , N'Mestari' , 178 , '53' , '1995-08-10', '46d73a48-3906-44f4-a4b4-e29f1cc40b4f' , '5ad90d2b-9848-42bb-a476-b701a888f40c'),
--('008833AC-E737-4B6C-95EA-85A5C03E0A24' , N'Лошадь, которая потеряла очки' , 78 , '43' , '2019-07-22', '46d73a48-3906-44f4-a4b4-e29f1cc40b4f' , '17db11d1-f50e-4cf4-9c54-cf1bd45802ea'),

--('7B29B4F6-C3B2-4756-9FC8-861EC9DC3A3D' , N'Год зайца' , 182 , '120' , '1975-01-18', '239450eb-a92f-4093-a74f-eaa38f8adbe2' , '7b08197b-c55f-4389-891f-bf12a575dffb'),
--('4431416E-1274-46CC-8F4F-864DA3B851A6' , N'Воющий мельник' , 257 , '117' , '1981-10-22', '239450eb-a92f-4093-a74f-eaa38f8adbe2' , '7b08197b-c55f-4389-891f-bf12a575dffb'),
--('3287666A-3620-4787-9747-8A3267964D79' , N'Нежная отравительница' , 239 , '94' , '1988-02-10', '239450eb-a92f-4093-a74f-eaa38f8adbe2' , '07629571-a507-4bf2-9b81-c4edd0d295d6'),


--('9D8814E2-2C24-4866-9FA6-8F4768903BA8' , N'Судья и его палач' , 569 , '35' , '1951-03-31', '6cbea09e-e3e4-4dd3-a6c5-ed9ccd986bc0' , '5f9e1269-4354-4d85-95df-a2ca08e77f0c'),
--('A535CBD8-8393-4573-93EE-92F8981FE0F0' , N'Обещание' , 780 , '65' , '1958-01-01', '6cbea09e-e3e4-4dd3-a6c5-ed9ccd986bc0' , '2dca5e44-b06d-4613-bb6a-d3bc91430bfe'),
--('19ED1FBC-7B0F-498B-BE27-93F901799D9C' , N'Правосудие' , 453 , '73' , '1985-01-01', '6cbea09e-e3e4-4dd3-a6c5-ed9ccd986bc0' , '5f9e1269-4354-4d85-95df-a2ca08e77f0c'),

--('5CDB1260-6E8E-47CA-966F-946D44EC58B3' , N'Сиддхартха' , 156 , '78' , '1922-08-17', '23dbe38c-0ed4-4e90-8bc7-f168134e8674' , '5ad90d2b-9848-42bb-a476-b701a888f40c'),
--('3636929A-8001-4381-89AA-95BBC80E7CD9' , N'Степной волк' , 608 , '98' , '1927-04-27', '23dbe38c-0ed4-4e90-8bc7-f168134e8674' , '5f9e1269-4354-4d85-95df-a2ca08e77f0c'),
--('6CB837A6-9B2C-499A-AFEE-97FC709CAB49' , N'Демиан' , 143 , '49' , '1919-10-10', '23dbe38c-0ed4-4e90-8bc7-f168134e8674' , '07629571-a507-4bf2-9b81-c4edd0d295d6'),

--('DD3F715D-54F7-4308-91E3-9B75648154CC' , N'Назову себя Гантенбайн' , 502 , '120' , '1964-05-23', 'c5f771fb-a645-4ba1-8155-f3f5002b2b89' , '5ad90d2b-9848-42bb-a476-b701a888f40c'),
--('A759F9AB-1E98-4565-A390-9C5C505CCD89' , N'Синяя Борода Монток Человек появляется в эпоху ...' , 389 , '93' , '1979-09-29', 'c5f771fb-a645-4ba1-8155-f3f5002b2b89' , 'dbb32859-03bd-4f81-bf10-c7cee30e42b1'),
--('2120C3EB-5B37-4CE6-9324-9CA6746E5334' , N'An Answer from the Silence' , 130 , '60' , '1937-05-18', 'c5f771fb-a645-4ba1-8155-f3f5002b2b89' , '07629571-a507-4bf2-9b81-c4edd0d295d6')

--INSERT INTO Books
--VALUES 
--('78BE061D-1404-4DFB-BBA2-9519AAE25705' , N'Microsoft Windows' , 150 , '60' , '1937-05-18', 'c5f771fb-a645-4ba1-8155-f3f5002b2b89' , '07629571-a507-4bf2-9b81-c4edd0d295d6'),
--('D6A04A18-9064-4C7A-8EEE-C49422EA41F0' , N'Basic Microsoft' , 170 , '60' , '1937-05-18', 'c5f771fb-a645-4ba1-8155-f3f5002b2b89' , '07629571-a507-4bf2-9b81-c4edd0d295d6')


SELECT * FROM Books ORDER BY 2