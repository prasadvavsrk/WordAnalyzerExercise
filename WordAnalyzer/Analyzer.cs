using System.Collections.Generic;

namespace WordAnalyzer
{
    public class Analyzer
    {
        /// <summary>
        /// Requests the Analyzer to analyze the input
        /// </summary>
        /// <param name="input"></param>
        public Results Analyze(IEnumerable<string> input)
        {
            return new Results();
        }

        public class Results
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
        }
    }
}
