using System;
using System.Collections.Generic;
using System.Text;

namespace TextTask
{
    public class ConcordanceCollection
    {
        private SortedSet<WordCollection> _wordCollections = new SortedSet<WordCollection>(new SortCollectionsAlphabetically());
        public int CollectionsCount { get => _wordCollections.Count; }

        public void AddCollection(WordCollection wordCollection)
        {
            _wordCollections.Add(wordCollection);
        }

        public void AddWord(Word word)
        {
            if (word is null)
            {
                throw new ArgumentNullException();
            }
            if (word.FullText.Length == 0)
            {
                throw new ArgumentException();
            }

            foreach (var collection in _wordCollections)
            {
                if (collection.KeyLetter == word.KeyLetter)
                {
                    collection.AddWord(word);
                    return;
                }
            }

            //If no such key collection exists => create it
            WordCollection newCollection = new WordCollection(word.KeyLetter);
            newCollection.AddWord(word);
            AddCollection(newCollection);
        }

        public void DisplayConcordance()
        {
            Console.WriteLine();
            Console.WriteLine("Your final concordance:\n");

            foreach (var wordCols in _wordCollections)
            {
                Console.WriteLine(Char.ToUpper(wordCols.KeyLetter));
                Console.WriteLine();

                foreach (var word in wordCols.Words)
                {
                    string allLines = "";
                    foreach (var index in word.SourceLineIndeces)
                    {
                        allLines += $"{index}, ";
                    }
                    allLines = allLines[..^2];
                    Console.WriteLine($"{word.FullText}.....\t\tOccurences: {word.OccurenceCount}, Lines: {allLines}");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

    }
}
