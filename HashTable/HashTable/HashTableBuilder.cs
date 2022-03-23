using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class HashTableBuilder
    {
        // Senetnce property
        // Adding key/value pair in the hashtable
        public string Sentence { get; set; } = "To be or not to be";
        // Determine whether the given
        // key present or not
        // using Contains method
        public string WordToCheck { get; set; } = "be";
        /// Adds the splitPhrase into the map.
        public int FindFrequencyOfWord()
        {
            string[] words = Sentence.Split(' ');
            MyNode<string, int> map = new MyNode<string, int>(10);
            // for each loop
            foreach (string word in words)
            {
                if (map.GetValue(word) == 0)
                    map.AddValue(word, 1);
                else
                {
                    var freq = map.GetValue(word) + 1;
                    map.SetValue(word, freq);
                }
            }
            int count = map.GetValue(WordToCheck);
            return count;
        }
    }
}
