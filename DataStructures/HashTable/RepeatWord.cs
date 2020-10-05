using System;
using System.Collections.Generic;
using System.Linq;
using DataStructures.HT;

namespace DataStructures.HashTable
{
    public class RepeatWord
    {
        public RepeatWord(string words)
        {
            phraseArr = words.Split(delimiterChars);
        }

        char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
        public Dictionary<string, string> hashTable = new Dictionary<string, string>();
        private string[] phraseArr { get; set; }

        public string FirstWord()
        {
            foreach (string word in phraseArr)
            {
                if (hashTable.ContainsKey(word))
                {
                    return word;
                }
                else if (word != "")
                {
                    hashTable.Add(word, word);
                }
            }

            return null;
        }
    }
}
