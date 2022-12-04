using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, p=1;
            n= Convert.ToInt32(Console.ReadLine());
            Console.Write((n*(n+1))/2 + " ");
            for(int i = 2; i <= n; i++)
            {
                p *= i;
            }
            Console.Write(p);
            Console.Read();
        }
    }
}
