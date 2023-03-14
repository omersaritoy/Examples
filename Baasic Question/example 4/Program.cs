using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_4
{
    internal class Program
    {
        // array 1 --> 1 7 5 array 2-->1 2 4  we should add array1 and array2 same index element 
        //1+1 7+2 5+4 and make it 2 9 9 and reverse it and add third array 
        //third array -->9 9 2
        static void Main(string[] args)
        {
            int size1, size2;
            Console.Write("Enter size1 :");
            size1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter size 2:");
            size2 = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int[size1];
            int[] array2 = new int[size2];
            Write(array1, array2, size1, size2);
            reverse(array1, array2, size1, size2);
            result(array1, array2, size1, size2);

            Console.ReadLine();

        }
        static void Write(int[] array1, int[] array2, int size1, int size2)
        {
            Random random = new Random();

            for (int i = 0; i < size1; i++)
            {
                array1[i] = random.Next(0, 9);
            }
            for (int i = 0; i < size2; i++)
            {
                array2[i] = random.Next(0, 9);
            }
            Console.WriteLine("Elements of first Array");
            for (int i = 0; i < size1; i++)
                Console.WriteLine("{0}.element:{1}", i + 1, array1[i]);

            Console.WriteLine("\nElements of second Array");
            for (int i = 0; i < size2; i++)
                Console.WriteLine("{0}.element:{1}", i + 1, array2[i]);

        }

        static void reverse(int[] array1, int[] array2, int size1, int size2)
        {
            int j = size1 - 1;
            for (int i = 0; i < size1; i++)
            {
                array1[j] = array1[i];
                j--;
            }
            j = size2 - 1;
            for (int i = 0; i < size2; i++)
            {
                array2[j] = array2[i];
                j--;
            }

        }
        static void result(int[] array1, int[] array2, int size1, int size2)
        {
            int top = 0;//top mean Sum
            int k = 1;
            for (int i = 0; i < size1; i++)
            {
                top += array1[i] * k;
                k *= 10;
            }

            k = 1;
            for (int i = 0; i < size2; i++)
            {
                top += (array2[i] * k);
                k *= 10;
            }
            Console.Write("Sum =" + top);
            k = 1;
            int top1 = top;
            for (int i = 0; ; i++)
            {
                int temp = top1;
                if (top1 > 10)
                {
                    top1 = temp / 10;
                    temp = temp / 10;
                    k++;
                }
                else
                    break;
            }
            for (int i = 0; i < k; i++)
            {
                array1[i] = top % 10;
                top /= 10;
            }
            Console.WriteLine("\n\n");
            Console.Write("Elements of third Array=");
            for (int i = 0; i < k; i++)
            {
                Console.Write(" " + array1[i]);
            }

        }

    }
}
