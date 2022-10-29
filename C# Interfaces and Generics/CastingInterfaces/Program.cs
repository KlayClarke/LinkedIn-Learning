using System;
using System.Collections.Generic;

namespace CastingInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Document d = new Document("Test Document");
            
            // TODO: Use the 'is' operator
            if (d is IStorable)
            {
                d.Save();
            }
            
            // TODO: Use the 'as' operator
            IStorable istor = d as IStorable;
            if (istor != null)
            {
                istor.Load();
            }
            
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}