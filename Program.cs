using System;

namespace задачи
{
    class Program
    {
        static void Main(string[] args)
        {
            // ввести массив a из 6-ти эл-ов найти сумму и кол-во отрицательных а так же максимальный элемент
            const  int n = 6;
            int sum = 0;
            int sum_min = 0;
            int max = 0;
            int[] a = new int[n];
            foreach(int i  in a)
            {
                a[i] = Int32.Parse(Console.ReadLine());
                sum = sum + a[i];
                if (a[i] < 0)
                sum_min = sum_min + a[i];
                if(i == 0)
                max = a[i];
                if (a[i] > max)
                max = a[i];
            }
            Console.WriteLine("сумма элементов равна {0}, сумма отрицательных равно {1} максимальное число равно {2}",sum,sum_min,max);
            Console.ReadKey();


        }
    }
}
