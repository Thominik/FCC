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

    try
    {
        employee.AddGrade(input);
    }   
    catch (Exception ex)
    {
        Console.WriteLine($"Exception catched: {ex.Message}");
    }
}

var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average letter: {statistics.AverageLetter}");
