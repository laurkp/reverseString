using System.Collections.Generic;
using System.Transactions;

namespace reverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asking for a string as a input
            string inputString = ReverseStringMethods.InputString();

            // Initializing a string variable to an empty string
            string reverseString = string.Empty;

            // Using a foreach loop to reverse the string
            foreach (char c in inputString)
            {
                reverseString = c + reverseString;
            }
            ReverseStringMethods.OutputReverse(reverseString);

            // Using String.Equals() method to check if the string is a palindrome
            bool equal = String.Equals(inputString, reverseString, StringComparison.OrdinalIgnoreCase);
            if (equal == true)
            {
                ReverseStringMethods.PalindromeString(inputString);
            }
            else
            {
                ReverseStringMethods.NotPalindromeString(inputString); 
            }
        }
    }
}
