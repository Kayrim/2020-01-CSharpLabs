using System;
using System.Collections.Generic;

namespace lab_37_everything
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] names = { "Joe ", "John ", "Max " };
            Random rnd = new Random();
            Dad father = new Dad();
            

            List<Mum> family = new List<Mum>();
            for (int i = 0; i < 12; i++)
            {
                family.Add(new Child());
                family[i].name = names[rnd.Next(0,2)];
            }

            Console.WriteLine(father.FathersBlessing(family[rnd.Next(family.Count)].name));

            Queue<Mum> children = new Queue<Mum>();
            int x = 0;
            while (x<4)
            {
                children.Enqueue(new Child());
                children.Peek().name = names[rnd.Next(0,2)];
                x++;
            }

            Stack<Mum> kids = new Stack<Mum>();
            int y = 0;
            do
            {
                kids.Push(new Child());
                y++;
            } while (y<8);

            Dictionary<int, Mum> familyTree = new Dictionary<int, Mum>();

            for (int i = 0; i < 6; i++)
            {
                familyTree.Add(i, new Child());
            }

            Console.WriteLine($"The are {family.Count} children in this list");
            Console.WriteLine($"The are {children.Count} children in this queue");
            Console.WriteLine($"The are {kids.Count} children in this stack");
            Console.WriteLine($"The are {familyTree.Count} children in this dictionary");
            family[1].favouriteQuote();
        }
    }

    abstract class Mum
    {
        private int age;

        public string name { get; set; }

        public Mum()
        {

        }
        public Mum(int age)
        {
            this.age = age;

        }

        public abstract bool isAlive();

        public virtual void favouriteQuote()
        {
            Console.WriteLine("Forgive and Forget");
        }
    }

    internal class Child : Mum {

        public string childsName { get; set; }

        public override bool isAlive()
        {
            return true;
        }

        public override void favouriteQuote()
        {
            Console.WriteLine("To live and let Die");
        }
    }

    public sealed class Dad
    {
        public string FathersBlessing(string name)
        {
            return name + "has his fathers blessing but not his genes";
        }

        
    }

   
}
