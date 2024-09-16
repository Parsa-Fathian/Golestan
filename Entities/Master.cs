public class Master : IEntity
{
    public int Id { get; set; }
    public string MasterNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string StudyField { get; set; }
    public DateTime JoinDate { get; set; }
    public string password { get; set; }
    public string Department { get; set; }
}