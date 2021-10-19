using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201019_orai
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t = { 1, 2, 4,5,8 };
            int[] tz = new int[10];

            for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine(t[i]);
            }

            Random r = new Random();
            for (int i = 0; i < tz.Length; i++)
            {
                tz[i] = r.Next(1,101);
                Console.WriteLine(tz[i]);
            }
            int os = 0;
            for (int i = 0; i < tz.Length; i++)
            {
                os+=tz[i];
            }
            Console.WriteLine("Összeg: {0}",os);
            int atl = os / tz.Length;
            Console.WriteLine("Az atlag: {0}", atl);
            //int max = tz.Max();
            //Console.WriteLine("max: {0}", max);
            int max = tz[0];
            for (int i = 0; i < tz.Length; i++)
            {
                if (max < tz[i])
                {
                    max = tz[i];
                }
            }
            Console.WriteLine(max);

            for (int i = 0; i < tz.Length; i++)
            {
                if (tz[i]%2==0)
                {
                    Console.WriteLine(tz[i]);
                }
            }
            Console.WriteLine("Rendezés:");
            for (int i = 0; i < tz.Length; i++)
            {
                for (int j = 0; j < tz.Length; j++)
                {
                    if (tz[j]>tz[i])
                    {
                        tz[j] = tz[j] + tz[i];
                        tz[i] = tz[j] - tz[i];
                        tz[j] = tz[j] - tz[i];
                    }
                }
            }
            for (int i = 0; i < tz.Length; i++)
            {
                Console.WriteLine(tz[i]);
            }

            Console.ReadKey();
        }
    }
}
