using System;

namespace Onlycoding
{
    internal class Program
    {
        static void SpyNumber()
        {
            Console.WriteLine("Enter a Number:");
            int n = int.Parse(Console.ReadLine());
            int add = 0;
            int mul = 1;
            int tem = n;
            while (n > 0)
            {
                int rem = n% 10;
                add += rem;
                mul *= rem;
                n /= 10;
            }
            if (add + mul == tem)
                Console.WriteLine($"{tem} is a Spy Number");
            else Console.WriteLine($"{tem} is not a Spy Number");

        }
        static void PerfectOrNot()
        {
            Console.WriteLine("Enter a Number:");
            int n = int.Parse(Console.ReadLine());
            int p = 0;
            for (int i = 0; i < n; i++)
            {
                if (n % i == 0)
                {
                    p += i;

                }

            }
            if (p == n)
                Console.WriteLine($"{p} is a Perfect Number");
            else Console.WriteLine($"{p} is Not a Perfect Number");
        }
        static void PerfectOrNotWithinRange()
        {            
            for (int i = 1; i < 100; i++)
            {
                int p = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        p += j;

                    }

                }
                if (p == i)
                    Console.WriteLine($"{i} is a Perfect Number");

            }
        }
        static void PrimeOrNot()
        {
            int c = 0;
            Console.WriteLine("Enter a Number:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i < n; i++) 
            {
                if (n % i == 0)
                {   
                    Console.WriteLine($"{n} is not a Prime Number");
                    c = 1;
                    break;

                }
                
            }
            if (c == 0)
            {
                Console.WriteLine($"{n} is a Prime Number");
            }
        }
        static void PrimeOrNotWithinRange()
        {
            for (int i = 3; i <= 100; i++)
            {
                int c = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                 
                        c = 1;
                        break;

                    }

                }
                if (c == 0)
                {
                    Console.WriteLine($"{i} is a Prime Number");
                }
            }
        }
        static int fact(int n)
        {
            if (n == 1) return 1;
            else return n * fact(n - 1);
        }
        static void SpecialNumber()
        {
            Console.WriteLine("Enter a Number:");
            int n = int.Parse(Console.ReadLine());
            int tem = n;
            int rv = 0;
            while (n > 0)
            {
                int rem = n % 10;
                rv += fact(rem);
                n /= 10;
            }
            if (rv == tem) Console.WriteLine($"{tem} is Special Number");
            else Console.WriteLine($"{tem} is not a Special Number");
        }
        static void ReverseNumber()
        {
            Console.WriteLine("Enter a Number:");
            int n = int.Parse(Console.ReadLine());
            int tem = n;
            int rv = 0;
            while (n > 0)
            {
                int rem = n % 10;
                rv = rv * 10 + rem;
                n /= 10;
            }
            Console.WriteLine($"Reversed Number:{rv}");


        }
        static void NivenNumber()
        {
            Console.WriteLine("Enter a Number:");
            int n = int.Parse(Console.ReadLine());
            int tem = n;
            int sm = 0;
            while (n > 0)
            {
                int rem = n % 10;
                sm += rem;
                n /= 10;
            }
            if (tem % sm == 0) Console.WriteLine($"{tem} is Niven Number");
            else Console.WriteLine($"{tem} is not a Niven Number");

        }
        static void NeonNumber()
        {
            Console.WriteLine("Enter a Number:");
            int n = int.Parse(Console.ReadLine());
            long sm = 0;
            long sq = n * n;
            while (sq > 0)
            {
                long rem = sq % 10;
                sm += rem;
                sq /= 10;
            }
            if (sm == n) Console.WriteLine($"{n} is Neon Number");
            else Console.WriteLine($"{n} is not a Neon Number");

        }

        static void Main(string[] args)
        {
            
            //PrimeOrNotWithinRange();
            //SpyNumber();
            //PrimeOrNot();
            //PerfectOrNot();
            //ReverseNumber();
            //NeonNumber();
            //SpecialNumber();
            //NivenNumber();
            //PerfectOrNotWithinRange();
        }
    }
}
