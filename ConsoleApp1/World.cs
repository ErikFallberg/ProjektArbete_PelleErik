using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class World
    {
        (Coordinate, char)[] map;
        int size;  // Visar hur stor världen är, sätter manuellt. 

        List<Monster> allMonsters = new List<Monster>() { }; // 

        Player player;

        //public List<Item> sword = null;  // Svärdet sparas som en static "ITEM" (nu sword)
        //
        //int score; {get;}
        //int kills;
        //int itemspickedup;

        public void TakeTurn()
        {
            //Direction input = (Direction)Console.ReadKey().Key;             // Vi kan jobba med direction som en enumerator istället för consolekeys. Up / Down / Left / Right är nu av typen direction.
            ConsoleKey input = Console.ReadKey().Key;
            //player.MakeMove();
            //CheckAttack();
            allMonsters.RemoveAll(monster => monster.Dead == true);
            foreach(Monster monster in allMonsters)
            {
              //  monster.MakeMove();
            }
        }

        

        public void Spawn(int level)
        {

        }


        public (Coordinate, char)[] CreateMap()
        {

            return map;
        }

        public void Showmap() // inparameter skulle kunna vara score / level beroende på implementation
        {

        }
    }
}
