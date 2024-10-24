using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterface
{
    public interface IInformation
    {
        void personal(string name, string mail, string mobile);
        void education(double tenth_avg, double twelth_avg, double ug_grade, double pg_grade);
        void bank(string name, string acc_num, string ifsc, string micr, double avl_bal);
    }

    
    public interface IExtraDetails
    {
        void displayAccountDetails(string accountType, string nomineeName);
    }

    
    public class Details : IInformation, IExtraDetails
    {
        
        public void personal(string name, string mail, string mobile)
        {
            Console.WriteLine("---- Personal Information ----");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Mail: {mail}");
            Console.WriteLine($"Mobile: {mobile}");
        }

        
        public void education(double tenth_avg, double twelth_avg, double ug_grade, double pg_grade)
        {
            Console.WriteLine("---- Education Information ----");
            Console.WriteLine($"10th Average: {tenth_avg}");
            Console.WriteLine($"12th Average: {twelth_avg}");
            Console.WriteLine($"Undergraduate Grade: {ug_grade}");
            Console.WriteLine($"Postgraduate Grade: {pg_grade}");
        }

        
        public void bank(string name, string acc_num, string ifsc, string micr, double avl_bal)
        {
            Console.WriteLine("---- Bank Information ----");
            Console.WriteLine($"Bank Name: {name}");
            Console.WriteLine($"Account Number: {acc_num}");
            Console.WriteLine($"IFSC Code: {ifsc}");
            Console.WriteLine($"MICR Code: {micr}");
            Console.WriteLine($"Available Balance: {avl_bal}");
        }

        
        public void displayAccountDetails(string accountType, string nomineeName)
        {
            Console.WriteLine("---- Additional Account Details ----");
            Console.WriteLine($"Account Type: {accountType}");
            Console.WriteLine($"Nominee Name: {nomineeName}");
        }
    }
}
