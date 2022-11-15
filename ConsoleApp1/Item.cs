using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //class Sword // Bara för tillfället själva svärdet, Kommer använda det här som en static metod bara för att "hålla" svärdet för tillfället. Kan skapa variabeln i World om det är bättre
    //{

    //}

    class Item
    {
        char id;
        public Coordinate Coordinate { get; private set; }

        private Item(char id, Coordinate coordinate)
        {
            this.id = id;
            this.Coordinate = coordinate;
        }

        public static Item[] CreateSword(Coordinate coordinate, int swordlength, Direction direction)
        {
            Item[] sword = new Item[swordlength];

            for (int i = 0; i < swordlength; i++)
            {
                sword[i] = direction switch
                {
                    Direction.Up => new Item('|', coordinate.Add(direction, i)),
                    Direction.Down => new Item('|', coordinate.Add(direction, i)),
                    Direction.Left => new Item('-', coordinate.Add(direction, i)),
                    Direction.Right => new Item('-', coordinate.Add(direction, i)),
                    _ => throw new Exception("Direction is wrong, Direction can't be anything but down right up left!!!")
                };
            }
            return sword;
        }
    }
}
