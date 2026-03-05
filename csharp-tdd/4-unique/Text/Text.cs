using System;
using System.Collections.Generic;

namespace Text
{
    /// <summary>
    /// String operations class
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Returns the index of the first non-repeating character of a string
        /// </summary>
        /// <param name="s">The string to check</param>
        /// <returns>Index of first non-repeating character or -1 if none found</returns>
        public static int UniqueChar(string s)
        {
            if (string.IsNullOrEmpty(s))
                return -1;

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            // Count frequency of each character
            foreach (char c in s)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }

            // Find first character with count 1
            for (int i = 0; i < s.Length; i++)
            {
                if (charCount[s[i]] == 1)
                    return i;
            }

            return -1;
        }
    }
}
