using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon.flow_4
{
    public class Q3052
    {

        public static void Main()
        {
            

            int[] array = new int[10];
            int[] resultArray = new int[10];
            int result = 0;

            // 두 자연수 A B 가 있을 때
            // A % B는 A를 B로 나눈 나머지 
            // 7, 14, 27, 38을 3으로 나눈 나머지는 1, 2, 0 , 2

            for (int index = 0; index < 10; index ++)
            {
                array[index] = Convert.ToInt32(Console.ReadLine());
            }

            //수 10개입력 후 이를 42로 나눈 나머지를 구한다.
            for (int i = 0; i < 10; i ++)
            {
                resultArray[i] = array[i] % 42;

                if (resultArray[i] != resultArray[i + 1]) //나머지를 전 데이터와 비교한다.
                    result++;

            }

            Console.WriteLine(result.ToString());

            Console.Read();

        }
    }
}
