namespace FCCApp.Tests;

public class EmployeeTests
{
    [Test]
    public void AverangeShouldReturnCorrectValue()
    {
        var employee = new Employee("Dominik", "Bednarz");
        employee.AddGrade(4);
        employee.AddGrade(6);
        employee.AddGrade(5);

        var statistics = employee.GetStatistics();

        Assert.AreEqual(5f, statistics.Average);
    }

    [Test]
    public void MinShouldReturnCorrectValue()
    {
        var employee = new Employee("Dominik", "Bednarz");
        employee.AddGrade(4);
        employee.AddGrade(6);
        employee.AddGrade(5);

        var statistics = employee.GetStatistics();

        Assert.AreEqual(4f, statistics.Min);
    }

    [Test]
    public void MaxShouldReturnCorrectValue()
    {
        var employee = new Employee("Dominik", "Bednarz");
        employee.AddGrade(4);
        employee.AddGrade(6);
        employee.AddGrade(5);

        var statistics = employee.GetStatistics();

        Assert.AreEqual(6f, statistics.Max);
    }

    [Test]
    public void AverangeLetterShouldReturnCorrectValue()
    {
        var employee = new Employee("Dominik", "Bednarz");
        employee.AddGrade(100);
        employee.AddGrade(50);
        employee.AddGrade(30);

        var statistics = employee.GetStatistics();

        Assert.AreEqual('B', statistics.AverageLetter);
    }

    [Test]
    public void LetterShouldReturnCorrectAverangeValue()
    {
        var employee = new Employee("Dominik", "Bednarz");
        employee.AddGrade('A');
        employee.AddGrade('B');

        var statistics = employee.GetStatistics();

        Assert.AreEqual(90, statistics.Average);
    }

    [Test]
    public void LetterShouldReturnCorrectMinValue()
    {
        var employee = new Employee("Dominik", "Bednarz");
        employee.AddGrade('A');
        employee.AddGrade('B');

        var statistics = employee.GetStatistics();

        Assert.AreEqual(80, statistics.Min);
    }

    [Test]
    public void LetterShouldReturnCorrectAMaxValue()
    {
        var employee = new Employee("Dominik", "Bednarz");
        employee.AddGrade('A');
        employee.AddGrade('B');

        var statistics = employee.GetStatistics();

        Assert.AreEqual(100, statistics.Max);
    }

    [Test]
    public void LetterShouldReturnCorrectAverangeLetterValue()
    {
        var employee = new Employee("Dominik", "Bednarz");
        employee.AddGrade('A');
        employee.AddGrade('D');

        var statistics = employee.GetStatistics();

        Assert.AreEqual('B', statistics.AverageLetter);
    }
}