using System;
using System.Linq;
namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(IsPalindrome(text.ToLower()));
            Console.Read();
        }
        public static string IsPalindrome(string text)
        {
            //Remove all characters besides letters
            var word = new String(text.Where(c => char.IsLetter(c)).ToArray());
            //Check if te word is a palindrome
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                    return "NO";
            }
            return "YES";
        }
    }
}
