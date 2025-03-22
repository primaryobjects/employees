using Types;
using Types.Concrete;

namespace Managers;

public static class EmployeeManager
{
    /// <summary>
    /// Generates a random first and last name.
    /// </summary>
    /// <returns>string</returns>
    private static string RandomName()
    {
        string[] firstNames = ["John", "Jane", "Alex", "Emily", "Chris", "Taylor"];
        string[] lastNames = ["Smith", "Johnson", "Brown", "Williams", "Jones", "Davis"];

        Random random = new ();
        string firstName = firstNames[random.Next(firstNames.Length)];
        string lastName = lastNames[random.Next(lastNames.Length)];

        return $"{firstName} {lastName}";
    }

    /// <summary>
    /// Generate a random department.
    /// </summary>
    /// <returns>string</returns>
    private static string RandomDepartment()
    {
        string[] departments = ["IT", "HR", "InfoSec", "CTO", "TechOps", "Infrastructure", "CFO", "Management", "Engineering", "Marketing", "Art", "Facilities"];

        Random random = new();
        return departments[random.Next(departments.Length)];

    }

    /// <summary>
    /// Generates a random employee.
    /// </summary>
    /// <returns>Employee</returns>
    public static Employee Generate()
    {
        Random random = new();

        Employee employee = random.Next(2) % 2 == 0 ?
            new SalaryEmployee()
            {
                Name = EmployeeManager.RandomName(),
                Department = EmployeeManager.RandomDepartment(),
                Salary = random.Next(25000, 300000)
            } :
            new HourlyEmployee()
            {
                Name = EmployeeManager.RandomName(),
                Department = EmployeeManager.RandomDepartment(),
                HourlyRate = random.Next(15, 100)
            };
        
        return employee;
    }

    /// <summary>
    /// Generates multiple random employees.
    /// </summary>
    /// <param name="count">int</param>
    /// <returns>Employee</returns>
    public static IEnumerable<Employee> Generate(int count)
    {
        List<Employee> employees = [];

        for (var i=0; i<count; i++)
        {
            employees.Add(EmployeeManager.Generate());
        }

        return employees;
    }
}
