using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Latihan
{
    class InsertionSort
    {
        int[] array = { 5, 6, 7, 8, 34, 56, 7, 23, 8, 89, 1, -1 ,-2 };
        public void insert()
        {
            for (int i = 1; i < array.Length; i++)
            {
                int temp = array[i];
                int j = i;
                while ((j > 0) && (temp < array[j - 1]))
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = temp;
            }
            Console.Write("Pengurutan Insertion Sort : ");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }
    }
}
