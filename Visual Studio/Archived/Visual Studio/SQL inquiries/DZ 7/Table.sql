--create table [Curators]
--(
--	[Id] UNIQUEIDENTIFIER not null  PRIMARY KEY,
--	[Name] nvarchar(max) not null check ([Name] <> N''),
--	[Surname] nvarchar(max) not null check ([Surname] <> N'')
--);
--go

--create table [Departments]
--(
--	[Id] UNIQUEIDENTIFIER not null  PRIMARY KEY,
--	[Financing] money not null check ([Financing] >= 0.0) default 0.0,
--	[Name] nvarchar(100) not null unique check ([Name] <> N''),
--	[FacultyId] UNIQUEIDENTIFIER not null
--);
--go

--create table [Faculties]
--(
--	[Id] UNIQUEIDENTIFIER not null  PRIMARY KEY,
--	[Financing] money not null check ([Financing] >= 0.0) default 0.0,
--	[Name] nvarchar(100) not null unique check ([Name] <> N'')
--);
--go

--create table [Groups]
--(
--	[Id] UNIQUEIDENTIFIER not null  PRIMARY KEY,
--	[Name] nvarchar(100) not null unique check ([Name] <> N''),
--	[Year] int not null check ([Year] between 1 and 5),
--	[DepartmentId] UNIQUEIDENTIFIER not null
--);
--go

--create table [GroupsCurators]
--(
--	[Id] UNIQUEIDENTIFIER not null PRIMARY KEY ,
--	[CuratorId] UNIQUEIDENTIFIER not null,
--	[GroupId] UNIQUEIDENTIFIER not null
--);
--go

--create table [GroupsLectures]
--(
--	[Id] UNIQUEIDENTIFIER not null  PRIMARY KEY,
--	[GroupId] UNIQUEIDENTIFIER not null,
--	[LectureId] UNIQUEIDENTIFIER not null
--);
--go

--create table [Lectures]
--(
--	[Id] UNIQUEIDENTIFIER not null  PRIMARY KEY,
--	[LectureRoom] nvarchar(max) not null check ([LectureRoom] <> N''),
--	[SubjectId] UNIQUEIDENTIFIER not null,
--	[TeacherId] UNIQUEIDENTIFIER not null
--);
--go

--create table [Subjects]
--(
--	[Id] UNIQUEIDENTIFIER not null PRIMARY KEY,
--	[Name] nvarchar(100) not null unique check ([Name] <> N'')
--);
--go

--create table [Teachers]
--(
--	[Id] UNIQUEIDENTIFIER not null  PRIMARY KEY,
--	[Name] nvarchar(max) not null check ([Name] <> N''),
--	[Salary] money not null check ([Salary] > 0.0),
--	[Surname] nvarchar(max) not null check ([Surname] <> N'')
--);
--go


--DROP TABLE Curators
--DROP TABLE Departments
--DROP TABLE Groups
--DROP TABLE GroupsCurators
--DROP TABLE GroupsLectures
--DROP TABLE Subjects
--DROP TABLE Teachers
--DROP TABLE Faculties
--DROP TABLE Lectures


--alter table [Departments]
--add foreign key ([FacultyId]) references [Faculties]([Id]);
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

--alter table [Lectures]
--add foreign key ([SubjectId]) references [Subjects]([Id]);
--go

--alter table [Lectures]
--add foreign key ([TeacherId]) references [Teachers]([Id]);
--go