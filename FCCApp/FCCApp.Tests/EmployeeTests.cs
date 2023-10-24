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

        var statisticks = employee.GetStatistics();
        
        Assert.AreEqual(5f, statisticks.Average);
    }
    
    [Test]
    public void MinShouldReturnCorrectValue()
    {
        var employee = new Employee("Dominik", "Bednarz");
        employee.AddGrade(4);
        employee.AddGrade(6);
        employee.AddGrade(5);

        var statisticks = employee.GetStatistics();
        
        Assert.AreEqual(4f, statisticks.Min);
    }
    
    [Test]
    public void MaxShouldReturnCorrectValue()
    {
        var employee = new Employee("Dominik", "Bednarz");
        employee.AddGrade(4);
        employee.AddGrade(6);
        employee.AddGrade(5);

        var statisticks = employee.GetStatistics();
        
        Assert.AreEqual(6f, statisticks.Max);
    }
}