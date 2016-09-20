using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Latihan
{
    class Program
    {
        public void No1()
        {
            int x = 1;
            while(x <= 20)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine(x);
                }
                x++;
            }
            Console.ReadLine();
        }

        public void No2()
        {
            int x;
            Console.Write("Input Value: ");
            x = Convert.ToInt32(Console.ReadLine());
            if (x > 0)
            {
                Console.WriteLine("This Is Positive Number");
            }
            else if (x < 0)
            {
                Console.WriteLine("This Is Negative Number");
            }
            else
            {
                Console.WriteLine("This Is Zero Number");
            }
            Console.ReadLine();
        }

        public void No3()
        {
            int x = 1;
            if (x <= 10)
            {
                if (x != 4 || x != 8)
                {
                    Console.WriteLine(x);
                }
            }
            Console.ReadLine();
        }

        public void No4()
        {
            ArrayList ArrayGenap = new ArrayList();
            ArrayList ArrayGanjil = new ArrayList();
            int x = 1;
            while(x <= 20)
            {
                if (x % 2 == 0)
                {
                    ArrayGenap.Add(x);
                }
                else if (x % 2 != 0)
                {
                    ArrayGanjil.Add(x);
                }
                x++;
            }
            int a = 0;
            int b = 0;
            while (a < 10)
            {
                Console.Write(ArrayGenap[a] + " ");
                a++;
            }
            Console.WriteLine();
            while (b < 10)
            {
                Console.Write(ArrayGanjil[b] + " ");
                b++;
            }
            Console.ReadLine();
        }

        public void No5()
        {
            ArrayList ArrayGenap = new ArrayList();
            ArrayList ArrayGanjil = new ArrayList();
            ArrayList ArrayResult = new ArrayList();
            int x = 1;
            Console.Write("Input Value: ");
            int value = Convert.ToInt32(Console.ReadLine());
            while (x <= value)
            {
                if (x % 2 == 0)
                {
                     ArrayGenap.Add(x);
                }
                else if (x % 2 != 0)
                {
                    ArrayGanjil.Add(x);
                }
                x++;
            }
            int c = 0;
            int d = value /2;
            int e = 0;
            int f = 0;
            while (e < d)
            {
                if (e > 9)
                {
                    Console.Write(" " + ArrayGenap[e] + " ");
                }
                else
                {
                    Console.Write(ArrayGenap[e] + " ");
                }
                e++;
            }
            Console.WriteLine();
            while (f < d)
            {
                if (f > 9)
                {
                    Console.Write(" " + ArrayGanjil[f] + " ");
                }
                else
                {
                    Console.Write(ArrayGanjil[f] + " ");
                } 
                f++;
            }
            Console.WriteLine("\n---------------------------- +");
            while (c < d)
            {
                int a = Convert.ToInt32(ArrayGenap[c]);
                int b = Convert.ToInt32(ArrayGanjil[c]);
                int res = a + b;
                Console.Write(res + " ");
                c++;
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Program p = new Program();
        a:
            Console.Clear();
            Console.Write("Input Your Choice (1-5): ");
            int pil = Convert.ToInt32(Console.ReadLine());
            switch (pil)
            {
                case 1:
                    p.No1();
                    goto a;
                case 2:
                    p.No2();
                    goto a;
                case 3:
                    p.No3();
                    goto a;
                case 4:
                    p.No4();
                    goto a;
                case 5:
                    p.No5();
                    goto a;
            }
        }
    }
}
