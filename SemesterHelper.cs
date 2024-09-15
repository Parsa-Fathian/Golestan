
public class SemesterHelper : ISemesterHelper
{
    private List<Semester> Semesters = new List<Semester>();
    public void Add()
    {
        DateTime Date = DateTime.Now;
        Semesters.Add(new Semester
            {
                Time = Date
            }
            );
    }
}