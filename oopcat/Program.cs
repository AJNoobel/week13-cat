using System;

namespace oopcat
{
    class Program
    {
        class Cat
        {
            string name;
            string color;
            double hungriness;

            public Cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                hungriness = 0;

            }

            public string Name
            {
                get { return name; }
            }

            public string Color
            {
                get { return color; }
            }
            public double Hungriness
            {
                get { return hungriness; }
            }

            public void Sleeps()
            {
                Console.WriteLine("Z-z-z-z-z-Z");
                hungriness += 0.2;
            }

            public void meow()
            {
                Console.WriteLine($"{name} says \"eee choza\"");
            }

        }
        static void Main(string[] args)
        {
            Cat myCat = new Cat("Garfield", "ginger");

            while (myCat.Hungriness != 1)
            {
                myCat.Sleeps();
            }

            myCat.meow();
        }
    }
}
