using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array's lenght: ");
            int lenght = int.Parse(Console.ReadLine());
            int[] arr = new int[lenght];

            for (int value = 0; value < lenght; value++)
            {
                Console.WriteLine("Enter element {0}: ", value);
                arr[value] = int.Parse(Console.ReadLine());
            }

            int temp = 0;

            for (int index = 0; index < lenght; index++)
            {
                for (int sort = 0; sort < lenght - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp; 
                    }
                }
            }

            for(int i = 0; i < lenght; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
