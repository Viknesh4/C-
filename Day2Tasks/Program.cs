using System.Linq.Expressions;

namespace Day2Tasks
{
    internal class Program
    {
        enum months { January,February,March,April,May,June,July,August,September,October,Novemeber,December}
        static void itd()
        {

            Console.WriteLine("Enter a no:");
            int a = int.Parse(Console.ReadLine());
            double b = a;
            Console.WriteLine($"After double conversion:{b},{b.GetType()}");

        }
        static void sti()
        {
            Console.WriteLine("Enter a no:");
            string a = Console.ReadLine();
            int n = int.Parse(a);
            Console.WriteLine($"After Integer conversion:{n},{n.GetType()}");

        }
        static void oddoreven()
        {
            Console.WriteLine("Enter a no:");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine($"{a} is Even");
            else
                Console.WriteLine($"{a} is Odd");
        }
        static void fizzbuzz()
        {
            Console.WriteLine("Enter a no:");
            int a = int.Parse(Console.ReadLine());
            if (a % 3 == 0 && a % 5 == 0)
                Console.WriteLine($"Fizzbuzz");
            else if (a % 3 == 0)
                Console.WriteLine($"Fizz");
            else if (a % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine($"The Given Number is {a}");
        }
        static void calc()
        {
            Console.WriteLine("Enter no1:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter no1:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Type \"+\" for Addition\nType \"-\" for Subtraction\nType \"*\" for Multiplication\nType \"/\" for Division\n");
            char o = char.Parse(Console.ReadLine());
            if (o == '+')
                Console.WriteLine($"Addition of {a} and {b} is : {a + b}");
            else if (o == '-')
                Console.WriteLine($"Subtraction of {a} and {b} is : {a - b}");
            else if (o == '*')
                Console.WriteLine($"Multiplication of {a} and {b} is : {a * b}");
            else if (o == '/')
                Console.WriteLine($"Division of {a} and {b} is : {a / b}");
            else
                Console.WriteLine("Invalid Operator");
        }
        static void triangle()
        {
     
            Console.WriteLine("Enter Side A:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Side B:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Side C:");
            int c = int.Parse(Console.ReadLine());

            if (a == b && b == c && a == c)
                Console.WriteLine($"The Given sides form a Equilateral Triangle");
            else if (a == b || b == c || c == a)
                Console.WriteLine($"The Given sides form a Isoceles Triangle");
            else
                Console.WriteLine($"The Given sides form a Scalene Triangle");
        }
        static void Main(string[] args)
        {
            /*if ((int)months.January == 0)
                Console.WriteLine(months.January);
            else if ((int)months.February == 1)
                Console.WriteLine(months.February);
            else if ((int)months.March == 2)
                Console.WriteLine(months.March);
            else if ((int)months.April == 3)
                Console.WriteLine(months.April);
            else if ((int)months.May == 4)
                Console.WriteLine(months.May);
            else
                Console.WriteLine(months.June);*/
            //sti();
            //itd();
            //fizzbuzz();
            calc();
            //triangle();
            
            //oddoreven();
        }
    }
}
