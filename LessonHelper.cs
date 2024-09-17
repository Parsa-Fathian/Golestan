﻿
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
        Console.WriteLine("Enter lesson major");
        var major = Console.ReadLine();
        Lessons.Add(new Lesson
        {
            Name = name,
            LessonNumber = id,
            Credits = value,
            Date = DateTime.Now,
            major = major
        });
    }

    public void Search()
    {
        Console.WriteLine("Enter StudentId");
        String SId = Console.ReadLine();
        var result =Lessons.Where(i => i.LessonNumber.Contains(SId));
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