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
            if (words.Count == 0) return new AnalysisResults();

            var results = new AnalysisResults
            {
                LongestWordLength = words.Select(word => word.Length).Max(),
                MostCommonlyUsedWords = MostCommonlyUsedWordsIn(words),
                WordCount = words.Count
            };
            return results;
        }

        private static IEnumerable<string> MostCommonlyUsedWordsIn(IEnumerable<string> words)
        {
            var wordsWithCount = words.GroupBy(word => word).ToList();
            var maxWordFrequency = wordsWithCount.Max(wordWithCount => wordWithCount.Count());
            var mostCommonlyUsedWords = wordsWithCount.Where(wordWithCount => wordWithCount.Count() == maxWordFrequency)
                .Select(wordWithCount => wordWithCount.Key);
            return mostCommonlyUsedWords;
        }
    }
}
