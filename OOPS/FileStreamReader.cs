using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class FileStreamReader
    {

        static void Main1(string[] args)
        {
            string path = "C:\\Users\\hp\\source\\repos\\OOPS\\newfile1.txt";
            FileStream fsr = new FileStream(path, FileMode.Open, FileAccess.Read);
            try
            {
                /*
                string name = "New Nikhil";
                byte[] byte_Arr = Encoding.UTF8.GetBytes(name);
                fsr.Write(byte_Arr);
                Console.WriteLine("File Created Successfully");*/

                StreamReader streamReader = new StreamReader(fsr);
                string data = streamReader.ReadToEnd();
                Console.WriteLine(data);
                Console.WriteLine("File Read Successfully");
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                fsr.Close();
            }
        }
    }
}
