using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int row;
            int column;
            Console.Write("enter the row value of the array:");
            row = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the column value of the array:");
            column = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[row, column];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    array[i, j] = rand.Next(1, 9);
                }
            }
            int big, small;
            Console.Write("pls enter the big value:");
            big = Convert.ToInt32(Console.ReadLine());
            Console.Write("pls enter the small value:");
            small = Convert.ToInt32(Console.ReadLine());
            Array_Write(array, row, column);
            Console.WriteLine("-------------------------------");
            result(array, row, column, big, small);

            Console.ReadLine();
        }
        static void Array_Write(int[,] array, int row, int column)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(array[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
        static void result(int[,] array, int row, int column, int big, int small)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (small <= array[i, j] && array[i, j] <= big)
                        Console.Write("x  ");
                    else if (array[i, j] < small)
                        Console.Write("*  ");
                    else if (array[i, j] > big)
                        Console.Write("-  ");
                }
                Console.WriteLine();
            }
        }

    }
}
