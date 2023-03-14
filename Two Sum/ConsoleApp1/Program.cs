using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        //this problem try to find target in array
        //for instance array is[4,8,12,5.3,2,4] target is 12    
        //our code have to return [1,2] and [2,7]
         
        static void Main(string[] args)
        {

            int[] Array=new int[10];
            Random randoms = new Random();
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = randoms.Next(0,40);
            }
            int target;
            Console.Write("please enter a target for solution:");
            target = Convert.ToInt32(Console.ReadLine());

            Write(Array);
            Target(Array, target);

            Console.ReadLine();
        }

        static void Write(int[] array)
        {
            foreach (var elements in array)
            {
                Console.WriteLine(elements);
            }
        }



        static void Target(int[] array,int target) 
        {

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j <array.Length; j++)
                {
                    if (array[i] + array[j]==target)
                    {
                        Console.WriteLine("["+(i+1)+","+(j+1)+"]");
                    }
                }
            }
        
        }
    }
}
