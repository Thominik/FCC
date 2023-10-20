using FCCApp;

Employee employee1 = new Employee("Dominik", "Bednarz", 24);
Employee employee2 = new Employee("Adam", "Nowak", 34);
Employee employee3 = new Employee("Kamil", "Kowal", 14);

employee1.AddScoreToEmployee(10);
employee1.AddScoreToEmployee(1);
employee1.AddScoreToEmployee(4);
employee1.AddScoreToEmployee(10);
employee1.AddScoreToEmployee(6);

employee2.AddScoreToEmployee(1);
employee2.AddScoreToEmployee(1);
employee2.AddScoreToEmployee(1);
employee2.AddScoreToEmployee(1);
employee2.AddScoreToEmployee(-1);

employee3.AddScoreToEmployee(2);
employee3.AddScoreToEmployee(10);
employee3.AddScoreToEmployee(10);
employee3.AddScoreToEmployee(1);
employee3.AddScoreToEmployee(3);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;

Employee employeeWithMaxResult = null;

foreach (Employee employee in employees)
{
    if(employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employeeWithMaxResult.Result;
    }
}

Console.WriteLine($"Najlepszy wynik to: {employeeWithMaxResult.Result}");
Console.WriteLine($"Imię pracownika z najlepszym wynikiem to: {employeeWithMaxResult.Name}");
Console.WriteLine($"Nazwisko pracownika z najlepszym wynikiem to: {employeeWithMaxResult.Surname}");
Console.WriteLine($"Pracownik ten ma lat: {employeeWithMaxResult.Age}");