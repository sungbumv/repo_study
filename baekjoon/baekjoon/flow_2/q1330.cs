using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon.flow_2
{
    class q1330
    {
        public static void complete(string[] args)
        {
            string inputdata = Console.ReadLine();

            string[] number = inputdata.Split(' ');

            if(Convert.ToInt32(number[0]) > Convert.ToInt32(number[1]))
            {
                Console.WriteLine(">");
            }
            else if(Convert.ToInt32(number[0]) < Convert.ToInt32(number[1]))
            {
                Console.WriteLine("<");
            }
            else if(Convert.ToInt32(number[0]) == Convert.ToInt32(number[1]))
            {
                Console.WriteLine("==");
            }
        }
    }
}
