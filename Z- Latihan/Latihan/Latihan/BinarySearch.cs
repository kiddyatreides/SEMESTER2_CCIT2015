using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Latihan
{
    class BinarySearch
    {
        int[] sort = { 68, 80, 33, 4, 6, 10, 15, 2, 3, 70, 30, 3, 100, 30, 60 };
        public void binary()
        {
            for (int i = 1; i < sort.Length; i++) //Pengurutannya 
            {
                int temp = sort[i];
                int j = i;
                while ((j > 0) && (temp < sort[j - 1]))
                {
                    sort[j] = sort[j - 1];
                    j--;
                }
                sort[j] = temp;
            }
            int target = 15;
            int lower = 0;
            int upper = sort.Length - 1;
            int mid = (lower + upper) / 2;
            while (sort[mid] != target && lower <= upper)
            {
                if (target > sort[mid])
                {
                    lower = mid + 1;
                }
                else
                {
                    upper = mid - 1;
                }
                mid = (lower + upper) / 2;
            }
            if (target == sort[mid])
            {
                Console.WriteLine("Found");
            }
            else
            {
                Console.WriteLine("Not Found");
            }

        }
    }
}
