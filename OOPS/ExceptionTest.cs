using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class ExceptionTest
    {
        public void ExceptionRaise()
        {
            Console.WriteLine("Enter a numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a == 0 || b == 0) throw new Exception("try giving numbers other than zero");


            try
            {
                int a1 = int.Parse(Console.ReadLine());
                int b1 = int.Parse(Console.ReadLine());
                
                int c = a1/ b1;
                Console.WriteLine();
            }
            catch (DivideByZeroException E)
            {
                Console.WriteLine("Divide by zero raised");
                Console.WriteLine(E.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Alphabet given in place of Number");
            }
            catch(Exception e)
            {
                //Console.WriteLine(e);
                Console.WriteLine(e.Message);

            }
            
        }
    }
}
