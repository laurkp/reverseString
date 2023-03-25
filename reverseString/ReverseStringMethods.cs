



namespace reverseString
{
    public static class ReverseStringMethods
    {
        /// <summary>
        /// Ask for a input string
        /// </summary>
        /// <returns></returns>
        public static string InputString()
        {
            Console.Write("Please enter a String : ");
            string userString = Console.ReadLine();
            return userString;
        }
        /// <summary>
        /// Prompts the string in reverse
        /// </summary>
        /// <param name="reverse"></param>
        public static void OutputReverse(string reverse) 
        {
            Console.Write($"Reverse String is : {reverse}\n");
        }
        /// <summary>
        /// Prompts if the string is a palindrome
        /// </summary>
        /// <param name="palindrome"></param>
        public static void PalindromeString(string palindrome)
        {
            Console.WriteLine($"The string {palindrome} is a palindrome\n");
        }
        /// <summary>
        /// Prompts if the string is not a palindrome
        /// </summary>
        /// <param name="notPalindrome"></param>
        public static void NotPalindromeString(string notPalindrome)
        {
            Console.WriteLine($"The string {notPalindrome} is not a palindrome\n");
        }
    }
}
