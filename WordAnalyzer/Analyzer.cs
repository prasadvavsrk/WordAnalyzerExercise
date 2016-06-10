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
            result.WordCount = input.Count();
            bool wordListNotEmpty = input.Any();
            result.LongestWordLength = wordListNotEmpty ? wordCountDictionary.Keys.Select(word => word.Length).Max() : 0;
            int maxRepeatCount = wordListNotEmpty ? wordCountDictionary.Values.Max() : 0;
            result.MostCommonlyUsedWords = wordCountDictionary.Where(group => group.Value.Equals(maxRepeatCount)).Select(group => group.Key);

            return result;
        }
    }
}
