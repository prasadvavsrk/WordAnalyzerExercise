using System;

namespace WordAnalyzer
{
    public class AnalyzerApp
    {
        public static void Main(string[] args)
        {
            new AnalyzerApp().Run();
        }

        private void Run()
        {
            var analyzer = new Analyzer();
            var results = analyzer.Analyze(new WordSource1().Read());
            Console.WriteLine("WordSource1: {0}", results);
        }
    }
}