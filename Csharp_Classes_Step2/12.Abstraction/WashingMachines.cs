using System;

namespace MachineSystem
{
    // Abstract base class
    abstract class Machines
    {
        public string Brand { get; set; }
        public int Power { get; set; } // in watts

        // Abstract methods (rules every Machines must follow)
        public abstract void TurnOn();
        public abstract void TurnOff();
        public abstract void Function();

        // Concrete method (common to all Machines)
        public void ShowDetails()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Power: {Power} watts");
        }
    }

    // Derived class(Child class): Washing Machine 
    class WashingMachine : Machines
    {
        public override void TurnOn()
        {
            Console.WriteLine("Washing Machine is now ON.");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Washing Machine is now OFF.");
        }

        public override void Function()
        {
            Console.WriteLine("Washing Machine washes clothes.");
        }
    }

    // Derived class: Refrigerator
    class Refrigerator : Machines
    {
        public override void TurnOn()
        {
            Console.WriteLine("Refrigerator is cooling.");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Refrigerator is turned OFF.");
        }

        public override void Function()
        {
            Console.WriteLine("Refrigerator keeps food fresh.");
        }
    }

    class Program
    {
        static void Main()
        {
            Machines wm = new WashingMachine()
            {
                Brand = "LG",
                Power = 1500
            };
            wm.ShowDetails();
            wm.TurnOn();
            wm.Function();
            wm.TurnOff();

            Console.WriteLine("-------------------------------------------------------");

            Machines fridge = new Refrigerator()
            {
                Brand = "Samsung",
                Power = 800
            };
            fridge.ShowDetails();
            fridge.TurnOn();
            fridge.Function();
            fridge.TurnOff();
        }
    }
}