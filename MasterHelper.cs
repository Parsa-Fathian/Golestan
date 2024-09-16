
public class MasterHelper : IMasterHelper
{
    public List<Master> Masters = new List<Master>();
    public void Add()
    {
        Console.WriteLine("Enter Firstname");
        var FName = Console.ReadLine();
        Console.WriteLine("Enter Lastname");
        var LName = Console.ReadLine();
        Console.WriteLine("Enter field of study");
        var SF = Console.ReadLine();
        Console.WriteLine("Enter MasterId");
        var Id = Console.ReadLine();
        Console.WriteLine("Chose password");
        var pass = Console.ReadLine();
        Console.WriteLine("Enter department");
        var dep = Console.ReadLine();
        Masters.Add(new Master
        {
            FirstName = FName,
            LastName = LName,
            StudyField = SF,
            JoinDate = DateTime.Now,
            MasterNumber = Id,
            password = pass,
            Department = dep
        });
    }
    public void Search()
    {
        Console.WriteLine("Enter StudentId");
        String SId = Console.ReadLine();
        var result =Masters.Where(i => i.MasterNumber.Contains(SId));

        if (result.Any() == false)
        {
            Console.WriteLine("No student found.");
        }
        else
        {
            Console.WriteLine("This student has exsist");
        }
        Console.WriteLine();
    }

    public void Edit()
    {
        Console.WriteLine("Enter studentid to edit");
        string si = Console.ReadLine();
        var student = Masters.FirstOrDefault(s => s.MasterNumber == si);
        if (student != null)
        {
            Console.WriteLine($"Master found:{student.FirstName},{student.LastName}");
        }
        else
        {
            Console.WriteLine("Master not found!");
        }
        Console.ReadKey();
    }
}