using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Coordinate
    {
        public int x;
        public int y;

        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public bool CompareWith(Coordinate other)
         => this.x == other.x && this.y == other.y;
        
        
        // Generera spawnlocations kan ske här. 
        public static Coordinate SpawnLocation() // Spawnlocation måste förbättras.
        {
            return new Coordinate(0, 0);
        }
        //public Coordinate[] CreateSwordCoordinates(Coordinate player, int swordlength, ConsoleKey direction)     // Svärdskapare? Annars ha ett svärd som en typ static class AAAH VET INTE
        //{
            
            
        //}

    }
}
