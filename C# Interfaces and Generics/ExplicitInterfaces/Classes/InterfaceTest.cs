using System;

namespace ExplicitInterfaces
{
    // TODO: To implement two interfaces with conflicting methods
    class InterfaceTest : Intf1, Intf2
    {
        // TODO: Implement Intf1 and Intf2 SomeMethod
        void Intf1.SomeMethod()
        {
            Console.WriteLine("This is the Intf1 SomeMethod");
        }
        
        void Intf2.SomeMethod()
        {
            Console.WriteLine("This is the Intf2 SomeMethod");
        }
        
        public void SomeMethod()
        {
            Console.WriteLine("This is the class SomeMethod");
        }
    }
}