using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x, nrneg = 0, nrzero=0, nrpoz=0;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (x<0)
                {
                    nrneg++;
                }
                else
                {
                    if(x==0)
                    {
                        nrzero++;
                    }
                    else
                    {
                        nrpoz++;
                    }

                }
            }
            Console.WriteLine(nrneg + " " + nrzero + " " + nrpoz);
            Console.Read();
        }
    }
}
