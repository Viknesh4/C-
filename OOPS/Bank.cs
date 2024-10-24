using System;

namespace OOPS
{
    
    internal class Personal_Information
    {
        private string name, mobile_no, mail_id;

        
        public Personal_Information(string name, string mobile_no, string mail_id)
        {
            this.name = name;
            this.mobile_no = mobile_no;
            this.mail_id = mail_id;
        }

        
        public virtual void Display()
        {
            Console.WriteLine("-------Personal Details----------");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Mobile No: {mobile_no}");
            Console.WriteLine($"Mail ID: {mail_id}");
        }
    }

    
    class Education : Personal_Information
    {
        private int tenth, twelth;
        private double cgpa;

        
        public Education(string name, string mobile_no, string mail_id, int tenth, int twelth, double cgpa)
            : base(name, mobile_no, mail_id)  
        {
            this.tenth = tenth;
            this.twelth = twelth;
            this.cgpa = cgpa;
        }

        
        public override void Display()
        {
            base.Display();  
            Console.WriteLine("-------Educational Details----------");
            Console.WriteLine($"Tenth Marks: {tenth}");
            Console.WriteLine($"Twelfth Marks: {twelth}");
            Console.WriteLine($"CGPA: {cgpa}");
        }
    }


    class Bank : Education
    {
        private string acc_no, ifsc_code, bank_name, account_type;
        private int balance;

        
        public Bank(string name, string mobile_no, string mail_id, int tenth, int twelth, double cgpa,
                    string acc_no, string ifsc_code, string bank_name, string account_type, int balance)
            : base(name, mobile_no, mail_id, tenth, twelth, cgpa)  
        {
            this.acc_no = acc_no;
            this.ifsc_code = ifsc_code;
            this.bank_name = bank_name;
            this.account_type = account_type;
            this.balance = balance;
        }

        public override void Display()
        {
            base.Display(); 
            Console.WriteLine("-------Bank Details----------");
            Console.WriteLine($"Account Number: {acc_no}");
            Console.WriteLine($"IFSC Code: {ifsc_code}");
            Console.WriteLine($"Bank Name: {bank_name}");
            Console.WriteLine($"Account Type: {account_type}");
            Console.WriteLine($"Account Balance: {balance}");
        }
    }

    class Loan
    {
        private string loan_type;
        private double loan_amount, interest, total_amount;
        private int duration;

        public Loan(string loan_type, double loan_amount, int duration)
        {
            this.loan_type = loan_type;
            this.loan_amount = loan_amount;
            this.duration = duration;
            Calculate(); 
        }

        
        private void Calculate()
        {
            switch (loan_type)
            {
                case "Education":
                    interest = 0.75;
                    break;
                case "Personal":
                    interest = 14.5;
                    break;
                case "Car":
                    interest = 8.85;
                    break;
                case "Home":
                    interest = 1.5;
                    break;
                default:
                    Console.WriteLine("Invalid Loan type");
                    return;
            }

            total_amount = loan_amount + (loan_amount * (interest / 100) * duration);
        }

        public void Display()
        {
            Console.WriteLine("-------Loan Details----------");
            Console.WriteLine($"Loan Type: {loan_type}");
            Console.WriteLine($"Loan Amount: {loan_amount}");
            Console.WriteLine($"Interest Rate: {interest}%");
            Console.WriteLine($"Loan Duration: {duration} years");
            Console.WriteLine($"Total Amount to be Paid: {total_amount}");
        }
    }

    
}
