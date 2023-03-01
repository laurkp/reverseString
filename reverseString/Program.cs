using System.Collections.Generic;

namespace reverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asking for a string as a input
            Console.Write("Please enter a String : ");
            // Using Console.ReadLine() to read the input string
            string theString = Console.ReadLine();
            // Initializing a string variable to an empty string
            string reverseString = string.Empty;
            // Using a foreach loop to reverse the string
            foreach (char c in theString)
            {
                reverseString = c + reverseString;
            }
            Console.Write($"Reverse String is : {reverseString} ");
            Console.ReadLine();
            // Using String.Equals() method to check if the string is a palindrome
            bool equal = String.Equals(theString, reverseString, StringComparison.OrdinalIgnoreCase);
            if (equal == true)
            {
                Console.WriteLine($"The string {theString} is a palindrome");
            } 
            else
            {
                Console.WriteLine($"The string {theString} is not a palindrome");
            }
            Console.ReadLine();
        }
    }
}
