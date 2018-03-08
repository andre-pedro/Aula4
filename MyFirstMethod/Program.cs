using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMethod
{
    class Program
    {
        static void CountToN(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            int num;
            num = Convert.ToInt32(args[0]);
            CountToN(num);

        }
    }
}
