using System;
using System.Collections.Generic;

namespace MultipleInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Document d = new Document("Test Document");
            
            // TODO: Exercise the interfaces
            d.Load();
            d.Encrypt();
            d.Save();
            d.Decrypt();
            
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}