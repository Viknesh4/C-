using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicprogarm
{
    internal class prog1
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Dividend:");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Divisor:");
            int b = Convert.ToInt16(Console.ReadLine());
            float f = (a/b);
            int r = (a % b);
            Console.WriteLine("Dividend:" + a);
            Console.WriteLine("Divisor:" + b);
            Console.WriteLine("Remainder:" + r);
            Console.WriteLine("Quoitient" + f);
        }
    }
}
