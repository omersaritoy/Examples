using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_5
{
    internal class Program
    {   // print 1D and 2D array 
        static void Main(string[] args)
        {
            int diment1;
            Console.Write("Enter the value of the 1st array:");
            diment1 = Convert.ToInt32(Console.ReadLine());

            int row, column;
            Console.Write("Enter the row value of the 2st array:");
            row = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the column value of the 2st array:");
            column = Convert.ToInt32(Console.ReadLine());

            int[] dimen_1 = new int[diment1];

            int[,] dimen_2 = new int[row, column];

            for (int i = 0; i < diment1; i++)
            {
                dimen_1[i] = 3 * i + 5;
            }

            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < column; j++)
                {
                    dimen_2[i,j] = 2 * i + 5 * j + 17;
                }
            }
            print_one_dimen(dimen_1, diment1);
            print_two_dimen(dimen_2, row, column);

            Console.ReadLine();
        }
        static void print_one_dimen(int[] Array,int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write("\t{0}", i);
            }
            Console.WriteLine("\n");
            for(int i = 0; i < size; i++)
            {
                Console.Write("\t{0}", Array[i]);
            }
            Console.WriteLine("");
        }

        static void print_two_dimen(int[,] Array,int size1,int size2)
        {
            Console.Write("\n\t");

            for(int i = 0; i < size2; i++)
            {
                Console.Write("\t{0}", i);
            }
            Console.WriteLine("\n");

            for(int i = 0; i < size1; i++)
            {
                Console.Write("{0}\t", i);
                for(int j = 0; j < size2; j++)
                {
                    Console.Write("\t{0}",Array[i,j]);  
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");

        }

    }
}
