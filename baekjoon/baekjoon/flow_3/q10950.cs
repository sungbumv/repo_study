using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon.flow_3
{
    class q10950
    {
        public static void Main(string[] args)
        {
            int count = Convert.ToInt32(Console.ReadLine());
            for(int num = 0; num < count; num++)
            {

                string input = Console.ReadLine();
                string[] numbers = input.Split(' ');

                int firstNum = Convert.ToInt32(numbers[0]);
                int secondNum = Convert.ToInt32(numbers[1]);

                if((secondNum > 0 && secondNum < 10) && (firstNum > 0 && firstNum < 10))
                {
                    string[] numberMemory = { };
                    Array.Copy(numbers, numberMemory, num + 1);
                    
                }

            }
        }
    }
}
