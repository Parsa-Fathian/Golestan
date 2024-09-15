
public class DepartmentHelper : IDepartmentHelper
{
    public List<Department> Departments = new List<Department>();
    public void Add()
    {
        Console.WriteLine("Enter Department name:");
        var DName = Console.ReadLine();
        Departments.Add(new Department
            {
                Name = DName
            });
    }
}