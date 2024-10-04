using System;
using Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class stringoper
    {
        static void Main(String[] args)
        {
            string name = "hlo everyone how are you doing!";
            string lastname = "Hope you are doing well";
            string full_name = lastname.Substring(5,7);
            string[] str = {"vicky", "ram", "ragu"};
            string str1 = String.Concat(str);

            Console.WriteLine($"Full name of the person:{str1}");
        }
    }
}
