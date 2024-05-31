--CREATE TABLE Marks
--(
--[Surname] NVARCHAR(MAX) NOT NULL ,
--[Name] NVARCHAR(MAX) NOT NULL,
--[SecName] NVARCHAR(MAX) NOT NULL,
--[Name_Group] NVARCHAR(MAX) NOT NULL ,
--[AVG_All_Marks] FLOAT NOT NULL,
--[NameOfMin] NVARCHAR(MAX) NOT NULL,
--[OfMin] FLOAT NOT NULL,
--[OfMax] FLOAT NOT NULL,
--[NameOfMax] NVARCHAR(MAX) NOT NULL
--)
--DROP TABLE Marks

--INSERT INTO Marks 
--VALUES
--(N'Носков',	N'Орест',		N'Ярославович', 'KHFA876', 8.6, N'Математика', 5.9, 10.1, N'История'),
--(N'Никитин',	N'Станислав',	N'Брониславович', 'JDFHUI7', 7.3, N'Биология', 6.4, 7.8, N'ИЗО'),
--(N'Воронов',	N'Александр',	N'Леонидович', 'KHFA876', 10.9, N'Английский', 8.2, 11.7, N'Физ-ра'),
--(N'Евдокимов',N'Клим',		N'Викторович', 'JDFHUI7', 9.5, N'Математика', 4.5, 10.6, N'Физика'),
--(N'Жуков',	N'Влад',		N'Виталиевич', 'KHFA876', 11.1, N'Немецкий', 5.6, 9.9, N'Химия'),
--( N'Кулагин',	N'Максим',		N'Вадимович', 'KPOWESF', 9.2, N'Литература', 6.3, 11.2, N'Астрономия')





SELECT Name_Group AS [Group], AVG(AVG_All_Marks) AS [AVG In Group] FROM Marks M WHERE M.Name_Group IN (SELECT Name_Group FROM Marks GROUP BY Name_Group) GROUP BY Name_Group ORDER BY [AVG In Group] DESC


