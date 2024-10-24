using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class UPS

    {
        public int a;
        private UPS()
        {
            this.a = a;
            Console.WriteLine("private constructor is called");

        }

        static UPS()
        {
            Console.WriteLine("Invoked only once");
        }
        /*public UPS(int a)
        {
            Console.WriteLine("Default constructor is called");
        }*/
        public void Update()
        {
            Console.WriteLine("Updated using a non-static method");
        }

        public static void Create()
        {
          
            Console.WriteLine("Created a static method");
        }

        static void Main1(string[] args)
        {
            new UPS().Update();
            Create();
        }


        
    }
    
}
