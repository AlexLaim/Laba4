using System;
using System.Text;
using System.Text.RegularExpressions;

namespace zadanie_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string g = new string('_', 80);
            Console.WriteLine("Программа, находящая в тексте все слова, которые начинаются с большого латинского символа (от A до Z) и заканчиваются 2 цифрами");
            Console.WriteLine("Введите текст");
            string s = Console.ReadLine();
            Console.WriteLine(g);
            Console.WriteLine("Ваш текст: " + s);
            Console.WriteLine(g);
            //REGEX
            Console.WriteLine("Поиск слов с помощью Regex: ");
            //Regex regex = new Regex(@"\b[A-Z]{1}[a-z]*\d{2}\b");
            Regex regex = new Regex(@"\b[A-Z]{1}.*\d{2}\b");
            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Value);
                }
            }
            Console.WriteLine(g);
            //ARRAY
            Console.WriteLine("Поиск слов с помощью Array: ");
            string[] array = s.Split(" ");
            
            string a = " ";
            for (int i = 0; i < array.Length; i++)
            {   
                    string temp = array[i];
                    if (Char.IsUpper(temp[0]) && Char.IsNumber(temp[temp.Length - 1]) && Char.IsNumber(temp[temp.Length - 2]))
                    {                      
                       Console.WriteLine(array[i]);
                    }                             
            }                
        }
           
    }
}

