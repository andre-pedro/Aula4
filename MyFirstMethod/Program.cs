using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMethod
{
    class Program
    {
        /// <summary>
        /// Allows user to insert input
        /// </summary>
        /// <param name="n">user input</param>
        static void CountToN(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
        /// <summary>
        /// Converts user input to num and counts till said number
        /// </summary>
        /// <param name="args">arguments</param>
        static void Main(string[] args)
        {
            int num;
            num = Convert.ToInt32(args[0]);
            CountToN(num);

        }
    }
}
