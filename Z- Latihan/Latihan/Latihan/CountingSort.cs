using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Latihan
{
    class CountingSort
    {
        public void counting()
        {
            int[] sort = { 68, 80, 33, 4, 6, 10, 2, 3, 70, 30, 3, 100 };
            int[] count = new int[101];
            for (int pass = 1; pass <= 2; pass++)
            {
                if (pass == 1)
                {
                    for (int i = 0; i < sort.Length; i++)
                    {
                        count[sort[i]]++;
                    }
                }
                else
                {
                    int z = 0;
                    for (int y = 0; y < count.Length; y++)
                    {
                        for (int x = 0; x < count[y]; x++)
                        {
                            sort[z] = y;
                            z++;
                        }
                    }
                }
            }
            Console.WriteLine("Hasil Sort : ");
            foreach (int i in sort)
            {
                Console.Write(i + " ");
            }
        }
    }
}
