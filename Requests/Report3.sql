SELECT	DISTINCT Dep.[Name] as DepartmentName, 
		Emp2.[Name] as EmployeeName,
		Emp2.[Salary] as Salary
FROM Employee AS Emp1
JOIN Employee AS Emp2 ON Emp1.[chief_id] = Emp2.[id]
INNER JOIN [TestTask].[dbo].[Department] AS Dep ON Emp1.[Department_id] = Dep.[id] order by Emp2.[Salary] desc