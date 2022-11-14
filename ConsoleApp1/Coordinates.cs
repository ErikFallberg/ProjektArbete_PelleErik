using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Coordinates
    {
        public int x;
        public int y;

        public Coordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public bool CompareWith(Coordinates other)
         => this.x == other.x && this.y == other.y;
        
        
        // Generera spawnlocations kan ske här. 

    }
}
