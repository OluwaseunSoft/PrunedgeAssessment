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
                    if(arrival[i] <= departure[j])
                    {
                        platform++;
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            return result;
        }
    }
}
