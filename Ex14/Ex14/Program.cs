using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x1, x2, primul_element;
            bool cresc = true, rotire = false, stabilit=false, ok=true;
            n = Convert.ToInt32(Console.ReadLine());
            x1 = Convert.ToInt32(Console.ReadLine());
            primul_element = x1;
            for (int i = 1; i < n; i++)
            {
                x2 = Convert.ToInt32(Console.ReadLine());
                if(x2<x1 && stabilit == false)
                {
                    cresc = false;
                    stabilit = true;
                }
                if(x2>x1 && stabilit == false)
                {
                    stabilit = true;
                }
                //cresc
                if (cresc==true && stabilit==true && x2 < x1 && rotire == true)
                {
                    ok = false;
                }
                if (stabilit==true && cresc==true && x2 < x1 && rotire == false)
                {
                    rotire = true;
                    if(i==n-1 && x2 > primul_element)
                    {
                        ok = false;
                    }
                }
                //descresc
                if (cresc == false && stabilit == true && x2 > x1 && rotire == true)
                {
                    ok = false;
                }
                if (stabilit == true && cresc == false && x2 > x1 && rotire == false)
                {
                    rotire = true;
                    if (i == n - 1 && x2 < primul_element)
                    {
                        ok = false;
                    }
                }
                x1 = x2;
            }
            if (ok == true)
            {
                Console.WriteLine("Secventa este monotona rotita!");
            }
            else
            {
                Console.WriteLine("Secventa NU este monotona rotita!");
            }
            Console.Read();
        }
    }
}
