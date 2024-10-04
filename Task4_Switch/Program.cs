namespace Task4_Switch
{
    internal class Program
    {
        static void SwitchChoiceNum()
        {
            Console.WriteLine("Enter Two numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Press 1 for Addition \nPress 2 for Subtraction \nPress 3 for Multiplication \nPress 4 for Division\nPress 5 for Remainder:");
            int c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 1:
                    Console.WriteLine($"Addition of {a} and {b}:{a + b}");
                    break;
                case 2:
                    Console.WriteLine($"Subtraction of {a} and {b}:{a - b}");
                    break;
                case 3:
                    Console.WriteLine($"MUltiplication of {a} and {b}:{a * b}");
                    break;
                case 4:
                    Console.WriteLine($"Division of {a} and {b}:{a / b}");
                    break;
                case 5:
                    Console.WriteLine($"Remainder of {a} and {b}:{a % b}");
                    break;
                default:
                    Console.WriteLine(" InValid Choice ");
                    break;
            }
        }

        static void SwitchChoiceOPer()
        {

            Console.WriteLine("Enter Two numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Press + for Addition \nPress - for Subtraction \nPress * for Multiplication \nPress / for Division:\nPress % for Remainder");
            char c = char.Parse(Console.ReadLine());
            switch (c)
            {
                case '+':
                    Console.WriteLine($"Addition of {a} and {b}:{a + b}");
                    break;
                case '-':
                    Console.WriteLine($"Subtraction of {a} and {b}:{a - b}");
                    break;
                case '*':
                    Console.WriteLine($"MUltiplication of {a} and {b}:{a * b}");
                    break;
                case '/':
                    Console.WriteLine($"Division of {a} and {b}:{a / b}");
                    break;
                case '%':
                    Console.WriteLine($"Remainder of {a} and {b}:{a % b}");
                    break;
                default:
                    Console.WriteLine(" InValid Choice ");
                    break;

            }

        }
        static void SwitchChoiceStr()
        {

            Console.WriteLine("Enter Two numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Press ADD for Addition \nPress SUB for Subtraction \nPress MUL for Multiplication \nPress DIV for Division:\nPress REM for Remainder");
            string c = Console.ReadLine();

            switch (c.ToUpper())
            {
                case "ADD":
                    Console.WriteLine($"Addition of {a} and {b}:{a + b}");
                    break;
                case "SUB":
                    Console.WriteLine($"Subtraction of {a} and {b}:{a - b}");
                    break;
                case "MUL":
                    Console.WriteLine($"MUltiplication of {a} and {b}:{a * b}");
                    break;
                case "DIV":
                    Console.WriteLine($"Division of {a} and {b}:{a / b}");
                    break;
                case "REM":
                    Console.WriteLine($"Remainder of {a} and {b}:{a % b}");
                    break;
                default:
                    Console.WriteLine(" InValid Choice ");
                    break;

            }

        }
        static void SemesterWiseSubjects()
        {
            Console.WriteLine("Enter Year:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Semester:");
            int b = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    {
                        switch (b)
                        {
                            case 1:
                                Console.WriteLine("C programming");
                                Console.WriteLine("Engineering Viualization");
                                Console.WriteLine("English");
                                Console.WriteLine("Physics");
                                break;
                            case 2:
                                Console.WriteLine("Python programming");
                                Console.WriteLine("Chemistry");
                                Console.WriteLine("Maths");
                                Console.WriteLine("SDE");
                                break;
                            default:
                                Console.WriteLine("Invalid Semester Choice");
                                break;
                        }
                    }
                    break;
                case 2:
                    {
                        switch (b)
                        {
                            case 3:
                                Console.WriteLine("ITPSSs");
                                Console.WriteLine("IOT");
                                Console.WriteLine("DBMS");
                                Console.WriteLine("CAO");
                                break;
                            case 4:
                                Console.WriteLine("ML");
                                Console.WriteLine("ITA");
                                Console.WriteLine("Statistics");
                                Console.WriteLine("Design project");
                                break;
                            default:
                                Console.WriteLine("Invalid Semester Choice");
                                break;
                        }
                    }
                    break;
                case 3:
                    {
                        switch (b)
                        {
                            case 5:
                                Console.WriteLine("Design and Analysis of Algorithm");
                                Console.WriteLine("Digital Forensics");
                                Console.WriteLine("ITDS");
                                Console.WriteLine("Software Engineering");
                                break;
                            case 6:
                                Console.WriteLine("Innovation and Entrepreneurship");
                                Console.WriteLine("Compiler Design");
                                Console.WriteLine("Computer Networks");
                                Console.WriteLine("Ethical Hacking");
                                break;
                            default:
                                Console.WriteLine("Invalid Semester Choice");
                                break;
                        }
                    }
                    break;
                case 4:
                    {
                        switch (b)
                        {
                            case 7:
                                Console.WriteLine("Secured Computing");
                                Console.WriteLine(".Net");

                                break;
                            case 8:
                                Console.WriteLine("Capstone Project");

                                break;
                            default:
                                Console.WriteLine("Invalid Semester Choice");
                                break;
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Inavalid Choice");
                    break;
            }

        }
        static void HotelMenu()
        {
            Console.WriteLine("Enter 1 for Veg\n 2 for Non-veg:");
            int c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 1:
                    {
                        Console.WriteLine("Press\n1)Idli-10 rupess\n2)Chappathi - 20 rupees \n3)Pongal - 40 rupees\n4)Dosa - 20 rupees\n5)Poori- 20 rupees");
                        int a = int.Parse(Console.ReadLine());
                        switch (a)
                        {
                            case 1:
                                Console.WriteLine("Enter the quantity:");
                                int q1 = int.Parse(Console.ReadLine());
                                Console.WriteLine($"Amount to be paid:{q1 * 10}");
                                break;
                            case 2:
                                Console.WriteLine("Enter the quantity:");
                                int q2 = int.Parse(Console.ReadLine());
                                Console.WriteLine($"Amount to be paid:{q2 * 20}");
                                break;
                            case 3:
                                Console.WriteLine("Enter the quantity:");
                                int q3 = int.Parse(Console.ReadLine());
                                Console.WriteLine($"Amount to be paid:{q3 * 40}");
                                break;
                            case 4:
                                Console.WriteLine("Enter the quantity:");
                                int q4 = int.Parse(Console.ReadLine());
                                Console.WriteLine($"Amount to be paid:{q4 * 20}");
                                break;
                            case 5:
                                Console.WriteLine("Enter the quantity:");
                                int q5 = int.Parse(Console.ReadLine());
                                Console.WriteLine($"Amount to be paid:{q5 * 20}");
                                break;
                            default:
                                Console.WriteLine("Invalid Choice");
                                break;
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Press\n1)Chicken Fried Rice-100 rupess\n2)Chicken Briyani - 220 rupees \n3)Non_Veg Meals - 150 rupees\n4)Kari_Dosa - 100 rupees\n5)Parotta- 20 rupees");
                        int a = int.Parse(Console.ReadLine());
                        switch (a)
                        {
                            case 1:
                                Console.WriteLine("Enter the quantity:");
                                int q1 = int.Parse(Console.ReadLine());
                                Console.WriteLine($"Amount to be paid:{q1 * 100}");
                                break;
                            case 2:
                                Console.WriteLine("Enter the quantity:");
                                int q2 = int.Parse(Console.ReadLine());
                                Console.WriteLine($"Amount to be paid:{q2 * 220}");
                                break;
                            case 3:
                                Console.WriteLine("Enter the quantity:");
                                int q3 = int.Parse(Console.ReadLine());
                                Console.WriteLine($"Amount to be paid:{q3 * 150}");
                                break;
                            case 4:
                                Console.WriteLine("Enter the quantity:");
                                int q4 = int.Parse(Console.ReadLine());
                                Console.WriteLine($"Amount to be paid:{q4 * 100}");
                                break;
                            case 5:
                                Console.WriteLine("Enter the quantity:");
                                int q5 = int.Parse(Console.ReadLine());
                                Console.WriteLine($"Amount to be paid:{q5 * 20}");
                                break;
                            default:
                                Console.WriteLine("Invalid Choice");
                                break;
                        }
                        break;
                    }
                default:
                    Console.WriteLine("Invalid choice");
                    break;

            }
        }
        static void Main(string[] args)
        {
            HotelMenu();

        }
    }

}