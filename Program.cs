
using System.ComponentModel.Design;
using Golestan;

class Program
{

    static void Main(string[] args)
    {
        Menu Show = new Menu();
        while (true)
        {
            IStudentHelper Student = new StudentHelper();
            Show.Show_menu(); 
            string input = Console.ReadLine();
            if (int.TryParse(input, out int s))
            {
                if (s == 1)
                {
                    
                }
                if (s == 2)
                {
                    
                }
                if (s == 3)
                {
                    
                }
                if(s == 4)
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}   