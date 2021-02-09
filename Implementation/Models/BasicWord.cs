using System;
using System.Collections.Generic;
using System.Text;

namespace TextTask
{
    public class BasicWord
    {
        public string FullText { get; set; }
        public char KeyLetter { get => FullText[0]; }
        public int Length { get => FullText.Length; }
        public int SourceIndex { get; }

        public BasicWord()
        {
            FullText = "";
        }

        public BasicWord(string text, int lineNumber)
        {
            FullText = text.ToLower();
            SourceIndex = lineNumber;
        }
    }
}
