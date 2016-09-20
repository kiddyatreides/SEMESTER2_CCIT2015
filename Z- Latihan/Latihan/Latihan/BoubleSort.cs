using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Latihan
{
    class BoubleSort
    {
        int [] array = {10,3,5,6,7,100,1,8,11,20,23,35,50,60,40,30,90,70,80};
        public void bouble()
        {
            int pass = 0;
            int x = 1;
            while (pass < array.Length)
            {
                int index = 0;
                while(index < (array.Length - x))
                {
                    if (array[index] > array[index + 1])
                    {
                        int temp = array[index + 1];
                        array[index + 1] = array[index];
                        array[index] = temp;
                    }
                    index++;
                }
                pass++;
                x++;
            }
            Console.Write("Pengurutan Bubble sort : ");
            foreach (int c in array)
            {
                Console.Write(c + " ");
            }
        }
    }
}
