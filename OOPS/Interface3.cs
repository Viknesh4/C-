using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterface
{
    public interface ICalculator
    {
        int Add(int a, int b);
        int Sub(int a, int b);
        int Mul(int a, int b);
        double Div(int a, int b);
    }

   
    public class A4 : ICalculator
    {
        
        public int Add(int a, int b)
        {
            return a + b;
        }

        
        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Mul(int a, int b)
        {
            return a * b;
        }

        
        public double Div(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return 0;
            }
            return (double)a / b;
        }
    }
}
