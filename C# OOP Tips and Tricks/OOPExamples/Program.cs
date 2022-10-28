using System;

namespace OOPExamples
{
  class Program
  {
    static void Main(string[] args)
    {
      var comp = new Computer("Generic computer"); // able to access classes in same namespace -> in this case, OOPExamples
      
      Console.WriteLine(comp.GetType()); // "OOPExamples.Computer" -> namespace.class
      
      var isComputer = comp is Computer;
      
      Console.WriteLine("Is computer - " + isComputer); // "Is computer - True"
      Console.WriteLine("Computer name - " + comp.name); // "Generic computer"
      
      comp.TogglePower();
      comp.TogglePower();
      Console.WriteLine(comp.isOn);
      
      Console.Read();
    }
  }
}
