using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeriodsLib;

namespace Cw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            TimeSpan begin = new TimeSpan(8, 0, 0);
            TimeSpan end = new TimeSpan(20, 0, 0);
            TimeSpan dur = new TimeSpan(0, 30, 0);
            int[] duration = { 60, 30, 10, 10, 40,10 };
            TimeSpan[] startTimes = new TimeSpan[] { new TimeSpan(10, 0, 0), new TimeSpan(11, 0, 0), new TimeSpan(15, 0, 0), new TimeSpan(15, 30, 0), new TimeSpan(16, 50, 0), new TimeSpan(18, 0, 0), };
            int j = 0;
            for (var i = begin; i < end; i+=dur)
            {

                if ( j <= startTimes.Length - 1 && startTimes[j] == i)
                {
                    i += new TimeSpan(0, duration[j], 0);

                    j++;

                    if (j <= startTimes.Length - 1 && startTimes[j] == i)
                    {
                        i += new TimeSpan(0, duration[j], 0);
                        j++;
                    }
                    if (j <= startTimes.Length - 1 && startTimes[j] - i < dur)
                    {
                        i = startTimes[j] + new TimeSpan(0, duration[j], 0);
                        j++;
                    }

                }

                if(i < startTimes[startTimes.Length- 1 ] && j <= startTimes.Length - 1 && startTimes[j] - i < dur)
                {
                    i = startTimes[j] + new TimeSpan(0, duration[j], 0);
                    j++;
                }
                
                Console.WriteLine(i);
                
            }
        }
    }
}
