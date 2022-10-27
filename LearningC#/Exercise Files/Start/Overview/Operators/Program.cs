using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some variables to excercise the operators
            int x=10, y=5;
            string a="abcd", b="efgh";

            // TODO: Basic math operators are +, -, /, *
            Console.WriteLine("----- Basic Math -----");
            Console.WriteLine(x/y); // 2
            Console.WriteLine(x+y); // 15
            Console.WriteLine(x*y); // 50
            Console.WriteLine(x-y); // 5
            Console.WriteLine(a+b); // "abcdefgh"

            // TODO: Increment / decrement operators
            Console.WriteLine("----- Shorthand -----");
            x++;
            y--;
            Console.WriteLine(x); // 11
            Console.WriteLine(y); // 4

            // TODO: Operators can be shorthand: a = a + b
            a += b;
            Console.WriteLine(a); // "abcdefgh"

            // TODO: Logical operators &&, ||
            Console.WriteLine("----- Logic Operators -----");
            Console.WriteLine(x > y && y >= 5); // False
            Console.WriteLine(x > y || y >= 5); // True


            // null-coalescing operators
            string str = null;
            // TODO: the ?? operator uses left operand if not null, or right one if it is
            Console.WriteLine(str ?? "Unknown string");
            
            // TODO: the ??= operator assigns the right operand if the left one is null
            // it replaces the code:
            // if (variable is null) {
            //    variable = somevalue;
            // }

            str ??= "not null anymore";
            Console.WriteLine(str ?? "Unknown string");

        }
    }
}
