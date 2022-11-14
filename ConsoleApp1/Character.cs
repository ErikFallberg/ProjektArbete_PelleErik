using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Character
    {
        char id;
        Coordinates coordinate;
        ConsoleKey direction;

        public static int health;


        public virtual void MakeMove(ConsoleKey input, Monster[] monsters)
        {
            Move(input);
        }

        protected void Move(ConsoleKey input)
        {

        }
        // GetDirection för simplifiering. Och i world om vi har flera sprites.
    }

    class Player : Character
    {
        int SwordLength = 1;
        // Namn på spelare för att spara

        public override void MakeMove(ConsoleKey input, Monster[] monsters)
        {
            if (!Attack(monsters))
            base.MakeMove(input, monsters);
        }
        private bool Attack(Monster[] monsters)
        {
            //foreach (Monster monster in monsters)
            //{
            //    if (monster ==)
            //    {
            //        monster.dead = true;
            //    }
            //}
            return false;
        }
    }

    class Monster : Character
    {
        bool dead = false;

        public bool GetDead() => dead;

        public override void MakeMove(ConsoleKey input, Monster[] monsters)
        {
            if (!MonsterAttack())
            {
                input = GenerateInput();
                Move(input);
            }
        }
        private ConsoleKey GenerateInput()
        {
            return ConsoleKey.Decimal;
        }
        private bool MonsterAttack()
        {

            return false;
        }
    }





    //class Base
    //{
    //    string id;

    //    bool isplayer;
        
    //    public virtual void Metod()
    //    {
    //        switch (input)

    //    }
            
        
    //}
    //class Derived1 : Base
    //{
        
    //    public override Metod()
    //    {
    //        input == attack
    //                attack();
    //            else
    //        base.Move();

    //    }
    //    Attack()
    //        {
    //            attack = new item (coordinate, id) ;
    //        }
    //}
    //class Derived2 : Base
    //{
    //        attackcoordinates
    //    public override void Metod(Input , character[])
    //    {
    //            Generateinput();
    //        base.Metod();
    //            Attack();
    //    }
    //        Attack ()
    //        {
    //            awttackcoordinates. 
    //            foreach()
    //                foreach attackcoordinate
    //                character.getype == player && character corrdaintes = attackcoordinates.
            
    //            foreach (potential attackcoordinate)
                    
                            
    //                        }
    //}
}
