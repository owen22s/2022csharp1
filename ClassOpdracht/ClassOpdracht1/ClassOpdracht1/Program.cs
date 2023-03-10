using System;

namespace ClassOpdracht1
{
     //???
    //Schrijf met commentaar(//dit is commentaar) in deze file de naam bij elk onderdeel 
    internal class ClassStructureExercise
    {
        private readonly string accountName;

        internal ClassStructureExercise(string accountName)
        {
            this.accountName = accountName;
        }
        // maakt de string accountName account neem
        internal void ShowGreetingInConsole()
        {
            string greeting = "hello";
            Console.WriteLine(greeting + " " + accountName);
            //zegt de string greeting + de account naam 
        }

        internal void Show1To10()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i.ToString());
            }
            // telt tot 10
        }

        internal double DistBetweenPoints(int x1, int y1, int x2, int y2)
        {

            int dx = x2 - x1;
            int dy = y2 - y1;

            double lengthSquared = (dx * dx) + (dy * dy);

            double length = Math.Sqrt(lengthSquared);
            return length;
            //dobbelt de length

        }
        internal int MultiplyToPower2(int value)
        {
            int result = value * value;
            return result;
        }
        // doet het value keer value 


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //zegt hello world in de console
        }
    }
}