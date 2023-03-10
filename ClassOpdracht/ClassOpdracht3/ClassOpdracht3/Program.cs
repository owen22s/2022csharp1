using System;

namespace ClassOpdracht3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //we gaan de static ontsnappen

            //1) maak een nieuwe class aan die je GameEngine noemt       (gebruik rechter muis op het project ClassOpdracht3->add->new class

            GameEngine engine = new GameEngine();

            //3)  plak deze function hieronder in GameEngine:
           
           

            //4) roep hier de rungameloop aan 
           engine.RunGameLoop();    


        }
    }
}