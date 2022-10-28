using System;

namespace OOPExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var comp = new Desktop("Generic Computer", Desktop.CaseType.Tower); // able to access classes in same namespace -> in this case, OOPExamples
            // var comp2 = new Laptop("Generic Laptop", 1024, 768); // will throw error because caseType and ToggleSleep are exclusive to Desktop -> technical debt
            
            Console.WriteLine(comp.GetType()); // "OOPExamples.Computer" -> namespace.class
            
            var isComputer = comp is Computer;
            
            Console.WriteLine("Is computer - " + isComputer); // "Is computer - True"
            Console.WriteLine("Computer name - " + comp.name); // "Generic computer"
            Console.WriteLine("Case type - " + comp.caseType); // "Tower"
            
            comp.TogglePower();
            Console.WriteLine("Computer is on - " + comp.isOn);
            
            comp.ToggleSleep();
            Console.WriteLine("Computer is sleeping - " + comp.isOn);
            
            comp.TogglePower();
            Console.WriteLine("Computer is on - " + comp.isOn);
            
            
            Console.Read();
        }
    }
}
