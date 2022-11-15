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

        //public bool CompareX(Coordinate other) => x > other.x;
        //public bool CompareY(Coordinate other) => y > other.y;

        public Coordinate Compare(Coordinate other) => new Coordinate(x - other.x, y - other.y);

        public ConsoleKey GenerateInput(Coordinate other)
        {
            Coordinate difference = Compare(other);

            Random rand = new Random();
            int random = rand.Next(0, 2);
            
            if (difference.x == 0)
            {
                return difference.y > 0 ? ConsoleKey.S : ConsoleKey.W;
            }
            if (difference.y == 0)
            {
                return difference.x > 0 ? ConsoleKey.A : ConsoleKey.D;
            }
            if (difference.x > 0 && random == 0)
            {
                return ConsoleKey.A;
            }
            else if (difference.x < 0 && random == 0)
            {
                return ConsoleKey.D;
            }
            else
            { 
                return difference.y > 0 ? ConsoleKey.S : ConsoleKey.W;
            }            
        }

        public Coordinate Add(Direction direction, int steps)
        {
            return direction switch
            {
                Direction.Up => new Coordinate(x, y - steps),
                Direction.Down => new Coordinate(x, y + steps),
                Direction.Left => new Coordinate(x - steps, y),
                Direction.Right => new Coordinate(x + steps, y),
                _ => new Coordinate (x, y)
            };
        }
        public Coordinate CheckOne(Direction direction) => Add(direction, 1);
        public void MoveOne(Direction direction)
        {
            x += direction switch
            {
                Direction.Left => -1,
                Direction.Right => 1,
                _ => 0
            };
            y += direction switch
            {
                Direction.Up => -1,
                Direction.Down => 1,
                _ => 0
            };
        }

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
