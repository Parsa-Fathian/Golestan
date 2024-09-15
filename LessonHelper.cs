
public class LessonHelper : ILessonHelper
{
    private List<Lesson> Lessons = new List<Lesson>();
    public void Add()
    {
        Console.WriteLine("Enter lesson name");
        var name = Console.ReadLine();
        Console.WriteLine("Enter the number of course units");
        int value = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter lesson id");
        var id = Console.ReadLine();
        Lessons.Add(new Lesson
        {
            Name = name,
            LessonId = id,
            Credits = value,
            Date = DateTime.Now
        });
    }

    public void Search()
    {
        Console.WriteLine("Enter StudentId");
        String SId = Console.ReadLine();
        var result =Lessons.Where(i => i.LessonId.Contains(SId));

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
}