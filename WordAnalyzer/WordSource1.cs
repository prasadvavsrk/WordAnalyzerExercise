using System.Collections.Generic;
using System.Linq;

namespace WordAnalyzer
{
    public class WordSource1 : IWordSource
    {
        public IEnumerable<string> Read()
        {
            var words = Text.Value.Split(' ', ',', '.', '\n', '\r')
                .Where(word => !string.IsNullOrWhiteSpace(word))
                .Select(word => word.ToLower());
            return words;
        }
    }
}
