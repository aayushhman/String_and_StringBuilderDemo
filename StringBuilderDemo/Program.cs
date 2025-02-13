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
            StringBuilder sb = new StringBuilder("Hello world");
            sb.Replace("world", "C#");
        //    sb.Remove(6, 5);
          //  sb.Insert(5, " Aayush");

          //  sb.AppendFormat("{0:N}", 2500);
            Console.WriteLine(sb);

            Console.ReadLine();
        }
    }
}
