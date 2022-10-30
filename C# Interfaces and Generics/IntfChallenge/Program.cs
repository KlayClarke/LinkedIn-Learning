using System;

namespace IntfChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Player pl = new Player();
            
            do {
                Console.WriteLine("Enter a number for the upper bound");
                str = Console.ReadLine();
                
                
                try {
                    double upperBound = double.Parse(str);
                    pl.GetRandomNum(upperBound);
                } 
                catch (Exception) {}
                
            } while (str != "exit");
        }
    }
}