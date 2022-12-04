using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    internal class Program
    {
        public static int oglindint(int a)
        {
            int ogl=0;
            while(a!=0)
            {
                ogl = ogl * 10 + a % 10;
                a /= 10;
            }
            return ogl;
        }
        static void Main(string[] args)
        {
            int n, x, s=0;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                x = Convert.ToInt32(Console.ReadLine());
                s += oglindint(x);
            }
            Console.WriteLine(s);
            Console.Read();
        }
    }
}
