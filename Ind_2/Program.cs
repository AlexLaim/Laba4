using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Ind_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ВАРИАНТ 7
            string g = new string('_', 80);
            Console.WriteLine("Сформировать новую строку из исходной путем удаления из нее всех слов, которые и начинаются, и заканчиваются на один из символов a, o, e, i, u");
            Console.WriteLine("Введите текст: ");
            string s = Console.ReadLine().ToLower();           
            Console.WriteLine("Ваш текст: ");
            Console.WriteLine(s);
            Console.WriteLine(g);
            //ARRAY
            Console.WriteLine("С помощью ARRAY: ");                    
            //char[] charWord = s.ToCharArray();
            string[] words = s.Split(new char[] { ' ', ',', '.' });
            foreach (string word in words)
            {
                char[] charWord = word.ToCharArray();
                if (charWord[0] == 'a' || charWord[0] == 'o' || charWord[0] == 'e' || charWord[0] == 'i' || charWord[0] == 'u')
                {
                    s = s.Replace(word, "");
                }
            }
            Console.WriteLine();
            Console.WriteLine(s);
            Console.WriteLine();
            Console.WriteLine(g);
            //STRING
            Console.WriteLine("С помощью STRING: ");
                foreach (string word in words)
                {
                    if (word[0].Equals('a') || word[0].Equals('o') || word[0].Equals('e') || word[0].Equals('i') || word[0].Equals('u'))
                    {
                        s = s.Replace(word, "");
                    }
                }            
			Console.WriteLine(s);            
        }
    }
}
