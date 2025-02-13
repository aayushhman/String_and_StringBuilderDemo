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
            Console.WriteLine("Enter a sentence:");
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
            {
                if (!"aeiouAEIOU".Contains(c))
                {
                    sb.Append(c);
                }

            }
            Console.WriteLine("Modified sentence:" + sb.ToString());
            //  StringBuilder sb = new StringBuilder("Hello world");
            //  sb.Replace("world", "C#");
            //    sb.Remove(6, 5);
            //  sb.Insert(5, " Aayush");

            //  sb.AppendFormat("{0:N}", 2500);
            //Console.WriteLine(sb);

            Console.ReadLine();
        }
    }
}
