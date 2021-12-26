using System;

namespace zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string g = new string('_', 80);
            Console.WriteLine("Программа, которая формирует новую строку на основе исходной, в которой после каждого слова в скобках указан  номер  слова  в  предложении.");
            Console.WriteLine("Введите текст: ");
            string str = Console.ReadLine();
            str = str.Insert(str.Length, ".");
            Console.WriteLine($"Ваш текст: {str}");
            Console.WriteLine(g);
            Console.WriteLine("Измененный текст с помощью массива: ");  
            int y = 1, x = 1;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]) && (str[i + 1] == ' ' || str[i + 1] == '-' || str[i + 1] == ',' || str[i + 1] == '.'))
                {
                    Console.Write(str[i] + $"({x++})");
                }
                else
                {
                    Console.Write(str[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine(g);
            Console.WriteLine("Измененный текст с помощью строки: ");
            string[] mas = str.Split(new char[] { ' ' });
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i].EndsWith(",") || mas[i].EndsWith("."))
                {
                    mas[i] = mas[i].Insert(mas[i].Length, $"({y++}) ");
                }
                else if (mas[i] == "-")
                    mas[i] = "- ";
                else
                {
                    mas[i] = mas[i].Insert(mas[i].Length, $"({y++}) ");
                }
            }
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i]);
            }        
        }       
    }
}
