using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Types;
using Managers;
using Types.Concrete;

namespace Employees.Pages;

public class IndexModel(ILogger<IndexModel> logger) : PageModel
{
    private readonly ILogger<IndexModel> _logger = logger;
    public static List<Employee> Employees = [
        .. EmployeeManager.Generate(10),
        new Contractor() { Name = "Sara Diamond", Department = "Software Development", ContractLength = 24, Rate = 75000 }
    ];

    public void OnGet()
    {
    }

    public IActionResult OnPostAdd()
    {
        Employees.Add(EmployeeManager.Generate());
        return RedirectToPage();
    }

    public IActionResult OnGetTable()
    {
        return Partial("_EmployeeTable", this); // Return the table for AJAX reload
    }

    public IActionResult OnPostDelete(int id)
    {
        Employees = [.. Employees.Where(employee => employee.Id != id)];
        return OnGetTable();
    }

    public IActionResult OnPostSave(int id, string name, string department)
    {
        var employee = Employees.FirstOrDefault(e => e.Id == id);
        if (employee != null)
        {
            employee.Name = name;
            employee.Department = department;
        }
        return RedirectToPage();
    }
}
