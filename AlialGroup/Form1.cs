using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlialGroup
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.textBox.Text = @"Добро пожаловать!
        С помощью данного приложения Вы можете получить отчеты по следующим данным:
        1. Суммарную зарплату в разрезе департаментов (без руководителей и с руководителями).
            Для установки свойства без руководителей / с руководителями
            воспользуйтесь чекбоксом С учетом руководителей
            Для получения отчета нажмите кнопку 1.            
        2. Департамент, в котором у сотрудника зарплата максимальна
            Для получения отчета нажмите кнопку 2.
        3. Зарплаты руководителей департаментов (по убыванию)
            Для получения отчета нажмите кнопку 3.";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string request = string.Empty;
            string responce = string.Empty;

            if (this.checkBox1.CheckState == CheckState.Unchecked)
            {
                request =
                    @"SELECT    Dep.[Name] AS DepartmentName,
                                sum(Emp.[Salary]) AS SummSalary
                    FROM [TestTask].[dbo].[Employee] AS Emp
                    INNER JOIN [TestTask].[dbo].[Department] AS Dep ON Emp.[Department_id] = Dep.[id]
                    WHERE Emp.[Chief_id] != ''
                    GROUP BY Dep.[Name]";
            }
            else if (this.checkBox1.CheckState == CheckState.Checked)
            {
                request =
                    @"SELECT    DepartmentName,
                                sum(SummSalary) AS SummSalary
                    FROM
                    (SELECT	    Dep.[Name] AS DepartmentName,
                                sum(Emp.[Salary]) AS SummSalary
                    FROM [TestTask].[dbo].[Employee] AS Emp
                    INNER JOIN [TestTask].[dbo].[Department] AS Dep ON Emp.[Department_id] = Dep.[id]
                    WHERE Emp.[Chief_id] != ''
                    GROUP BY Dep.[Name]
                    UNION
                    SELECT	    DISTINCT Dep.[Name],
                                Emp2.[Salary]
                    FROM Employee AS Emp1
                    JOIN Employee AS Emp2 ON Emp1.[chief_id] = Emp2.[id]
                    INNER JOIN [TestTask].[dbo].[Department] AS Dep ON Emp1.[Department_id] = Dep.[id]) AS Report
                    GROUP BY DepartmentName";
            }

            responce = Program.MSSQLRequest(request);
            this.textBox.Text = responce + System.Environment.NewLine + @"где:
Значение 1 - Название Департамента
Значение 2 - Суммарная зарплата";
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            string request = string.Empty;
            string responce = string.Empty;

            request =
                    @"SELECT	TOP 1 Dep.[Name] as DepartmentName,
                                Emp.[Salary] as Salary
                    FROM Employee AS Emp
                    INNER JOIN Department AS Dep ON Emp.[department_id] = Dep.[id]
                    WHERE Emp.[chief_id] != ''
                    ORDER BY Emp.[Salary] DESC";

            responce = Program.MSSQLRequest(request);
            this.textBox.Text = responce + System.Environment.NewLine + @"где:
Значение 1 - Название Департамента
Значение 2 - Максимальная зарплата";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string request = string.Empty;
            string responce = string.Empty;

            request =
                    @"SELECT	DISTINCT Dep.[Name] as DepartmentName,
                                Emp2.[Salary] as Salary
                    FROM Employee AS Emp1
                    JOIN Employee AS Emp2 ON Emp1.[chief_id] = Emp2.[id]
                    INNER JOIN [TestTask].[dbo].[Department] AS Dep ON Emp1.[Department_id] = Dep.[id]
                    ORDER BY Emp2.[Salary] DESC";

            responce = Program.MSSQLRequest(request);
            this.textBox.Text = responce + System.Environment.NewLine + @"где:
Значение 1 - Название Департамента
Значение 2 - Зарплата руководителя";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox.Text = @"Добро пожаловать!
        С помощью данного приложения Вы можете получить отчеты по следующим данным:
        1. Суммарную зарплату в разрезе департаментов (без руководителей и с руководителями).
            Для установки свойства без руководителей / с руководителями
            воспользуйтесь чекбоксом С учетом руководителей
            Для получения отчета нажмите кнопку 1.            
        2. Департамент, в котором у сотрудника зарплата максимальна
            Для получения отчета нажмите кнопку 2.
        3. Зарплаты руководителей департаментов (по убыванию)
            Для получения отчета нажмите кнопку 3.";
        }
    }
}
