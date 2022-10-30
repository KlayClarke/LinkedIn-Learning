using System;

namespace IntfChallenge
{
    class Player : IRandomizable
    {
        public double num { get; set; }
        
        public void GetRandomNum(double num)
        {
            double sample = new Random().NextDouble();
            double scaled = (sample * num);
            Console.WriteLine($"Random number between 0 and {num}: {scaled}");
        }
        
        
    }
}