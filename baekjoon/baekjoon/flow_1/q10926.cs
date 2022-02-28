using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon.flow_1
{
    class q10926
    {
        public static void Main(string[] args)
        {

            
            string name = Console.ReadLine();
            if(name.Length > 50)
            {
                Console.WriteLine("50자를 넘지 않아야 한다."); 
            }
            else
            {
                Console.WriteLine(name+"??!");
            }
        }
    }
}
