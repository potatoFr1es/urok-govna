using System;

namespace задачи
{
    class Program
    {
        static void Main(string[] args)
        {
          //здаание эл-ов массива при его описании 
          //многомерные массивы
        //   int[,] a = new int[4,2];
        
          //даны натуральные n целых чисел a1 an все числа попарно различны поменять в последовательности местами наибольший и наименьший члены
          byte n;
          int[] a;
          int max, min;
          byte i, nom_max, nom_min;
          Console.WriteLine("Input n");
          n = byte.Parse(Console.ReadLine());
          if (n == 0) return;
          a = new int[n];
          for (i = 0; i< n; i++)
          {
            Console.Write("Input a[{0}]",i);
            a[i] = int.Parse(Console.ReadLine());
          }
          min = a[0];
          max = a[0];
          nom_max = 0;
          nom_min = 0;
          for (i=1;i<n;i++)
          {
              if(a[i]<min)
              {
                  min = a[i];
                  nom_min = i;
              }
              if(a[i]>max)
              {
                max = a[i];
                nom_max = i;
              }

          }
           a[nom_min] = max;
           a[nom_max] = min;
           for (i = 0; i<n;i++)
           {
               Console.WriteLine(a[i]);
           }

          Console.ReadKey();


        }
    }
}
