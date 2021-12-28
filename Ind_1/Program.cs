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
            char[] str2 = str.ToCharArray();
            char[] str3 = str.ToCharArray();
            Console.WriteLine("Введите ключ для шифра Полибия: ");

            Console.WriteLine(g);
            Console.WriteLine("Введите ключ для шифра Цезаря: ");
            int skey2 = int.Parse(Console.ReadLine());
            Console.WriteLine(g);
            Console.WriteLine("Введите ключ для шифра Виженера: ");
            string skey3 = Console.ReadLine();
            char[] ar2 = skey3.ToCharArray();
            //string[] Ru = {"А","Б","В","Г","Д","Е","Ё","Ж","З","И","Й","К","Л","М","Н","О","П","Р","С","Т","У","Ф","X","Ц","Ч","Ш","Щ","Ъ","Ы","Ь","Э","Ю","Я","а","б","в","г","д","е","ё","ж","з","и","й","к","л","м","н","о","п","р","с","т","у","ф","х","ц","ч","ш","щ","ъ","ы","ь","э","ю","я"};
            char[] alfavit = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };

            //ШИФР ПОЛИБИЯ
            Console.WriteLine("Шифр Полибия: ");
            Console.WriteLine("Зашифрованная строка: ");

            Console.WriteLine();
            Console.WriteLine(g);
            //ШИФР ЦЕЗАРЯ
            Console.WriteLine("Шифр Цезаря: ");
            Console.WriteLine("Зашифрованная строка: ");
            int d=0, k=0, n= 0;
            for (int i = 0; i < str2.Length; i++)
            {
                if (str2[i] == ' ') //Для пробелов в тексте
                {
                    continue;
                }
                // Ищем индекс буквы
                for (int j = 0; j < alfavit.Length; j++)
                {
                    if (str2[i] == alfavit[j])
                    {
                        break;
                    }
                    k = j;
                }
                    if (k != 33) // Если j равно 33, значит символ не из алфавита
                    {
                        n = k; // Индекс буквы
                        d = n + skey2 + 1; // Делаем смещение
                        // Проверяем, чтобы не вышли за пределы алфавита
                        if (d > 32)
                        {
                            d = d - 33;
                        }
                        str2[i] = alfavit[d]; // Меняем букву
                    }              
            }
            string s3 = new string(str2);
            Console.Write(s3);
            Console.WriteLine();
            Console.WriteLine("Расшифрованная строка: ");           
            char[] array = s3.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == ' ')
                {
                    continue;
                }
                for (int j = 0; j < alfavit.Length; j++)
                {
                    if (array[i] == alfavit[j])
                    {
                        break;
                    }
                    k = j;
                }
                if (k != 33) 
                {
                    n = k; 
                    d = n - skey2 + 1; 
                    if (d > 32)
                    {
                        d = d + 33;
                    }
                    array[i] = alfavit[d];
                }
            }
            string s4 = new string(array);
            Console.WriteLine(s4);
            Console.WriteLine();
            Console.WriteLine(g);
            //ШИФР ВИЖЕНЕРА
            Console.WriteLine("Шифр Виженера: ");
            Console.WriteLine("Зашифрованная строка: ");
            k = 0;
            int t = 0, p = 0; //Переменная для номера ключа, переменная для нумерации символа не из алфавита
            for (int i = 0; i < str3.Length; i++)
            {
                if (str3[i] == ' ') //Для пробелов в тексте
                {
                    continue;
                }
                // Ищем индекс буквы
                for (int j = 0; j < alfavit.Length; j++)
                {
                    if (str3[i] == alfavit[j])
                    {
                        break;
                    }
                    k = j;
                }
                if (k != 33) // Если j равно 33, значит символ не из алфавита
                {
                    n = k; // Индекс буквы
                    // Ключ закончился - начинаем сначала.
                    if (t > skey3.Length - 1) 
                    { 
                        t = 0;
                    }
                    // Ищем индекс буквы ключа
                    for (int m = 0; m < alfavit.Length; m++)
                    {
                        if (skey3[t] == alfavit[m])
                        {
                            break;
                        }
                        p = m;
                    }
                    t++;
                    if (p != 33) // Если f равно 33, значит символ не из алфавита
                    {
                        d = n + p + 2;
                    }
                    else
                    {
                        d = n;
                    }
                    // Проверяем, чтобы не вышли за пределы алфавита
                    if (d > 32)
                    {
                        d = d - 33;
                    }
                    str3[i] = alfavit[d]; // Меняем букву
                }
            }
            string s5 = new string(str3);
            Console.WriteLine(s5);
            Console.WriteLine();
            Console.WriteLine(g);
            Console.WriteLine("Расшифрованная строка:");
            char[] array5 = s5.ToCharArray();
            for (int i = 0; i < array5.Length; i++)
            {
                if (array5[i] == ' ') 
                {
                    continue;
                }
                
                for (int j = 0; j < alfavit.Length; j++)
                {
                    if (array5[i] == alfavit[j])
                    {
                        break;
                    }
                    k = j;
                }
                if (k != 33) 
                {
                    n = k; 
                    
                    if (t > skey3.Length - 1)
                    {
                        t = 0;
                    }
                    
                    for (int m = 0; m < alfavit.Length; m++)
                    {
                        if (skey3[t] == alfavit[m])
                        {
                            break;
                        }
                        p = m;
                    }
                    t++;
                    if (p != 33) 
                    {
                        d = n - p + 2;
                    }
                    else
                    {
                        d = n;
                    }
                    
                    if (d > 32)
                    {
                        d = d - 33;
                    }
                    array5[i] = alfavit[d]; 
                }
            }
            string s6 = new string(array5);
                Console.WriteLine(s6);
        }
    }
}
