using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon.flow_3
{
    internal class q2742
    {
        public static void complete(string[] args)
        {
            // N을 입력
            // N ~ 1 까지 한줄에 하나씩 출력 
            // 조건 : 100000보다 작거나 같은 자연수 

            int inNum = int.Parse(Console.ReadLine());

            if(inNum <= 100000)
            {
                StringBuilder strBuilder = new StringBuilder();

                for (int inIdx = inNum; inIdx > 0; inIdx--)
                {
                    strBuilder.Append(inIdx + "\n");
                }
                Console.WriteLine(strBuilder.ToString());
            }
        }
    }
}
