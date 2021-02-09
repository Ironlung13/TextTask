using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace TextTask
{
    public class SortCollectionsAlphabetically : IComparer<WordCollection>
    {
        public int Compare([AllowNull] WordCollection firstCollection, [AllowNull] WordCollection secondCollection)
        {
            return string.Compare(firstCollection.KeyLetter.ToString(), secondCollection.KeyLetter.ToString(), StringComparison.CurrentCultureIgnoreCase);
        }
    }


}
