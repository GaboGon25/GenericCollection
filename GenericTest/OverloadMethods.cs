using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTest
{
    public static class OverloadMethods
    {
       // output int array
       public static void DisplayArray(int[] inputArray)
        {
            foreach(var item in inputArray)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine();
        }

        // output char array
        public static void DisplayArray(char[] inputArray)
        {
            foreach (var item in inputArray)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine();
        }
    }
}
