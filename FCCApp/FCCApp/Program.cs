using FCCApp;
using System.ComponentModel;

Console.WriteLine("Witamy w programie do oceny użytkowników!");
Console.WriteLine();
Console.WriteLine("Pamiętaj, że jeśli chcesz wyjść to wpisz q");
Console.WriteLine();
Console.WriteLine("Gotowy? (potwierdź jakim kolwiek klawiszem)");
Console.WriteLine();

var inp = Console.ReadKey();

if (inp != null )
{
    Console.Clear();
}

Console.WriteLine("Wybierz co chcesz zrobić (zatwierdź klawiszem enter):");
Console.WriteLine("1. Dodać oceny dla pracownika");
Console.WriteLine("2. Wyświetlić statystyki dla pracownika");
Console.WriteLine();

var employee = new EmployeeInFile("Dominik", "Bednarz");
employee.GradeAdded += EmployeeGradeAdded;

var menuInput = Console.ReadLine();

switch (menuInput)
{
    case "1":
        Console.Clear();
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
        break;
    case "2":
        Console.Clear();
        var statistics = employee.GetStatistics();
        Console.WriteLine($"Average: {statistics.Average:N2}");
        Console.WriteLine($"Min: {statistics.Min}");
        Console.WriteLine($"Max: {statistics.Max}");
        Console.WriteLine($"Average letter: {statistics.AverageLetter}");
        break;
}

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}