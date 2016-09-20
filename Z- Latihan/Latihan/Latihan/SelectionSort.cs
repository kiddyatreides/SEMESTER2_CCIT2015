using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Latihan
{
    class SelectionSort
    {
        int[] array = { 5, 6, 7, 8, 34, 56, 7, 23, 8, 89, 1, -1, 0, -2 };
        int pass = 0;
        public void selection()
        {
            while (pass < array.Length)
            {
                int index = pass;
                int min = array[pass];
                int address_min = pass;
                while (index < (array.Length - 1))
                {
                    if (min > array[index + 1])
                    {
                        min = array[index + 1];
                        address_min = index + 1;
                    }
                    index++;
                }
                int temp = array[pass];
                array[pass] = array[address_min];
                array[address_min] = temp;
                pass++;
            }
            Console.Write("Pengurutan Selection Sort : ");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }
    }
}
