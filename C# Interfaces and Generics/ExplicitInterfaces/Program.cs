using System;
using System.Collections.Generic;

namespace ExplicitInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            InterfaceTest testclass = new InterfaceTest();
            testclass.SomeMethod();
            
            // TODO: Call SomeMethod in the two interfaces -> Can resolve naming conflicts this way
            Intf1 i1 = testclass as Intf1;
            i1.SomeMethod();
            
            Intf2 i2 = testclass as Intf2;
            i2.SomeMethod();
            
            Console.WriteLine("\nPress Enter key to continue...");
            Console.ReadLine();
        }
    }
}