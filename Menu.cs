namespace Golestan;
public class Menu : IMenu
{
    public void Show_menu()
    {
        Console.WriteLine("\n\n Golestan");
        Console.WriteLine("1.Admin");
        Console.WriteLine("2.student");
        Console.WriteLine("3.master");
        Console.WriteLine("4.Exit");
        Console.Write("Select an option: ");
    }
    public void Admin_menu()
    {
        Console.WriteLine("1.Add student");
        Console.WriteLine("2.Add Master");
        Console.WriteLine("3.Add department");
        Console.WriteLine("4.Add lesson");
        Console.WriteLine("5.Edit Student");
        Console.WriteLine("6.Edit master");
        Console.WriteLine("7.Search student by studentid");
        Console.WriteLine("8.Search student by masterid");
    }
    public void Student_menu()
    {
        Console.WriteLine("1.Unit selection");
        Console.WriteLine("2.Show grades");
    }
    public void Master_menu()
    {
        Console.WriteLine("1.Enter student grade");
        Console.WriteLine("2.Choosing a lesson to teach");
    }
}
