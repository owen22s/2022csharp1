using System;

namespace FunctionOpdracht4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program= new Program();


            int result = program.AddNumbers(2, 6, 18);

            Console.WriteLine("should be 26?");
            Console.WriteLine(result);
        }


        //1) maak hier een function AddNumbers die 3 argumenten heeft
        //2) de function telt de 3 argumenten bij elkaar op en geeft dat als resultaat terug
        public int AddNumbers(int num1, int num2, int num3)
        {
            int sum = num1 + num2 + num3;
            return sum;
        }
    }

}
