using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1.Zadanie6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string words, lon;
            Console.WriteLine("Введите предложение без знаков препинания");
            words = Console.ReadLine();
            string[] split = words.Split(' ');
            lon = split[0];
            foreach (string s in split)
            {
                if (s.Trim() != "")
                {
                    if (lon.Length < s.Length) lon = s;
                }
            }
            Console.WriteLine("Самое длинное слово - " + lon);
            Console.ReadKey();

        }
    }
}
