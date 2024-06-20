using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_09_14_06_2024
{
    internal class EngFrDictionary
    {
        public Dictionary<string, List<string>> _dict;
        public EngFrDictionary() 
        { 
            _dict = new Dictionary<string, List<string>>();
        }
        public void AddNewWord(string word, string transletion)
        {
            if (!_dict.ContainsKey(word))
            {
                _dict[word] = new List<string>();
            }
            _dict[word].Add(transletion);
        }
        public void AddNewWord(string word, List<string> transletion)
        {
            if (!_dict.ContainsKey(word))
            {
                _dict[word] = transletion;
            }
        }
        public void AddTranslation (string word, string transletion)
        {
            _dict[word].Add (transletion);
        }
        public string Translate(string word)
        {
            if (_dict.ContainsKey(word))
            {
                string transl = "";
                foreach (var item in _dict[word])
                { 
                    transl +=(item+", ");
                }
                return transl;
            }
            else
            {
                Console.WriteLine("Слово не найдено в словаре.");
                return "";
            }
        }
        public void DeleteWord(string word)
        {
            _dict.Remove(word);
        }
        public void DeleteTranslate(string word)
        {
            _dict[word].Clear();
        }
         public void ChangeTranslation(string word, string newTranslation)
        {
            if (_dict.ContainsKey(word))
            {
                _dict[word].Clear();
                _dict[word].Add(newTranslation);
            }
        }
        
        public static EngFrDictionary operator+(EngFrDictionary dict1, EngFrDictionary dict2)
        {
            foreach (var item in dict2._dict)
            {   
                dict1.AddNewWord(item.Key, item.Value);
            }
            return dict1;
        }
        public override string ToString()
        {
            Console.WriteLine("English-France dictionary:");
            foreach (var item in _dict)
            {
                Console.WriteLine($"Word: {item.Key}");
                Console.Write("Translation: ");
                foreach (var item2 in item.Value)
                {
                    Console.Write(item2 + ", ");
                }
                Console.WriteLine();
            }
            return "";
        }
    }
}
