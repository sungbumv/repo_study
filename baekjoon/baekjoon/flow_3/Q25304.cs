using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon.flow_3
{
    internal class Q25304
    {
        public static void Main()
        {
            int totalAmount = Convert.ToInt32(Console.ReadLine());
            int totalTypeCnt = Convert.ToInt32(Console.ReadLine());
            string[] itemDetail = null;

            for (int Idx = 0; Idx <= totalTypeCnt; Idx++)
            {
               itemDetail = Console.ReadLine().Split(' ');
               Convert.ToInt32(itemDetail[0] + itemDetail[1]);
            }
        }
    }
}
