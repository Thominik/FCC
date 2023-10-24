using FCCApp;

var employee = new Employee("Dominik", "Bednarz");
employee.AddGrade(2f);
employee.AddGrade(2);
employee.AddGrade(6d);

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");