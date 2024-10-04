using System;

namespace ClassTask
{
    internal class Program
    {   
        public static void div()
        {
            Console.WriteLine("Enter Dividend:");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Divisor:");
            int b = Convert.ToInt16(Console.ReadLine());
            float f = (a / b);
            int r = (a % b);
            Console.WriteLine("Dividend:" + a);
            Console.WriteLine("Divisor:" + b);
            Console.WriteLine("Remainder:" + r);
            Console.WriteLine("Quoitient" + f);

        }

        public static void divfloat()
        {
            Console.WriteLine("Enter Dividend:");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Divisor:");
            float b = float.Parse(Console.ReadLine());
            float f = (a / b);
            float r = (a % b);
            Console.WriteLine("Dividend:" + a);
            Console.WriteLine("Divisor:" + b);
            Console.WriteLine("Remainder:" + r);
            Console.WriteLine("Quoitient" + f);
        }

        public static void arithmetic()
        {
            Console.WriteLine("Enter a number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Addition of {a} and {b} is : {a + b}");
            Console.WriteLine($"Subtraction of {a} and {b} is : {a - b}");
            Console.WriteLine($"Multiplication of {a} and {b} is : {a * b}");
            Console.WriteLine($"Division of {a} and {b} is : {a * b}");
        }

        public static void conver()
        {
            Console.WriteLine("Enter a number a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number b:");
            int b = int.Parse(Console.ReadLine());
            a += b;
            b *= 50;
            a /= b;
            Console.WriteLine($"Value of a and b after conversion {a} and {b} ");

        }

        public static void compare()
        {
            Console.WriteLine("Enter a number a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine((a==b)?"Two numbers are equal":"Two numbers are not equal");
        }

        public static void a5() {
            Console.WriteLine("Enter a number a:");
            int a = int.Parse(Console.ReadLine());
            string s = (a == 5) ? "Number Equal to 5" : "Number not equal to 5";
            Console.WriteLine($"{s}");

        }
        public  static void DollortoInr() {
            Console.WriteLine("Enter Dollor value:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine($"Conversion of {a} Dollars to INR:{a * 84.01}");
        }

        public static void InrtoDollor()
        {
            Console.WriteLine("Enter INR value:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine( $"Conversion of {a} INR to Dollars :{a / 84.01}");
        }

        

        public static void MetertoKM()
        {
            Console.WriteLine("Enter Meter value:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine($"Conversion of {a} Meters to KMs :{a / 1000}");

        }

        public static void Gst()
        {
            Console.WriteLine("Enter Price:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Quantity:");
            int b = int.Parse(Console.ReadLine());
            int tot = a * b;
            float gst = tot * (12 / 100.0F);
            Console.WriteLine($"Amount to be paid:{tot + gst}");
        }
        public static void discount()
        {
            Console.WriteLine("Enter Price:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Quantity:");
            int b = int.Parse(Console.ReadLine());
            int tot = a * b;
            decimal discount = (tot > 1000) ? tot * 0.05m : 0;
            Console.WriteLine($"Amount to be paid:" + (tot - discount));
        }

        public static void radintodeg()
        {
            Console.WriteLine("Enter Radians:");
            double radians = double.Parse(Console.ReadLine());
            double degrees = radians * (180 / Math.PI);
            Console.WriteLine($"{radians} radians is equal to {degrees} degrees");

        }

        static void Main(string[] args)
        {
            //div();
            //divfloat(); 
            //arithmetic();
            //conver();
            //compare();
            //a5();
            //DollortoInr();
            //InrtoDollor();
            //MetertoKM();
            //Gst();
            //discount();
            radintodeg();
        }
        }
}
