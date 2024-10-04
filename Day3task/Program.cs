using Microsoft.VisualBasic;
using System.Formats.Asn1;
using System.Runtime.Intrinsics.X86;

namespace Day3task
{
    internal class Program
    {
        static void greattwo()
        {
            Console.WriteLine("Enter Two numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a > b)
                Console.WriteLine($"{a} is greater than {b}");
            else
                Console.WriteLine($"{b} is greater than {a}");
        }
        static void greathree() {
            Console.WriteLine("Enter Three numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a > b && a > c)
                Console.WriteLine($"{a} is greater than {b} and {c}");
            else if (b > c) Console.WriteLine($"{b} is greater than {a} and {c}");
            else Console.WriteLine($"{c} is greater than {b} and {a}");
        }
        static void leapornot()
        {
            Console.WriteLine("Enter the year:");
            int a = int.Parse(Console.ReadLine());
            if ((a % 4 == 0 && a % 100 != 0) || (a % 400 == 0))
                Console.WriteLine($"{a} is a leap year");
            else Console.WriteLine($"{a} is not a leap year");
        }
        static void positiveornot()
        {
            Console.WriteLine("Enter a number:");
            int a = int.Parse(Console.ReadLine());
            if (a > 0) Console.WriteLine($"{a} is a positive number");
            else Console.WriteLine($"{a} is a negative number");
        }

        static void m()
        {
            Console.WriteLine("Enter a number:");
            int m = int.Parse(Console.ReadLine());
            if (m > 1) Console.WriteLine("1");
            else if (m == 0) Console.WriteLine("0");
            else if (m < 0) Console.WriteLine("-1");
  
        }

        static void quad()
        {
            Console.WriteLine("Enter Two numbers (x and y):");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if (x > 0 && y > 0) Console.WriteLine($"{x} and {y} are in Quadrant 1");
            else if (x < 0 && y > 0) Console.WriteLine($"{x} and {y} are in Quadrant 2");
            else if (x < 0 && y < 0) Console.WriteLine($"{x} and {y} are in Quadrant 3");
            else if (x > 0 && y < 0) Console.WriteLine($"{x} and {y} are in Quadrant 4");
        }
        static void eleccalc()
        {
            Console.WriteLine("Enter the number of units:");
            int unit = int.Parse(Console.ReadLine());
            if (unit <= 100) Console.WriteLine("The charges are free");
            else if (unit > 100 && unit <= 500) Console.WriteLine($"Amount to be paid:{unit * 5}");
            else Console.WriteLine($"Amount to be paid:{unit * 7.5}");
        }

        static void Main(string[] args)
        {
            //greattwo();
            //greathree();
            //leapornot();
            //positiveornot();
            //m();
            //quad();
            //eleccalc();
        }
    }
}
