using System;
using System.Collections.Generic;

namespace WordAnalyzer
{
    public class AnalysisResults
    {
        /// <summary>
        /// Returns the number of words in the text
        /// </summary>
        public int WordCount { get; set; }

        /// <summary>
        /// Returns the length of the longest word in the input
        /// </summary>
        public int LongestWordLength { get; set; }

        /// <summary>
        /// Returns the most commonly used words in the input. 
        /// If two or more words share the most commonly used slot, they are all returned.
        /// </summary>
        public IEnumerable<string> MostCommonlyUsedWords { get; set; }

        public override string ToString()
        {
            return String.Format("WordCount: {0}, LongestWordLength: {1}, MostCommonlyUsedWords: {2}",
                WordCount, LongestWordLength, String.Join(", ", MostCommonlyUsedWords ?? new string[0]));
        }
    }
}