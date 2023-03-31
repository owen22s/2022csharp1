using PropertyOpdracht1;
using System;

namespace PropertyOpdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Hond huisdier = new Hond("kattig");

            
            // huisdier.Naam = "magniet";

            Console.WriteLine($"De naam van mijn hond is {huisdier.Naam}");
        }
    }
}
