using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Prime
    {
        public int n;

        public Prime()
        {
            this.n = 0;
        }

        public void input(int n)
        {
            this.n = n;
        }

        public int Calculate()
        {
            int flag = 0;
            for (int i = 2; i < n/2; i++)
            {
                if (n % i == 0)
                {
                    flag++;
                    break;
                }
            }
            return flag;
        }

        public void display()
        {
            if (Calculate() != 0)
                Console.WriteLine($"\'{n}\' is not a Prime Number");
            else Console.WriteLine($"\'{n}\' is a Prime Number");
        }
    }
}
