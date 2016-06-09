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
            int wordCount = 0;
            int longestWordLength = 0;
            Dictionary<string, int> wordDictionary = new Dictionary<string, int>();

            foreach ( var word in input)
            {
                ++wordCount;
                longestWordLength = word.Length > longestWordLength ? word.Length : longestWordLength;
                if ( wordDictionary.ContainsKey(word) )
                {
                    ++wordDictionary[word];
                }
                else
                {
                    wordDictionary.Add(word, 1);
                }
            }

            var result = new AnalysisResults();
            result.WordCount = wordCount;
            result.LongestWordLength = longestWordLength;
            result.MostCommonlyUsedWords = GetMostCommonWords(wordDictionary);
            return result;
        }

        private IList<string> GetMostCommonWords(IDictionary<string, int> wordDictionary)
        {
            var wordList = wordDictionary.ToList();
            wordList.Sort((entry1, entry2) => entry2.Value.CompareTo(entry1.Value));
            int maxRepeatCount = wordList.Count > 0 ? wordList.ElementAt(0).Value : 0;

            List<string> mostCommonWordsList = new List<string>();
            foreach (var wordCountPair in wordList)
            {
                if (wordCountPair.Value.Equals(maxRepeatCount))
                {
                    mostCommonWordsList.Add(wordCountPair.Key);
                }
                else
                    break;
            }
            return mostCommonWordsList;
        }
    }
}
