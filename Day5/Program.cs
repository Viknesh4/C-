namespace Day5
{
    internal class Program
    {
        static void Print1toN()
        {
            Console.WriteLine("Enter the Ending value:");
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            while (i <= n)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        static void PrintAvg() 
        {
            int oddsum,evensum, countodd, counteven,sum;
            oddsum = sum = evensum = countodd = counteven = 0;
            int i = 1;
            while (i <= 100)
            {
                if (i % 2 == 0)
                {
                    counteven++;
                    evensum += i;
                }
                else
                {
                    oddsum += i;
                    countodd++;
                }
                sum+= i;
                i++;
            }
            Console.WriteLine($"Average :{sum/100.0F}");
            Console.WriteLine($"Even Sum:{evensum}");
            Console.WriteLine($"Odd Sum:{oddsum}");
            Console.WriteLine($"Count of Odd Numbers:{countodd}");
            Console.WriteLine($"Count of Even Numbers:{counteven}");

        }
        static void LoopPrint()
        {
            Console.WriteLine("Enter the starting and Ending value:");
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            if (start > end)
            {
                int i = start;
                while (i >= end)
                {
                    Console.WriteLine(i);
                    i--;
                }
            }
            else
            {
                int i = start;
                while (i <= end)
                {
                    Console.WriteLine(i);
                    i++;
                }
            }
        }
        static void MultiplicationTable()
        {
            Console.WriteLine("Enter the Value:");
            int m  = int.Parse(Console.ReadLine());
            int i = 1;
            while(i <= 10)
            {
                Console.WriteLine($"{i}*{m}={i*m}");
                i++;
            }
        }
        static void Factorial ()
        {
            Console.WriteLine("Enter the Value:");
            int f = int.Parse(Console.ReadLine());
            int i = 1;
            int fact = 1;
            while (i <= f)
            {
                fact *= i;
                i++;
            }
            Console.WriteLine($"Factorial of {f} : {fact}");

        }

        static void MultiplicationTable1to10()
        {
         
            int i = 1;
            while (i <= 10)
            {
                int j = 1;
                Console.WriteLine("---------------------------");
                Console.WriteLine($"{i} Table");
                Console.WriteLine("---------------------------");
                while (j <= 10)
                {
                    Console.WriteLine($"{j}*{i}={i * j}");
                    j++;
                }
                i++;
            }
        }
        static void Power()
        {
            Console.WriteLine("Enter the Base Value:");
            int baase = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Power Value:");
            int power = int.Parse(Console.ReadLine());
            long ans = 1;
            int i = 0;
            
            while (i < power)
            {
                ans *= baase;
                i++;
            }
            Console.WriteLine($"Value : {ans}");

        }
        static void InfiniteForLoop()
        { 
            for(; ; )
            {
                Console.WriteLine("Vicky");
            }

        }
        static void InfiniteWhileLoop()
        {
            while(true)
            {
                Console.WriteLine("Vicky");
            }

        }
        static void InfiniteDoWhileLoop()
        {
            do
            {
                Console.WriteLine("Vicky");
            } while (true);

        }
        static void CubeOrSquare()
        {
            Console.WriteLine("Enter a Number:");
            int a  = int.Parse(Console.ReadLine());
            long n = 1;
            Console.WriteLine("Press 3 for Cube \n 2 for Square:");
            int val = int.Parse(Console.ReadLine());
            int i = 0;
            while (i<val)
            {
                n *= a;
                i++;
            }
            Console.WriteLine((val == 3) ? $"Cube of {a}:{n}": $"Square of {a}:{n}");
        }
        static void PrintAllNumbers()
        {
            int i = 1;
            while(i<=1000)
            {
                if (i % 7 == 0 && i % 5 == 0)
                    Console.WriteLine(i);
                i++;
            }
        }
        static void PrintBreak()
        {
            int i = 1;
            while (i <= 10)
            {
                if (i % 5 == 0) break;
                Console.WriteLine(i);
                i++;
            }
        }
        static void PrintContinue()
        {
            int i = 1;
            while (i <= 100)
            {
                if (i % 5 == 0) 
                {
                    i++;
                    continue;
                }
                
                Console.WriteLine(i);
                i++;
            }
        }

        static void FizzBuzz()
        {
            int i = 1;
            while (i <= 100)
            {
                if ((i % 5) == 0 && (i % 3) == 0) Console.WriteLine("FizzBuzz");
                else if ((i % 3) == 0) Console.WriteLine("Fizz");
                else if ((i % 5) == 0) Console.WriteLine("Buzz");
                else Console.WriteLine(i);
                i++;
            }
        }
        static void Main(string[] args)
        {
            //InfiniteForLoop();
            //InfiniteDoWhileLoop();
            //InfiniteWhileLoop();
            //Power();
            //MultiplicationTable1to10();
            //PrintAllNumbers();
            //Print1toN();
            //MultiplicationTable();
            //Factorial();
            //LoopPrint();
            //PrintAvg();
            //CubeOrSquare();
            //PrintBreak();
            //PrintContinue();
            FizzBuzz();
        }
    }
}
