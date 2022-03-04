using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon.flow_2
{
    class q9498
    {
        public static void Main(string[] args)
        {
            int point = Convert.ToInt32(Console.ReadLine());
            
            if(point >= 0 && point <= 100)
            {
                if (point >= 90 && point <= 100)
                {
                    Console.WriteLine("A");
                }
                else if (point >= 80 && point < 90)
                {
                    Console.WriteLine("B");
                }
                else if (point >= 70 && point < 80)
                {
                    Console.WriteLine("C");
                }
                else if (point >= 60 && point < 70)
                {
                    Console.WriteLine("D");
                }
                else
                {
                    Console.WriteLine("F");
                }
            }
        }
    }
}
