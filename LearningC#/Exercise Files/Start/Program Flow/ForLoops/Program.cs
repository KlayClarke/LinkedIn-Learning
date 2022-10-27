using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVal = 15;
            int[] nums = new int[] {3, 14, 15, 92, 6};
            string str = "The quick brown fox jumps over the lazy dog";

            // TODO: the basic for loop
            Console.WriteLine("The basic for loop:");

            for (int i = 1; i <= myVal; i++) {
              Console.WriteLine("i is currently {0}",i);
            }

            // TODO: the foreach-in loop can be used to iterate over sequences
            Console.WriteLine("The foreach loop:");

            foreach (int num in nums) {
              Console.WriteLine("num is currently {0}",num);
            }

            // TODO: count the number of o's in the stringsToMap
            Console.WriteLine("Counting:");

            int count = 0;

            foreach (char c in str) {
              if (c == 'o') {
                count++;
              }
            }

            Console.WriteLine("There are {0} o's in the string", count);
    }
    }
}
