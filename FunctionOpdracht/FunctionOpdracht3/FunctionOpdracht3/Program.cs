using System;

namespace FunctionOpdracht3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Call the AskForAge function
            AskForAge();
        }
        // AskForAge function
        public static void AskForAge()
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            Console.WriteLine($"Your age is {age}");
        }
    }
}