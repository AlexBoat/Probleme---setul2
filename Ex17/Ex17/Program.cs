using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, nr_0 = 0, nr_1 = 0, x1, x2, nivel = 1, nivel_max=1;
            bool ok=true;
            n = Convert.ToInt32(Console.ReadLine());
            x1 = Convert.ToInt32(Console.ReadLine());
            if(x1 == 1)
            {
                ok = false;
                nr_1++;
            }
            else
            {
                nr_0++;
            }
            for (int i = 1; i < n; i++)
            {
                x2 = Convert.ToInt32(Console.ReadLine());
                if(i==n-1 && x2==0)
                {
                    ok = false;
                }
                if(x2==0)
                {
                    nr_0++;
                    if(x1==0)
                    {
                        nivel++;
                        if(nivel>nivel_max)
                        {
                            nivel_max = nivel;
                        }
                    }
                }
                else
                {
                    nr_1++;
                    if(nivel>1)
                    {
                        nivel--;
                    }
                }
                x1 = x2;
            }
            if(nr_0==nr_1 && ok==true)
            {
                Console.WriteLine("Secventa corecta de paranteze!");
                Console.WriteLine("Nivel maxim de incuibare: {0}", nivel_max);
            }
            else
            {
                Console.WriteLine("Secventa incorecta de paranteze..");
            }
            Console.Read();
        }
    }
}
