using System;
using System.Text;
namespace Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 5,9,8,4, 7, 2, 8,9,1,4};
            for (int i = 0; i < array1.Length-1; i++)
            {
                for (int j = 0; j < array1.Length-1; j++)
                {
                    if (array1[j] > array1[j + 1])
                    {
                        int temp = array1[j];
                        array1[j] = array1[j + 1];
                        array1[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted Array in Ascending Order:");
            foreach (int num in array1)
                Console.Write(num+",");
            Console.WriteLine();
            Console.WriteLine("Sorted Array in Descending Order:");
            for(int i  = array1.Length-1;i>=0;i--)
                Console.Write(array1[i] + ",");
            Console.WriteLine();
            Console.WriteLine($"Minimum value:{array1[0]}");
            Console.WriteLine($"Maximum value:{array1[array1.Length - 1]}");
            //Console.WriteLine(string.Join(" ",array1));
            Console.WriteLine($"Second Largest value:{array1[array1.Length - 2]}");
            Console.WriteLine($"Second Smallest Value:{array1[1]}");

            Console.WriteLine("Duplicate Elements:");
            for (int i = 0; i < array1.Length - 1; i++)
            {
                if (array1[i] == array1[i + 1])
                    Console.Write(array1[i]+" ");
            }
        }
    }
}
