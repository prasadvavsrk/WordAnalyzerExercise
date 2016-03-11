using System;
using System.Collections.Generic;

namespace WordAnalyzer
{
    public class MostCommonlyUsedWordFinder
    {
        private readonly List<string> m_Words;

        public MostCommonlyUsedWordFinder(List<string> words)
        {
            m_Words = words;
        }

        private Dictionary<string, int> m_Frequencies;

        public IEnumerable<string> MostCommonlyUsedWordsIn()
        {
            m_Frequencies = WordFrequencies(m_Words);
            var highestFrequency = FindHighestFrequency();
            var mostCommonlyUsedWords = FindWordsWithFrequencyEqualTo(highestFrequency);
            return mostCommonlyUsedWords;
        }

        private IEnumerable<string> FindWordsWithFrequencyEqualTo(int highestFrequency)
        {
            var mostCommonlyUsedWords = new List<string>();
            foreach (var frequency in m_Frequencies)
            {
                if (frequency.Value == highestFrequency)
                    mostCommonlyUsedWords.Add(frequency.Key);
            }
            return mostCommonlyUsedWords;
        }

        private int FindHighestFrequency()
        {
            var highestFrequency = 0;
            foreach (var frequency in m_Frequencies)
            {
                highestFrequency = Math.Max(highestFrequency, frequency.Value);
            }
            return highestFrequency;
        }

        private Dictionary<string, int> WordFrequencies(IEnumerable<string> words)
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