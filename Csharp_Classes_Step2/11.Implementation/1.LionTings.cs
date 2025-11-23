using System;

namespace InterfaceInheritanceWithProperties
{
    // First interface
    interface IAnimal
    {
        string Name { get; set; }   // Property with get/set
        void Eat();
    }

    // Second interface
    interface IWalk
    {
        int Speed { get; set; }     // Property with get/set
        void Walk();
    }

    // Third interface
    interface IRoar
    {
        string Sound { get; set; }  // Property with get/set
        void Roar();
    }

    // Class implementing all three interfaces
    class Lion : IAnimal, IWalk, IRoar
    {
        // Implement properties
        public string Name { get; set; }
        public int Speed { get; set; }
        public string Sound { get; set; }

        // Constructor
        public Lion(string name, int speed, string sound)
        {
            Name = name;
            Speed = speed;
            Sound = sound;
        }

        // Implement methods
        public void Eat()
        {
            Console.WriteLine($"{Name} eats meat.");
        }

        public void Walk()
        {
            Console.WriteLine($"{Name} walks at {Speed} km/h.");
        }

        public void Roar()
        {
            Console.WriteLine($"{Name} roars: {Sound}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Create Lion object
            Lion simba = new Lion("Simba", 20, "ROARRR!");

            // Access properties
            Console.WriteLine($"Lion Name: {simba.Name}");
            Console.WriteLine($"Lion Speed: {simba.Speed}");
            Console.WriteLine($"Lion Sound: {simba.Sound}");

            // Call methods
            simba.Eat();
            simba.Walk();
            simba.Roar();
        }
    }
}