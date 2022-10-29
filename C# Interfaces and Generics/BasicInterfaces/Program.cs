using System;
using System.Collections.Generic;

namespace BasicInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Document d = new Document("Test Document");
            
            // TODO: Exercise the IStorable interface
            d.Load();
            d.Save();
            
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}