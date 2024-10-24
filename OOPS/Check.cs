/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Check
    {
        static void Main(string[] args)
        {
            string path = "Log1.txt";
            if (!File.Exists(path))
            {
                File.Create(path);

                Console.WriteLine("file Created");
            }
            else
                File.WriteAllText(path, "Vignesg");


            Console.WriteLine("Created");
        }
    }
}
*/

using System;
using System.IO;

namespace OOPS
{
    class Check
    {
        static void Main1(string[] args)
        {
            string path = "Log2.txt";

            // Create the file and close the stream immediately
            using (FileStream fs = File.Create(path))
            {
                // File created and stream closed
            }

            Console.WriteLine("File created");
        }
    }
}
