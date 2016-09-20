using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Latihan
{
    class LatihanPola
    {
        public void Pola()
        {
            Console.Write("Masukan Bilangan ?..");
            int bil = Convert.ToInt16(Console.ReadLine());
            int loop = 0;
            for (int i = bil; i > 0; i--)
            {
                loop++;
                for (int x = loop; x != 0; x--)
                {
                    Console.Write(x);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
