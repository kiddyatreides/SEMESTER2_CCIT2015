using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Latihan
{
    class BubbleWithtxt
    {
        public void sorthighscore()
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
            int z = 1;
            while (pass < score.Length)
            {
                int index = 0;
                while (index < (score.Length - z))
                {
                    if (score[index] > score[index + 1])
                    {
                        int temp1 = score[index + 1];
                        score[index + 1] = score[index];
                        score[index] = temp1;

                        string temp2 = nama[index + 1];
                        nama[index + 1] = nama[index];
                        nama[index] = temp2;
                    }
                    index++;
                }
                pass++;
                z++;
            }
            foreach (string a in nama)
            {
                Console.Write(a + " "
                    );
            }
            Console.WriteLine();
            foreach (int a in score)
            {
                Console.Write(a + " ");
            }
        }
    }
}
