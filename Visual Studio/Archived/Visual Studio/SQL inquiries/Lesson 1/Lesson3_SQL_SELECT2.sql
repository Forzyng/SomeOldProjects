SELECT                        -- ВЫБОР
    CONCAT('UUID = ', U.Id)    
    AS UUID                   -- Конкатенация - соединение строк
FROM
    Users AS U                -- Перечень таблиц с псевдонимами
WHERE 
    U.[Name] LIKE N'%o%'      
ORDER BY                      -- Сортировка результата
    NEWID()                   

