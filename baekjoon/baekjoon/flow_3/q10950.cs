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
         
            
            
            string[] tempArray = new string[100];

            for (int num = 0; num < count; num++)
            {

                string input = Console.ReadLine();
                string[] numbers = input.Split(' ');

                if (Convert.ToInt32(numbers[0]) > 10 && Convert.ToInt32(numbers[1]) > 10) return;
                if (Convert.ToInt32(numbers[0]) < 0 && Convert.ToInt32(numbers[1]) < 0) return;

                tempArray[num] =  (Convert.ToInt32(numbers[0]) + Convert.ToInt32(numbers[1])).ToString();

            }
            for(int num = 0; num < count; num++)
            {
                Console.WriteLine(tempArray[num]);
            }
        }
    }
}
