// TODO: Include the namespace that contains INotifyPropertyChanged
using System.ComponentModel;
using System.Data;
using System;
using System.Collections.Generic;

namespace NETInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Document d = new Document("Test Document");
            
            // TODO: implement a delegate to handle the PropertyChanged event -> runs when PropertyChanged
            d.PropertyChanged += delegate(object? sender, PropertyChangedEventArgs e) 
            {
                Console.WriteLine($"Document property changed: {e.PropertyName}");
            };
            
            // TODO: change properties to trigger event
            d.DocName = "My Document";
            d.NeedsSave = true;
            
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}