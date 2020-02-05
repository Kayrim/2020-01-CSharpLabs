using System;

namespace lab_37_Interfaces
{

    interface Car
    {
        void Speed(int a);

        void Model(string model);

        void Make(string make);
    }

    interface Window
    {
        void Size(int x, int y);

        void Material(string material);
    }

    class MyCar : Window, Car
    {
        int[] windowSize = new int[2];
        string material;

        int speed;
        string model;
        string make;

        public void Material(string myMaterial)
        {
            material = myMaterial;

        }



        public void Size(int a, int b)
        {
            windowSize[0] = a;
            windowSize[1] = b;
        }

        public void Speed(int sp)
        {
            speed = sp;
        }

        public void Model(string md) 
        {
            model = md;
        }

        public void Make(string mk)
        {
            make = mk;
        }

        public void PrintCar()
        {
            Console.WriteLine($"This car is a {make}, {model} that drives at {speed}mph with windows made of {material} of " +
                $"size {windowSize[0]}cm, {windowSize[1]}cm");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyCar me = new MyCar();
            me.Speed(80);
            me.Make("Audi");
            me.Material("Glass");
            me.Size(50, 50);
            me.Model("RS5");

            me.PrintCar();
            
        }
    }
}
