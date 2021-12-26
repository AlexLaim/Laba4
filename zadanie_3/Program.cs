using System;
using System.Text;

namespace zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string g = new string('_', 80);
            Console.WriteLine("Программа, которая формирует новую строку на основе исходной, в которой порядок слов меняется.");
            Console.WriteLine("Введите текст: ");
            string str = Console.ReadLine();
            str = str.Insert(str.Length, ".");
            string[] str2 = str.Split(" ");
            string str3 = str;
            Console.WriteLine($"Ваш текст: {str}");
            Console.WriteLine(g);
            string [] mas = str.Split(new char[] { ' ' });
            string a = string.Empty;
            Console.WriteLine("При помощи строки:");
            for (int i = mas.Length - 1; i >= 0; i--)
            {
                a += mas[i] + " "; 
            }
            Console.Write(a);
            Console.WriteLine();
            Console.WriteLine(g);
            Console.WriteLine("При помощи StringBuilder:");
            StringBuilder sb = new StringBuilder(str2.Length);
            for (int i = str2.Length; i-- != 0;)
            {
                sb.Append(str2[i]);
                Console.Write(str2[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine(g);
            Console.WriteLine("При помощи массива:");
            string[] st = str3.Split(new char[] { ' ' });
            Array.Reverse(st);
            for (int i = 0; i < st.Length; i++)
            {
                if (i == st.Length - 1)
                    Console.Write(st[i]);
                else
                    Console.Write(st[i] + ' ');
            }
        }
    }
}
