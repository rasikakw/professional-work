using System;
using System.Collections.Generic;

namespace Palindrome
{
    /// <summary>
    /// Program.
    /// </summary>
    class Program
    {
        private const string Line1 = "------------------------------------------------------------------";
        private const string Line2 = "==================================================================";

        /// <summary>
        /// Application entry point.
        /// </summary>
        /// <param name="args">Arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine($"{Line1}{Environment.NewLine}{Environment.NewLine}");
            Console.WriteLine($"      {Constants.AppName} v{Constants.AppVersion}{Environment.NewLine}{Environment.NewLine}");
            Console.WriteLine($"      Finds all palindromes in a string of text. See https://en.wikipedia.org/wiki/Palindrome{Environment.NewLine}{Environment.NewLine}");
            Console.WriteLine($"{Line2}{Environment.NewLine}");
            Console.WriteLine($"Enter text:");
            string text = Console.ReadLine();
            Console.WriteLine($"{Environment.NewLine}{Line1}");

            Palindrome palindrome = new Palindrome();
            IList<string> results = palindrome.Find(text);
            if (results.Count > 0)
            {
                Console.WriteLine($"{Environment.NewLine}Found {results.Count} result(s) for '{text}'.{Environment.NewLine}");
                for (int i = 0; i < results.Count; i++)
                    Console.WriteLine($"{i + 1}) {results[i]}");
            }
            else
                Console.WriteLine($"No results for '{text}'.");
            Console.WriteLine($"{Environment.NewLine}{Line2}{Environment.NewLine}");
            Console.ReadLine();
        }
    }
}