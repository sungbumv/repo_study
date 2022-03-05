using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon.flow_2
{
    class q14681
    {
        public static void Main(string[] args)
        {
            int point_x = Convert.ToInt32(Console.ReadLine());
            int point_y = Convert.ToInt32(Console.ReadLine());

            if (point_x < -1000 && point_x > 1000 && point_x == 0)
                return;

            if (point_y < -1000 && point_y > 1000 && point_y == 0)
                return;

            if(point_x > 0 && point_y > 0)
            {
                Console.WriteLine("1");
            }
            else if(point_x < 0 && point_y > 0)
            {
                Console.WriteLine("2");
            }
            else if(point_x < 0 && point_y < 0)
            {
                Console.WriteLine("3");
            }    
            else
            {
                Console.WriteLine("4");
            }
        }
    }
}
