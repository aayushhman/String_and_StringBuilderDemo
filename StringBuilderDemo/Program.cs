using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
          string s1 = "Aayush";
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            for (int i = 0; i < 10000; i++)
            {
                s1 = s1 + i;
               
            }
            sw1.Stop();
            StringBuilder sb = new StringBuilder();
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            for (int i = 0; i < 10000; i++)
            {
                sb.Append(i);
            }
            sw2.Stop();
            Console.WriteLine("Time taken by string:" + sw1.ElapsedMilliseconds);
            Console.WriteLine("Time taken by stringBuilder:" + sw2.ElapsedMilliseconds);

            Console.ReadLine();
        }
    }
}
