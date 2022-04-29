-- Суммарную зарплату в разрезе департаментов (без руководителей)
SELECT	Dep.[Name] AS DepartmentName,
		sum(Emp.[Salary]) AS SummSalary 
FROM [TestTask].[dbo].[Employee] AS Emp 
INNER JOIN [TestTask].[dbo].[Department] AS Dep ON Emp.[Department_id] = Dep.[id] WHERE Emp.[Chief_id] != '' GROUP BY Dep.[Name] 

-- Суммарную зарплату в разрезе департаментов (с руководителями)
SELECT  DepartmentName, 
		sum(SummSalary) AS SummSalary 
FROM 
(SELECT	Dep.[Name] AS DepartmentName,
		sum(Emp.[Salary]) AS SummSalary 
FROM [TestTask].[dbo].[Employee] AS Emp 
INNER JOIN [TestTask].[dbo].[Department] AS Dep ON Emp.[Department_id] = Dep.[id] WHERE Emp.[Chief_id] != '' GROUP BY Dep.[Name] 

UNION

SELECT	DISTINCT Dep.[Name], 
		Emp2.[Salary]
FROM Employee AS Emp1
JOIN Employee AS Emp2 ON Emp1.[chief_id] = Emp2.[id]
INNER JOIN [TestTask].[dbo].[Department] AS Dep ON Emp1.[Department_id] = Dep.[id]) AS Report GROUP BY DepartmentName





