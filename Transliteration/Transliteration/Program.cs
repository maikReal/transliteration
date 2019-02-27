using System;
using System.Collections.Generic;
using System.Transactions;

namespace Transliteration
{
    class Transliteration
    {
        public static string transliteration(string word)
        {
            Dictionary<string, string> mainRule;
            
            Dictionary<string, string> rulesRUS_EN = new Dictionary<string, string>
            {
                {"ее", "eye"},{"ое", "oye"},{"цы", "tsy"},{"сы", "sy"},{"ий", "y"},{"ые", "ye"},{"сыч", "sych"},
                {"ё", "yo"},{"аев", "ayev"},{"ты", "ty"},{"лье", "lye"},{"ый", "y"},{"кс", "x"},{"ье", "e"},
                {"лы", "ly"},{"а", "a"},{"б", "b"},{"в", "v"},{"г", "g"},{"д", "d"},{"е", "e"},{"ж", "zh"},
                {"з", "z"},{"и", "i"},{"й", "y"},{"к", "k"},{"л", "l"},{"м", "m"},{"н", "n"},{"о", "o"},{"п", "p"},
                {"р", "r"},{"с", "s"},{"т", "t"},{"у", "u"},{"ф", "f"},{"х", "kh"},{"ц", "ts"},{"ч", "ch"},
                {"ш", "sh"},{"щ", "shch"},{"ъ", ""},{"ы", "yi"},{"ь", ""},{"э", "e"},{"ю", "yu"},{"я", "ya"}
            };

            Dictionary<string, string> rulesEN_RUS = new Dictionary<string, string>
            {
                {"a","a"}, {"age","и"},{"ate","и"},{"cae","ка"},{"ae","и"},{"lay","лей"},{"ai","эй"},
                {"ain","ен"},{"air","эр"},{"ayr","эр"},{"aire","эр"},{"ar","ар"},{"are","ар"},{"b","б"},
                {"ca","ка"},{"ci","си"},{"cia","шия"},{"wich","вич"},{"chu","че"},{"chr","кр"},{"cha","ша"},
                {"ck","л"},{"d","д"},{"set","сет"},{"en","ин"},{"ed","ид"},{"kea","ки"},{"rea","рей"},
                {"ear","эр"},{"dear","дир"},{"ee","и"},{"eer","ир"},{"ere","ир"},{"peo","пи"},{"geon","жен"},
                {"erd","эрд"},{"ew","юэ"},{"eu","ю"},{"ewe","ю"},{"ewer","юр"},{"key","ки"},{"hey","хей"},
                {"f","ф"},{"ge","ж"},{"g","ж"},{"gg","гг"},{"h","х"},{"i","и"},{"ia","иа"},{"iar","айар"},
                {"ie","айе"},{"ier","айер"},{"igh","ай"},{"ir","ир"},{"ire","айр"},{"k","к"},{"j","дж"},
                {"ll","л"},{"m","м"},{"mpb","мпб"},{"n","н"},{"ng","нг"},{"oa","оу"},{"o","о"},{"oar","ор"},
                {"oi","ой"},{"oy","ой"},{"oo","у"},{"oor","ор"},{"oore","ур"},{"or","ор"},{"ough","оу"},
                {"our","аур"},{"ow","оу"},{"ower","оуэр"},{"ph","ф"},{"p","п"},{"qu","ку"},{"r","р"},{"s","с"},
                {"sh","ш"},{"ss","сс"},{"t","т"},{"tch","тч"},{"ts","тс"},{"u","у"},{"ue","е"},{"v","в"},{"w","в"},
                {"wor","уэр"},{"x","кс"},{"y","ай"},{"yr","эр"},{"z","з"}
                
            };

            word = word.ToLower();


            mainRule = (int) word[0] < 127 ? rulesEN_RUS : rulesRUS_EN;

            foreach (var keyVal in mainRule)
            {
                word = word.Replace(keyVal.Key, keyVal.Value);
            }

            return word;
        }


        public static void Main(string[] args)
        {
            Console.WriteLine(transliteration("hello"));
        }
    }
}