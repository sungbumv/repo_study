using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon.flow_3
{
    class q15552
    {
        //string Reader,Builder 둘다 봐야할듯.. 
        public static void Main(string[] args)
        {
            int numOfTimes = int.Parse(Console.ReadLine());
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < numOfTimes; i++)
            {
                using (StringReader reader = new StringReader(Console.ReadLine()))
                {
                    string[] text = reader.ReadLine().Split(' ');
                    int a = int.Parse(text[0]);
                    int b = int.Parse(text[1]);
                    builder.Append((a + b) + "\n");
                }
            }
            Console.WriteLine(builder);
            /*
            int limitCnt = Convert.ToInt32(Console.ReadLine());
            string[] addArray = new string[1000];

            for (int cnt = 0; cnt < limitCnt; cnt++)
            {
                string numbers = Console.ReadLine();
                string[] numberArray = numbers.Split(' ');

                addArray[cnt] = Convert.ToString(Convert.ToInt32(numberArray[0]) + Convert.ToInt32(numberArray[1]));

            }
            for(int index = 0; index < limitCnt; index++)
            {
                Console.WriteLine(addArray[index]);
            }
            */
        }
    }
}
