--create table [Departments]
--(
--	[Id] UNIQUEIDENTIFIER not null primary key,
--	[Financing] money not null check ([Financing] >= 0.0),
--	[Name] nvarchar(100) not null unique check ([Name] <> N'')
--);
--go

----INSERT INTO [Departments]
----VALUES
----(NEWID(), 10000, N'Software Development'),
----(NEWID(), 8000, N'History'),
----(NEWID(), 20000, N'Water Development'),
----(NEWID(), 19000, N'Tongue and Langue Development'),
----(NEWID(), 15000, N'Professional Development'),
----(NEWID(), 25500, N'Alphabet Development')

--create table [Faculties]
--(
--	[Id] UNIQUEIDENTIFIER not null primary key,
--	[Dean] nvarchar(max) not null check ([Dean] <> N''),
--	[Name] nvarchar(100) not null unique check ([Name] <> N''),
--);
--go

----INSERT INTO [Faculties]
----VALUES
----(NEWID(), N'Максим', N'экономика'),
----(NEWID(), N'Андрей', N'Программирование'),
----(NEWID(), N'Артём', N'Экология'),
----(NEWID(), N'Едуард', N'Медецина'),
----(NEWID(), N'Олег', N'Юриспруденция'),
----(NEWID(), N'Виктор', N'История')

--create table [Groups]
--(
--	[Id] UNIQUEIDENTIFIER not null primary key,
--	[Name] nvarchar(10) not null unique check ([Name] <> N''),
--	[Rating] float not null check ([Rating] between 0 and 5),
--	[Year] int not null check ([Year] between 1 and 5)
--);
--go

----INSERT INTO [Groups]
----VALUES
----(NEWID(), N'РПО78А1', 4.4, 5),
----(NEWID(), N'РПP93А1', 4, 5),
----(NEWID(), N'ОВЕ89У4', 3.8, 2),
----(NEWID(), N'ЗЕС45Ш9', 2.7, 2),
----(NEWID(), N'ПАЦ09О0', 5, 4),
----(NEWID(), N'АРТ78О2', 1.2, 5),
----(NEWID(), N'НТК12Т4', 3.6, 3),
----(NEWID(), N'ЛОК63В8', 4.8, 1)


--create table [Teachers]
--(
--	[Id] UNIQUEIDENTIFIER not null primary key,
--	[EmploymentDate] date not null check ([EmploymentDate] >= '1990-01-01'),
--	[IsAssistant] bit not null default 0,
--	[IsProfessor] bit not null default 0,
--	[Name] nvarchar(max) not null check ([Name] <> N''),
--	[Position] nvarchar(max) not null check ([Position] <> N''),
--	[Premium] money not null check ([Premium] >= 0.0) default 0.0,
--	[Salary] money not null check ([Salary] > 0.0),
--	[Surname] nvarchar(max) not null check ([Surname] <> N'')
--);
--go

----INSERT INTO [Teachers]
----VALUES
----(NEWID(), '1992-03-04', 0, 1, N'Катерина', 'Teacher', 1000, 1100, 'Клутонова'),
----(NEWID(), '1992-03-04', 1, 0, N'Максим', 'Teacher', 800, 2100, 'Жытенко'),
----(NEWID(), '1992-03-04', 1, 0, N'Артём', 'Teacher', 400, 1000, 'Ротов'),
----(NEWID(), '1992-03-04', 0, 1, N'Анастасия', 'Teacher', 1200, 3100, 'Ливкова'),
----(NEWID(), '1992-03-04', 0, 1, N'Олег', 'Teacher', 4000, 1100, 'Лотов')

--DROP TABLE Groups
--DROP TABLE Teachers
--DROP TABLE Faculties
--DROP TABLE Departments


