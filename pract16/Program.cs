using System;
using System.IO;
using System.Linq;
namespace pract16
{
    class Program
    {
        static void Main(string[] args)
        {//Задание 1
            Console.WriteLine("Введите слово для поиска");
            string word = Console.ReadLine()?.ToLower();
            if(string.IsNullOrEmpty(word))
            {
                Console.WriteLine("Введено пустое значение");
                return;
            }
            string text = File.ReadAllText("file.txt").ToLower();
            int count = text.Split(' ', '.', ',', ';', ':', '!', '?', '\n', '\r').Count(w => w == word);
            Console.WriteLine($"Были найдены {count} вхождений запроса: \"{word}\"");
        }
    }
}
