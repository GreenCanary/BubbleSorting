using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorting
{
    internal class Program
    {
        static void bubbleSort(int[] arr, int n)
        {
            int i, j, t;
            bool swap;
            for (i = 0; i < n - 1; i++)
            {
                swap = false;
                for (j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        t = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = t;
                        swap = true;
                    }
                }
                if (swap == false)
                    break;
            }
        }

        static void Main(string[] args)
        {
            int[] arr = new int[7];
            int n = arr.Length;

            Console.WriteLine("Type in your array:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            bubbleSort(arr, n);

            Console.WriteLine("Sorted array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

// Ivanov M.V.