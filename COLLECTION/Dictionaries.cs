namespace COLLECTION;

public class Dictionaries
{
    private Employee[] employees =
    {
        new Employee("CEO", "Marry", 45, 34.4f),
        new Employee("UI", "Jones", 23, 14.4f),
        new Employee("UX", "Quinee", 38, 78.4f),
        new Employee("C#", "King", 22, 57.4f),
    };
    
    Dictionary<int, string> dictionary = new Dictionary<int, string>() //key value 
    {
        {1,"Aston"},
        {7, "Molly"},
        {8, "Marry"},
    };

    private Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();

    public void EmployeesDirectoryMethod()
    {
        foreach (Employee emp in employees)
        {
            employeesDirectory.Add(emp.Role, emp);
        }
        
        string key = "CEO";
        
        
    }
    
}

public class Employee
{
    public string Role { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public float Rate { get; set; }

    public float Salary
    {
        get
        {
            return 8 * 5 * 4 * 12 * Rate;
        }
    }

    public Employee(string role, string name, int age, float rate)
    {
        Role = role;
        Name = name;
        Age = age;
        Rate = rate;
    }
}