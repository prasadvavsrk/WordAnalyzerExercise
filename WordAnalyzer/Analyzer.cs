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
            var wordCountDictionary = input.GroupBy(word => word).ToDictionary(x => x.Key, x => x.Count());

            var result = new AnalysisResults();
            result.WordCount = wordCountDictionary.Values.DefaultIfEmpty(0).Sum();
            result.LongestWordLength = wordCountDictionary.Keys.Select(word => word.Length).DefaultIfEmpty(0).Max();
            result.MostCommonlyUsedWords = GetMostCommonlyUsedWords(wordCountDictionary);

            return result;
        }

        private IEnumerable<string> GetMostCommonlyUsedWords(IReadOnlyDictionary<string, int> wordCountDictionary)
        {
            int maxRepeatCount = wordCountDictionary.Values.DefaultIfEmpty(0).Max();
            return wordCountDictionary.Where(group => group.Value.Equals(maxRepeatCount)).Select(group => group.Key);
        }
    }
}
