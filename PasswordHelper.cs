
public class PasswordHelper : IPasswordHelper
{
    private List<Password> Passwords = new List<Password>();
    public void Add()
    {
       Console.WriteLine("Enter your password");
       var p = Console.ReadLine();
       Passwords.Add(new Password
           {
               Pass = p
           });
    }
}