using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Practtice_File
    {
        bool flag = true;
        public string path = "log.txt";
        private void Authetication(string username, string password)
        {
            if (username.ToLower() == "viknesh@gmail.com" && password == "viknesh")
            {
                Console.WriteLine("Login Sucessful");

            }
            else
            {
                Console.WriteLine("Login Failed");
                this.flag = false;
            }

        }
        private void Create()
        {
            Console.WriteLine("Enter the number of students:");
            int c = int.Parse(Console.ReadLine());
            for (int i = 0; i < c; i++)
            {
                Console.WriteLine("Enter Name:");
                File.AppendAllText(path,$"name:{Console.ReadLine()}\n");
                Console.WriteLine("Enter Age:");
                File.AppendAllText(path, $"Age:{Console.ReadLine()}\n");
                Console.WriteLine("Enter Mobile:");
                File.AppendAllText(path, $"Mobile Number:{Console.ReadLine()}\n");
                Console.WriteLine("Enter Mail_ID :");
                File.AppendAllText(path, $"Mail:{Console.ReadLine()}\n");

            }

        }

        private void Write()
        {
            Console.WriteLine("Enter the number of students:");
            int c = int.Parse(Console.ReadLine());
            for (int i = 0; i < c; i++)
            {
                Console.WriteLine("Enter Name:");
                File.AppendAllText(path, $"name:{Console.ReadLine()}\n");
                Console.WriteLine("Enter Age:");
                File.AppendAllText(path, $"Age:{Console.ReadLine()}\n");
                Console.WriteLine("Enter Mobile:");
                File.AppendAllText(path, $"Mobile Number:{Console.ReadLine()}\n");
                Console.WriteLine("Enter Mail_ID :");
                File.AppendAllText(path, $"Mail:{Console.ReadLine()}\n");
            }
        }
        

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the user Name : ");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the Password : ");
            string password = Convert.ToString(Console.ReadLine());
            Practtice_File obj = new Practtice_File();
            obj.Authetication(name, password);
            if (obj.flag)
            {
                Console.WriteLine("Create Read Write Delete BackUp\nEnter : ");
                string option = Console.ReadLine();
                switch (option.ToUpper())
                {
                    case "CREATE":
                        obj.Create();
                        break;
                    case "WRITE":
                        obj.Write();
                        break;

                }

            }
        }
    }
}