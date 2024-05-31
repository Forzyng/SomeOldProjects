

--create table [Assistants]
--(
--	[Id] UNIQUEIDENTIFIER not null primary key,
--	[TeacherId] UNIQUEIDENTIFIER not null
--);
--go

--create table [Curators]
--(
--	[Id] UNIQUEIDENTIFIER not null  primary key,
--	[TeacherId] UNIQUEIDENTIFIER not null
--);
--go

--create table [Deans]
--(
--	[Id] UNIQUEIDENTIFIER not null primary key,
--	[TeacherId] UNIQUEIDENTIFIER not null
--);
--go

--create table [Departments]
--(
--	[Id] UNIQUEIDENTIFIER not null  primary key,
--	[Building] int not null check ([Building] between 1 and 5),
--	[Name] nvarchar(100) not null unique check ([Name] <> N''),
--	[FacultyId] UNIQUEIDENTIFIER not null,
--	[HeadId] UNIQUEIDENTIFIER not null
--);
--go

--create table [Faculties]
--(
--	[Id] UNIQUEIDENTIFIER not null  primary key,
--	[Building] int not null check ([Building] between 1 and 5),
--	[Name] nvarchar(100) not null unique check ([Name] <> N''),
--	[DeanId] UNIQUEIDENTIFIER not null
--);
--go

--create table [Groups]
--(
--	[Id] UNIQUEIDENTIFIER not null   primary key,
--	[Name] nvarchar(10) not null unique check ([Name] <> N''),
--	[Year] int not null check ([Year] between 1 and 5),
--	[DepartmentId] UNIQUEIDENTIFIER not null
--);
--go

--create table [GroupsCurators]
--(
--	[Id] UNIQUEIDENTIFIER not null primary key,
--	[CuratorId] UNIQUEIDENTIFIER not null,
--	[GroupId] UNIQUEIDENTIFIER not null
--);
--go

--create table [GroupsLectures]
--(
--	[Id] UNIQUEIDENTIFIER not null   primary key,
--	[GroupId] UNIQUEIDENTIFIER not null,
--	[LectureId] UNIQUEIDENTIFIER not null
--);
--go

--create table [Heads]
--(
--	[Id] UNIQUEIDENTIFIER not null   primary key,
--	[TeacherId] UNIQUEIDENTIFIER not null
--);
--go

--create table [LectureRooms]
--(
--	[Id] UNIQUEIDENTIFIER not null   primary key,
--	[Building] int not null check ([Building] between 1 and 5),
--	[Name] nvarchar(10) not null unique check ([Name] <> N'')
--);
--go

--create table [Lectures]
--(
--	[Id] UNIQUEIDENTIFIER not null   primary key,
--	[SubjectId] UNIQUEIDENTIFIER not null,
--	[TeacherId] UNIQUEIDENTIFIER not null
--);
--go

--create table [Schedules]
--(
--	[Id] UNIQUEIDENTIFIER not null   primary key,
--	[Class] int not null check ([Class] between 1 and 8),
--	[DayOfWeek] int not null check ([DayOfWeek] between 1 and 7),
--	[Week] int not null check ([Week] between 1 and 52),
--	[LectureId] UNIQUEIDENTIFIER not null,
--	[LectureRoomId] UNIQUEIDENTIFIER not null
--);
--go

--create table [Subjects]
--(
--	[Id] UNIQUEIDENTIFIER not null   primary key,
--	[Name] nvarchar(100) not null unique check ([Name] <> N'')
--);
--go

--create table [Teachers]
--(
--	[Id] UNIQUEIDENTIFIER not null   primary key,
--	[Name] nvarchar(max) not null check ([Name] <> N''),
--	[Surname] nvarchar(max) not null check ([Surname] <> N'')
--);
--go

--alter table [Assistants]
--add foreign key ([TeacherId]) references [Teachers]([Id]);
--go

