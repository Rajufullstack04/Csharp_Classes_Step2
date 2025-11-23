using System;

namespace SimplePolymorphism
{
    //method overloading -- compile polymorphisam
    class Calculator
    {
        // we don't use static void here because we want to create an instance of calculator class to call the methods.
        // Add two integers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Add three integers
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Add two doubles
        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main()
        {
            Calculator calc = new Calculator();

            int sum1 = calc.Add(2, 3);          // calls int Add(int,int)
            int sum2 = calc.Add(2, 3, 4);       // calls int Add(int,int,int)
            double sum3 = calc.Add(2.3, 3.4);   // calls double Add(double,double)

           
            Console.WriteLine($"Sum1 Adding int(a+b) = {sum1}");   // Output: 5
            Console.WriteLine($"Sum2 Adding int(a+b+c) = {sum2}");   // Output: 9
            Console.WriteLine($"Sum3 Adding dabule(a+b) ={sum3}");   // Output: 6.0
        }
    }
}