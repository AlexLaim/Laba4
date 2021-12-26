using System;
using System.Text;
using System.Text.RegularExpressions;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string g = new string('_', 80);
            Console.WriteLine("Программа которая разбирает строку и заносит в переменные типа int оба операнда и сумму");
            Console.WriteLine("Введите строку вида: 15 + 36 = 51 ");
            string str = Console.ReadLine();
            Regex num = new Regex(@"-?\d+");
            int a = 1;
            Console.WriteLine(g);
            MatchCollection matches = num.Matches(str);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    int nums = int.Parse(match.Value);                  
                    Console.Write(nums + " --> " + $"{a} элемент |");
                    a++;
                }
            }
        }
    }
}
