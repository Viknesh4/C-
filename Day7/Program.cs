using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Day7
{
    internal class Program
    {
        static void Temp()
        {
            Console.WriteLine("Enter the temperature in Centigrade:");
            int c = int.Parse(Console.ReadLine());
            if (c < 0)
                Console.WriteLine("Temperature is Freezing Cold");
            else if (c < 10) Console.WriteLine("Temperature is Very cold");
            else if (c < 20) Console.WriteLine("Temperature is Cold");
            else if (c < 30) Console.WriteLine("Temperature is Normal");
            else if (c < 40) Console.WriteLine("Temperature is Hot");
            else Console.WriteLine("Temperature is Very hot");
        }

        static void CredentialsVerification()
        {
            Console.Write("Enter the Username:");
            string name = Console.ReadLine();
            Console.Write("Enter Mail ID:");
            string mail = Console.ReadLine();
            if (name.ToLower() == "viknesh" && mail.ToLower() == "viknesh4@gmail.com")
                Console.WriteLine("Credentials are valid");
            else Console.WriteLine("Inavalid Credentials");
        }
        static void Salary()
        {
            Console.WriteLine("Enter the Aptitude marks:");
            int apti = int.Parse(Console.ReadLine());
            if (apti >= 85)
            {
                Console.WriteLine("You have passed the Aptitude Round. You are eligible for next round!!");
                Console.WriteLine("Enter the GD marks:");
                int gd = int.Parse(Console.ReadLine());
                if (gd >= 90)
                {
                    Console.WriteLine("You have passed the GD Round. You are eligible for next round!!");
                    Console.WriteLine("Enter the Technical marks:");
                    int tech = int.Parse(Console.ReadLine());
                    if (tech >= 90)
                    {
                        Console.WriteLine("You have passed the Technical Round. You are eligible for next round!!");
                        Console.WriteLine("Enter the Subject marks:");
                        int sub = int.Parse(Console.ReadLine());
                        if (sub >= 95)
                        {
                            Console.WriteLine("You have passed the All rounds!!");
                            int per = (apti + gd + tech + sub) / 100;
                            if ((per*100) >= 95) Console.WriteLine("Your salary is 25000 Rupees");
                            else if (per >= 80) Console.WriteLine("Your salary is 20000 Rupees");
                            else Console.WriteLine("Your salary is 15000 Rupees");
                        }
                        else Console.WriteLine("You have Failed in the Subject Round. Better luck next time!!");
                    }
                    else Console.WriteLine("You have Failed in the Technical Round. Better luck next time!!");
                }
                else Console.WriteLine("You have Failed in the GD Round. Better luck next time!!");
            }
            else Console.WriteLine("You have Failed in the Aptitude Round. Better luck next time!!");
        }

        static void SquareOrNot()
        {
            Console.Write("Enter the values of Length and Breadth:");
            int len = int.Parse(Console.ReadLine());
            int breadth = int.Parse(Console.ReadLine());
            Console.WriteLine((len == breadth) ? "The given values form a square" : "The given values doesn't form a square");
        }
        static void Bill()
        {
            Console.Write("Enter the Product name:");
            string pname = Console.ReadLine();
            Console.Write("Enter the Product price:");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Enter the Product quantity:");
            int quantity = int.Parse(Console.ReadLine());
            float purchase = price * quantity;
            float amount = (purchase >= 1000) ? purchase - (purchase * 0.10F) : purchase;
            Console.WriteLine("###################################################");
            Console.WriteLine($"           Product Name      : {pname}");
            Console.WriteLine($"           Product Price     : {price}");
            Console.WriteLine($"           Product Quantity  : {quantity}");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"           Total amount      : {purchase}");
            Console.WriteLine($"           Discount          : {purchase - amount}");
            Console.WriteLine($"          Amount to be paid  : {amount}");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("###################################################");
        }
        static void Bonus()
        {
            Console.Write("Enter the Employee name:");
            string ename = Console.ReadLine();
            Console.Write("Enter the Employee ID:");
            string eid = Console.ReadLine();
            Console.Write("Enter the Employee Experience:");
            int exp = int.Parse(Console.ReadLine());
            Console.Write("Enter the Employee salary:");
            int salary = int.Parse(Console.ReadLine());
            float bonus = (exp >= 5) ? (salary * 0.05F) : 0;
            if (bonus > 0) Console.WriteLine($"Salary is {salary+bonus} with Bonus added");
            else Console.WriteLine($"Salary is {salary} ");
        }
        static void ExamEligibility()
        {
            Console.Write("Enter the Total number of classed held:");
            int tot = int.Parse(Console.ReadLine());
            Console.Write("Enter the Number of classes attended::");
            int att = int.Parse(Console.ReadLine());
            float per = (att / (float)tot) * 100;
            if (per >= 75)
                Console.WriteLine("The Student is Eligible For Exam");
            else
                Console.WriteLine("The Student is Not Eligible For Exam");

        }
        static void Main(string[] args)
        {
            
            //Temp();
            //CredentialsVerification();
            //Salary();
            //SquareOrNot();
            //Bill();
            //Bonus();
            ExamEligibility();

        }

    }
}
