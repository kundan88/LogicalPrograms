using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public static class PerfectNumber
    {
        public static void Perfect()
        {
            int n, sum, mx, mn, i;
            Console.WriteLine("Enter Starting Number");
            mn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the end Range of the Number");
            mx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Perfect Number within given Range");

            for (n = mn; n <= mx; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)

                        sum = sum + i;
                    i++;
                }
                if (sum == n)

                    Console.Write("{0} , ", n);


            }
        }
    }
}



