using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class InvalidAgeException : Exception

    {

        public InvalidAgeException(int age) : base(String.Format($"Invalid age: {age}")) { }
      
    }

    internal class Age

    {
        int age;

        public Age(int age) 
        {
            this.age = age;
        }
        public void check()
        {
            if (age < 18) throw new InvalidAgeException(age);
            else Console.WriteLine("Account created Successfully");

        }

    }
}
