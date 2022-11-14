using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class World
    {
        (Coordinates, char)[] map;
        int size;  // Visar hur stor världen är, sätter manuellt. 

        List<Monster> allMonsters = new List<Monster>() { }; // 
        Player player = new Player();

        public List<Item> tempItem = new List<Item>() { };

        //int score; {get;}
        //int kills;
        //int itemspickedup;

        public void TakeTurn()
        {
            //player.MakeMove();
            //CheckAttack();
            allMonsters.RemoveAll(monster => monster.GetDead() == true);
            foreach(Monster monster in allMonsters)
            {
              //  monster.MakeMove();
            }
        }

        

        public void Spawn(int level)
        {

        }


        public (Coordinates, char)[] CreateMap()
        {

            return map;
        }

        public void Showmap() // inparameter skulle kunna vara score / level beroende på implementation
        {

        }
    }
}
