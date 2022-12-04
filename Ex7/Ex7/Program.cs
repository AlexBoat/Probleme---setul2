using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x, min=int.MaxValue, max=int.MinValue;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                x = Convert.ToInt32(Console.ReadLine());
                if(x > max)
                {
                    max = x;
                }
                if(x < min)
                {
                    min = x;
                }
            }
            Console.WriteLine(min + " " + max);
            Console.Read();
        }
    }
}
