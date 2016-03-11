using System;

namespace WordAnalyzer
{
    public class AnalyzerApp
    {
        private Analyzer m_Analyzer;

        public static void Main(string[] args)
        {
            new AnalyzerApp().Run();
        }

        private void Run()
        {
            m_Analyzer = new Analyzer();

            RunWith(new WordSource1());
            RunWith(new WordSource2());
            RunWith(new WordSource3());
        }

        private void RunWith(IWordSource wordSource)
        {
            var results = m_Analyzer.Analyze(wordSource.Read());
            Console.WriteLine("{0}: {1}", wordSource, results);
        }
    }
}