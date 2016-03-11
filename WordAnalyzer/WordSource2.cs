using System.Collections.Generic;

namespace WordAnalyzer
{
    public class WordSource2 : IWordSource
    {
        private readonly IEnumerator<string> m_TextEnumerator;

        public WordSource2()
        {
            m_TextEnumerator = new WordSource1().Read().GetEnumerator();
        }

        public IEnumerable<string> Read()
        {
            while (m_TextEnumerator.MoveNext())
                yield return m_TextEnumerator.Current;
        }
    }
}