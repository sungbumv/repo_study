using System;

namespace baekjoon.flow_4
{
    internal class q2562
    {
        public static void complete()
        {
           
            int maxNum = 0;
            int maxPoint = 0;
            
            int[] inArr = new int[10];

            for(int idx = 1; idx < 10; idx++ )
            {
                inArr[idx] = Convert.ToInt32(Console.ReadLine());
            }

            for(int index = 1; index < 10; index++)
            {
                if (inArr[index] > inArr[index - 1])
                {
                    maxNum = inArr[index];
                    maxPoint = index;
                }
                else
                {
                    maxNum = inArr[index - 1];
                    maxPoint = index - 1;
                }
            }

            Console.WriteLine(maxNum.ToString());
            Console.WriteLine(maxPoint.ToString());
        }
    }
}
