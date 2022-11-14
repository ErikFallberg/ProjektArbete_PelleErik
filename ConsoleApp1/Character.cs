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

        protected ConsoleKey direction;  // Vill ändra från en ConsoleKey till en Direction - måste ha en try catch någonstans för att fånga att vi fått in rätt kommando. Dessutom ska man kunna attackera fortfarande.

        public static int health = 20;

        protected Character(char id, Coordinate coordinate)
        {
            this.id = id;
            coordinate = coordinate;
        }
        //public virtual void MakeMove(ConsoleKey input, Monster[] monsters)        // Den här behövs inte när vi har två listor med monsters och players eftersom vi kan kalla på MakeMove. Makemove har inget gemensamt. Move har
        //{                                                                             // Försöker behålla metoderna som public void MakeMove() ifall vi kommer på något vi kan overloada med. Kanske ändra input till direction?
        //    direction = input;
        //    Move(input);
        //}

        protected void Move(ConsoleKey input, Monster[] monsters)
        {
            direction = input;
        }
        // GetDirection för simplifiering. Och i world om vi har flera sprites.
    }

    class Player : Character
    {       
        int swordLength = 1;
        string name;                                        // Namn finns bara för att kunna spara spelhighscore - kanske borde finnas i World istället?

        private Player(char id, int size, string name) : base(id, new Coordinate(size / 2, size / 2))
         => this.name = name;
        
        public static Player CreatePlayer()
        => new Player('0', 20, "Player 1");                     // Konstruktor Player, namnsättningen kan få göras av spelaren istället. (eller i world)

        public void MakeMove(ConsoleKey input, Monster[] monsters)            // Spaghettikod, Kan returnera svärdets positioner istället för en egen Klass.
        {

            if (input == ConsoleKey.Spacebar)
                Attack(monsters);
            else
                Move(input, monsters);                           
        }
        private void Attack(Monster[] monsters)                                 // Enda sättet jag kan komma på för att skapa svärdet är att göra en egen klass av det.
        {
            Sword.CreateSword(coordinate, swordLength, (Direction)direction);
            foreach (Monster monster in monsters)
            {
                foreach (Coordinate swordcoordinate in Sword.Coordinates)
                    if (swordcoordinate == monster.Coordinate)
                    {
                        monster.Dead = true;                                    // istället för GetDead här skulle vi kunna göra så att monstret i sin makemove kollar ifall den är på svärdet och isåfall dödar sig själv.
                    }
            }

        }
    }

    class Monster : Character
    {
        bool dead = false;
        public bool Dead { get; set; }
       

        private Monster(char id) : base(id, Coordinate.SpawnLocation()) { }

        public Monster CreateMonster()                      //Konstruktor för Monster.
            => new Monster('X');
        
          
        
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
