using System;

namespace lab_13_polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy enemy = new Enemy();
            Enemy ninEnemy = new NinjaEnemy();
            var bruteEnemy = new Enemy();

            enemy.EnemyAttack();
            ninEnemy.EnemyAttack();
            bruteEnemy.EnemyAttack();
        }
    }

    class Enemy
    {
        public virtual void EnemyAttack()
        {
            Console.WriteLine("ENEMY ATTACK!");
        }
    }

    class NinjaEnemy : Enemy
    {
        public override void EnemyAttack()
        {
            Console.WriteLine("Ninja Attack!");
        }
    }

    class BruteEnemy : Enemy
    {
        public override void EnemyAttack()
        {
            Console.WriteLine("BRUTE ATTACK!");
        }
    }
}
