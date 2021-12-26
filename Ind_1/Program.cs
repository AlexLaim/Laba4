using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Ind_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ВАРИАНТ 7 (ШИФР ЦЕЗАРЯ)
            string g = new string('_', 80);
            Console.WriteLine("Программа для шифровки и расшифровки строки символов");
            Console.WriteLine("Введите строку, которую хотите зашифровать: ");
            string str = Console.ReadLine();
            str = str.ToLower();
            char[] ru = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ь', 'ы', 'ъ', 'э', 'ю', 'я' };
            //char[] RU = {'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю', 'Я'};
            char[] array = str.ToCharArray();
            //ШИФР ПОЛИБИЯ

            //ШИФР ЦЕЗАРЯ           
            
            //ШИФР ВИЖЕНЕРА

        }
    }
}
