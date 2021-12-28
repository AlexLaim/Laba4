using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Ind_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ВАРИАНТ 7
            string g = new string('_', 80);
            Console.WriteLine("Программа, которая находит все «смайлы» – подстроки вида «:)», «:-)», «)))»");
            Console.WriteLine("Введите текст: ");
            string s = Console.ReadLine();
            Console.WriteLine("Ваши текст: ");
            Console.WriteLine(s);
            Console.WriteLine(g);
            Console.WriteLine("Ваши «смайлы»: ");
            Regex regex = new Regex(@":?-?\)*");
            MatchCollection smiles = regex.Matches(s);
            foreach (Match match in smiles)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
