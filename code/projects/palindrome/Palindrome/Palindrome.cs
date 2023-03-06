using System.Collections.Generic;

namespace Palindrome
{
    /// <summary>
    /// Palindrome.
    /// </summary>
    public class Palindrome : Base
    {
        public string Text { get; set; }

        public string Separator { get; set; } = ",";

        public IList<string> Result { get; set; } = new List<string>();

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Palindrome()
        {
        }

        /// <summary>
        /// Finds all palindromes in a string.
        /// </summary>
        /// <param name="text">Text to process.</param>
        /// <returns>All found palindromes.</returns>
        public IList<string> Find(string text)
        {
            Result = new List<string>();

            if (string.IsNullOrWhiteSpace(text))
            {
                LogError("Null or empty text supplied.");
                return Result;
            }

            Text = text.Trim();

            for (int i = 0; i < Text.Length; i++)
            {
                string variation = GetDelimited(Text);
                int len = i + 1;
                IList<string> textParts = GetTextParts(len);
                IList<string> palindromes = new List<string>();
                foreach (string textPart in textParts)
                    if (IsPalindrome(textPart))
                        if (!palindromes.Contains(textPart))
                            palindromes.Add(textPart);

                // Ignore first line, which always contains single characters, e.g. 1,2,3,4,5.
                if (i > 0)
                    foreach (string palindrome in palindromes)
                        variation = variation.Replace(GetDelimited(palindrome), palindrome);

                if (!Result.Contains(variation))
                    Result.Add(variation);
            }
            return Result;
        }

        /// <summary>
        /// Checks if text is a palindrome or not.
        /// </summary>
        /// <param name="text">Text to check.</param>
        /// <returns>Result of the check.</returns>
        public bool IsPalindrome(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                // ""
                return false;
            else if (text.Length == 1)
                // "a"
                return true;
            else
            {
                // Split the string in half and compare the characters from left and right
                // sides counting to the middle. Odd numbered string lengths also work, since
                // the character in the middle gets ignored, e.g. "abba" and "abcba".
                int halfLen = text.Length / 2;
                for (int i = 0; i < halfLen; i++)
                {
                    char leftSideChar = text[i];
                    char rightSideChar = text[text.Length - i - 1];
                    if (leftSideChar != rightSideChar)
                        return false;
                }
                return true;
            }
        }

        /// <summary>
        /// Delmits any text.
        /// </summary>
        /// <param name="text">Text to delimit.</param>
        /// <returns></returns>
        private string GetDelimited(string text)
        {
            string delimitted = null;
            foreach (char c in text)
            {
                if (string.IsNullOrWhiteSpace(delimitted))
                    delimitted += c;
                else
                    delimitted += Separator + c;
            }
            return delimitted;
        }

        /// <summary>
        /// Separates and returns text in parts.
        /// </summary>
        /// <param name="length">Length of text part.</param>
        /// <returns>Text in parts.</returns>
        private IList<string> GetTextParts(int length)
        {
            IList<string> parts = new List<string>();
            if (length < 1)
                return parts;
            int idx = 0;
            while(true)
            {
                string part = null;
                for (int i = idx; i < Text.Length; i++)
                {
                    part += Text[i];
                    if (part.Length == length)
                        break;
                }
                if (part.Length == length)
                    parts.Add(part);
                idx++;
                if (idx + 1 > Text.Length)
                    break;
            }
            return parts;
        }
    }
}