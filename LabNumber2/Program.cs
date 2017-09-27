using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ContinueOn = true;
            while (ContinueOn == true)
            {
                int UserNum;

                Console.WriteLine("Enter a number between 1 and 100");
                UserNum = int.Parse(Console.ReadLine());

                if (UserNum % 2 == 1)
                {
                    Console.WriteLine(UserNum + "Odd");
                
                    string UserChoice;
                    Console.WriteLine("Continue? (Y/N)");
                    UserChoice = Console.ReadLine();
                    if (UserChoice == "N")
                    {
                        ContinueOn = false;
                    }
                }
                else if (UserNum >= 2 && UserNum <= 25)
                {
                    Console.WriteLine("Even and less than 25");

                    string UserChoice;
                    Console.WriteLine("Continue? (Y/N)");
                    UserChoice = Console.ReadLine();
                    if (UserChoice == "N")
                    {
                        ContinueOn = false;
                    }

                }
                else if (UserNum % 2 == 0 && UserNum >= 26 && UserNum <= 60)
                {
                    Console.WriteLine("Even");
                    string UserChoice;
                    Console.WriteLine("Continue? (Y/N)");
                    UserChoice = Console.ReadLine();
                    if (UserChoice == "N")
                    {
                        ContinueOn = false;
                    }


                }
                else if (UserNum % 2 == 0 && UserNum >= 60)
                {
                    Console.WriteLine(UserNum + "Even");

                    string UserChoice;
                    Console.WriteLine("Continue? (Y/N)");
                    UserChoice = Console.ReadLine();
                    if (UserChoice == "N")
                    {
                        ContinueOn = false;
                    }
                }
                else
                {
                    Console.WriteLine(UserNum + "Odd");

                    string UserChoice;
                    Console.WriteLine("Continue? (Y/N)");
                    UserChoice = Console.ReadLine();
                    if (UserChoice == "N")
                    {
                        ContinueOn = false;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
