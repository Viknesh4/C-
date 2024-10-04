using System.Runtime;

namespace Arrays
{
    internal class Program
    {

        static void GetFirstElement()
        {
            int[] arr = { 1, 2, 3 };
            Console.WriteLine($"First Element : {arr[0]}");
        }
        static void GetLastElement()
        {
            int[] arr = { 1, 2, 3 };
            Console.WriteLine($"Last Element : {arr[arr.Length - 1]}");
        }

        static void SumOfArray()
        {
            Console.WriteLine("Enter the Size of the array:");
            int size = int.Parse( Console.ReadLine() );
            int[] arr = new int[size];
            Console.WriteLine("Enter the Elements of the array:");
            for ( int i = 0; i < size; i++ )
                arr[i] = int.Parse( Console.ReadLine() );
            int sum = 0;
            for (int i = 0; i < size; i++)
                sum += arr[i];
            Console.WriteLine($"Sum of the Array Elements: {sum}");       
        }

        static void AvgOfArray()
        {
            Console.WriteLine("Enter the Size of the array:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter the Elements of the array:");
            for (int i = 0; i < size; i++)
                arr[i] = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < size; i++)
                sum += arr[i];
            Console.WriteLine($"Avg of the Array Elements: {sum/ (float)size}");
        }

        static void SumAndProd()
        {
            Console.WriteLine("Enter the Size of the array:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter the Elements of the array:");
            for (int i = 0; i < size; i++)
                arr[i] = int.Parse(Console.ReadLine());
            int sum = 0;
            int prod = 1;
            for (int i = 0; i < size; i++)
            {
                sum += arr[i];
                prod *= arr[i];
            }
            Console.WriteLine($"Sum of the Array Elements: {sum}");
            Console.WriteLine($"Product of the Array Elements: {prod}");
        }

        static void FindLeapYear()
        {
            int[] arr = { 2002, 2004, 2006, 2008, 2010, 2011, 2015, 2019, 2020 };
            
            foreach (int year in arr)
            {
                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                    Console.WriteLine(year);
            }
            
        }

        static void FindElement()
        {
            Console.WriteLine("Enter the Size of the array:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter the Elements of the array:");
            for (int i = 0; i < size; i++)
                arr[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Element to Find:");
            int ele = int.Parse(Console.ReadLine());
            for (int i = 0; i < size; i++)
                if (arr[i] == ele)
                {
                    Console.WriteLine($"{ele} Found");
                    break;
                }
        }
        static void FindIndex()
        {
            int[] arr = { 1, 2, 3, 6, 9, 8, 5 };
            int ele = 9;
            Console.WriteLine($"{ele} is Found in Index:{Array.IndexOf(arr,ele)}");

        }
        static void OddEven()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int ec = 0, oc = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    ec++;
                else
                    oc++;
            }
            Console.WriteLine("Even numbers: " + ec);
            Console.WriteLine("Odd numbers: " + oc);
        }

        static void PrimeCount()
        {
            int[] num = { 1,2,3,4,5,6,7,8,9,10};
            int pc = 0;
            foreach (int number in num)
            {
                bool flag = true;
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        flag = false;
                        break;

                    }
                }
                if (flag)
                    pc++;
            }
            Console.WriteLine($"Count of prime numbers in a array is (1,2,3,4,5,6,7,8,9) \n" + pc);
        }
        static void InsertElement()
        {
            int[] num = { 1, 2, 3, 4, 5 };
            Console.Write("Enter the element to insert: ");
            int ele = int.Parse(Console.ReadLine());
            Console.Write("Enter the position to insert the element: ");
            int pos = int.Parse(Console.ReadLine());
            int[] newArray = new int[num.Length + 1];

            for (int i = 0, j = 0; i < newArray.Length; i++)
            {
                if (i == pos)
                {
                    newArray[i] = ele;
                }
                else
                {
                    newArray[i] = num[j];
                    j++;
                }
            }
            Console.WriteLine("Array after insertion:");
            foreach (int number in newArray)
            {
                Console.Write(number + " ");
            }
        }

       
    
        static void Main(string[] args)
        {
            GetFirstElement();
            GetLastElement();
            SumOfArray();
            //AvgOfArray();
            //FindLeapYear();
            //FindElement();
            //SumAndProd();
            //FindIndex();
            //OddEven();
            //PrimeCount();
            //InsertElement();

        }
    }
}
