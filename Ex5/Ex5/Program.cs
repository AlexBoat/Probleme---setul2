using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x, nr = 0;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (x == i)
                {
                    nr++;
                }
            }
            Console.WriteLine("{0} elemente", nr);
            Console.Read();
        }
    }
}
