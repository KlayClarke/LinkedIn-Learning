using System;

namespace ProgChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
          bool play = true;
          Console.WriteLine("Let's begin: ");
          
          while (play) 
          {
            string input = Console.ReadLine();
            if (input == "exit") 
            {
              play = false;
            }
            else 
            {
              (bool palindrome, int length) = IsPalindrome(input);
              Console.WriteLine($"Palindrome: {palindrome}, Length: {length}");   
            }
          }
          
          Console.WriteLine();
        }
        static (bool, int) IsPalindrome(string str) 
        {
          int length = str.Length;
          int left = 0, right = length-1;
          while (left <= right) 
          {
            if (char.IsPunctuation(str[left]) || str[left] == ' ') 
            {
              left++;
            }
            else if (char.IsPunctuation(str[right]) || str[right] == ' ')
            {
              right--;
            }
            else if (char.ToLower(str[left]) != char.ToLower(str[right])) 
            {
              return (false, 0);
            }
            else {
              left++;
              right--;  
            }
          }
          return (true, length);
        }
    }
}
