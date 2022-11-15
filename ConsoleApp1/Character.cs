using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
 
    class Character
    {
        char id;
        protected Coordinate coordinate;
        public Coordinate Coordinate { get; }

        protected Direction direction = Direction.Up;  // Vill ändra från en ConsoleKey till en Direction - måste ha en try catch någonstans för att fånga att vi fått in rätt kommando. Dessutom ska man kunna attackera fortfarande.

        public static int health = 20;

        protected Character(char id, Coordinate coordinate)
        {
            this.id = id;
            this.coordinate = coordinate;
        }
        //public virtual void MakeMove(ConsoleKey input, Monster[] monsters)        // Den här behövs inte när vi har två listor med monsters och players eftersom vi kan kalla på MakeMove. Makemove har inget gemensamt. Move har
        //{                                                                             // Försöker behålla metoderna som public void MakeMove() ifall vi kommer på något vi kan overloada med. Men är inte det just nu
        //    direction = input;
        //    Move(input);
        //}

        protected void Move(ConsoleKey input, Monster[] monsters)
        {            
            if (input == ConsoleKey.A || input == ConsoleKey.D || input == ConsoleKey.W || input == ConsoleKey.S)
            {
                direction = (Direction)input;
                foreach (Monster monster in monsters)
                    if (coordinate.CheckOne(direction) == monster.coordinate)
                        return;
                coordinate.MoveOne(direction);
            }
            //direction = input;
        }
        // GetDirection för simplifiering. Och i world om vi har flera sprites.
    }

    class Player : Character
    {       
        int swordLength = 1;
        string name;                // Namn finns bara för att kunna spara spelhighscore - kanske borde finnas i World istället?
        Item[] swords;

        private Player(char id, int size, string name) : base(id, new Coordinate(size / 2, size / 2)) // Konstruktorn är inte injicerad!
         => this.name = name;
        
        public static Player CreatePlayer()
        => new Player('0', 20, "Player 1");                     // Factory Player, namnsättningen kan få göras av spelaren istället. (eller i world)

        public void MakeMove(ConsoleKey input, Monster[] monsters)            // Spaghettikod, Kan returnera svärdets positioner istället för att hålla ett svärd
        {

            if (input == ConsoleKey.Spacebar)
                Attack(monsters);
            else
                Move(input, monsters);                           
        }
        private void Attack(Monster[] monsters)                               
        {
            swords = Item.CreateSword(coordinate, swordLength, direction);
            foreach (Monster monster in monsters)
            {
                foreach (Item sword in swords)
                    if (sword.Coordinate == monster.Coordinate)
                    {
                        monster.Dead = true;                                    // istället för GetDead här skulle vi kunna göra så att monstret i sin makemove kollar ifall den är på svärdet och isåfall dödar sig själv.
                    }
            }

        }
    }

    class Monster : Character
    {
        public bool Dead { get; set; }


        private Monster(char id, Direction direction) : base(id, Coordinate.SpawnLocation())
            => this.direction = direction;

        public Monster CreateMonster()                      //Konstruktor för Monster. Börjar alltid kollandes neråt, kanske kan fixas till att kolla på spelaren???
            => new Monster('X', Direction.Down);
        
          
        
        public void MakeMove(ConsoleKey input, Monster[] monsters)
        {
            if (!MonsterAttack())
            {
                input = GenerateInput();
                Move(input, monsters);
            }
        }
        private ConsoleKey GenerateInput()
        {

            return ConsoleKey.Decimal;
        }
        private bool MonsterAttack()
        {
            //if (coordinate.CheckOne(direction) == )                 //FIX
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
