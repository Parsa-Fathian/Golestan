public class Grade
{
    public string StudentId { get; set; }
    public Student Student { get; set; }

    public int LessonId { get; set; }
    public Lesson Lesson { get; set; }

    public float Score { get; set; }
}