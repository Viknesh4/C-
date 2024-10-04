using System.Diagnostics.Tracing;

namespace MultiArray
{
    internal class Program
    {

        static void CopyArray()
        {
            int[] sourceArray = { 1, 2, 5, 8, 6 };
            int[] targetArray = new int[5];
            Array.Copy(sourceArray, 2, targetArray, 3, 1);
            Console.WriteLine(string.Join(", ", targetArray));
        }

        static void DescArray()
        {
            int[] sourceArray = { 1, 2, 5, 8, 6 };
            Array.Sort(sourceArray);
            Array.Reverse(sourceArray);
            Console.WriteLine(string.Join(", ", sourceArray));
        }

        static void MultiArray()
        {
            Console.WriteLine("Enter the Row and Column Size :");
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            int[,] sourceArray = new int[row, col];
            Console.WriteLine("Enter the Array Elements :");
            for (int i = 0; i < sourceArray.GetLength(0); i++)
            {
                for (int j = 0; j < sourceArray.GetLength(1); j++)
                {
                    sourceArray[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Printing the Array Elements :");
            for (int i = 0; i < sourceArray.GetLength(0); i++)
            {
                for (int j = 0; j < sourceArray.GetLength(1); j++)
                {
                    Console.Write(sourceArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }


        static void MatAdd()
        {
            Console.WriteLine("Enter the Row and Column Size  :");
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            int[,] sourceArray1 = new int[row, col];
            int[,] sourceArray2 = new int[row, col];
            Console.WriteLine("Enter the Elements of Matrix 1 :");
            for (int i = 0; i < sourceArray1.GetLength(0); i++)
            {
                for (int j = 0; j < sourceArray1.GetLength(1); j++)
                {
                    sourceArray1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter the Elements of Matrix 2 :");
            for (int i = 0; i < sourceArray2.GetLength(0); i++)
            {
                for (int j = 0; j < sourceArray2.GetLength(1); j++)
                {
                    sourceArray2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int[,] resultMat = new int[row, col];
            for (int i = 0; i < resultMat.GetLength(0); i++)
            {
                for (int j = 0; j < resultMat.GetLength(1); j++)
                {
                    resultMat[i,j]= sourceArray1[i, j]+sourceArray2[i, j];
                }
            }
            Console.WriteLine("Printing the Added Matrix Elements:");
            for (int i = 0; i < resultMat.GetLength(0); i++)
            {
                for (int j = 0; j < resultMat.GetLength(1); j++)
                {
                    Console.Write(resultMat[i, j]+" ");
                }
                Console.WriteLine();
            }
        }
        static void MatMul()
        {
            Console.WriteLine("Enter the Row and Column Size  :");
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            int[,] sourceArray1 = new int[row, col];
            int[,] sourceArray2 = new int[row, col];
            Console.WriteLine("Enter the Elements of Matrix 1 :");
            for (int i = 0; i < sourceArray1.GetLength(0); i++)
            {
                for (int j = 0; j < sourceArray1.GetLength(1); j++)
                {
                    sourceArray1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter the Elements of Matrix 2 :");
            for (int i = 0; i < sourceArray2.GetLength(0); i++)
            {
                for (int j = 0; j < sourceArray2.GetLength(1); j++)
                {
                    sourceArray2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int[,] resultMat = new int[row, col];
            for (int i = 0; i < sourceArray1.GetLength(0); i++)
            {
                for (int j = 0; j < sourceArray2.GetLength(1); j++)
                {
                    for (int k = 0; k < sourceArray1.GetLength(1); k++)
                        resultMat[i, j] += sourceArray1[i, k] * sourceArray2[k, j];
                }
            }
            Console.WriteLine("Printing the Multiplied Matrix Elements:");
            for (int i = 0; i < resultMat.GetLength(0); i++)
            {
                for (int j = 0; j < resultMat.GetLength(1); j++)
                {
                    Console.Write(resultMat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }


            static void Main(string[] args)
        {
            CopyArray();
            DescArray();
            MultiArray();
            //MatAdd();
            //MatMul();
         }
    }
}
