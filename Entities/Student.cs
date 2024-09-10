
public class Student:IEntity
{
    public int Id { get; set; }
    public string StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string StudyFeild { get; set; }
    public DateTime JoinDate { get; set; }
}