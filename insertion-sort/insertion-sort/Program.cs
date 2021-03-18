using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace insertion_sort
{
    class Program
    {
        static void InsertionSort(List<int> minLista)
        {
            int i, n;
            int length = minLista.Count; if (length < 2) return;
            int temp;

            for (n = 1; n < length; n++)
            {
                temp = minLista[n];
                i = n - 1;

                while (i >= 0 && minLista[i] > temp)
                {
                    minLista[i + 1] = minLista[i];
                    i--;
                }
                minLista[i + 1] = temp;
            }

        }
        static void Main(string[] args)
        {
            var tallista = new List<int>();
            Stopwatch stopWatch = new Stopwatch();
            Random slump = new Random();

            //Sorterar 10 tal
            for (int i = 0; i < 10; i++)
            {
                tallista.Add(slump.Next(1000000));
            }
            stopWatch.Start();
            InsertionSort(tallista);
            stopWatch.Stop();
            Console.WriteLine("Listan sorterades på: " + stopWatch.Elapsed);

            //Sorterar 1 000 tal
            for (int i = 0; i < 1000; i++)
            {
                tallista.Add(slump.Next(1000000));
            }
            stopWatch.Reset();
            stopWatch.Start();
            InsertionSort(tallista);
            stopWatch.Stop();
            Console.WriteLine("Listan sorterades på: " + stopWatch.Elapsed);

            //Sorterar 100 000 tal
            for (int i = 0; i < 100000; i++)
            {
                tallista.Add(slump.Next(1000000));
            }
            stopWatch.Reset();
            stopWatch.Start();
            InsertionSort(tallista);
            stopWatch.Stop();
            Console.WriteLine("Listan sorterades på: " + stopWatch.Elapsed);
        }
    }
}
