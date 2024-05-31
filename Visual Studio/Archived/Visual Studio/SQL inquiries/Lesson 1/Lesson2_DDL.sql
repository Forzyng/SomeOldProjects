    /*
ALTER TABLE 
    strings
ADD 
    moment DATETIME,
    price FLOAT
    */

    /*
    ALTER TABLE 
    strings
    DROP COLUMN
    price 
    */

    -- DROP TABLE strings

    -- UPDATE strings SET moment = CURRENT_TIMESTAMP WHERE id < 3
    -- UPDATE strings SET moment = '2021-06-08 18:01:33' WHERE id = 2

    -- SELECT * FROM strings WHERE moment IS NOT NULL

    /*
    NULL - особый смысл - "прочерк в таблице", отсутствие данных
    Все операции с NULL (хотя бы один аргумент NULL) дают результат NULL
    Для сравнения с NULL выделены специальные операторы IS NULL / IS NOT NULL
    */