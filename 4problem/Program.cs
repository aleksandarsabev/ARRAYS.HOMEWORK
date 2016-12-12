using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int index = 0; index < n; index++)
            {
                Console.Write("Enter element {0}: ", index);
                arr[index] = int.Parse(Console.ReadLine());
            }
            int min = int.MaxValue;
            int minIndex = 0;
            int temp = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (arr[j] < min)
                    {
                        min = arr[j];
                        minIndex = j;
                    }
                }
                temp = arr[i];
                arr[i] = min;
                arr[minIndex] = temp;
                min = int.MaxValue;
            }

            for (int index = 0; index < n; index++)
            {
                Console.Write("{0} ", arr[index]);
            }
            Console.ReadLine();
        }

    }
}
