using System;
using System.Text;
using System.Text.RegularExpressions; //Нужен для REGEX

namespace zadanie_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string g = new string('_', 80);
            Console.WriteLine("Программа, которая выводит все строки, в которых содержится хотя бы одно слово, оканчивающееся на “.com”, а также номер строки, содержащей наименьшее число пробелов");
            int length = 7, number = 1;
            string[] s = new string[length];
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(number + ". ");
                Console.WriteLine("Введите строку: ");
                s[i] = Console.ReadLine();
                number++;
                Console.WriteLine(g);
            }
            Console.WriteLine(g);
            number = 1;
            Console.WriteLine("Ваши строки: ");
            foreach (string str in s)
            {
                Console.Write(number + ". ");
                Console.WriteLine(str);
                number++;
            }
            Console.WriteLine(g);
            Console.WriteLine("Строки в которых содержится .com с помощью метода регулярных выражений: ");
            number = 1;
            foreach (string str in s)
            {
                Regex regex = new Regex(@"^.*.*.\.com$", RegexOptions.CultureInvariant | RegexOptions.IgnoreCase);
                MatchCollection matches = regex.Matches(str);
                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                    {
                        Console.WriteLine($"{number}.  {match.Value}");
                    }
                }
                if (str.Equals(".com", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine($"{number} {str}");
                }
                number++;
            }
            Console.WriteLine(g);
            Console.WriteLine("Строки в которых содержится .com с помощью метода строк: ");          
            number = 1;
            foreach (string str in s)
            {
                if (str.EndsWith(".com", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine($"{number} {str}");
                }
                number++;
            }
            Console.WriteLine(g);
            Console.WriteLine("Строки в которых содержится .com с помощью метода массива: ");
            number = 1;
            for (int i = 0; i < s.Length; i++)
            {
                string temp = s[i].ToLower();
                for (int j = 0; j < s[i].Length - 3; j++)
                {
                    if (temp[j].Equals('.') & temp[j + 1].Equals('c') & temp[j + 2].Equals('o') & temp[j + 3].Equals('m'))
                    {
                        Console.WriteLine($"{number} {temp}");
                    }
                }
                number++;
            }
            Console.WriteLine(g);
            Console.WriteLine("Строка в которой содержится меньше всего пробелов: ");
            //int spaces = 0;          
            //number = 1;
            // int c = 0;
            // string strr = s[0];
            //for (int i = 0; i < strr.Length; i++)
            //{
            //    if (strr[i] == ' ')
            //    {
            //        c++;
            //    }
            //}
            //for (int i = 0; i < s.Length; i++)
            //{
            //    number++;
            //    if (s[i] == " ")
            //    {
            //        spaces++;
            //    }
            //    if (c > spaces)
            //    {
            //       int nums = number;
            //        c = spaces;
            //        Console.WriteLine($"{nums}");
            //    } 
            //}
            int minindex = 0;
            for (int i = 0, space = 100; i < 7; i++)
            {
                string temp2 = s[i];
                for (int j = 0, spaces = 0; j < temp2.Length; j++)
                    if (temp2[j] == ' ')
                    {
                        spaces++;
                    }
                    else if (j == temp2.Length - 1)
                    {
                        if (spaces < space)
                        {
                            space = spaces;
                            spaces = 0;
                            minindex = i + 1;
                        }
                    }
            }         
            Console.WriteLine($"Номер строки с наименьшим количеством пробелов: {minindex}");
        }
    }
}
