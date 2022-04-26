using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon.flow_3
{
    class q2741
    {
        public static void complete(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            StringBuilder strBuilder = new StringBuilder();

            if (num > 100000) return;

            for(int idx = 1; idx <= num; idx++)
            {
                strBuilder.Append(idx + "\n");
            }
            Console.WriteLine(strBuilder.ToString());
        }
    }
}
