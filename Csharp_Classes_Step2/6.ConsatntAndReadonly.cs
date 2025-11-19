using System;
using System.Runtime.CompilerServices;
class ConstantAndReadonly

{

    //compile time
    //In Compile time - shared across all instances. 


    //readonly  - i and do assing the value in runtime only in consturctor.
    //runtime  Assingted through the constuctror


    const double pi = 3.14159;   // 

    const string MisardCompanySLogin = "Be MAD, Step Forward";

    readonly string cretedDate = "Mar-05-2025";


    public ConstantAndReadonly()
    {
        //this.pi = 10.98;
        this.cretedDate = "April-09-2025";
    }

    public void GetMethod1()
    {
        //this.cretedDate = "Jun-09-2025";
    }




    static void Main()
    {
        ConstantAndReadonly constAndReadOnly = new ConstantAndReadonly();
        Console.WriteLine(constAndReadOnly.cretedDate);  //april-09-2025
        //constAndReadOnly.pi = 10.98;
    }
}



