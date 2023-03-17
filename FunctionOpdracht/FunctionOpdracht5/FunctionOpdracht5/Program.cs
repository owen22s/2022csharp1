using System;

namespace FunctionOpdracht5
{
    internal class Program
    {
        string heroName;
        int heroStrength;
        int health;
        string name;

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        private void Run()
        {
            Console.WriteLine("Choose your hero's name:");
            name = Console.ReadLine();
            heroName = GetHeroName();

            Console.WriteLine($"Your hero is called {heroName}");

            SetHeroStrength(9999);

            SetHealth(1000);

            while (!IsHeroDead())
            {
                int damage = RollDamage();

                Console.WriteLine($"Your hero takes {damage} damage");
                DoDamageToHero(damage);

                Console.WriteLine($"Your hero has {health} health");
            }

            Console.WriteLine("Exercise complete!");
        }

        private string GetHeroName()
        {
            Console.WriteLine("Enter hero name:");
            return Console.ReadLine();
        }

        private void SetHeroStrength(int strength)
        {
            heroStrength = strength;
        }

        private bool IsHeroDead()
        {
            return health <= 0;
        }

        private int RollDamage()
        {
            // You can replace this with any method you want to calculate the damage
            Random random = new Random();
            return random.Next(10, 21);
        }

        private void DoDamageToHero(int damage)
        {
            health -= damage;
        }

        private void SetHealth(int health)
        {
            this.health = health;
        }
    }
}