--alter table [Curators]
--add foreign key ([TeacherId]) references [Teachers]([Id]);
--go

--alter table [Deans]
--add foreign key ([TeacherId]) references [Teachers]([Id]);
--go

--alter table [Departments]
--add foreign key ([FacultyId]) references [Faculties]([Id]);
--go

--alter table [Departments]
--add foreign key ([HeadId]) references [Heads]([Id]);
--go

--alter table [Faculties]
--add foreign key ([DeanId]) references [Deans]([Id]);
--go

--alter table [Groups]
--add foreign key ([DepartmentId]) references [Departments]([Id]);
--go

--alter table [GroupsCurators]
--add foreign key ([CuratorId]) references [Curators]([Id]);
--go

--alter table [GroupsCurators]
--add foreign key ([GroupId]) references [Groups]([Id]);
--go

--alter table [GroupsLectures]
--add foreign key ([GroupId]) references [Groups]([Id]);
--go

--alter table [GroupsLectures]
--add foreign key ([LectureId]) references [Lectures]([Id]);
--go

--alter table [Heads]
--add foreign key ([TeacherId]) references [Teachers]([Id]);
--go

--alter table [Lectures]
--add foreign key ([SubjectId]) references [Subjects]([Id]);
--go

--alter table [Lectures]
--add foreign key ([TeacherId]) references [Teachers]([Id]);
--go

--alter table [Schedules]
--add foreign key ([LectureId]) references [Lectures]([Id]);
--go

--alter table [Schedules]
--add foreign key ([LectureRoomId]) references [LectureRooms]([Id]);
--go


-- Task 1

SELECT
   Dep.Name AS [Departments name]
FROM
   Teachers T
   JOIN 
   Deans D ON T.Id = D.TeacherId
   JOIN Faculties F ON D.Id = F.DeanId
   JOIN Departments Dep ON F.Id = Dep.FacultyId
WHERE
   T.Name LIKE N'Edward'
   AND T.Surname LIKE N'Hopper'


   -- Task 2

SELECT
   T.Surname + ' ' + T.Name AS [Assistant]
FROM
   Assistants A
   JOIN Teachers T ON A.TeacherId = T.Id
   JOIN Lectures L ON T.Id = L.TeacherId
   JOIN GroupsLectures GL ON L.Id = GL.LectureId
   JOIN Groups G ON GL.GroupId = G.Id
WHERE 
   G.Name LIKE 'F505'


-- Task 3

SELECT
   T.Surname + ' ' + T.Name AS [Teacher],
   S.Name AS [Subjects]
FROM
   Teachers T
   JOIN Lectures L ON T.Id = L.TeacherId
   JOIN Subjects S ON L.SubjectId = S.Id
   JOIN GroupsLectures GL ON L.Id = GL.LectureId
   JOIN Groups G ON GL.GroupId = G.Id
   
WHERE 
   G.Year = 5 AND T.Name LIKE 'Alex' AND T.Surname = 'Carmack'


-- Tasks 4


SELECT
   T.Surname + ' ' + T.Name AS [Teacher]
FROM
   Assistants A
   JOIN Teachers T ON A.TeacherId = T.Id
   JOIN Lectures L ON T.Id = L.TeacherId
   JOIN Schedules S ON L.Id = S.LectureId
WHERE 
   S.DayOfWeek = 1


-- Task 5

SELECT
   Dep.Name AS [Departments name],
   sub.Name AS [Subject]
FROM
   Faculties F
   JOIN Departments Dep ON F.Id = Dep.FacultyId

   JOIN Groups G ON Dep.Id = G.DepartmentId
   JOIN GroupsLectures GP ON G.Id = GP.GroupId
   JOIN Lectures L ON GP.LectureId = L.Id
   JOIN Schedules S ON L.Id  = S.LectureId
   JOIN Subjects sub ON L.SubjectId = sub.Id

   WHERE
   S.Week = 2 AND S.DayOfWeek = 3 AND S.Class = 3

