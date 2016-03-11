using System.Collections.Generic;

namespace WordAnalyzer
{
    public interface IWordSource
    {
        IEnumerable<string> Read();
    }
}