using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace TextTask
{
    class SortWordsAlphabetically : IComparer<Word>
    {
        public int Compare([AllowNull] Word firstWord, [AllowNull] Word secondWord)
        {
            return string.Compare(firstWord.FullText, secondWord.FullText, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
