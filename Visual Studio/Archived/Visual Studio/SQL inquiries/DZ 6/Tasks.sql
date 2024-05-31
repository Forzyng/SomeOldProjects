-- Task 1

--SELECT
--   [Name],
--   [Financing],
--   [Id]
--FROM
--   Departments



-- Task 2

--SELECT
--   [Name] AS [Group Name],
--   [Rating] AS [Group Rating]
--FROM
--   Groups



-- Task 3

--SELECT 
--   MAX([Name]) AS [Name],
--   MAX(Salary) AS [Salary],
--   Premium,
--   COUNT(Premium) * 100.0 / SUM(COUNT(*)) OVER() as 'Percent'
--FROM 
--   Teachers 
--GROUP BY
--   Premium



-- Task 4

--SELECT
--   CONCAT('The dean of faculty ', [Name], ' is ', [Dean])
--FROM
--   Faculties



-- Task 5

--SELECT
--   Surname
--FROM
--   Teachers
--WHERE
--   Position LIKE 'Teacher'
--   AND Salary > 1050
 


-- Task 6

--SELECT 
--   [Name],
--   Financing
--FROM 
--   Departments
--WHERE
--   Financing > 11000
--   AND Financing < 25000
 


-- Task 7

--SELECT 
--   [Name] 
--FROM
--   Faculties
--WHERE 
--   [Name] NOT LIKE 'Software Development'
 


 -- Task 8

--SELECT
--   Surname,
--   Position 
--FROM 
--   Teachers
--WHERE
--   Position NOT LIKE 'Professor'
 


 -- Task 9

--SELECT
--   Surname,
--   Salary,
--   Premium,
--   Position 
--FROM 
--   Teachers
--WHERE
--   Premium >= 160
--   AND Premium <= 550
--   AND  IsAssistant = 1
 


--Task 10

--SELECT 
--   Surname,
--   Salary
--FROM
--   Teachers
--WHERE
--   IsAssistant = 1

 


-- Task 11

--SELECT 
--   Name,
--   Position,
--   EmploymentDate
--FROM
--   Teachers
--WHERE
--   EmploymentDate <= '01-01-2000'
 


-- Task 12

--SELECT
--   [Name] AS [Name of Department]
--FROM 
--   Departments
--WHERE
--   [Name] < 'Software Development'

 

-- Task 13
 
--SELECT 
--   Surname
--FROM
--   Teachers
--WHERE
--   Salary + Premium <= 1200
 


-- Task 14

--SELECT 
--   [Name],
--   Rating
--FROM 
--   Groups
--WHERE
--   Rating >= 2 
--   AND Rating <= 4 
--   AND [Year] = 5
 


-- Task 15

--SELECT
--   Surname  
--FROM 
--   Teachers
--WHERE
--   Salary < 550
--   OR Premium < 200
--   AND IsAssistant = 1
