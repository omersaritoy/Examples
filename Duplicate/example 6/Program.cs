using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // delete dupicate number in array
            Random random = new Random();
            Console.Write("Enter size of array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            int i, j, k;

            for (i = 0; i < size; i++)
            {
                array[i] = random.Next(0, 9);
            }
            foreach(int a in array)
            {
                Console.Write(a+" ");
            }

            for (i = 0; i < size; i++)
            {
                for (j = i+1; j <size; j++)
                {
                    if (array[i] == array[j])
                    {
                        for (k = j; k < size-1 ; k++)
                        {
                            array[k] = array[k+1];
                        }
                        size--;
                        j--;
                    }
                }
            }
            Console.WriteLine("\nArray content after duplicate values ​​are deleted : ");
            for (i = 0; i < size; i++)
            {
                Console.Write(array[i]+" ");
            }
            Console.ReadLine();
        }
    }
}
