using System;
using System.Collections.Generic;
using System.Text;

namespace TextTask
{
    public class Word : BasicWord
    {
        public SortedSet<int> SourceLineIndeces { get; } = new SortedSet<int>();
        public int OccurenceCount { get; set; }

        public Word()
        {
            
        }

        public Word(string text, int lineNumber)
        {

        }

        public void AddSourceLineIndex(int index)
        {
            if (!SourceLineIndeces.Contains(index))
            {
                SourceLineIndeces.Add(index);
            }
        }
    }
}
