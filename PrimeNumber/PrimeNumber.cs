using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class PrimeNumber
    {

        public static void Prime()
        {
            int Num, checkprime = 1;
            Console.Write("Enter Number To Check Number is prime or not:");
            Num = Convert.ToInt16(Console.ReadLine());
            for (int i = 2; i <= Num / 2; i++)
            {
                if (Num % i == 0)
                {
                    checkprime = 0;
                }

            }
            if (checkprime == 1)
                Console.Write(Num + " Is a Prime Number\n\n");


            else
            {
                Console.Write(Num + " Is Not Prime Number\n\n");
            }

        }
    }
}

     

        
    

