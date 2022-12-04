using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x1, x2;
            n = Convert.ToInt32(Console.ReadLine());
            bool cresc = false, ok = true;
            if(n == 1)
            {
                x1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Este monoton");
            }
            else
            {
                x1 = Convert.ToInt32(Console.ReadLine());
                x2 = Convert.ToInt32(Console.ReadLine());
                if(x1 < x2)
                    cresc = true;
                x1 = x2;
                for (int i = 2; i < n; i++)
                {
                    x2 = Convert.ToInt32(Console.ReadLine());
                    if(cresc==true && x1>x2)
                    {
                        ok = false;
                    }
                    if(cresc == false&&x1<x2)
                    {
                        ok = false;
                    }
                    x1 = x2;
                }
                if (ok == true)
                    Console.WriteLine("Este monoton");
                else
                    Console.WriteLine("NU este monoton");
            }
            Console.Read();
        }
    }
}
