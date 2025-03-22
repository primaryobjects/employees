using Types.Static;

namespace Types;

public abstract class Employee
{
    public int Id { get; } = IdGenerator.GenerateId();
    public required string Name { get; set; }
    public required string Department { get; set; }
    public abstract double AdjustSalary(double percentage);
    public abstract double GetRate();
    override public string ToString()
    {
        return $"{Id} - {Name} - {Department}";
    }
}
