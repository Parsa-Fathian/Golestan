namespace Golestan;

public class Lesson:IEntity
{
    public int Id { get; set; }
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public int Credits { get; set; }
}