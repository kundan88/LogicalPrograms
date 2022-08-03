namespace LogicalProgram
{
     public class Program
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Enter the number for problem.\n");
                Console.WriteLine("1 Fibonacci Series.");
                Console.WriteLine("2 Prime Number.");
                Console.WriteLine("3 Perfect Number.");
                Console.WriteLine("4 Reverse Number.");
                Console.WriteLine("5 Stop Watch.");
                Console.WriteLine("6 Coupon Code.");

                int problem = Convert.ToInt32(Console.ReadLine());
                Program Logic = new Program();
                switch (problem)
                {
                    case 1:
                        FibonacciSeries.Fibonacci();
                        break;
                    case 2:
                        PrimeNumber.Prime();
                        break;
                    case 3:
                        PerfectNumber.Perfect();
                        break;
                    case 4:
                         ReverseNumber.Reverse();
                        break;
                    case 5:
                         StopWatch.stopWatch();
                        break;
                    case 6:
                         CouponCode.couponCode();
                        break;
                    default:
                        Console.WriteLine("Enter the valid nmber from 1 to 6");
                        break;

                }

            }
        }
}
    

