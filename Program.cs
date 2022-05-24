using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akinwaleoluwaseun2015_gmail.com
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrival = { 900, 940, 950, 1100, 1500, 1800 };
            int[] departure = { 910, 1200, 1120, 1130, 1900, 2000 };
            int result = MinimumPlatformRequired(arrival, departure);
            Console.WriteLine("" + result);
        }

        public static int MinimumPlatformRequired(int[] arrival, int[] departure)
        {
            int result = 1, platform = 1, i = 1, j = 0;

            try
            {
                Array.Sort(arrival);
                Array.Sort(departure);

                while (i < arrival.Length && j < arrival.Length)
                {
                    if (arrival[i] <= departure[j])
                    {
                        platform++;
                        i++;
                    }
                    else if (arrival[i] > departure[j])
                    {
                        platform--;
                        j++;
                    }
                    if (platform > result) result = platform;
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            return result;
        }
    }
}
