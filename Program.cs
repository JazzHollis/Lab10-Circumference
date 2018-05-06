using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program


    {
        static int NumOfCircles = 0;
        static void Main(string[] args)
        {


            bool repeat = true;
            Circle circle1 = new Circle();//instaniate

            Console.WriteLine("Welcome to the Circle Tester!");
            while (repeat)

            {
                Console.Write("Enter radius: ");

                circle1.Radius = Double.Parse(Console.ReadLine());


                //Calling the methods from the Cicle Class
                Console.WriteLine($"Area:{circle1.CalculateArea()}");
                Console.WriteLine($"Formatted Area:{circle1.CalculatedFormattedArea()}");
                Console.WriteLine($"Circumference:{circle1.CalculateCircumference()}");
                Console.WriteLine($"Formatted Circumference:{circle1.CalculateFormattedCircumference()}");

                // Counts number of circle objects created by user
                NumOfCircles++;

                while (true)
                {
                    Console.WriteLine("Would you like to enter calculate another circle?(y/n)");
                    string input = Console.ReadLine().ToLower();

                    if (input == "y")
                    {
                        break;
                    }

                    else if (input == "n")
                    {
                        Console.WriteLine($"You created {NumOfCircles} circle object(s). Goodbye!");
                        repeat = false;
                        break;
                    }

                    else //validation of user input

                    {
                        Console.WriteLine("Invalid input please enter (y/n) for response.");
                    }


                }

            }

        }
    }
}
