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
            var words = input.ToList();
            var results = new AnalysisResults
                {
                    LongestWordLength = MaxOrZeroIfEmpty(words, word => word.Length),
                    MostCommonlyUsedWords = MostCommonlyUsedWordsIn(words),
                    WordCount = words.Count
                };
            return results;
        }

        private static IEnumerable<string> MostCommonlyUsedWordsIn(IEnumerable<string> words)
        {
            var wordsWithCounts = words.GroupBy(word => word)
                    .Select(wordWithCounts => new {word = wordWithCounts.Key, count = wordWithCounts.Count()})
                    .ToList();
            var maxWordFrequency = MaxOrZeroIfEmpty(wordsWithCounts, wordWithCount => wordWithCount.count);
            var mostCommonlyUsedWords = wordsWithCounts.Where(wordWithCount => wordWithCount.count == maxWordFrequency).Select(wordWithCount => wordWithCount.word);
            return mostCommonlyUsedWords;
        }

        private static int MaxOrZeroIfEmpty<T>(IEnumerable<T> input, Func<T, int> selector)
        {
            return input.Select(selector).DefaultIfEmpty().Max();
        }
    }
}
