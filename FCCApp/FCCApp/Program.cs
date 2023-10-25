using FCCApp;

var employee = new Employee("Dominik", "Bednarz");
employee.AddGrade(2);
employee.AddGrade(2);
employee.AddGrade(6);

var statistics = employee.GetStatistics();
var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();


Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

Console.WriteLine($"AverageWithFor: {statistics2.Average:N2}");
Console.WriteLine($"MinWithFor: {statistics2.Min}");
Console.WriteLine($"MaxWithFor: {statistics2.Max}");

Console.WriteLine($"AverageWithDoWhile: {statistics3.Average:N2}");
Console.WriteLine($"MinWithDoWhile: {statistics3.Min}");
Console.WriteLine($"MaxDoWhile: {statistics3.Max}");

Console.WriteLine($"AverageWithWhile: {statistics4.Average:N2}");
Console.WriteLine($"MinWithWhile: {statistics4.Min}");
Console.WriteLine($"MaxWithWhile: {statistics4.Max}");
