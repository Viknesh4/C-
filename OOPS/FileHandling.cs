using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class FileHandling
    {
        public void CreateFile(string path)
        {

            try
            {
                File.Create("D://path.txt");
                Console.WriteLine("File Created");
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

        }
        public void DeleteFile(string path)
        {
            try
            {
                File.Delete(path);
                Console.WriteLine("File Deleted");
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public void WriteFile(string path, string content)
        {
            try {
                File.WriteAllText(path, content);
                Console.WriteLine("Content added");
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            Console.ReadLine();

        }
        public void ReadFile(string path)
        {
            try
            {
                Console.WriteLine(File.ReadAllText(path));
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        

        static void Main1(string[] args)
        {
            Console.WriteLine("Press 1 --> Create\n2 --> Write File \n3 --> Read File\n4-->Delete File");
            string path = "D:\\C#\\newfile.txt";
            int choice = int.Parse(Console.ReadLine());
            FileHandling fh = new FileHandling();

            switch (choice)
            {
                case 1:
                    fh.CreateFile(path);
                    break;
                case 2:
                    fh.WriteFile(path, " NewFile \n new content \n new line\n new Life");
                    break;
                case 3:
                    fh.ReadFile(path);
                    break;
                case 4:
                    fh.DeleteFile(path);
                    break;
            }

        }

    }
}
