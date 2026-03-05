using System;

namespace Text
{
    /// <summary>
    /// String operations class
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Determines how many words are in a camelCase string
        /// </summary>
        /// <param name="s">The camelCase string</param>
        /// <returns>Number of words in the string</returns>
        public static int CamelCase(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            int wordCount = 1; // Start with 1 for the first word

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    wordCount++;
                }
            }

            return wordCount;
        }
    }
}
