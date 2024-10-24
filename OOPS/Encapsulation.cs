using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Encapsulation
    {
        public Encapsulation() 
        { 

        }



        static void Main1(string[] args)
        {
            Personal p = new Personal(21, "Viknesh");
            p.name = "Ram";

        }

    }

    class Personal
    {
        private int age;
        public string name;

        public int Age { get => age; private set => age = value; }

        public Personal(int age, string name)
        {
            Age = age;
            this.name = name;
        }

    }
}
