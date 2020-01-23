using System;

namespace lab_13_polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon kn = new Knife();
            kn.Attack();
        }
    }

    class Weapon
    {
        public int dmg = 0;

        public virtual void Attack() {
            Console.WriteLine("I dont have a weapon - no damage");
        }
        
    }

    class Knife : Weapon
    {
        
        public override void Attack()
        {
            Console.WriteLine("I have a knife - 10 damage");
        }

    }
}
