using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Xml.Linq;



namespace AnimalWorld
{
    // Base class
    class LionKing
    {
        // Property with get and set
        public string KName { get; set; }

        public LionKing()
        {
            KName = "Mufasa";

            Console.WriteLine($"King name is : {KName}");
        }

        public LionKing(string CName)
        {
            KName = "Mufasa";

            Console.WriteLine($"King name is:{KName},King Kid Name:{CName}");
        }
    }
    // Derived class(child)
    class Queen : LionKing
    {
        public Queen(string QName)
        {
            QName = "Sarabi";
            Console.WriteLine($"Queen  name is :{QName}");
            Console.WriteLine($"King and Queen are : {KName} and {QName}");
        }

    }
    class Child : LionKing
    {
        public Child()
        {
            
            Console.WriteLine($"Simba child of :{KName} And Sarabi. ");
        }
        public Child (string childName) : base(childName)
        {
            childName = "Simba";
            Console.WriteLine($"My Name is:{childName},I am child of : {KName} And Sarabi");
            Console.WriteLine("I will be the King of pride lands one day.");
            Console.WriteLine(this);  // here this means Childclass not Parentclass

        }
        class Program
        {
            static void Main()
            {
                Queen queen = new Queen("Sarabi");
                Child child = new Child();
                    //Note first here parent of members will be treated first then child


            }
        }


    }
}
  

