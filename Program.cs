using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lr5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            string newText = Regex.Replace(text, @"\b[a-zA-Z]+\b", "...");

            Console.WriteLine("\nРезультат обработки:");
            Console.WriteLine(newText);
        }
    }
}
// Тест новой ветки feature-branch