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
            results.MostCommonlyUsedWords = MostCommonlyUsedWordsIn(words);
            return results;
        }

        private static IEnumerable<string> MostCommonlyUsedWordsIn(IEnumerable<string> words)
        {
            var frequencies = CountWordFrequencies(words);
            var highestFrequency = FindHighestFrequency(frequencies);
            var mostCommonlyUsedWords = FindWordsWithFrequencyEqualTo(frequencies, highestFrequency);

            return mostCommonlyUsedWords;
        }

        private static IEnumerable<string> FindWordsWithFrequencyEqualTo(Dictionary<string, int> frequencies, int highestFrequency)
        {
            var mostCommonlyUsedWords = new List<string>();
            foreach (var frequency in frequencies)
            {
                if (frequency.Value == highestFrequency)
                    mostCommonlyUsedWords.Add(frequency.Key);
            }
            return mostCommonlyUsedWords;
        }

        private static int FindHighestFrequency(Dictionary<string, int> frequencies)
        {
            var highestFrequency = 0;
            foreach (var frequency in frequencies)
            {
                highestFrequency = Math.Max(highestFrequency, frequency.Value);
            }
            return highestFrequency;
        }

        private static Dictionary<string, int> CountWordFrequencies(IEnumerable<string> words)
        {
            var frequencies = new Dictionary<string, int>();
            foreach (var word in words)
            {
                int frequencyOfThisWord;
                frequencies.TryGetValue(word, out frequencyOfThisWord);
                frequencies[word] = frequencyOfThisWord + 1;
            }
            return frequencies;
        }
    }
}
