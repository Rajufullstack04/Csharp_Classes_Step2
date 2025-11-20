using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Classes_Step2
{
    // Staatic class: A static class is a class that can not be instantiated.
    // It can only contain static members. Staric classes are used to group related utility methods and properties that do not require an instance of the class to be accessed.
    // all members of static class related to class itself only
    class StaticClassDemo

    {
        // in static class we con't create instance of class(we can't use this keyword inside static class)
        static int age = 25;
        static string name = "Raju";

        static void PrintDetails()
        {
            Console.WriteLine($"Name: {name}\n Age:{age}");

        }
        static string[] getNames()
        {
            return new string[] { "Raju", "Somu", "Ramu", "venu" };
        }
        static void Main()
        {
            // StaticClassDemo demo = new StaticClassDemo(); // Error : Cannot create an instance of the static class 'StaticClassDemo'
            int personAge = StaticClassDemo.age;
            string personName = StaticClassDemo.name;
            Console.WriteLine($"Person Name: {personName}\n Person Age:{personAge}");

            StaticClassDemo.getNames();
            foreach (var n in StaticClassDemo.getNames())
            {
                Console.WriteLine(n);
            }
        }
       

      

    }
}
