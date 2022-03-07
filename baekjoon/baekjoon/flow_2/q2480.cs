using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon.flow_2
{
    class q2480
    {

        //삼항연산으로 해야할듯.. 어렵네 (다시풀기)
        public static void complete(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int A = int.Parse(str[0]);
            int B = int.Parse(str[1]);
            int C = int.Parse(str[2]);

            if (A == B && B == C)
            {
                Console.WriteLine(10000 + (A * 1000));
            }
            else if (A == B)
            {
                Console.WriteLine(1000 + A * 100);
            }
            else if (A == C)
            {
                Console.WriteLine(1000 + A * 100);
            }
            else if (B == C)
            {
                Console.WriteLine(1000 + B * 100);
            }
            else
            {
                if (A > B && A > C)
                {
                    Console.WriteLine(100 * A);
                }
                else if (B > C)
                {
                    Console.WriteLine(100 * B);
                }
                else
                {
                    Console.WriteLine(100 * C);
                }
            }
            /*
                        int dice1 = Convert.ToInt32(data[0]);
                        int dice2 = Convert.ToInt32(data[1]);
                        int dice3 = Convert.ToInt32(data[2]);

                        if (dice1 < 1 && dice1 > 6) return;

                        if (dice2 < 1 && dice2 > 6) return;

                        if (dice3 < 1 && dice3 > 6) return;

                        if((dice1 == dice2) && (dice2  == dice3) && (dice3 == dice1))
                        {

                            Console.WriteLine("%d", 10000 * dice1 * 1000);
                        }

                        if ((dice1 == dice2) && (dice1 != dice3) && (dice2 != dice3) ||
                            (dice1 != dice2) && (dice1 == dice3) && (dice2 != dice3) ||
                            (dice1 != dice2) && (dice1 != dice3) && (dice2 == dice3))
                        {
                            if (dice1 == dice2)
                                Console.WriteLine("%d", 1000 * dice1 * 100);
                            else
                                Console.WriteLine("%d", 1000 * dice3 * 100);
                        }
            */


        }
    }
}
