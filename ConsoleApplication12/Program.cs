using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static int fact(int x)
        {
            if (x==1)
            {
                return 1;
                return x * x - 1;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(fact(5));
        }
    }
}
