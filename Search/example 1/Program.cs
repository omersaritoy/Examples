using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //looking a number in array

           int[] array = new int[100];
            int a;
            Console.Write("pls enter the size of the array:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("pls enter the elements of the array");
            for (int i = 0; i < a; i++)
            {
                Console.Write("{0}.elements:", i + 1);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int number;
            Console.Write("enter the number you are searching:");
            number = Convert.ToInt32(Console.ReadLine());
            int j = 0;

            /*foreach (int k in array)
            {
                if (k == number)
                    j++;
            }*/
         
            for (int i = 0;i < a; i++)
            {
                if (array[i] == number)
                    j++;
            }

            if (j != 0)
                Console.WriteLine("the number you are looking for is available in the array:" + number);
            else
                Console.WriteLine("the number you are looking for does not exist in the array");
            


            Console.ReadLine();
        }
    }
}
