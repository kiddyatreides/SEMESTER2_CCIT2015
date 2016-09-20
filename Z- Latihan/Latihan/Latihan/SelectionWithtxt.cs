using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Latihan
{
    class SelectionWithtxt
    {
        public void selection()
        {
            FileStream fs = new FileStream("highscore.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            int jumlah = File.ReadLines("highscore.txt").Count();
            string[] nama = new string[jumlah];
            int[] score = new int[jumlah];

            string line = sr.ReadLine();
            int x = 0;
            while (line != null)
            {
                string[] isi = line.Split(',');
                nama[x] = isi[0];
                score[x] = Convert.ToInt16(isi[1]);
                x++;
                line = sr.ReadLine();
            }
            int pass = 0;
            while (pass < score.Length)
            {
                int index = pass;
                int min = score[pass];
                int address_min = pass;
                while (index < (score.Length - 1))
                {
                    if (min > score[index + 1])
                    {
                        min = score[index + 1];
                        address_min = index + 1;
                    }
                    index++;
                }
                int temp = score[pass];
                score[pass] = score[address_min];
                score[address_min] = temp;
                pass++;
            }


            foreach (string a in nama)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
            foreach (int a in score)
            {
                Console.Write(a + " ");
            }
        }
    }
}
