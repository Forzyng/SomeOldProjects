--INSERT INTO
--    Comments(Id, [Text], Id_Author)
--VALUES
--    (NEWID(), N'SQL - Хватит издеватся надо мной', N'3F2C98A8-5DDE-4C2A-911E-43AA4F69D604')
-- по случайному Id


--UPDATE Comments SET Id_Author = N'0C3D71AF-2DC7-45BF-AFD2-DBBE47471DA2' WHERE [Text] = 'Ya musulman'


--INSERT INTO
--    Comments(Id, [Text], Id_Author)
--VALUES
--    (NEWID(), N'Ya musulman',(SELECT TOP 1 Id FROM Users ORDER BY NEWID ()) )


--INSERT INTO
--    Comments(Id, [Text], Id_Author, Moment)
--VALUES
--    (NEWID(), N'A kto ya?',(SELECT TOP 1 Id FROM Users ORDER BY NEWID ()), 
--        '2021-05-10'
--    + DATEADD(DAY, ABS ( CHECKSUM( NEWID() ) ) % 365, 0)
--    + DATEADD(MINUTE, + ABS ( CHECKSUM( NEWID() ) ) % 1440, 0)
--    + DATEADD(SECOND,  ABS ( CHECKSUM( NEWID() ) ) % 60, 0) )
 

SELECT * FROM Comments

/*

     Любые данные, используемые в запросе, могут быть
   указаны в виде подзапроса. Его необходимо брать в ()
   
     INSERT:
   После имени таблицы ЖЕЛАТЕЛЬНО указывать перечень полей
   1. Не  всегда известен порядок полей в БД, а перечень
      вставляет согласну указанному порядку
   2. Возможны изменения в БД (ALTER), например, добавится 
      новое поле. Тогда запросы без перечня полей станут ошибочными
   
   Поля, не указанные в перечне, заполняются значением 
   по умолчанию, если оно указано при создании таблицы
        MOMENT DATETIME DEFAULT CURRENT_TIMESTAMP
    Иначе - NULL. Если NULL не допустим для данного поля
    (и нет DEFAULT), то запрос завершается ошибкой

*/