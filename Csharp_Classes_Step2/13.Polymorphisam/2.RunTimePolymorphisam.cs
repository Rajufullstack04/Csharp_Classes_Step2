using System;
using System.Collections.Generic;

namespace RuntimePolyVehicles
{
    class Vehicle
    {
        public string Brand { get; set; }
        public int Speed { get; set; }

        // Virtual method
        public virtual void Drive()
        {
            Console.WriteLine($"{Brand} is driving at {Speed} km/h.");
        }
    }

    class Car : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine($"{Brand} car cruises smoothly at {Speed} km/h.");
        }
    }

    class Bike : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine($"{Brand} bike zips through traffic at {Speed} km/h.");
        }
    }

    class Truck : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine($"{Brand} truck hauls cargo at {Speed} km/h.");
        }
    }

    class Program
    {
        static void Main()
        {
            List<Vehicle> vehicles = new List<Vehicle>
            {
                new Car { Brand = "Toyota", Speed = 80 },
                new Bike { Brand = "Yamaha", Speed = 60 },
                new Truck { Brand = "Volvo", Speed = 50 }
            };

            foreach (var v in vehicles)
            {
                v.Drive(); // Runtime polymorphism in action
            }
        }
    }
}