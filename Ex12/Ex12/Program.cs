using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x1, x2, nr=0;
            n = Convert.ToInt32(Console.ReadLine());
            x1 = Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<n; i++)
            {
                x2 = Convert.ToInt32(Console.ReadLine());
                if(x2 == 0 && x1 != 0)
                {
                    nr++;
                }
                if(i==n-1 && x2!=0)
                {
                    nr++;
                }
                x1 = x2;
            }
            if (n == 1 && x1 != 0)
                nr = 1;
            
            Console.WriteLine(nr + " secvente");
            Console.Read();
        }
    }
}
