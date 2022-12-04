using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x1, x2;
            bool bitonica = true, cresc = true;
            n = Convert.ToInt32(Console.ReadLine());
            x1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                x2 = Convert.ToInt32(Console.ReadLine());
                if(cresc ==  true && x2 < x1)
                {
                    cresc = false;
                }
                if(cresc == false && x2 > x1)
                {
                    bitonica = false;
                }
                x1 = x2;
            }
            // 1 2 mai este bitonica??
            if (n>2 && bitonica == true)
            {
                Console.WriteLine("Secventa este bitonica!");
            }
            else
            {
                Console.WriteLine("Secventa NU este bitonica!");
            }
            Console.Read();
        }
    }
}
