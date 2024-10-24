using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Calculator
    {
        int a, b;
        public Calculator(int a,int b) 
        { 
            this.a = a; this.b = b; 
        }
        public int Add()
        {
            return a + b;
        }
        public int Sub()
        {
            return a - b;
        }
        public int Mul()
        {
            return a * b;
        }
        public int Div()
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return a / b;
        }
    }
    class ScientificCalculator:Calculator
    {
        double a, b;int c, d;
        public ScientificCalculator(double a, double b,int c,int d):base(c,d)
        {
            this.a = a; this.b=b;
            
        }
        public int Power()
        {
            return (int)Math.Pow(a,b);
        }
        public double Exponential() 
        {
            return Math.Exp(a);
        }
        public double SquareRoot() 
        {
            return Math.Sqrt(a);
        }
        public int Square() 
        { 
            return (int)Math.Pow(a,2);
        }
        public int Cube()
        {
            return (int)Math.Pow(a,3);
        }
        public double Degree() 
        {
            return a * (180 / Math.PI);
        }

    }
}
