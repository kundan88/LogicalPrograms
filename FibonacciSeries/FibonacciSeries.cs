using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public static class FibonacciSeries
    {
        public static void Fibonacci()
        {
            int n1 = 0, n2 = 1, n3, i;
            Console.WriteLine("Enter the number:");
            int Num = Convert.ToInt32(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " ");

            for (i = 2; i < Num; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 +" " );
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
