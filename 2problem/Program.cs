using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of elements: ");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            int maxCount = 0;
            int currentCount = 1;
            int sequenceStart = 0;
            for (int index = 0; index < length; index++)
            {
                Console.Write("Enter element {0}: ", index);
                arr[index] = int.Parse(Console.ReadLine());
                if (index != 0)
                {
                    if (arr[index] == arr[index - 1])
                    {
                        currentCount++;
                    }
                    else
                    {
                        currentCount = 1;
                    }
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        sequenceStart = index + 1 - maxCount;
                    }
                }
            }

            Console.Write("The maximal sequence of equal elements is: ");
            for (int index = sequenceStart; index < sequenceStart + maxCount; index++)
            {
                Console.Write("{0} ", arr[index]);
            }

            Console.ReadLine();

        }
    }
}
