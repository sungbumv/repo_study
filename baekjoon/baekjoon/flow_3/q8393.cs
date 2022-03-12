using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon.flow_3
{
    class q8393
    {
        public static void complete(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            int sumNo = 0;

            if (number <= 0 || number > 10000)
                return;

            for (int idx = 1; idx <= number; idx++)
            {
                sumNo += idx;
            }
            Console.WriteLine(sumNo);
        }
    }
}
