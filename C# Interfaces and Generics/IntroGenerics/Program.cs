using System;
using System.Collections;

namespace IntroGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            
            // // non-generic ArrayList can hold any object
            // ArrayList arrList = new ArrayList();
            // arrList.Add(1);
            // arrList.Add(2);
            // arrList.Add(3);
            // arrList.Add("Four"); // -> causes exception
            
            // TODO: We can tell a Generic List what to hold
            List<int> arrList = new List<int>();
            arrList.Add(1);
            arrList.Add(2);
            arrList.Add(3);
            arrList.Add("Four"); // -> causes build error
            foreach (int i in arrList)
            {
                total += i;
            }
            Console.WriteLine($"The total is {total}!");
            
        }
    }
}