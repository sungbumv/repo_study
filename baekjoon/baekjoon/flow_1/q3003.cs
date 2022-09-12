using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon.flow_1
{
    internal class q3003
    {

        public static void complete(string[] args)
        {
            // 입력은 동혁이가 찾은 개수  이 값은 0 ~ 10 사이 
            string[] findCnt = Console.ReadLine().Split(' ');
            // 출력은 입력에서 주어진 순서대로 몇개의 피스를 더하거나 빼야하는지 출력 
            int[] maxArray = { 1, 1, 2, 2, 2, 8 };

            for(int i = 0; i < findCnt.Length; i++)
            {
                maxArray[i] -= int.Parse(findCnt[i]);
            }

            foreach(int j in maxArray)
            {
                Console.Write(j.ToString() + " ");
            }
        }
    }
}
