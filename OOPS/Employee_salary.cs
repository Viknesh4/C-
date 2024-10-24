using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Employee_Salary
    {
        public string name;
        public string employ_number;
        public int basic;
        public double DA, HRA, PF, Total;

        public Employee_Salary(string name, string employ_number, int basic)
        {
            this.name = name;
            this.employ_number = employ_number;
            this.basic = basic;
            this.DA = 0.0;    
            this.HRA = 0.0;   
            this.PF = 0.0;    
            this.Total = 0.0;
        }

        public void Compute()
        {
            this.DA = 0.30 * basic;    
            this.HRA = 0.15 * basic;  
            this.PF = 0.12 * basic;
            Total = (basic + DA + HRA) - PF;
        }

        public void Display()
        {
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Employee Number: " + employ_number);
            Console.WriteLine("Basic Salary: " + basic);
            Console.WriteLine("DA (30%): " + DA);
            Console.WriteLine("HRA (15%): " + HRA);
            Console.WriteLine("PF (12%): " + PF);
            Console.WriteLine("Total Salary: " + Total);
        }

    }
}
