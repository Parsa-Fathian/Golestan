public class Grade : IEntity
{
    public int Id { get; set; } 
    
    public int StudentId { get; set; }
    public Student Student { get; set; }

    public int LessonId { get; set; }
    public Lesson Lesson { get; set; }  
    
    public int SemesterId { get; set; }
    public Semester Semester { get; set; }
    
    public float Score { get; set; }
}