using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon.flow_3
{
    internal class q2525
    {
        public static void Main(string[] args)
        {
            //첫째줄에는 현재시각 ( 0 ~ 23시  0 ~ 59분)
            string[] inputHHmm = Console.ReadLine().Split(' ');

            int inputHour = Convert.ToInt32(inputHHmm[0]);
            int inputMinute = Convert.ToInt32(inputHHmm[1]);

            if (inputHour >= 0 && inputHour <= 23)
            {
                if(inputMinute >= 0 && inputMinute <= 59)
                {
                    string cookingTime = Console.ReadLine();
                    int cooktime = Convert.ToInt32(cookingTime);
                    if(cooktime >= 0 && cooktime <= 1000)
                    {
                        int secondHour = cooktime % 60;
                        if (secondHour <= 60)
                        {
                            int secondMinute = secondHour;
                            if(secondMinute + inputMinute < 60)
                            {
                                Console.WriteLine(secondHour + );
                            }
                        }
                    }
                }
            }
        }
    }
}
