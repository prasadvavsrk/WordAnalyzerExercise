using System.Collections.Generic;

namespace WordAnalyzer
{
    public class WordSource2 : IWordSource
    {
        private readonly IEnumerable<string> m_Text;

        public WordSource2()
        {
            m_Text = new WordSource1().Read();
        }

        public IEnumerable<string> Read()
        {
            return m_Text;
        }
    }
}