using System;
using System.Collections.Generic;
using System.Text;

namespace TextTask
{
    public class WordCollection
    {
        private SortedSet<Word> _words = new SortedSet<Word>(new SortWordsAlphabetically());
        public SortedSet<Word> Words { get => _words; }

        public int WordCount { get => _words.Count; }
        public char KeyLetter { get; set; }

        public WordCollection()
        {
            KeyLetter = ' ';
        }

        public WordCollection(char key)
        {
            KeyLetter = Char.ToLower(key);
        }
        public void AddWord(Word word)
        {
            if (word.KeyLetter == KeyLetter)    //Find Collection with Key
            {
                foreach(var storedWord in _words)   //If this word had been stored previously => add to count and Line Indeces
                {
                    if (storedWord.FullText == word.FullText)
                    {
                        storedWord.OccurenceCount++;
                        storedWord.AddSourceLineIndex(word.FirstSourceIndex);
                        return;
                    }
                }
                _words.Add(word);
            }
        }

    }
}
