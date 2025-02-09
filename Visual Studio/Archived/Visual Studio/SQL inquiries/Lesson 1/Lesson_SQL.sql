﻿/*
     SQL - Structured Query Language - Язык структурированных запросов
     Язык "общения" с СУБД
     Общение с СУБД происходит в виде запросов (Query)
     Консоль (редактор SQL) --> СУБД (Сервер) -- Компиляция, выполнение 
                           Результат               <-------------------|
*/
SELECT CURRENT_TIMESTAMP 
/*
     SQL - регистронезависимый (иногда - регистрозависимы имена, созданные пользователем)
     Популярен подход, когда имена, созданные пользователем, и встроенные команды языка
     печатают в разном регистре. Например, команды - ВЕРХНИЙ, имена - нижний

     В SQL разделяются команды работы с данными и метаданными
     DDL - Data Definition Lang - Язык "разметки" - работа с метаданными (Рисуем карандашом)
     DML - Data Manipulation Lang - Язык работы с данными

     DDL:
         CREATE ТИП имя - создание элемента с заданным типом и именем
         DROP - удалить
         ALTER - поменять
     DML:
     SELECT - выборка (чтение)
     INSERT - создание
     DELETE - удаление
     UPDATE - поменять
*/