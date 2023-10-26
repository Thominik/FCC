using FCCApp;

Console.WriteLine("Witamy w programie do oceny użytkowników!");
Console.WriteLine();
Console.WriteLine("Pamiętaj, że jeśli chcesz wyjść to wpisz q");
Console.WriteLine();

var employee = new Employee("Dominik", "Bednarz");

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika:");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}


var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average letter: {statistics.AverageLetter}");
