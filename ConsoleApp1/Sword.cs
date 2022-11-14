using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Sword // Bara för tillfället själva svärdet, Kommer använda det här som en static metod bara för att "hålla" svärdet för tillfället. Kan skapa variabeln i World om det är bättre
    {
        static string id;
        static Coordinate[] coordinates;

        public static Coordinate[] Coordinates { get; set; }
        public static void CreateSword(Coordinate playerpos, int swordlength, Direction direction)
        {

        }
    }

    //class Item
    //{
    //    string id;
    //    Coordinate coordinate;
    //}
}
