using System;
using System.Collections.Generic;

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
            var results = new AnalysisResults();
            var frequencies = new Dictionary<string, int>();
            foreach (var word in input)
            {
                results.WordCount++;
                results.LongestWordLength = Math.Max(word.Length, results.LongestWordLength);

                int frequencyOfThisWord;
                frequencies.TryGetValue(word, out frequencyOfThisWord);
                frequencies[word] = frequencyOfThisWord + 1;
            }

            var highestFrequency = 0;
            foreach (var frequency in frequencies)
            {
                highestFrequency = Math.Max(highestFrequency, frequency.Value);
            }

            var mostCommonlyUsedWords = new List<string>();
            foreach (var frequency in frequencies)
            {
                if (frequency.Value == highestFrequency)
                    mostCommonlyUsedWords.Add(frequency.Key);
            }
            return results;
        }
    }
}
