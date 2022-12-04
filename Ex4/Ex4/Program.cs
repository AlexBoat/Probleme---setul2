using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, a, x, poz=-1;
            n = Convert.ToInt32(Console.ReadLine());
            a = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i<n; i++)
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (x == a)
                {
                    poz = i;
                }
            }
            Console.WriteLine("{0} se afla pe pozitia {1}", a, poz);
            Console.Read();
            
        }
    }
}
