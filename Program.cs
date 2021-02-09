using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TextTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting your text for you:\n");

            string currentPath = @"D:\Programming text files\Text.txt";
            var sourceTextLines = GetTextAsArray(currentPath);

            WriteArrayToConsole(sourceTextLines);

            ConcordanceCollection concordance = new ConcordanceCollection();
            for (int currentLineIndex = 0; currentLineIndex < sourceTextLines.Length; currentLineIndex++)
            {
                string[] foundWords = Regex.Split(sourceTextLines[currentLineIndex], @"\W|(\w+\S\w+)");      //TODO: Solve this riddle
                foreach (string wordString in foundWords)
                {
                    if (!string.IsNullOrEmpty(wordString))
                    {
                        Word word = new Word(wordString, currentLineIndex + 1);
                        concordance.AddWord(word);
                    }
                }
            }

            concordance.DisplayConcordance();
            Console.ReadLine();
        }

        static string GetTextAsString(string path)
        {
            return System.IO.File.ReadAllText(path);
        }

        static string[] GetTextAsArray(string path)
        {
            return System.IO.File.ReadAllLines(path);
        }

        static void WriteArrayToConsole(string[] arrayOfStrings)
        {
            foreach (string str in arrayOfStrings)
            {
                Console.WriteLine(str);
            }
        }
    }
}
