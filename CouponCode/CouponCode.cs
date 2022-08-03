using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class CouponCode
    {

        public static int Generator()
        {
            int Code;
            Code = Convert.ToInt32(new Random().Next(0, 20));
            return Code;

        }
        public static void couponCode()
        {
            Console.Write("Enter the number of unique coupons request:");
            int check=Generator();
            int count=0;
            int n = Convert.ToInt32(Console.ReadLine());
            int Coupon_Code = Generator();

            while (n > 0)
            {
                if ( check == n)
                {
                    Console.WriteLine("coupon numbers.");
                    break;
                }

                count++;
                Console.WriteLine(" coupon numbers Are:" + count);
                n--;
            }
            Console.WriteLine(" The number of times random number using:" + count);



        }
    }
}

     

        
    

