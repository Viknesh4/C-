using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class College
    {
        public string name, mobile_no, mail_id;


        public College(string name, string mobile_no, string mail_id)
        {
            this.name = name;
            this.mobile_no = mobile_no;
            this.mail_id = mail_id;
        }


        public virtual void Display()
        {
            Console.WriteLine("-------College Details----------");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Mobile No: {mobile_no}");
            Console.WriteLine($"Mail ID: {mail_id}");
        }
    }


    class Student : College
    {
        private string Id, department;
        private int year;
        private double[] gpa;


        public Student(string name, string Id, string department, string mobile_no, string mail_id, int year)
            : base(name, mobile_no, mail_id)
        {
            this.Id = Id;
            this.department = department;
            this.year = year;
            gpa = new double[year * 2];
        }


        public void GetSemesterGPA()
        {
            Console.WriteLine($"Enter GPA for {year * 2} semesters: ");
            for (int i = 0; i < year * 2; i++)
            {
                Console.Write($"Enter GPA for Semester {i + 1}: ");
                gpa[i] = double.Parse(Console.ReadLine());
            }
        }


        public double CalculateCGPA()
        {
            double sum = 0.0;
            for (int i = 0; i < gpa.Length; i++)
            {
                sum += gpa[i];
            }
            return sum / gpa.Length;
        }


        public override void Display()
        {
            base.Display();
            Console.WriteLine("-------Student Details----------");
            Console.WriteLine($"Student ID: {Id}");
            Console.WriteLine($"Department: {department}");
            Console.WriteLine($"Year: {year}");

            Console.WriteLine("-------GPA Details----------");
            for (int i = 0; i < gpa.Length; i++)
            {
                Console.WriteLine($"Semester {i + 1} GPA: {gpa[i]}");
            }

            Console.WriteLine($"CGPA: {CalculateCGPA()}");
        }
    }


    class Staff : College
    {
        private string Id, department;
        private double experience, basicSalary;


        public Staff(string name, string Id, string department, string mobile_no, string mail_id, double experience, double basicSalary)
            : base(name, mobile_no, mail_id)
        {
            this.Id = Id;
            this.department = department;
            this.experience = experience;
            this.basicSalary = basicSalary;
        }


        public double CalculateSalary()
        {
            double bonusPercentage = 0.0;
            if (experience >= 0.6 && experience <= 1.9)
                bonusPercentage = 0.05;
            else if (experience >= 2.0 && experience <= 2.9)
                bonusPercentage = 0.15;
            else if (experience >= 3.0 && experience <= 5.0)
                bonusPercentage = 0.20;
            else if (experience > 5.0)
                bonusPercentage = 0.25;

            return basicSalary + (basicSalary * bonusPercentage);
        }


        public override void Display()
        {
            base.Display();
            Console.WriteLine("-------Staff Details----------");
            Console.WriteLine($"Staff ID: {Id}");
            Console.WriteLine($"Department: {department}");
            Console.WriteLine($"Experience: {experience} years");
            Console.WriteLine($"Total Salary: {CalculateSalary()}");
        }
    }
}

