
using System.ComponentModel.Design;

class Program
{
    class menu
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
    }

    static void Main(string[] args)
    {
        menu Show = new menu();
        while (true)
        {
            Show.Show_menu(); 
            string input = Console.ReadLine();
            if (int.TryParse(input, out int s))
            {
                
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}   