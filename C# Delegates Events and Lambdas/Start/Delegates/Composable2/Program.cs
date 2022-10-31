using System;

namespace Composable2
{
    // declare the delegate type
    public delegate void MyDelegate(int arg1, ref int arg2);

    class Program
    {
        static void func1(int arg1, ref int arg2)
        {
            string result = (arg1 + arg2).ToString();
            arg2 += 20; // because arg2 is passed by ref, its value outside this function is going to change
            Console.WriteLine("The number is: " + result);
        }
        static void func2(int arg1, ref int arg2)
        {
            string result = (arg1 * arg2).ToString(); // arg2 is now equal to 20 more than it was in the prev function
            Console.WriteLine("The number is: " + result);
        }
        static void Main(string[] args)
        {
            MyDelegate f1 = func1;
            MyDelegate f2 = func2;
            // Create a composed delegate from f1 and f2
            MyDelegate f1f2 = f1 + f2;

            int a=10;
            int b=20;

            // call each delegate and then the chain
            Console.WriteLine("Calling the first delegate");
            f1(a, ref b); // 10 + 20 -> add 20 to 20 after result is realized
            Console.WriteLine("Calling the second delegate");
            f2(a, ref b); // 10 * 40 
            // Call the composed delegate
            Console.WriteLine("\nCalling the chained delegates");
            f1f2(a, ref b); // 10 + 40 -> add 20 to 40 after result is realized -> then do 10 * 60 (chained)

        }
    }
}
