
using System.ComponentModel.Design;
using Golestan;

class Program
{
    static void Main(string[] args)
    {
        Menu Show = new Menu();
        StudentHelper student = new StudentHelper();
        MasterHelper master = new MasterHelper();
        DepartmentHelper department = new DepartmentHelper();
        LessonHelper lesson = new LessonHelper();
        string pass = "pf1380";
        while (true)
        {
            IStudentHelper Student = new StudentHelper();
            Show.Show_menu(); 
            string input = Console.ReadLine();
            if (int.TryParse(input, out int s))
            {
                if (s == 1)
                {
                    
                    Console.Write("Enter Password:");
                    string ps = Console.ReadLine();
                    if(ps == pass)
                    {
                        Show.Admin_menu();
                        string inputAdmin = Console.ReadLine();
                        if (int.TryParse(inputAdmin, out int z))
                        {
                            if (z == 1)
                            {
                                student.Add();
                            }

                            if (z == 2)
                            {
                                master.Add();
                            }

                            if (z == 3)
                            {
                                department.Add();
                            }

                            if (z == 4)
                            {
                                lesson.Add();
                            }

                            if (z == 5)
                            {
                                student.Edit();
                            }

                            if (z == 6)
                            {
                                master.Edit();
                            }

                            if (z == 7)
                            {
                                student.search();
                                
                            }

                            if (z == 8)
                            {
                                master.Search();
                            }

                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong!please enter correct form ");
                    }

                }
                if (s == 2)
                {
                    
                }
                if (s == 3)
                {
                    
                }
                if(s == 9)
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