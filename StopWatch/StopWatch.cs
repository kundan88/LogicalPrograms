using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LogicalProgram
{
     public static class StopWatch
     {
         public static void stopWatch()
         {
            Stopwatch stopwatch = new Stopwatch();
             stopwatch.Start();
            for (int i = 0; i < 1000; i++)
             {
                 Thread.Sleep(1);
             }

              stopwatch.Stop();
              Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
         }
      }
}

     

        
    

