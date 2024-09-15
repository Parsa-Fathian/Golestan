
public class Lesson : IEntity
{
    public int Id { get; set; }
    public string LessonId { get; set; }
    public string Name { get; set; }
    public int Credits { get; set; }
    public DateTime Date { get; set; }
}