
public class StudentHelper : IStudentHelper
{
    public List<Student> students = new List<Student>();   
    public void Add()
    {
       Console.WriteLine("Enter StedentId");
       var Id = Console.ReadLine();
       Console.WriteLine("Enter Firstname");
       var Fname = Console.ReadLine();
       Console.WriteLine("Enter Lastname");
       var Lname = Console.ReadLine();
       Console.WriteLine("Enter your studyfeild");
       var major = Console.ReadLine();
       Console.WriteLine("Choose password");
       var pass = Console.ReadLine();
       Console.WriteLine("Enter department");
       var dep = Console.ReadLine();
       students.Add(new Student
           {
               StudentNumber = Id,
               FirstName = Fname,
               LastName = Lname,
               StudyFeild = major,
               JoinDate = DateTime.Now,
               password = pass,
               Department = dep
           });
       Console.WriteLine("Added successful");
    }
    
    public void search()
    {
       Console.WriteLine("Enter StudentId");
       String SId = Console.ReadLine();
       var result =students.Where(i => i.StudentNumber.Contains(SId));
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
        var student = students.FirstOrDefault(s => s.StudentNumber == si);
        if (student != null)
        {
            Console.WriteLine($"Student found:{student.FirstName},{student.LastName}");
        }
        else
        {
            Console.WriteLine("Student not found!");
        }
        Console.ReadKey();
    }
}