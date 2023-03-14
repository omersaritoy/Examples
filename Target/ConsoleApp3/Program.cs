using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    //this problem try to find target in array
    //for instance array is[4,8,12,5.3,2,4] target is 12    
    //our code have to return [1,2] and [2,7] or [-1,-1] 
    //solution with classes
    internal class Program
    {
        static void Main(string[] args)
        {
            int Target, Size;
            Console.Write("Please enter size of Array:");
            Size = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[Size];
            Console.Write("Please enter the target you are looking for:");
            Target = Convert.ToInt32(Console.ReadLine());

            Solition solition = new Solition();
            solition.Write(Array, Size);
    
            solition.SearchRange(Array, Size, Target);

            Console.ReadLine();

        }
    }

    class Solition
    {   
        public void Write(int[] Array,int Size)
        {
            Random random = new Random();
            
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = random.Next(0,100);
            }
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine("[{0}].element={1}", i + 1, Array[i]);
            }
        }

        public void SearchRange(int[] Array, int Size, int Target)
        {   
            int count=0;
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j =i+1; j < Array.Length; j++)
                {
                    if (Array[i] + Array[j] == Target)
                    {
                        Console.WriteLine("["+(i+1)+","+(j+1)+"]");
                        count = 1;

                    }
                }
            }
            if (count!=1)
            {
                Console.WriteLine("[-1,-1]");
            }
            
        }
    }
}
