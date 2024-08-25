using ChallengeApp;

Employee Employee1 = new Employee("Ewa", "Banach", 26);
Employee Employee2 = new Employee("Monika", "Norwid", 35);
Employee Employee3 = new Employee("Mariusz", "Newton", 50);

Employee1.AddScore(2);
Employee1.AddScore(3);
Employee1.AddScore(8);
Employee1.AddScore(6);
Employee1.AddScore(8);

Employee2.AddScore(3);
Employee2.AddScore(5);
Employee2.AddScore(10);
Employee2.AddScore(9);
Employee2.AddScore(5);

Employee3.AddScore(5);
Employee3.AddScore(3);
Employee3.AddScore(8);
Employee3.AddScore(8);
Employee3.AddScore(3);

List<Employee> Employees = new List<Employee>()
{
    Employee1, Employee2, Employee3
};

int maxResult = -1;
Employee EmployeeWithMaxResult = null;

foreach (var Employee in Employees)
{
    if (Employee.Result > maxResult)
    {
        EmployeeWithMaxResult = Employee;
        maxResult = Employee.Result;
    }
}
Console.WriteLine("");
Console.WriteLine("Najwięcej punktów zdobył pracownik:");
Console.WriteLine(EmployeeWithMaxResult.Name + " " + EmployeeWithMaxResult.Surname);
Console.WriteLine("Wiek: " + EmployeeWithMaxResult.Age);
Console.WriteLine("Maksymalna ilość punktów: " + EmployeeWithMaxResult.Result);
Console.WriteLine("");