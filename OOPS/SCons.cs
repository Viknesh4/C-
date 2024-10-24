using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class SCons
    {
        static SCons()
        {
            Console.WriteLine("Invoked only once");
        }
        public void Display()
        {
            Console.WriteLine("Displayed");
        }
        public static void Main1(string[] args)
        {
            SCons sCons = new SCons();
            sCons.Display();
            SCons sCons1 = new SCons();
            sCons1.Display();
        }
    }
}
