using System;
using System.Linq;

namespace Text
{
    /// <summary>
    /// String operations class
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Returns True if a string is a palindrome or False if it's not
        /// </summary>
        /// <param name="s">The string to check</param>
        /// <returns>True if string is a palindrome, False if it's not</returns>
        public static bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;

            // Remove spaces and punctuation, convert to lowercase
            string cleaned = new string(s.Where(c => char.IsLetterOrDigit(c))
                                        .Select(c => char.ToLower(c))
                                        .ToArray());

            // Compare string with its reverse
            string reversed = new string(cleaned.Reverse().ToArray());
            return cleaned == reversed;
        }
    }
}
