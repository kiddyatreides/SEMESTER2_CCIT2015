using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Latihan
{
    class LinearSearch
    {
        int[] sort = { 68, 80, 33, 4, 6, 10, 2, 3, 70, 30, 3, 100 };
        public void linear()
        {
            int target = 10;
            int a = 0;
            while (a < sort.Length)
            {
                if (sort[a] == target)
                {
                    Console.WriteLine("Found");
                    break;
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                a++;
            }
        }
    }
}
