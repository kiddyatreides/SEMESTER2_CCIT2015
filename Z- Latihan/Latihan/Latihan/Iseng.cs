using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Latihan
{
    class Iseng
    {
        public void test()
        {
            string aku = "gw"; string kamu = "lu"; string kita = aku + kamu; string pacaran = "iya"; int cobalagi = 100;
            if (kita == pacaran)
            {
                Console.WriteLine("ALHAMDULILLAH");
            }
            else
            {
                for (int coba = 0 ; coba > cobalagi ; coba++)
                {
                    string carakesatu = "kesih perhatian terus";
                    string carakedua = "di buat selalu senang dan nyaman";
                    if (kita == carakesatu && kita == carakedua && kita == pacaran )
                    {
                        Console.WriteLine("ALHAMDULILLAH AKHIRNYA BERHASIL PACARAN JUGA");
                    }
                    else
                    {
                        Console.WriteLine("CARI CEWE LAIN AJA !!!");
                    }
                }
            }
        }
    }
}
