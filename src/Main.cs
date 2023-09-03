using System;
using ConsoleApplication1;
using Homework2.Homework2Part1;
using Homework2.Homework2Part2;

namespace HomeworkApp
{
    class Program
    {
        static void Main(string[] args )
        {
            MyFirstProgram hw1 = new MyFirstProgram();
            PigLatin hw2Part1 = new PigLatin();
            FahrenheitToCelcius hw2Part2 = new FahrenheitToCelcius();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Select a homework to run:");
                Console.WriteLine("1. Homework 1");
                Console.WriteLine("2. Homework 2");
                Console.WriteLine("3. Exit");
                Console.WriteLine();
                
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        hw1.Run();
                        break;
                    case "2":
                        hw2Part1.Run();
                        Console.WriteLine();
                        hw2Part2.Run();
                        break;
                    case "3":
                        return; // Exit the application
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
