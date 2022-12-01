using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x, nr=0;
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=n; i++)
            {
                x = Convert.ToInt32(Console.ReadLine());
                if(x%2==0)
                {
                    nr++;
                }
            }
            Console.WriteLine(nr);
            Console.Read();
        }
    }
}
