SELECT                        -- ВЫБОР
    U.Id AS UUID,             -- Перечень полей
    U.[Login] AS [Login],     -- С указанием табл.
    U.[Name] AS [ФИО]         -- И псевдонимов
FROM
    Users AS U                -- Перечень таблиц с псевдонимами
WHERE 
    U.[Name] LIKE N'%o%'      -- Сравнение по шаблону
ORDER BY                      -- Сортировка результата
    NEWID()                   --U.[Name] DESC             -- ASC (default) / DESC