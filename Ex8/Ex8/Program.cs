using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    internal class Program
    {
        public static ulong Fibonacci(int x)
        {
            if(x == 0)
                return 0;
            if (x == 1)
                return 0;
            if (x == 2)
                return 1;
            return (Fibonacci(x-1) + Fibonacci(x-2));
        }
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fibonacci(n));
            Console.Read();
        }
    }
}
