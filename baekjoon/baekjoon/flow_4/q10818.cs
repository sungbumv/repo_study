using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon.flow_4
{
    internal class q10818
    {
        public static void complete(string[] args)
        {
            //입력 : 첫째 줄에 정수의 개수 N을 입력받는다.
            // - N을 입력받고 정수로 바꾼다.
            string input = Console.ReadLine();
            int n = int.Parse(input);

            //입력 : 둘째 줄에 N개의 정수를 공백으로 구분하여 입력받는다.
            // - n개의 정수를 공백으로 구분하여 받는다.
            string[] input2 = Console.ReadLine().Split(' ');
            // - N 크기의 정수형 배열을 생성한다.
            int[] numbers = new int[n];
            // - n개의 정수를 배열에 집어넣는다.
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(input2[i]);
            }

            //출력 : 정수 N개 중 최솟값과 최댓값을 공백으로 구분하여 출력한다.
            // - 최솟값을 넣을 변수를 설정한다.
            int minNumber = numbers[numbers.Length - 1];
            // - 최댓값을 넣을 변수를 설정한다.
            int maxNumber = numbers[numbers.Length - 1];
            // - 정수 N개를 비교하여 최솟값과 최댓값을 구하는 식을 짠다.
            for (int i = 0; i < numbers.Length; i++)
            {

                // - 배열의 끝 수를 가져온다.
                int endN = numbers[numbers.Length - (i + 1)];

                // 배열의 끝 수를 최대값 최소값 변수에 넣고 끝 수부터 차례대로 비교한다.
                if (maxNumber <= endN)
                {
                    maxNumber = endN;
                }

                if (minNumber >= endN)
                {
                    minNumber = endN;
                }
            }

            //결과를 출력한다.
            Console.WriteLine("{0} {1}", minNumber, maxNumber);
        }

     }
}
