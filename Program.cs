using System;

namespace задачи
{
    class Program
    {
        static void Main(string[] args)
        {
            //Даны две строки: S1 и S2. Проверить, содержится ли строка S2 в строке S1. Если да, то вывести номер позиции, начиная с которой S2 содержится в S1, если нет, то вывести 0.
            var s1 = Console.ReadLine();
            var s2 = Console.ReadLine();
            int k = s1.IndexOf(s2);
            if (k == -1)
            Console.WriteLine(0);
            else 
            Console.WriteLine(k);
        }
    }
}
