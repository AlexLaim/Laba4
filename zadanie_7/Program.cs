using System;
using System.Text;
using System.Text.RegularExpressions;

namespace zadanie_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string g = new string('_', 80);
            Console.WriteLine("Дан треклист – массив из 10 строк следующего вида: ");
            Console.WriteLine(g);
            string[] tracklist = {  "Gentle Giant – Free Hand[06:15]",
                                    "Supertramp – Child Of Vision[07:27]",
                                    "Camel – Lawrence[10:46]",
                                    "Yes – Don’t Kill The Whale[03:55]",
                                    "10CC – Notell Hotel[04:58]",
                                    "Nektar – King Of Twilight[04:16]",
                                    "The Flower Kings – Monsters & Men[21:19]",
                                    "Focus – Le Clochard[01:59]",
                                    "Pendragon – Fallen Dream And Angel[05:23]",
                                    "Kaipa – Remains Of The Day(08:02)"};
            foreach (string s in tracklist)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(g);
            Console.WriteLine("Программа обрабатывает весь треклист, суммирует время звучания песен, а также отображает самую длинную и самую короткую песню в списке и пару песен с минимальной разницей во времени звучания.");
            Console.WriteLine(g);
            //ВРЕМЯ ПЕСЕН
            int[] durations = new int[tracklist.Length];
            int sum2 = 0, sum1 = 0, sec = 0, min = 0, H = 0;
            Regex minutes = new Regex(@"(\d{2})(?=:)");
            Regex seconds = new Regex(@"(?<=:)(\d{2})");
            for (int i = 0; i < tracklist.Length; i++)
            {
                MatchCollection minut = minutes.Matches(tracklist[i]);
                MatchCollection second = seconds.Matches(tracklist[i]);
                foreach (Match m in minut)
                {
                    min = int.Parse(m.Value);
                    sum1 += min;
                    if (sum1 >= 60)
                    {
                        H++;
                        sum1 = sum1 - 60;
                    }
                }
                foreach (Match s in second)
                {
                    sec = int.Parse(s.Value);
                    sum2 += sec;
                    if (sum2 >= 60)
                    {
                        sum1++;
                        sum2 = sum2 - 60;
                    }
                }
                durations[i] = min * 60 + sec; //НУЖНО ДЛЯ ПРОВЕРКИ МИНИМАЛЬНОЙ РАЗНИЦЫ
            }
            Console.WriteLine($"Сумма звучания песен = {H} часов, {sum1} минут, {sum2} секунд");
            Console.WriteLine(g);
            //САМАЯ ДЛИННАЯ И САМАЯ КОРОТКАЯ ПЕСНИ           
            string longest = string.Empty;
            string shortest = string.Empty;
            int minDuration = int.MaxValue, maxDuration = 0, temp = 0;
            Regex duration = new Regex(@"(\d{2})(?=:)");
            for (int i = 0; i < tracklist.Length; i++)
            {
                MatchCollection dur = duration.Matches(tracklist[i]);
                foreach (Match d in dur)
                {
                    temp = int.Parse(d.Value);
                    if (maxDuration < temp)
                    {
                        maxDuration = temp;
                        longest = tracklist[i];
                    }
                    if (minDuration > temp)
                    {
                        minDuration = temp;
                        shortest = tracklist[i];
                    }
                }               
            }
            Console.WriteLine($"Самая короткая песня: {shortest}");
            Console.WriteLine($"Самая длинная песня: {longest}");
            Console.WriteLine(g);
            //ПЕСНИ С МИНИМАЛЬНОЙ РАЗНИЦЕЙ           
            int difference = int.MaxValue, firstIndex = 0, secondIndex = 0, temp2 = 0;                      
            for (int q = 0; q < durations.Length; q++)
            {
                for (int w = 0; w < durations.Length; w++)
                {
                    if (q == w)
                    {
                        continue;
                    }
                    if (Math.Abs(durations[q] - durations[w]) < difference)
                    {
                        firstIndex = q;
                        secondIndex = w;
                        difference = Math.Abs(durations[q] - durations[w]);
                    }
                }
            }
              Console.WriteLine("Песни с минимальной разницей: {0} и {1}", tracklist[firstIndex], tracklist[secondIndex]);            
        }
    }
}

