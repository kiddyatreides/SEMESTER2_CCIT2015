using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Latihan
{
    class LatihanSearch
    {
        public void cari()
        {
            FileStream fs = new FileStream("cari.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            Console.Write("Masukan ID Pencarian :");
            string id = Console.ReadLine();
            int target = Convert.ToInt16(id);

            string line = sr.ReadLine();
            char delim = '#';
            string[] isi = line.Split(delim); 

            while (line != null) //apabila barisnya tidak kosong
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }

            sr.Close();
            fs.Close();
            int a = 0;
            while (a < isi.Length)
            {
                if (Convert.ToInt16(isi[a]) == target)
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
