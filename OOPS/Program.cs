namespace OOPS
{
    internal class Program
    {
        static void Main1(string[] args)
        {

            /*Prime p = new Prime();
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            p.input(n);
            p.display();*/

            /*Piglatin pg = new Piglatin();
            Console.WriteLine("Enter a word:");
            string pl = Console.ReadLine();
            pg.input(pl);   
            pg.display();*/

            /*Console.WriteLine("Enter a Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter a Employee Number:");
            string E_no = Console.ReadLine();
            Console.WriteLine("Enter a Basic Pay:");
            int basic = int.Parse(Console.ReadLine());
            Employee_Salary emp = new Employee_Salary(name,E_no,basic);
            emp.Compute();
            emp.Display();*/

            //Movie_Status movie = new Movie_Status();
            //movie.Accept();
            //movie.Display();

            //ExceptionTest exceptionTest = new ExceptionTest();
            //exceptionTest.ExceptionRaise();
            /*Console.WriteLine("Enter the age:");
            int a = int.Parse(Console.ReadLine());
            Age age = new Age(a);
            age.check();
            */



            /*ScientificCalculator scicalc = new ScientificCalculator(5.5, 3.3, 2, 3);

            Console.WriteLine("Choose an option:");
            Console.WriteLine("1: Add");
            Console.WriteLine("2: Subtract");
            Console.WriteLine("3: Multiply");
            Console.WriteLine("4: Divide");
            Console.WriteLine("5: Power");
            Console.WriteLine("6: Exponential");
            Console.WriteLine("7: Square Root");
            Console.WriteLine("8: Square");
            Console.WriteLine("9: Cube");
            Console.WriteLine("10: Degree (Radian to Degree)");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Addition: " + scicalc.Add());
                    break;
                case 2:
                    Console.WriteLine("Subtraction: " + scicalc.Sub());
                    break;
                case 3:
                    Console.WriteLine("Multiplication: " + scicalc.Mul());
                    break;
                case 4:
                    try
                    {
                        Console.WriteLine("Division: " + scicalc.Div());
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 5:
                    Console.WriteLine("Power: " + scicalc.Power());
                    break;
                case 6:
                    Console.WriteLine("Exponential: " + scicalc.Exponential());
                    break;
                case 7:
                    Console.WriteLine("Square Root: " + scicalc.SquareRoot());
                    break;
                case 8:
                    Console.WriteLine("Square: " + scicalc.Square());
                    break;
                case 9:
                    Console.WriteLine("Cube: " + scicalc.Cube());
                    break;
                case 10:
                    Console.WriteLine("Degree: " + scicalc.Degree());
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }*/



            /*Console.WriteLine("Do you have an account? (yes/no): ");
            string hasAccount = Console.ReadLine();

            if (hasAccount.ToLower() == "no")
            {
 
                Console.WriteLine("Enter your name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter your mobile number: ");
                string mobile_no = Console.ReadLine();

                Console.WriteLine("Enter your mail ID: ");
                string mail_id = Console.ReadLine();

                Console.WriteLine("Enter your 10th marks: ");
                int tenth = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter your 12th marks: ");
                int twelth = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter your CGPA: ");
                double cgpa = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter account number: ");
                string acc_no = Console.ReadLine();

                Console.WriteLine("Enter IFSC code: ");
                string ifsc_code = Console.ReadLine();

                Console.WriteLine("Enter bank name: ");
                string bank_name = Console.ReadLine();

                Console.WriteLine("Enter account type: ");
                string account_type = Console.ReadLine();

                Console.WriteLine("Enter account balance: ");
                int balance = int.Parse(Console.ReadLine());

                Bank bank = new Bank(name, mobile_no, mail_id, tenth, twelth, cgpa, acc_no, ifsc_code, bank_name, account_type, balance);
                bank.Display();
            }

            Console.WriteLine("Enter the loan type (Education/Personal/Car/Home): ");
            string loan_type = Console.ReadLine();

            Console.WriteLine("Enter loan amount: ");
            double loan_amount = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter duration (in years): ");
            int duration = int.Parse(Console.ReadLine());

            Loan loan = new Loan(loan_type, loan_amount, duration);
            loan.Display();*/


            /*Console.WriteLine("Enter details for the Student: ");
            Console.WriteLine("Name: ");
            string studentName = Console.ReadLine();

            Console.WriteLine("ID: ");
            string studentId = Console.ReadLine();

            Console.WriteLine("Department: ");
            string studentDept = Console.ReadLine();

            Console.WriteLine("Mobile No: ");
            string studentMobile = Console.ReadLine();

            Console.WriteLine("Mail ID: ");
            string studentMail = Console.ReadLine();

            Console.WriteLine("Year: ");
            int studentYear = int.Parse(Console.ReadLine());

            Student student = new Student(studentName, studentId, studentDept, studentMobile, studentMail, studentYear);
            student.GetSemesterGPA();
            student.Display();

            // Example of a Staff
            Console.WriteLine("\n\nEnter details for the Staff: ");
            Console.WriteLine("Name: ");
            string staffName = Console.ReadLine();

            Console.WriteLine("ID: ");
            string staffId = Console.ReadLine();

            Console.WriteLine("Department: ");
            string staffDept = Console.ReadLine();

            Console.WriteLine("Mobile No: ");
            string staffMobile = Console.ReadLine();

            Console.WriteLine("Mail ID: ");
            string staffMail = Console.ReadLine();

            Console.WriteLine("Experience (in years): ");
            double staffExp = double.Parse(Console.ReadLine());

            Console.WriteLine("Basic Salary: ");
            double basicSalary = double.Parse(Console.ReadLine());

            Staff staff = new Staff(staffName, staffId, staffDept, staffMobile, staffMail, staffExp, basicSalary);
            staff.Display();*/
            
            

        }
        }

    }

