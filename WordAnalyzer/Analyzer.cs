using System;
using System.Collections.Generic;
using System.Linq;

namespace WordAnalyzer
{
    public class Analyzer
    {
        /// <summary>
        /// Requests the Analyzer to analyze the input
        /// </summary>
        /// <param name="input"></param>
        public AnalysisResults Analyze(IEnumerable<string> input)
        {
            var words  = input.ToList();

            var results = new AnalysisResults();
            foreach (var word in words )
            {
                results.WordCount++;
                results.LongestWordLength = Math.Max(word.Length, results.LongestWordLength);
            }
            var mostCommonlyUsedsWordFinder = new MostCommonlyUsedWordFinder(words);
            results.MostCommonlyUsedWords = mostCommonlyUsedsWordFinder.MostCommonlyUsedWordsIn();
            return results;
        }
    }
}
