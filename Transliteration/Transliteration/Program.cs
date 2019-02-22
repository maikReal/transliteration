using System;
using System.Collections.Generic;
using System.Transactions;

namespace Transliteration
{
    class Transliteration
    {
        public static string transliteration(string word)
        {
            Dictionary<string, string> rules = new Dictionary<string, string>
            {
                {"ее", "eye"},{"ое", "oye"},{"цы", "tsy"},{"сы", "sy"},{"ий", "y"},{"ые", "ye"},{"сыч", "sych"},
                {"ё", "yo"},{"аев", "ayev"},{"ты", "ty"},{"лье", "lye"},{"ый", "y"},{"кс", "x"},{"ье", "e"},
                {"лы", "ly"},{"а", "a"},{"б", "b"},{"в", "v"},{"г", "g"},{"д", "d"},{"е", "e"},{"ж", "zh"},
                {"з", "z"},{"и", "i"},{"й", "y"},{"к", "k"},{"л", "l"},{"м", "m"},{"н", "n"},{"о", "o"},{"п", "p"},
                {"р", "r"},{"с", "s"},{"т", "t"},{"у", "u"},{"ф", "f"},{"х", "kh"},{"ц", "ts"},{"ч", "ch"},
                {"ш", "sh"},{"щ", "shch"},{"ъ", ""},{"ы", "yi"},{"ь", ""},{"э", "e"},{"ю", "yu"},{"я", "ya"}
            };

            word = word.ToLower();
            foreach (var keyVal in rules)
            {
                word = word.Replace(keyVal.Key, keyVal.Value);
            }

            return word;
        }


        public static void Main(string[] args)
        {
            Console.WriteLine(transliteration("привет"));
        }
    }
}