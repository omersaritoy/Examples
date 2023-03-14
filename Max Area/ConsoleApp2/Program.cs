using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        // Container With Most Water 
        //Explanation: The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7].
        //In this case, the max area of water (blue section) the container can contain is 49.

        static void Main(string[] args)
        {
            int[] container_hight = new int[10];
            Value(container_hight);

            Console.WriteLine("solituon=" + Max_Container_Value(container_hight));

            Console.ReadLine();
        }

        static void Value(int[] height)
        {
            Random rand = new Random();

            for (int i = 0; i < height.Length; i++)
            {
                height[i] = rand.Next(1, 10);
            }
            foreach (var write in height)
            {
                Console.WriteLine(write);
            }
        }


        

        
        static int Max_Container_Value(int[] height)
        {
            int Max_Area = 0;
            int a_pointer = 0;
            int b_pointer = height.Length - 1;

            while (a_pointer < b_pointer)
            {
                if (height[a_pointer] < height[b_pointer])
                {
                    Max_Area = Math.Max(Max_Area, height[a_pointer] * (b_pointer - a_pointer));
                    a_pointer++;
                }
                else
                {
                    Max_Area = Math.Max(Max_Area, height[b_pointer] * (b_pointer - a_pointer));
                    b_pointer--;
                }
            }
            return Max_Area;
        }
        
        
        
        /*
        static int Max_Container_Value(int[] height)
        {
            int maxArea = 0;
            for (int i = 0; i < height.Length; i++)
            {
                for (int j = 0; j < height.Length; j++)
                    maxArea = Math.Max(maxArea, Math.Abs(i - j) * Math.Min(height[i], height[j]));
            }   
            return maxArea;
        }*/
    }
}
