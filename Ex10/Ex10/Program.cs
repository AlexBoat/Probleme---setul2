using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x1, x2, nr=1, max=1;
            n = Convert.ToInt32(Console.ReadLine());
            x1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                x2 = Convert.ToInt32(Console.ReadLine());
                if(x1==x2)
                {
                    nr++;
                    if (nr > max)
                        max = nr;
                }
                else
                {
                    nr = 1;
                }
                x1 = x2;
            }
            Console.WriteLine(max);
            Console.Read();
        }
    }
}
