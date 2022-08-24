using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon.flow_3
{
    internal class q2525
    {
        public static void complete(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int A = int.Parse(str[0]);
            int B = int.Parse(str[1]);
            int C = int.Parse(Console.ReadLine());

            B += C;

            while (B >= 60)
            {
                A++;
                B -= 60;
            }

            if (A >= 24)
            {
                A -= 24;
            }

            Console.WriteLine(A + " " + B);
        }
    }
}
