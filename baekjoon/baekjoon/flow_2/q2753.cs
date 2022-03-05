using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace baekjoon.flow_2
{
    class q2753
    {
        public static void complete(string[] args)
        {
            int year = Convert.ToInt32(Console.ReadLine());

            if (year < 1 || year > 4000) return;

            if( year % 4 == 0 && ((year % 100 != 0) || (year % 400 == 0)))
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
