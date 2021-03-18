using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace bubble_sort
{
    class Program
    {
        static void BubbleSort(List<int> minLista)
        {
            for (int i = 0; i < minLista.Count; i++)
            {
                for (int j = 0; j < minLista.Count - 1 - i; j++)
                {
                    if (minLista[j] > minLista[j + 1])
                    {
                        int temp = minLista[j];
                        minLista[j] = minLista[j + 1];
                        minLista[j + 1] = temp;
                    }
                }
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
            BubbleSort(tallista);
            stopWatch.Stop();
            Console.WriteLine("Listan sorterades på: " + stopWatch.Elapsed);

            //Sorterar 1 000 tal
            for (int i = 0; i < 1000; i++)
            {
                tallista.Add(slump.Next(1000000));
            }
            stopWatch.Reset();
            stopWatch.Start();
            BubbleSort(tallista);
            stopWatch.Stop();
            Console.WriteLine("Listan sorterades på: " + stopWatch.Elapsed);

            //Sorterar 100 000 tal
            for (int i = 0; i < 100000; i++)
            {
                tallista.Add(slump.Next(1000000));
            }
            stopWatch.Reset();
            stopWatch.Start();
            BubbleSort(tallista);
            stopWatch.Stop();
            Console.WriteLine("Listan sorterades på: " + stopWatch.Elapsed);
        }
    }
}
