SELECT	TOP 1 Dep.[Name] as DepartmentName, 
		Emp.[Name] as EmployeeName, 
		Emp.[Salary] as Salary
FROM Employee AS Emp
INNER JOIN Department AS Dep ON Emp.[department_id] = Dep.[id] WHERE Emp.[chief_id] != '' ORDER BY Emp.[Salary] DESC