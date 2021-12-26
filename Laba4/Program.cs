using System;
//using System.Text; -----> Нужно для StringBuilder
namespace zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string g = new string('_', 80);
            Console.WriteLine("Программа, которая выводит на консоль  все символы, которые входят в текст.");
            Console.WriteLine("Введите текст: ");
            string str = Console.ReadLine();
            str = str.Insert(str.Length, ".");
            //string[] array = str.Split(new char[] {'\r'});//StringSplitOptions.RemoveEmptyEntries); //str.ToCharArray();
            Console.WriteLine($"Ваш текст: {str}");
            Console.WriteLine(g);
            Console.WriteLine("Вывод каждого символа строки отдельно с помощью массива: ");
            char[] mas = str.ToCharArray();
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }
            Console.WriteLine(g);
            Console.WriteLine("Вывод каждого символа строки отдельно с помощью строки: ");
            //foreach (char x in str)
            //{
            //    Console.WriteLine(x);
            //} 
            for (int i = 0; i < str.LastIndexOf('.') + 1; i++)
            {
                Console.WriteLine(str[i]);
            }
        }
    }
}
