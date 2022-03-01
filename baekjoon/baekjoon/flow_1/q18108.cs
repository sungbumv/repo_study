using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon.flow_1
{
    class q18108
    {
        public static void Main(string[] args)
        {
            int inputData = Convert.ToInt32(Console.ReadLine());

            if(inputData >= 1000 && inputData <= 3000)
            {
                Console.WriteLine(inputData - 543);
            }
        }
    }
}
