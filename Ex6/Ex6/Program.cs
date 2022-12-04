using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n , x1, x2;
            bool ok = true;
            n = Convert.ToInt32(Console.ReadLine());
            x1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                x2 = Convert.ToInt32(Console.ReadLine());
                if (x1>x2)
                {
                    ok = false;
                }
                x1 = x1 + x2;
                x2 = x1 - x2;
                x1 = x1 - x2;
            }
            if (ok == true)
                Console.WriteLine("DA");
            else
                Console.WriteLine("NU");
            Console.Read();
        }
    }
}
