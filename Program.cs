using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first lenght: ");
            int length1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second lenght: ");
            int length2 = int.Parse(Console.ReadLine());

            char[] array1 = new char[length1];
            char[] array2 = new char[length2];
            int index = 0;

            for (int i = 0; i < length1; i++)
            {
                Console.WriteLine("Enter {0} letter from first array", i + 1);
                array1[i] = char.Parse(Console.ReadLine());
            }

            for (int i = 0; i < length2; i++)
            {
                Console.WriteLine("Enter {0} letter from second array", i + 1);
                array2[i] = char.Parse(Console.ReadLine());
            }

            for(int i = 0; i< length1 && i < length2; i ++)
            {
                if (array1[i] == array2[i])
                {
                    index++;
                }
                else
                {
                    Console.WriteLine("The to arrays are no comparable.");
                    break;
                }

                if(index != 0)
                {
                    Console.WriteLine("The two arrays are comparable.");
                }

                Console.ReadLine();
            }
        }
    }
}
