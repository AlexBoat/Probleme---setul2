using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x1, x2, primul_element;
            bool cresc = true, rotire = false;
            n = Convert.ToInt32(Console.ReadLine());
            x1 = Convert.ToInt32(Console.ReadLine());
            primul_element = x1;
            for (int i = 1; i < n; i++)
            {
                x2 = Convert.ToInt32(Console.ReadLine());
                if ((i == n - 1 && x2 > primul_element) || (x2 < x1 && rotire == true))
                {
                    cresc = false;
                }
                if(x2<x1 && rotire==false)
                {
                    rotire= true;
                }
                x1 = x2;
            }
            if(cresc==true)
            {
                Console.WriteLine("Secventa este crescatoare rotita!");
            }
            else
            {
                Console.WriteLine("Secventa NU este crescatoare rotita!");
            }
            Console.Read();
        }
    }
}
