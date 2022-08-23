using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon.flow_3
{
    internal class q11021
    {
        public static void Complete(string[] args)
        {
            int loopNum     = Convert.ToInt32(Console.ReadLine());
        
            StringBuilder stringBuilder = new StringBuilder();
           
                for (int inIdx = 1; inIdx <= loopNum; inIdx++)
                {
                    string[] numbers = Console.ReadLine().Split(' ');
                    int firstNum = Convert.ToInt32(numbers[0]);
                    int secondNum = Convert.ToInt32(numbers[1]); 

                if (!(firstNum > 0 && firstNum < 10) && (secondNum > 0 && secondNum < 10))
                    return;

                    stringBuilder.Append("Case #"+ inIdx + ": ");

                    int  sum = firstNum + secondNum;
                    stringBuilder.Append(sum +"\n");
                }
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
