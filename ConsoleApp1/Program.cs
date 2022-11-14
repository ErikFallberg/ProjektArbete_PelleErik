using System;

namespace ConsoleApp1
{
    class Program
    {
        // Många av klasserna saknar konstruktorer, Dessa kan agera som menyer och för att förändra utseende på spelare etc.

        // Optional features - 
        static void Main(string[] args)
        {
            int turnCounter = 0;
            int level = 0;

            World world = new World();   // CreateMap();

            while(true)
            {
                Console.WriteLine($"Current turn:{turnCounter}. Your life: {Character.health}. Current level: {level}");
                world.Showmap();
                world.TakeTurn();
                world.Spawn(level);

                Console.Clear();

                turnCounter++;
            }

        }
        
    }
}
