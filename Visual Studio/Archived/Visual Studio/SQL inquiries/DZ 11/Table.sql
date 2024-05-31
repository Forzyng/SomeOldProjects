--create table [Departments]
--(
--	[Id] UNIQUEIDENTIFIER not null primary key,
--	[Financing] money not null check ([Financing] >= 0.0) default 0.0,
--	[Name] nvarchar(100) not null unique check ([Name] <> N''),
--	[FacultyId] UNIQUEIDENTIFIER not null
--);
--go



--create table [Faculties]
--(
--	[Id] UNIQUEIDENTIFIER not null primary key,
--	[Name] nvarchar(100) not null unique check ([Name] <> N'')
--);
--go


--create table [Groups]
--(
--	[Id] UNIQUEIDENTIFIER not null  primary key,
--	[Name] nvarchar(100) not null unique check ([Name] <> N''),
--	[Year] int not null check ([Year] between 1 and 5),
--	[DepartmentId] UNIQUEIDENTIFIER not null
--);
--go



--create table [GroupsLectures]
--(
--	[Id] UNIQUEIDENTIFIER not null primary key,
--	[DayOfWeek] int not null check ([DayOfWeek] between 1 and 7),
--	[GroupId] UNIQUEIDENTIFIER not null,
--	[LectureId] UNIQUEIDENTIFIER not null
--);
--go



--create table [Lectures]
--(
--	[Id] UNIQUEIDENTIFIER not null primary key,
--	[LectureRoom] nvarchar(max) not null check ([LectureRoom] <> N''),
--	[SubjectId] UNIQUEIDENTIFIER not null,
--	[TeacherId] UNIQUEIDENTIFIER not null
--);
--go


--create table [Subjects]
--(
--	[Id] UNIQUEIDENTIFIER not null  primary key,
--	[Name] nvarchar(100) not null unique check ([Name] <> N'')
--);
--go

--create table [Teachers]
--(
--	[Id] UNIQUEIDENTIFIER not null  primary key,
--	[Name] nvarchar(max) not null check ([Name] <> N''),
--	[Salary] money not null check ([Salary] > 0.0),
--	[Surname] nvarchar(max) not null check ([Surname] <> N'')
--);
--go

--alter table [Departments]
--add foreign key ([FacultyId]) references [Faculties]([Id]);
--go

--alter table [Groups]
--add foreign key ([DepartmentId]) references [Departments]([Id]);
--go

--alter table [GroupsLectures]
--add foreign key ([GroupId]) references [Groups]([Id]);
--go

--alter table [GroupsLectures]
--add foreign key ([LectureId]) references [Lectures]([Id]);
--go

--alter table [Lectures]
--add foreign key ([SubjectId]) references [Subjects]([Id]);
--go

--alter table [Lectures]
--add foreign key ([TeacherId]) references [Teachers]([Id]);
--go





-- Task 1

SELECT
   COUNT(D.Id) AS [Count Departments]
FROM
   Departments D
WHERE
   D.Name LIKE 'Software Development'

-- Task 2

SELECT
   COUNT(L.Id) AS [Count Lectures]
FROM
   Lectures L
   JOIN Teachers T ON L.TeacherId = T.Id
WHERE
   T.Name = 'Dave' AND T.Surname = 'McQueen'

-- Task 3

SELECT 
   COUNt(L.Id) [Count Groups Lectures]
FROM
   Lectures L
WHERE
   L.LectureRoom LIKE 'D201'

-- Task 4

SELECT
   L.LectureRoom AS [Auditoriya],
   COUNT(L.Id) AS [Count Lectures]
FROM
   Lectures L
GROUP BY
   L.LectureRoom

   -- Task 5 -- Здесь нет количества студентов, поэтому посчитал кол-во лекций

SELECT
   COUNT(L.Id) AS [Count Lectures]
FROM
   Lectures L
   JOIN Teachers T ON L.TeacherId = T.Id
WHERE
   T.Name = 'Jack' AND T.Surname = 'Underhill'

-- Task 6

SELECT
   AVG(T.Salary) AS [AVG]
FROM
   Teachers T
   JOIN Lectures L ON T.Id = L.TeacherId
   JOIN Subjects S ON L.SubjectId = S.Id
WHERE
   S.Name = 'Computer Science'

-- Task 7 нету кол-во студентов, поэтому выведу максимальный год среди всех групп

SELECT
   MAX(G.Year) AS [MAX],
   MIN(G.Year) AS [MIN]
FROM 
   Groups G

-- Task 8

SELECT
   AVG(D.Financing) AS [AVG]
FROM
   Departments D


-- Task 9

SELECT
   MAX(T.Name) + ' ' + MAX(T.Surname) AS [Teacher],
   COUNT(L.Id) AS [Count Lectures]
FROM 
   Teachers T
   JOIN Lectures L ON L.TeacherId = T.Id
GROUP BY 
    T.Id


-- Task 10

SELECT
   COUNT(L.Id) AS [Count Lectures]
FROM
   GroupsLectures GR
   JOIN Lectures L ON GR.LectureId = L.Id
GROUP BY 
   GR.DayOfWeek

-- Task 11

SELECT
   MAX(L.LectureRoom) AS [Name],
   COUNT(D.Id) AS [COUNT]
FROM
   Lectures L
   JOIN GroupsLectures Gr ON L.Id = Gr.LectureId
   JOIN Groups G ON Gr.GroupId = G.Id
   JOIN Departments D ON G.DepartmentId = D.Id
GROUP BY
   L.Id

-- Task 12

SELECT
   MAX(F.Name) AS [Name],
   COUNT(D.FacultyId) AS [COUNT]
FROM 
   Faculties F
   JOIN Departments D ON F.Id = D.FacultyId
GROUP BY 
   F.Id

-- Task 13

SELECT
   MAX(T.Name) + ' ' + MAX(T.Surname) AS [Teacher],
   MAX(L.LectureRoom) AS [Room],
   COUNT(L.Id) AS [COUNT]
FROM
   Teachers T
   JOIN Lectures L ON T.Id = L.TeacherId
GROUP BY
   L.Id, T.Id