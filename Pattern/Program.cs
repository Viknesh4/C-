namespace Pattern
{
    internal class Program
    {
        static void SquarePattern1()
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
        static void SquarePattern2()
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        static void SquarePattern3()
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            int c = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(c);
                    c++;
                }
                Console.WriteLine();
            }
        }
        static void FavoriteNumber()
        {
           
            
            
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if (i == 1 || i == 4 || i == 7 || j == 1 || j == 4)
                    {
                        Console.Write("* ");
                    }
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }
        }
        static void FavoriteLetter()
        {
            
            
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if (i == 1  || i == 7 || j == 1 )
                        Console.Write("* ");
                    
                }
                Console.WriteLine();
            }
        }
        static void RightAngledTriangle1()
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        static void RightAngledTriangle2()
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int k = i;
                for (int j = 1; j <= i; j++)
                {
                     Console.Write(k);
                     k--;

                }
                Console.WriteLine();
            }
        }
        static void HashStar()
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=  n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j%2 != 0)
                        Console.Write("#");
                    else Console.Write("*");

                }
                Console.WriteLine();
            }
        }
        static void RightAngledTriangle3()
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 3; i <= n+3; i++)
            {
                for (int j = 3; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
        static void RightAngledTriangle4()
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            int k = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(k);
                    k++;
                }
                Console.WriteLine();
            }
        }
        static void HallowSquare()
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i == 1 || i == n || j == 1 || j == n)
                        Console.Write("*"+" ");
                    else Console.Write("  ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {

            SquarePattern1();
            SquarePattern2();
            SquarePattern3();
            //FavoriteNumber();
            //FavoriteLetter();
            //RightAngledTriangle1();
            //HashStar();
            //RightAngledTriangle4();
            //RightAngledTriangle3();
            //HallowSquare();
            //RightAngledTriangle2();
        }
    }
}
