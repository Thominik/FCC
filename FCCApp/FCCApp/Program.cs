using FCCApp;

var employee = new Employee("Dominik", "Bednarz");
employee.AddGrade(2d);
employee.AddGrade(2);
employee.AddGrade('A');

var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average letter: {statistics.AverageLetter}");
