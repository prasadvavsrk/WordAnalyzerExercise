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
            var x = words.GroupBy(word => word)
                    .Select(wordWithCounts => new {word = wordWithCounts.Key, count = wordWithCounts.Count()})
                    .ToList();
            var maxWordFrequency = x.Max(xx => xx.count);
            var mostCommonlyUsedWords = x.Where(xx => xx.count == maxWordFrequency).Select(xx => xx.word);
            return mostCommonlyUsedWords;
        }
    }
}
