using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Sortering
{
    class Program

    {

        static void BubbleSort(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }

        static void InsertionSort(List<int> list)
        {
            int i, j;
            for (i = 1; i < list.Count; i++)
            {
                int item = list[i];
                int ins = 0;
                for (j = i - 1; j >= 0 && ins != 1;)
                {
                    if (item < list[j])
                    {
                        list[j + 1] = list[j];
                        j--;
                        list[j + 1] = item;
                    }
                    else ins = 1;
                }
            }
        }

        static void SelectionSort(List<int> list)
        {
            int pos_min, temp;

            for (int i = 0; i < list.Count - 1; i++)
            {
                pos_min = i;

                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j] < list[pos_min])
                    {
                        pos_min = j;
                    }
                }

                if (pos_min != i)
                {
                    temp = list[i];
                    list[i] = list[pos_min];
                    list[pos_min] = temp;
                }
            }
        }
            static void SkapaSlumplista(List<int> List, int size)
            {
                Random slump = new Random();
                for (int i = 0; i < size; i++)
                {
                    List.Add(slump.Next(100000));
                }
            }

            static void Main(string[] args)
            {
                Stopwatch sw = new Stopwatch();
                int listSize = 100000;
                List<int> tallista1 = new List<int>();
                List<int> tallista2 = new List<int>();
                List<int> tallista3 = new List<int>();

                SkapaSlumplista(tallista1, listSize);
                SkapaSlumplista(tallista2, listSize);
                SkapaSlumplista(tallista3, listSize);

                sw.Reset();
                sw.Start();
                BubbleSort(tallista1);
                sw.Stop();
                Console.WriteLine("Bubblesort: " + sw.ElapsedMilliseconds + " Millisekunder");

                sw.Reset();
                sw.Start();
                InsertionSort(tallista2);
                sw.Stop();
                Console.WriteLine("Insertionsort: " + sw.ElapsedMilliseconds + " Millisekunder");

                sw.Reset();
                sw.Start();
                SelectionSort(tallista3);
                sw.Stop();
                Console.WriteLine("SelectionSort: " + sw.ElapsedMilliseconds + " Millisekunder");
        }
    }
}